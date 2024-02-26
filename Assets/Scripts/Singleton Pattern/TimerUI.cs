using SingletonPattern;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimerUI : MonoBehaviour
{
    public Text timerText;
    public Button togglePauseButton; // �Ͻ�����/�簳�� ����ϴ� ��ư

    private void Start()
    {
        togglePauseButton.onClick.AddListener(TogglePauseResumeGame);
        UpdateButtonText(); // �ʱ� ��ư �ؽ�Ʈ ����
    }

    private void Update()
    {
        timerText.text = $"Time: {GameManager.Instance.Timer:F2}";
    }

    // ���� �Ͻ�����/�簳 ���
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
        UpdateButtonText(); // ��ư �ؽ�Ʈ ������Ʈ
    }

    // ��ư �ؽ�Ʈ ������Ʈ
    void UpdateButtonText()
    {
        // ������ �Ͻ����� ���¶�� ��ư �ؽ�Ʈ�� "Resume"����, �ƴ϶�� "Pause"�� ����
        togglePauseButton.GetComponentInChildren<Text>().text = GameManager.Instance.IsGamePaused ? "Resume" : "Pause";
    }
}
