using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace AbstractFactory
{
    public interface IEnemy
    {
        void Spawn();
    }

    public class GoblinWarrior : IEnemy
    {
        public void Spawn()
        {
            Debug.Log("고블린 전사 소환");
        }
    }

    public class GoblinArcher : IEnemy
    {
        public void Spawn()
        {
            Debug.Log("고블린 궁수 소환");
        }
    }

    public class TrollWarrior : IEnemy
    {
        public void Spawn()
        {
            Debug.Log("트롤 전사 소환");
        }
    }

    public class TrollArcher : IEnemy
    {
        public void Spawn()
        {
            Debug.Log("트롤 궁수 소환");
        }
    }
}
