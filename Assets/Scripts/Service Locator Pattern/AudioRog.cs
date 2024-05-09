using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioRog : MonoBehaviour
{
    void Start()
    {
        AudioManager audioManager = new AudioManager();
        ServiceLocator.RegisterService<IAudioService>(audioManager);

        // ���� ��� �׽�Ʈ
        ServiceLocator.GetService<IAudioService>().PlaySound("music");
        ServiceLocator.GetService<IAudioService>().StopSound("music");
    }
}
