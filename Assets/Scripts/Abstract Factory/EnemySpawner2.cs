using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace AbstractFactory
{
    public class EnemySpawner2
    {
        private IEnemyFactory enemyFactory;

        public EnemySpawner2(IEnemyFactory factory)
        {
            enemyFactory = factory;
        }

        // 각 Factory로부터 몬스터를 생성하여 소환
        public void SpawnEnemies()
        {
            IEnemy meleeEnemy = enemyFactory.CreateMelee();
            IEnemy rangedEnemy = enemyFactory.CreateRanged();

            meleeEnemy.Spawn();
            rangedEnemy.Spawn();
        }
    }
}
