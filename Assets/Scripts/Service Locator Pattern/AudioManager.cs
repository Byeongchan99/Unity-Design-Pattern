using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : IAudioService
{
    private Dictionary<string, AudioClip> audioClips = new Dictionary<string, AudioClip>();

    // ���� Ŭ���� ����ϴ� �޼ҵ�
    public void RegisterSound(string clipName, AudioClip clip)
    {
        if (!audioClips.ContainsKey(clipName))
        {
            audioClips[clipName] = clip;
        }
        else
        {
            Debug.LogWarning("Clip already registered: " + clipName);
        }
    }

    // �Ҹ� ��� �� ������ �α׷� ���
    // ���� Ŭ���� ����ϴ� �޼ҵ�
    public void PlaySound(string clipName)
    {
        /*
        if (audioClips.TryGetValue(clipName, out AudioClip clip))
        {
            audioSource.clip = clip;
            audioSource.Play();
        }
        else
        {
            Debug.LogError("Audio clip not found: " + clipName);
        }
        */

        Debug.Log("Playing sound: " + clipName);
    }

    // ���� Ŭ���� �����ϴ� �޼ҵ�
    public void StopSound(string clipName)
    {
        /*
        if (audioSource.isPlaying && audioSource.clip.name == clipName)
        {
            audioSource.Stop();
        }
        */

        Debug.Log("Stopping sound: " + clipName);
    }
}
