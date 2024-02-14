﻿// <auto-generated />
using System;
using System.Collections.Generic;
using System.Reflection;
using GZCTF.Utils;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Storage.Json;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion.Internal;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using Npgsql.EntityFrameworkCore.PostgreSQL.Storage.Internal.Mapping;

#pragma warning disable 219, 612, 618
#nullable disable

namespace GZCTF.Models.Data.Compiled
{
    internal partial class SubmissionEntityType
    {
        public static RuntimeEntityType Create(RuntimeModel model, RuntimeEntityType baseEntityType = null)
        {
            var runtimeEntityType = model.AddEntityType(
                "GZCTF.Models.Data.Submission",
                typeof(Submission),
                baseEntityType);

            var id = runtimeEntityType.AddProperty(
                "Id",
                typeof(int),
                propertyInfo: typeof(Submission).GetProperty("Id", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(Submission).GetField("<Id>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                valueGenerated: ValueGenerated.OnAdd,
                afterSaveBehavior: PropertySaveBehavior.Throw,
                sentinel: 0);
            id.TypeMapping = IntTypeMapping.Default.Clone(
                comparer: new ValueComparer<int>(
                    (int v1, int v2) => v1 == v2,
                    (int v) => v,
                    (int v) => v),
                keyComparer: new ValueComparer<int>(
                    (int v1, int v2) => v1 == v2,
                    (int v) => v,
                    (int v) => v),
                providerValueComparer: new ValueComparer<int>(
                    (int v1, int v2) => v1 == v2,
                    (int v) => v,
                    (int v) => v),
                mappingInfo: new RelationalTypeMappingInfo(
                    storeTypeName: "integer"));
            id.AddAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

            var answer = runtimeEntityType.AddProperty(
                "Answer",
                typeof(string),
                propertyInfo: typeof(Submission).GetProperty("Answer", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(Submission).GetField("<Answer>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                maxLength: 127);
            answer.TypeMapping = NpgsqlStringTypeMapping.Default.Clone(
                comparer: new ValueComparer<string>(
                    (string v1, string v2) => v1 == v2,
                    (string v) => v.GetHashCode(),
                    (string v) => v),
                keyComparer: new ValueComparer<string>(
                    (string v1, string v2) => v1 == v2,
                    (string v) => v.GetHashCode(),
                    (string v) => v),
                providerValueComparer: new ValueComparer<string>(
                    (string v1, string v2) => v1 == v2,
                    (string v) => v.GetHashCode(),
                    (string v) => v),
                mappingInfo: new RelationalTypeMappingInfo(
                    storeTypeName: "character varying(127)",
                    size: 127));
            answer.TypeMapping = ((NpgsqlStringTypeMapping)answer.TypeMapping).Clone(npgsqlDbType: NpgsqlTypes.NpgsqlDbType.Varchar);
        answer.AddAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.None);

        var challengeId = runtimeEntityType.AddProperty(
            "ChallengeId",
            typeof(int),
            propertyInfo: typeof(Submission).GetProperty("ChallengeId", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
            fieldInfo: typeof(Submission).GetField("<ChallengeId>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
            sentinel: 0);
        challengeId.TypeMapping = IntTypeMapping.Default.Clone(
            comparer: new ValueComparer<int>(
                (int v1, int v2) => v1 == v2,
                (int v) => v,
                (int v) => v),
            keyComparer: new ValueComparer<int>(
                (int v1, int v2) => v1 == v2,
                (int v) => v,
                (int v) => v),
            providerValueComparer: new ValueComparer<int>(
                (int v1, int v2) => v1 == v2,
                (int v) => v,
                (int v) => v),
            mappingInfo: new RelationalTypeMappingInfo(
                storeTypeName: "integer"));
        challengeId.AddAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.None);

        var gameId = runtimeEntityType.AddProperty(
            "GameId",
            typeof(int),
            propertyInfo: typeof(Submission).GetProperty("GameId", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
            fieldInfo: typeof(Submission).GetField("<GameId>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
            sentinel: 0);
        gameId.TypeMapping = IntTypeMapping.Default.Clone(
            comparer: new ValueComparer<int>(
                (int v1, int v2) => v1 == v2,
                (int v) => v,
                (int v) => v),
            keyComparer: new ValueComparer<int>(
                (int v1, int v2) => v1 == v2,
                (int v) => v,
                (int v) => v),
            providerValueComparer: new ValueComparer<int>(
                (int v1, int v2) => v1 == v2,
                (int v) => v,
                (int v) => v),
            mappingInfo: new RelationalTypeMappingInfo(
                storeTypeName: "integer"));
        gameId.AddAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.None);

        var participationId = runtimeEntityType.AddProperty(
            "ParticipationId",
            typeof(int),
            propertyInfo: typeof(Submission).GetProperty("ParticipationId", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
            fieldInfo: typeof(Submission).GetField("<ParticipationId>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
            sentinel: 0);
        participationId.TypeMapping = IntTypeMapping.Default.Clone(
            comparer: new ValueComparer<int>(
                (int v1, int v2) => v1 == v2,
                (int v) => v,
                (int v) => v),
            keyComparer: new ValueComparer<int>(
                (int v1, int v2) => v1 == v2,
                (int v) => v,
                (int v) => v),
            providerValueComparer: new ValueComparer<int>(
                (int v1, int v2) => v1 == v2,
                (int v) => v,
                (int v) => v),
            mappingInfo: new RelationalTypeMappingInfo(
                storeTypeName: "integer"));
        participationId.AddAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.None);

        var status = runtimeEntityType.AddProperty(
            "Status",
            typeof(AnswerResult),
            propertyInfo: typeof(Submission).GetProperty("Status", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
            fieldInfo: typeof(Submission).GetField("<Status>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
            providerPropertyType: typeof(string));
        status.TypeMapping = StringTypeMapping.Default.Clone(
            comparer: new ValueComparer<AnswerResult>(
                (AnswerResult v1, AnswerResult v2) => object.Equals((object)v1, (object)v2),
                (AnswerResult v) => v.GetHashCode(),
                (AnswerResult v) => v),
            keyComparer: new ValueComparer<AnswerResult>(
                (AnswerResult v1, AnswerResult v2) => object.Equals((object)v1, (object)v2),
                (AnswerResult v) => v.GetHashCode(),
                (AnswerResult v) => v),
            providerValueComparer: new ValueComparer<string>(
                (string v1, string v2) => v1 == v2,
                (string v) => v.GetHashCode(),
                (string v) => v),
            mappingInfo: new RelationalTypeMappingInfo(
                dbType: System.Data.DbType.String),
            converter: new ValueConverter<AnswerResult, string>(
                (AnswerResult v) => v.ToString(),
                (string v) => StringEnumConverter<AnswerResult, string, AnswerResult>.ConvertToEnum(v)),
            jsonValueReaderWriter: new JsonConvertedValueReaderWriter<AnswerResult, string>(
                JsonStringReaderWriter.Instance,
                new ValueConverter<AnswerResult, string>(
                    (AnswerResult v) => v.ToString(),
                    (string v) => StringEnumConverter<AnswerResult, string, AnswerResult>.ConvertToEnum(v))));
        status.SetSentinelFromProviderValue("FlagSubmitted");
        status.AddAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.None);

        var submitTimeUtc = runtimeEntityType.AddProperty(
            "SubmitTimeUtc",
            typeof(DateTimeOffset),
            propertyInfo: typeof(Submission).GetProperty("SubmitTimeUtc", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
            fieldInfo: typeof(Submission).GetField("<SubmitTimeUtc>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
            sentinel: new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)));
        submitTimeUtc.TypeMapping = NpgsqlTimestampTzTypeMapping.Default.Clone(
            comparer: new ValueComparer<DateTimeOffset>(
                (DateTimeOffset v1, DateTimeOffset v2) => v1.EqualsExact(v2),
                (DateTimeOffset v) => v.GetHashCode(),
                (DateTimeOffset v) => v),
            keyComparer: new ValueComparer<DateTimeOffset>(
                (DateTimeOffset v1, DateTimeOffset v2) => v1.EqualsExact(v2),
                (DateTimeOffset v) => v.GetHashCode(),
                (DateTimeOffset v) => v),
            providerValueComparer: new ValueComparer<DateTimeOffset>(
                (DateTimeOffset v1, DateTimeOffset v2) => v1.EqualsExact(v2),
                (DateTimeOffset v) => v.GetHashCode(),
                (DateTimeOffset v) => v),
            clrType: typeof(DateTimeOffset),
            jsonValueReaderWriter: new NpgsqlTimestampTzTypeMapping.NpgsqlJsonTimestampTzDateTimeOffsetReaderWriter());
        submitTimeUtc.AddAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.None);
        submitTimeUtc.AddAnnotation("Relational:JsonPropertyName", "time");

        var teamId = runtimeEntityType.AddProperty(
            "TeamId",
            typeof(int),
            propertyInfo: typeof(Submission).GetProperty("TeamId", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
            fieldInfo: typeof(Submission).GetField("<TeamId>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
            sentinel: 0);
        teamId.TypeMapping = IntTypeMapping.Default.Clone(
            comparer: new ValueComparer<int>(
                (int v1, int v2) => v1 == v2,
                (int v) => v,
                (int v) => v),
            keyComparer: new ValueComparer<int>(
                (int v1, int v2) => v1 == v2,
                (int v) => v,
                (int v) => v),
            providerValueComparer: new ValueComparer<int>(
                (int v1, int v2) => v1 == v2,
                (int v) => v,
                (int v) => v),
            mappingInfo: new RelationalTypeMappingInfo(
                storeTypeName: "integer"));
        teamId.AddAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.None);

        var userId = runtimeEntityType.AddProperty(
            "UserId",
            typeof(Guid?),
            propertyInfo: typeof(Submission).GetProperty("UserId", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
            fieldInfo: typeof(Submission).GetField("<UserId>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
            nullable: true);
        userId.TypeMapping = GuidTypeMapping.Default.Clone(
            comparer: new ValueComparer<Guid?>(
                (Nullable<Guid> v1, Nullable<Guid> v2) => v1.HasValue && v2.HasValue && (Guid)v1 == (Guid)v2 || !v1.HasValue && !v2.HasValue,
                (Nullable<Guid> v) => v.HasValue ? ((Guid)v).GetHashCode() : 0,
                (Nullable<Guid> v) => v.HasValue ? (Nullable<Guid>)(Guid)v : default(Nullable<Guid>)),
            keyComparer: new ValueComparer<Guid?>(
                (Nullable<Guid> v1, Nullable<Guid> v2) => v1.HasValue && v2.HasValue && (Guid)v1 == (Guid)v2 || !v1.HasValue && !v2.HasValue,
                (Nullable<Guid> v) => v.HasValue ? ((Guid)v).GetHashCode() : 0,
                (Nullable<Guid> v) => v.HasValue ? (Nullable<Guid>)(Guid)v : default(Nullable<Guid>)),
            providerValueComparer: new ValueComparer<Guid?>(
                (Nullable<Guid> v1, Nullable<Guid> v2) => v1.HasValue && v2.HasValue && (Guid)v1 == (Guid)v2 || !v1.HasValue && !v2.HasValue,
                (Nullable<Guid> v) => v.HasValue ? ((Guid)v).GetHashCode() : 0,
                (Nullable<Guid> v) => v.HasValue ? (Nullable<Guid>)(Guid)v : default(Nullable<Guid>)),
            mappingInfo: new RelationalTypeMappingInfo(
                storeTypeName: "uuid"));
        userId.AddAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.None);

        var key = runtimeEntityType.AddKey(
            new[] { id });
        runtimeEntityType.SetPrimaryKey(key);

        var index = runtimeEntityType.AddIndex(
            new[] { challengeId });

        var index0 = runtimeEntityType.AddIndex(
            new[] { gameId });

        var index1 = runtimeEntityType.AddIndex(
            new[] { participationId });

        var index2 = runtimeEntityType.AddIndex(
            new[] { userId });

        var index3 = runtimeEntityType.AddIndex(
            new[] { teamId, challengeId, gameId });

        return runtimeEntityType;
    }

    public static RuntimeForeignKey CreateForeignKey1(RuntimeEntityType declaringEntityType, RuntimeEntityType principalEntityType)
    {
        var runtimeForeignKey = declaringEntityType.AddForeignKey(new[] { declaringEntityType.FindProperty("ChallengeId") },
            principalEntityType.FindKey(new[] { principalEntityType.FindProperty("Id") }),
            principalEntityType,
            deleteBehavior: DeleteBehavior.Cascade,
            required: true);

        var gameChallenge = declaringEntityType.AddNavigation("GameChallenge",
            runtimeForeignKey,
            onDependent: true,
            typeof(GameChallenge),
            propertyInfo: typeof(Submission).GetProperty("GameChallenge", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
            fieldInfo: typeof(Submission).GetField("<GameChallenge>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
            eagerLoaded: true);

        var submissions = principalEntityType.AddNavigation("Submissions",
            runtimeForeignKey,
            onDependent: false,
            typeof(List<Submission>),
            propertyInfo: typeof(GameChallenge).GetProperty("Submissions", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
            fieldInfo: typeof(GameChallenge).GetField("<Submissions>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly));

        return runtimeForeignKey;
    }

    public static RuntimeForeignKey CreateForeignKey2(RuntimeEntityType declaringEntityType, RuntimeEntityType principalEntityType)
    {
        var runtimeForeignKey = declaringEntityType.AddForeignKey(new[] { declaringEntityType.FindProperty("GameId") },
            principalEntityType.FindKey(new[] { principalEntityType.FindProperty("Id") }),
            principalEntityType,
            deleteBehavior: DeleteBehavior.Cascade,
            required: true);

        var game = declaringEntityType.AddNavigation("Game",
            runtimeForeignKey,
            onDependent: true,
            typeof(Game),
            propertyInfo: typeof(Submission).GetProperty("Game", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
            fieldInfo: typeof(Submission).GetField("<Game>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly));

        var submissions = principalEntityType.AddNavigation("Submissions",
            runtimeForeignKey,
            onDependent: false,
            typeof(List<Submission>),
            propertyInfo: typeof(Game).GetProperty("Submissions", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
            fieldInfo: typeof(Game).GetField("<Submissions>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly));

        return runtimeForeignKey;
    }

    public static RuntimeForeignKey CreateForeignKey3(RuntimeEntityType declaringEntityType, RuntimeEntityType principalEntityType)
    {
        var runtimeForeignKey = declaringEntityType.AddForeignKey(new[] { declaringEntityType.FindProperty("ParticipationId") },
            principalEntityType.FindKey(new[] { principalEntityType.FindProperty("Id") }),
            principalEntityType,
            deleteBehavior: DeleteBehavior.Cascade,
            required: true);

        var participation = declaringEntityType.AddNavigation("Participation",
            runtimeForeignKey,
            onDependent: true,
            typeof(Participation),
            propertyInfo: typeof(Submission).GetProperty("Participation", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
            fieldInfo: typeof(Submission).GetField("<Participation>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly));

        var submissions = principalEntityType.AddNavigation("Submissions",
            runtimeForeignKey,
            onDependent: false,
            typeof(List<Submission>),
            propertyInfo: typeof(Participation).GetProperty("Submissions", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
            fieldInfo: typeof(Participation).GetField("<Submissions>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly));

        return runtimeForeignKey;
    }

    public static RuntimeForeignKey CreateForeignKey4(RuntimeEntityType declaringEntityType, RuntimeEntityType principalEntityType)
    {
        var runtimeForeignKey = declaringEntityType.AddForeignKey(new[] { declaringEntityType.FindProperty("TeamId") },
            principalEntityType.FindKey(new[] { principalEntityType.FindProperty("Id") }),
            principalEntityType,
            deleteBehavior: DeleteBehavior.Cascade,
            required: true);

        var team = declaringEntityType.AddNavigation("Team",
            runtimeForeignKey,
            onDependent: true,
            typeof(Team),
            propertyInfo: typeof(Submission).GetProperty("Team", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
            fieldInfo: typeof(Submission).GetField("<Team>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
            eagerLoaded: true);

        return runtimeForeignKey;
    }

    public static RuntimeForeignKey CreateForeignKey5(RuntimeEntityType declaringEntityType, RuntimeEntityType principalEntityType)
    {
        var runtimeForeignKey = declaringEntityType.AddForeignKey(new[] { declaringEntityType.FindProperty("UserId") },
            principalEntityType.FindKey(new[] { principalEntityType.FindProperty("Id") }),
            principalEntityType,
            deleteBehavior: DeleteBehavior.SetNull);

        var user = declaringEntityType.AddNavigation("User",
            runtimeForeignKey,
            onDependent: true,
            typeof(UserInfo),
            propertyInfo: typeof(Submission).GetProperty("User", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
            fieldInfo: typeof(Submission).GetField("<User>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
            eagerLoaded: true);

        var submissions = principalEntityType.AddNavigation("Submissions",
            runtimeForeignKey,
            onDependent: false,
            typeof(List<Submission>),
            propertyInfo: typeof(UserInfo).GetProperty("Submissions", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
            fieldInfo: typeof(UserInfo).GetField("<Submissions>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly));

        return runtimeForeignKey;
    }

    public static void CreateAnnotations(RuntimeEntityType runtimeEntityType)
    {
        runtimeEntityType.AddAnnotation("Relational:FunctionName", null);
        runtimeEntityType.AddAnnotation("Relational:Schema", null);
        runtimeEntityType.AddAnnotation("Relational:SqlQuery", null);
        runtimeEntityType.AddAnnotation("Relational:TableName", "Submissions");
        runtimeEntityType.AddAnnotation("Relational:ViewName", null);
        runtimeEntityType.AddAnnotation("Relational:ViewSchema", null);

        Customize(runtimeEntityType);
    }

    static partial void Customize(RuntimeEntityType runtimeEntityType);
}
}
