using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioRog : MonoBehaviour
{
    void Start()
    {
        AudioManager audioManager = new AudioManager();
        ServiceLocator.RegisterService<IAudioService>(audioManager);

        // 사운드 재생 테스트
        ServiceLocator.GetService<IAudioService>().PlaySound("music");
        ServiceLocator.GetService<IAudioService>().StopSound("music");

        // 사운드 재생 테스트 2
        ServiceLocator.GetService<IAudioService>().PlaySound("backgroundSound");
        ServiceLocator.GetService<IAudioService>().StopSound("backgroundSound");
    }
}
