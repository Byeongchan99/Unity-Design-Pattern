using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace StrategyPattern
{
    public class Simulator : MonoBehaviour
    {
        void Start()
        {
            GoblinWarrior goblinWarrior = new GoblinWarrior();
            Debug.Log(goblinWarrior.Name + "의 공격 전략");
            goblinWarrior.SetAttackStrategy(new MeleeAttack());
            goblinWarrior.PerformAttack();

            SkeletonArcher skeletonArcher = new SkeletonArcher();
            Debug.Log(skeletonArcher.Name + "의 공격 전략");
            skeletonArcher.SetAttackStrategy(new RangedAttack());
            skeletonArcher.PerformAttack();

            Slime slime = new Slime();
            Debug.Log(slime.Name + "의 공격 전략");
            slime.SetAttackStrategy(new DashAttack());
            slime.PerformAttack();
        }
    }
}
