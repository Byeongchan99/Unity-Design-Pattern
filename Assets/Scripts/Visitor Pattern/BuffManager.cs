using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuffManager : MonoBehaviour
{
    public Warrior warrior;
    public Wizard wizard;
    public AttackBuff attackBuff;
    public DefenseBuff defenseBuff;

    // 버프 적용
    public void ApplyBuffs()
    {
        warrior.Accept(attackBuff);
        warrior.Accept(defenseBuff);
        wizard.Accept(attackBuff);
        wizard.Accept(defenseBuff);
    }
}
