using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Warrior : MonoBehaviour, ICharacter
{
    public int Attack { get; private set; } = 100;
    public int Defense { get; private set; } = 100;
    public Text attackText;
    public Text defenseText;

    public void Update()
    {
        attackText.text = "Attack: " + Attack;
        defenseText.text = "Defense: " + Defense;
    }

    public void Accept(IBuffVisitor visitor)
    {
        visitor.Visit(this);
    }

    // 공격력 증가
    public void IncreaseAttack(int amount)
    {
        Attack += amount;
        Debug.Log("Warrior's Attack Increased: " + Attack);
    }

    // 방어력 증가
    public void IncreaseDefense(int amount)
    {
        Defense += amount;
        Debug.Log("Warrior's Defense Increased: " + Defense);
    }
}
