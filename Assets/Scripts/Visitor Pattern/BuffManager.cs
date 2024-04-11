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
        attackBuff.Visit(warrior);
        attackBuff.Visit(wizard);
        defenseBuff.Visit(warrior);
        defenseBuff.Visit(wizard);
    }
}
