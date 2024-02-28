using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace FactoryMedthodPattern
{
    // �� �������̽�
    public interface IEnemy
    {
        void Spawn();
    }

    // ����
    public class Zombie : IEnemy
    {
        public void Spawn()
        {
            Debug.Log("���� ��ȯ");
        }
    }

    // ���̷���
    public class Skeleton : IEnemy
    {
        public void Spawn()
        {
            Debug.Log("���̷��� ��ȯ");
        }
    }
}