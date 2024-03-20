using FactoryMedthodPattern;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace FactoryMethodPattern
{
    public class EnemySpawner : MonoBehaviour
    {
        private EnemyFactory enemyFactory;

        // 좀비 소환
        public void SpawnZombie()
        {
            SpawnEnemy("Zombie");
        }

        // 스켈레톤 소환
        public void SpawnSkeleton()
        {
            SpawnEnemy("Skeleton");
        }

        // type에 따라 적을 생성
        void SpawnEnemy(string type)
        {
            switch (type)
            {
                case "Zombie":
                    enemyFactory = new ZombieFactory();
                    break;
                case "Skeleton":
                    enemyFactory = new SkeletonFactory();
                    break;
                default:
                    Debug.LogError("Unknown enemy type.");
                    return;
            }

            IEnemy enemy = enemyFactory.CreateEnemy();
            enemy.Spawn();
        }
    }
}