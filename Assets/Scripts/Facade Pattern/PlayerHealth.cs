using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    public int health = 100;

    public void DecreaseHealth(int amount)
    {
        health -= amount;
        Debug.Log($"�÷��̾� ü�� {amount} ����! ���� ü��: {health}");
    }
}
