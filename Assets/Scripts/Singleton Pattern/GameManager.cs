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
        // �� ���� ������Ƽ
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
            // ������ �Ͻ����� ���°� �ƴ϶�� Ÿ�̸Ӹ� ����
            if (!IsGamePaused)
            {
                timer += Time.deltaTime;
            }
        }

        // �Ͻ�����
        public void PauseGame()
        {
            IsGamePaused = true;
            Time.timeScale = 0f;
        }

        // ���� �簳
        public void ResumeGame()
        {
            IsGamePaused = false;
            Time.timeScale = 1f;
        }
    }
}
