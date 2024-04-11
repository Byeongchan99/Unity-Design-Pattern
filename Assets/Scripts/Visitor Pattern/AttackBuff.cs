using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackBuff : MonoBehaviour, IBuffVisitor
{
    // ���翡�Դ� ���ݷ� 30 ����
    public void Visit(Warrior warrior)
    {
        warrior.IncreaseAttack(30);
    }

    // �����翡�Դ� ���ݷ� 50 ����
    public void Visit(Wizard wizard)
    {
        wizard.IncreaseAttack(50);
    }
}
