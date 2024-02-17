using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace StrategyPattern
{
    // Monster �߻� Ŭ����
    public abstract class Monster
    {
        protected IAttackStrategy attackStrategy;
        protected string name;

        public string Name
        {
            get { return name; } // ���� ���� ��
            set { name = value; } // ���� �Ҵ��� ��
        }

        public void SetAttackStrategy(IAttackStrategy strategy)
        {
            this.attackStrategy = strategy;
        }

        public void PerformAttack()
        {
            if (attackStrategy != null)
            {
                attackStrategy.Attack();
            }
            else
            {
                Debug.Log("���� ���� �غ���� ����");
            }
        }
    }

    // GoblinWarrior Ŭ����
    public class GoblinWarrior : Monster
    {
        // ��� ������ ����
        public GoblinWarrior()
        {
            name = "��� ������";
        }
    }

    // SkeletonArcher Ŭ����
    public class SkeletonArcher : Monster
    {
        // ���̷��� ���� ����
        public SkeletonArcher()
        {
            name = "���̷��� ����";
        }
    }

    // Slime Ŭ����
    public class Slime : Monster
    {
        // ������ ����
        public Slime()
        {
            name = "������";
        }
    }
}
