using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : IAudioService
{
    private Dictionary<string, AudioClip> audioClips = new Dictionary<string, AudioClip>();

    // 사운드 클립을 등록하는 메소드
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

    // 소리 재생 및 정지를 로그로 기록
    // 사운드 클립을 재생하는 메소드
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

    // 사운드 클립을 정지하는 메소드
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
