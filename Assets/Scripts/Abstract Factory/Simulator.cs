using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace AbstractFactory
{
    public class Simulator : MonoBehaviour
    {
        void Start()
        {
            // ��� ������
            EnemySpawner2 goblinSpawner = new EnemySpawner2(new GoblinFactory());
            goblinSpawner.SpawnEnemies();

            // Ʈ�� ������
            EnemySpawner2 trollSpawner = new EnemySpawner2(new TrollFactory());
            trollSpawner.SpawnEnemies();
        }
    }
}
