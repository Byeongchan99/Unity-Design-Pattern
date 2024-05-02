using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerFacade : MonoBehaviour
{
    [SerializeField] private PlayerHealth playerHealth;
    [SerializeField] private InvincibilityEffect invincibilityEffect;
    [SerializeField] private SpriteFlicker spriteFlicker;

    public PlayerFacade(PlayerHealth health, InvincibilityEffect invincibility, SpriteFlicker flicker)
    {
        this.playerHealth = health;
        this.invincibilityEffect = invincibility;
        this.spriteFlicker = flicker;
    }

    public void HitByMonster()
    {
        Debug.Log("플레이어 피격 당함");

        // 체력 감소
        playerHealth.DecreaseHealth(10);  // 체력 10 감소

        // 무적 효과 적용
        invincibilityEffect.Activate(2);  // 2초간 무적

        // 스프라이트 깜박거림 효과
        spriteFlicker.StartFlickering(2);  // 2초간 깜박거림
    }
}
