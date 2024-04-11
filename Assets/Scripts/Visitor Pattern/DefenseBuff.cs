using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DefenseBuff : MonoBehaviour, IBuffVisitor
{
    // ���翡�Դ� ���� 20 ����
    public void Visit(Warrior warrior)
    {
        warrior.IncreaseDefense(20);
    }

    // �����翡�Դ� ���� 10 ����
    public void Visit(Wizard wizard)
    {
        wizard.IncreaseDefense(10);
    }
}
