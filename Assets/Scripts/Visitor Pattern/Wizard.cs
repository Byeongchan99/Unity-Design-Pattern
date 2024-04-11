using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Wizard : MonoBehaviour, ICharacter
{
    public int Attack { get; private set; } = 80;
    public int Defense { get; private set; } = 50;
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

    // ���ݷ� ����
    public void IncreaseAttack(int amount)
    {
        Attack += amount;
        Debug.Log("Wizard's Attack Increased: " + Attack);
    }

    // ���� ����
    public void IncreaseDefense(int amount)
    {
        Defense += amount;
        Debug.Log("Wizard's Defense Increased: " + Defense);
    }
}
