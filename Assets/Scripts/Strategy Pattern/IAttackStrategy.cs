using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace StrategyPattern
{
    // IAttackStrategy 인터페이스
    public interface IAttackStrategy
    {
        void Attack();
    }

    // MeleeAttack 클래스
    public class MeleeAttack : IAttackStrategy
    {
        public void Attack()
        {
            Debug.Log("근접 공격 실행");
        }
    }

    // RangedAttack 클래스
    public class RangedAttack : IAttackStrategy
    {
        public void Attack()
        {
            Debug.Log("원거리 공격 실행");
        }
    }

    // DashAttack 클래스
    public class DashAttack : IAttackStrategy
    {
        public void Attack()
        {
            Debug.Log("돌진 공격 실행");
        }
    }
}