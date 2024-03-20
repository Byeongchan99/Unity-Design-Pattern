using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace EventBusPattern
{
    public class EventBusUI : MonoBehaviour
    {
        public Text scoreText;
        public Text levelText;
        public Text levelTimerText;

        private void OnEnable()
        {
            EventBus.Instance.Subscribe<ScoreUpdateEvent>(OnScoreUpdate);
            EventBus.Instance.Subscribe<LevelUpEvent>(OnLevelUp);
            EventBus.Instance.Subscribe<LevelTimerUpdateEvent>(OnLevelTimerUpdate);
        }

        private void OnDisable()
        {
            EventBus.Instance.Unsubscribe<ScoreUpdateEvent>(OnScoreUpdate);
            EventBus.Instance.Unsubscribe<LevelUpEvent>(OnLevelUp);
            EventBus.Instance.Unsubscribe<LevelTimerUpdateEvent>(OnLevelTimerUpdate);
        }

        private void OnScoreUpdate(object eventData)
        {
            var eventInfo = (ScoreUpdateEvent)eventData;
            scoreText.text = $"Score: {eventInfo.NewScore}";
        }

        private void OnLevelUp(object eventData)
        {
            var eventInfo = (LevelUpEvent)eventData;
            levelText.text = $"Level: {eventInfo.NewLevel}";
        }

        private void OnLevelTimerUpdate(object eventData)
        {
            var eventInfo = (LevelTimerUpdateEvent)eventData;
            levelTimerText.text = $"Time Left: {eventInfo.TimeLeft.ToString("F2")}"; // 소수점 두 자리까지 표시
        }
    }
}
