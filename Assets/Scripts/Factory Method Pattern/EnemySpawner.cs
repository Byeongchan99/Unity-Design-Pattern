using FactoryMedthodPattern;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace FactoryMethodPattern
{
    public class EnemySpawner : MonoBehaviour
    {
        private EnemyFactory enemyFactory;

        // ���� ��ȯ
        public void SpawnZombie()
        {
            SpawnEnemy("Zombie");
        }

        // ���̷��� ��ȯ
        public void SpawnSkeleton()
        {
            SpawnEnemy("Skeleton");
        }

        // type�� ���� ���� ����
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