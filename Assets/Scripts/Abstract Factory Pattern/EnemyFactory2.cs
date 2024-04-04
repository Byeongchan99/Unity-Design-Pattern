using FactoryMedthodPattern;
using StrategyPattern;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace AbstractFactory
{
    public interface IEnemyFactory
    {
        // 근접 공격 몬스터 소환
        IEnemy CreateMelee();
        // 원거리 공격 몬스터 소환
        IEnemy CreateRanged();
    }

    public class GoblinFactory : IEnemyFactory
    {
        // 고블린 전사
        public IEnemy CreateMelee()
        {
            return new GoblinWarrior();
        }

        // 고블린 궁수
        public IEnemy CreateRanged()
        {
            return new GoblinArcher();
        }
    }

    public class TrollFactory : IEnemyFactory
    {
        // 트롤 전사
        public IEnemy CreateMelee()
        {
            return new TrollWarrior();
        }

        // 트롤 궁수
        public IEnemy CreateRanged()
        {
            return new TrollArcher();
        }
    }
}
