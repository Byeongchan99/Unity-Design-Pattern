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
            Debug.Log("��� ���� ��ȯ");
        }
    }

    public class GoblinArcher : IEnemy
    {
        public void Spawn()
        {
            Debug.Log("��� �ü� ��ȯ");
        }
    }

    public class TrollWarrior : IEnemy
    {
        public void Spawn()
        {
            Debug.Log("Ʈ�� ���� ��ȯ");
        }
    }

    public class TrollArcher : IEnemy
    {
        public void Spawn()
        {
            Debug.Log("Ʈ�� �ü� ��ȯ");
        }
    }
}
