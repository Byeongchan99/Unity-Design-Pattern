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

        // �� Factory�κ��� ���͸� �����Ͽ� ��ȯ
        public void SpawnEnemies()
        {
            IEnemy meleeEnemy = enemyFactory.CreateMelee();
            IEnemy rangedEnemy = enemyFactory.CreateRanged();

            meleeEnemy.Spawn();
            rangedEnemy.Spawn();
        }
    }
}
