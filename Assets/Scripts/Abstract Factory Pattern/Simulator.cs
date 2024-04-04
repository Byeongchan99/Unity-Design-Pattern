using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace AbstractFactory
{
    public class Simulator : MonoBehaviour
    {
        void Start()
        {
            // 고블린 스포너
            EnemySpawner2 goblinSpawner = new EnemySpawner2(new GoblinFactory());
            goblinSpawner.SpawnEnemies();

            // 트롤 스포너
            EnemySpawner2 trollSpawner = new EnemySpawner2(new TrollFactory());
            trollSpawner.SpawnEnemies();
        }
    }
}
