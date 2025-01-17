import {
  ActionIcon,
  Card,
  Group,
  Progress,
  Stack,
  Switch,
  Text,
  Tooltip,
  useMantineColorScheme,
  useMantineTheme,
} from '@mantine/core'
import { mdiDatabaseEditOutline, mdiPuzzleEditOutline } from '@mdi/js'
import { Icon } from '@mdi/react'
import { Dispatch, FC, SetStateAction, useState } from 'react'
import { useTranslation } from 'react-i18next'
import { Link, useParams } from 'react-router'
import { useChallengeCategoryLabelMap } from '@Utils/Shared'
import { ChallengeInfoModel, ChallengeCategory } from '@Api'
import classes from '@Styles/ChallengeEditCard.module.css'

interface ChallengeEditCardProps {
  challenge: ChallengeInfoModel
  onToggle: (challenge: ChallengeInfoModel, setDisabled: Dispatch<SetStateAction<boolean>>) => void
}

export const ChallengeEditCard: FC<ChallengeEditCardProps> = ({ challenge, onToggle }) => {
  const challengeCategoryLabelMap = useChallengeCategoryLabelMap()
  const data = challengeCategoryLabelMap.get(challenge.category as ChallengeCategory)
  const theme = useMantineTheme()
  const { id } = useParams()

  const [disabled, setDisabled] = useState(false)

  const { t } = useTranslation()
  const { colorScheme } = useMantineColorScheme()

  const color = data?.color ?? theme.primaryColor
  const colors = theme.colors[color]

  const minIdx = colorScheme === 'dark' ? 8 : 6
  const curIdx = colorScheme === 'dark' ? 6 : 4

  const [min, cur, tot] = [challenge.minScore ?? 0, challenge.score ?? 500, challenge.originalScore ?? 500]
  const minRate = (min / tot) * 100
  const curRate = (cur / tot) * 100

  const contentWidth = 'calc(100% - 12rem)'

  return (
    <Card shadow="sm" p="sm">
      <Group wrap="nowrap" justify="space-between" gap="xs">
        <Switch
          color={color}
          disabled={disabled}
          checked={challenge.isEnabled}
          onChange={() => onToggle(challenge, setDisabled)}
        />

        <Icon path={data!.icon} color={theme.colors[data?.color ?? theme.primaryColor][5]} size={1.2} />

        <Stack gap={0} maw={contentWidth} miw={contentWidth}>
          <Text truncate fw="bold">
            {challenge.title}
          </Text>
          <Text size="sm" fw="bold" ff="monospace" w="5rem">
            {challenge.score}
            <Text span fw="bold" c="dimmed">
              /{challenge.originalScore}pts
            </Text>
          </Text>
        </Stack>

        <Tooltip label={t('admin.button.challenges.edit')} position="left" offset={10} classNames={classes}>
          <ActionIcon c={color} component={Link} to={`/admin/games/${id}/challenges/${challenge.id}`}>
            <Icon path={mdiPuzzleEditOutline} size={1} />
          </ActionIcon>
        </Tooltip>
        <Tooltip
          label={t('admin.button.challenges.edit_more')}
          ta="end"
          position="left"
          offset={54}
          classNames={classes}
        >
          <ActionIcon c={color} component={Link} to={`/admin/games/${id}/challenges/${challenge.id}/flags`}>
            <Icon path={mdiDatabaseEditOutline} size={1} />
          </ActionIcon>
        </Tooltip>
      </Group>

      <Card.Section mt="sm">
        <Progress.Root radius={0}>
          <Progress.Section value={minRate} color={colors[minIdx]} />
          <Progress.Section value={curRate - minRate} color={colors[curIdx]} />
        </Progress.Root>
      </Card.Section>
    </Card>
  )
}
