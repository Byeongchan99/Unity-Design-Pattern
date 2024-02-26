using SingletonPattern;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimerUI : MonoBehaviour
{
    public Text timerText;
    public Button togglePauseButton; // 일시정지/재개를 토글하는 버튼

    private void Start()
    {
        togglePauseButton.onClick.AddListener(TogglePauseResumeGame);
        UpdateButtonText(); // 초기 버튼 텍스트 설정
    }

    private void Update()
    {
        timerText.text = $"Time: {GameManager.Instance.Timer:F2}";
    }

    // 게임 일시정지/재개 토글
    void TogglePauseResumeGame()
    {
        if (GameManager.Instance.IsGamePaused)
        {
            GameManager.Instance.ResumeGame();
        }
        else
        {
            GameManager.Instance.PauseGame();
        }
        UpdateButtonText(); // 버튼 텍스트 업데이트
    }

    // 버튼 텍스트 업데이트
    void UpdateButtonText()
    {
        // 게임이 일시정지 상태라면 버튼 텍스트를 "Resume"으로, 아니라면 "Pause"로 설정
        togglePauseButton.GetComponentInChildren<Text>().text = GameManager.Instance.IsGamePaused ? "Resume" : "Pause";
    }
}
