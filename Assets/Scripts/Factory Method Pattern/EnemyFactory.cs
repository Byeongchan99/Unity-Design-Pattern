using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace FactoryMedthodPattern
{
    public abstract class EnemyFactory
    {
        public abstract IEnemy CreateEnemy();
    }

    // ���� �����ϴ� ���丮
    public class ZombieFactory : EnemyFactory
    {
        public override IEnemy CreateEnemy()
        {
            return new Zombie();
        }
    }

    // ���̷����� �����ϴ� ���丮
    public class SkeletonFactory : EnemyFactory
    {
        public override IEnemy CreateEnemy()
        {
            return new Skeleton();
        }
    }
}