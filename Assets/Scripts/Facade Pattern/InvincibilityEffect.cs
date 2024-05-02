using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InvincibilityEffect : MonoBehaviour
{
    public void Activate(float duration)
    {
        Debug.Log($"플레이어 {duration}초 동안 무적 효과 적용");
    }
}
