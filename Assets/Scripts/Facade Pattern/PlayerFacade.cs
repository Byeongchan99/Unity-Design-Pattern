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
        Debug.Log("�÷��̾� �ǰ� ����");

        // ü�� ����
        playerHealth.DecreaseHealth(10);  // ü�� 10 ����

        // ���� ȿ�� ����
        invincibilityEffect.Activate(2);  // 2�ʰ� ����

        // ��������Ʈ ���ڰŸ� ȿ��
        spriteFlicker.StartFlickering(2);  // 2�ʰ� ���ڰŸ�
    }
}
