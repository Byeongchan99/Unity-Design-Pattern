using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    public int health = 100;

    public void DecreaseHealth(int amount)
    {
        health -= amount;
        Debug.Log($"플레이어 체력 {amount} 감소! 현재 체력: {health}");
    }
}
