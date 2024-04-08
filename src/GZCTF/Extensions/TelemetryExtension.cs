﻿using Azure.Monitor.OpenTelemetry.AspNetCore;
using GZCTF.Models.Internal;
using Npgsql;
using OpenTelemetry;
using OpenTelemetry.Metrics;
using OpenTelemetry.Resources;
using OpenTelemetry.Trace;

namespace GZCTF.Extensions;

public static class TelemetryExtension
{
    public static void AddTelemetry(this IServiceCollection services, TelemetryConfig? config)
    {
        if (config is { Enable: true })
        {
            var otel = services.AddOpenTelemetry();

            otel.ConfigureResource(resource => resource.AddService("GZCTF"));

            otel.WithMetrics(metrics =>
            {
                metrics.AddAspNetCoreInstrumentation();
                metrics.AddHttpClientInstrumentation();
                metrics.AddRuntimeInstrumentation();
                metrics.AddProcessInstrumentation();

                if (config.Prometheus.Enable)
                {
                    metrics.AddPrometheusExporter(options =>
                    {
                        options.DisableTotalNameSuffixForCounters = true;
                    });
                }

                if (config.Console.Enable)
                {
                    metrics.AddConsoleExporter();
                }
            });

            otel.WithTracing(tracing =>
            {
                tracing.AddAspNetCoreInstrumentation();
                tracing.AddHttpClientInstrumentation();
                tracing.AddEntityFrameworkCoreInstrumentation();
                tracing.AddRedisInstrumentation();
                tracing.AddNpgsql();
                if (config.Console.Enable)
                {
                    tracing.AddConsoleExporter();
                }
            });

            if (config.AzureMonitor.Enable)
            {
                otel.UseAzureMonitor(
                    options => options.ConnectionString = config.AzureMonitor.ConnectionString);
            }

            if (config.OpenTelemetry.Enable)
            {
                otel.UseOtlpExporter(config.OpenTelemetry.Protocol, new(config.OpenTelemetry.EndpointUri ?? "http://localhost:4317"));
            }
        }
    }

    public static void UseTelemetry(this IApplicationBuilder app, TelemetryConfig? config)
    {
        if (config is { Enable: true, Prometheus.Enable: true })
        {
            if (config.Prometheus.Port is ushort port)
            {
                app.UseOpenTelemetryPrometheusScrapingEndpoint(context => context.Connection.LocalPort == port);
            }
            else
            {
                app.UseOpenTelemetryPrometheusScrapingEndpoint();
            }
        }
    }
}
