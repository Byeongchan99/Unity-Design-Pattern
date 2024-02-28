using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace FactoryMedthodPattern
{
    // 적 인터페이스
    public interface IEnemy
    {
        void Spawn();
    }

    // 좀비
    public class Zombie : IEnemy
    {
        public void Spawn()
        {
            Debug.Log("좀비 소환");
        }
    }

    // 스켈레톤
    public class Skeleton : IEnemy
    {
        public void Spawn()
        {
            Debug.Log("스켈레톤 소환");
        }
    }
}