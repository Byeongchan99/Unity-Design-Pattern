using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestAudioRog : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        // 사운드 재생 테스트 2
        ServiceLocator.GetService<IAudioService>().PlaySound("backgroundSound");
        ServiceLocator.GetService<IAudioService>().StopSound("backgroundSound");
    }
}
