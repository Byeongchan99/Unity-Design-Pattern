using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackBuff : MonoBehaviour, IBuffVisitor
{
    // 전사에게는 공격력 30 증가
    public void Visit(Warrior warrior)
    {
        warrior.IncreaseAttack(30);
    }

    // 마법사에게는 공격력 50 증가
    public void Visit(Wizard wizard)
    {
        wizard.IncreaseAttack(50);
    }
}
