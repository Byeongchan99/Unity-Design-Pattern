using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace StrategyPattern
{
    // Monster 추상 클래스
    public abstract class Monster
    {
        protected IAttackStrategy attackStrategy;
        protected string name;

        public string Name
        {
            get { return name; } // 값을 읽을 때
            set { name = value; } // 값을 할당할 때
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
                Debug.Log("공격 전략 준비되지 않음");
            }
        }
    }

    // GoblinWarrior 클래스
    public class GoblinWarrior : Monster
    {
        // 고블린 워리어 구현
        public GoblinWarrior()
        {
            name = "고블린 워리어";
        }
    }

    // SkeletonArcher 클래스
    public class SkeletonArcher : Monster
    {
        // 스켈레톤 아쳐 구현
        public SkeletonArcher()
        {
            name = "스켈레톤 아쳐";
        }
    }

    // Slime 클래스
    public class Slime : Monster
    {
        // 슬라임 구현
        public Slime()
        {
            name = "슬라임";
        }
    }
}
