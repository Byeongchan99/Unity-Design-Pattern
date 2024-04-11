using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DefenseBuff : MonoBehaviour, IBuffVisitor
{
    // 전사에게는 방어력 20 증가
    public void Visit(Warrior warrior)
    {
        warrior.IncreaseDefense(20);
    }

    // 마법사에게는 방어력 10 증가
    public void Visit(Wizard wizard)
    {
        wizard.IncreaseDefense(10);
    }
}
