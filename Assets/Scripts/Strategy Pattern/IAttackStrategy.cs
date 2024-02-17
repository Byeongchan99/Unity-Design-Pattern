using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace StrategyPattern
{
    // IAttackStrategy �������̽�
    public interface IAttackStrategy
    {
        void Attack();
    }

    // MeleeAttack Ŭ����
    public class MeleeAttack : IAttackStrategy
    {
        public void Attack()
        {
            Debug.Log("���� ���� ����");
        }
    }

    // RangedAttack Ŭ����
    public class RangedAttack : IAttackStrategy
    {
        public void Attack()
        {
            Debug.Log("���Ÿ� ���� ����");
        }
    }

    // DashAttack Ŭ����
    public class DashAttack : IAttackStrategy
    {
        public void Attack()
        {
            Debug.Log("���� ���� ����");
        }
    }
}