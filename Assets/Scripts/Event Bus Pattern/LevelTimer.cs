using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace EventBusPattern
{
    public class LevelTimer : MonoBehaviour
    {
        private int score = 0;
        private int level = 1;
        private float levelTimer = 10f;
        private float scoreTimer = 1f; // ������ �����ϱ������ Ÿ�̸�

        private void Update()
        {
            // ���� �� ����
            levelTimer -= Time.deltaTime;
            if (levelTimer <= 0f)
            {
                level++;
                levelTimer = 10f;
                EventBus.Instance.Publish(new LevelUpEvent(level));
            }

            // ���� ������Ʈ ���� ����
            scoreTimer -= Time.deltaTime;
            if (scoreTimer <= 0f)
            {
                score++;
                scoreTimer = 1f; // 1�ʸ��� ���� ����
                EventBus.Instance.Publish(new ScoreUpdateEvent(score));
            }

            // ���� �ð� ������Ʈ �̺�Ʈ
            EventBus.Instance.Publish(new LevelTimerUpdateEvent(levelTimer));
        }
    }
}
