import {
  BackgroundImage,
  Badge,
  Card,
  Center,
  Group,
  MantineColor,
  Stack,
  Text,
  Title,
  useMantineTheme,
} from '@mantine/core'
import { mdiChevronTripleRight, mdiFlagOutline } from '@mdi/js'
import { Icon } from '@mdi/react'
import { FC } from 'react'
import { useTranslation } from 'react-i18next'
import { Link } from 'react-router'
import { useLanguage } from '@Utils/I18n'
import { getGameStatus, toLimitTag } from '@Hooks/useGame'
import { BasicGameInfoModel } from '@Api'
import classes from '@Styles/HoverCard.module.css'

export enum GameStatus {
  Coming = 'coming',
  OnGoing = 'ongoing',
  Ended = 'ended',
}

export const GameColorMap = new Map<GameStatus, MantineColor>([
  [GameStatus.Coming, 'yellow'],
  [GameStatus.OnGoing, 'green'],
  [GameStatus.Ended, 'blue'],
])

interface GameCardProps {
  game: BasicGameInfoModel
}

export const GameCard: FC<GameCardProps> = ({ game, ...others }) => {
  const theme = useMantineTheme()
  const { t } = useTranslation()
  const { locale } = useLanguage()

  const { summary, title, poster, limit } = game
  const { startTime, endTime, status } = getGameStatus(game)

  const duration = endTime.diff(startTime, 'hours')

  const color = GameColorMap.get(status)

  return (
    <Card {...others} shadow="sm" component={Link} to={`/games/${game.id}`} classNames={classes}>
      <Card.Section>
        <Group wrap="nowrap" align="flex-start">
          <BackgroundImage src={poster ?? ''} h="10rem" maw="20rem" miw="20rem">
            <Center h="100%">{!poster && <Icon path={mdiFlagOutline} size={4} color={theme.colors.gray[5]} />}</Center>
          </BackgroundImage>
          <Stack gap="sm" p="md" w="100%">
            <Group gap={0} justify="space-between" align="flex-start">
              <Stack gap={2}>
                <Group wrap="nowrap" gap="xs">
                  <Badge size="xs" color={color}>
                    {toLimitTag(t, limit)}
                  </Badge>
                  <Badge size="xs" color={color}>
                    {t('game.content.duration', {
                      hours: duration,
                    })}
                  </Badge>
                </Group>
                <Title order={2} ta="left">
                  {title}
                </Title>
              </Stack>
              <Group mt={4} wrap="nowrap" gap={3}>
                <Badge size="xs" color={color}>
                  {startTime.locale(locale).format('L LTS')}
                </Badge>
                <Icon path={mdiChevronTripleRight} size={1} />
                <Badge size="xs" color={color}>
                  {endTime.locale(locale).format('L LTS')}
                </Badge>
              </Group>
            </Group>
            <Text fw={500} size="sm" lineClamp={3}>
              {summary}
            </Text>
          </Stack>
        </Group>
      </Card.Section>
    </Card>
  )
}
