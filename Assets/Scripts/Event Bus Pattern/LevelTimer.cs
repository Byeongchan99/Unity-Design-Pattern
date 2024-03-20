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
        private float scoreTimer = 1f; // 점수가 증가하기까지의 타이머

        private void Update()
        {
            // 레벨 업 로직
            levelTimer -= Time.deltaTime;
            if (levelTimer <= 0f)
            {
                level++;
                levelTimer = 10f;
                EventBus.Instance.Publish(new LevelUpEvent(level));
            }

            // 점수 업데이트 로직 수정
            scoreTimer -= Time.deltaTime;
            if (scoreTimer <= 0f)
            {
                score++;
                scoreTimer = 1f; // 1초마다 점수 증가
                EventBus.Instance.Publish(new ScoreUpdateEvent(score));
            }

            // 남은 시간 업데이트 이벤트
            EventBus.Instance.Publish(new LevelTimerUpdateEvent(levelTimer));
        }
    }
}
