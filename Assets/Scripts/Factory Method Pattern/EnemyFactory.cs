using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace FactoryMedthodPattern
{
    public abstract class EnemyFactory
    {
        public abstract IEnemy CreateEnemy();
    }

    // 좀비를 생성하는 팩토리
    public class ZombieFactory : EnemyFactory
    {
        public override IEnemy CreateEnemy()
        {
            return new Zombie();
        }
    }

    // 스켈레톤을 생성하는 팩토리
    public class SkeletonFactory : EnemyFactory
    {
        public override IEnemy CreateEnemy()
        {
            return new Skeleton();
        }
    }
}