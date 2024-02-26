using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SingletonPattern
{
    public class GameManager : MonoBehaviour
    {
        public static GameManager Instance { get; private set; }
        public bool IsGamePaused { get; private set; }

        private float timer = 0f;
        // 식 본문 프로퍼티
        public float Timer => timer;

        private void Awake()
        {
            if (Instance == null)
            {
                Instance = this;
                DontDestroyOnLoad(gameObject);
            }
            else
            {
                Destroy(gameObject);
            }
        }

        private void Update()
        {
            // 게임이 일시정지 상태가 아니라면 타이머를 증가
            if (!IsGamePaused)
            {
                timer += Time.deltaTime;
            }
        }

        // 일시정지
        public void PauseGame()
        {
            IsGamePaused = true;
            Time.timeScale = 0f;
        }

        // 게임 재개
        public void ResumeGame()
        {
            IsGamePaused = false;
            Time.timeScale = 1f;
        }
    }
}
