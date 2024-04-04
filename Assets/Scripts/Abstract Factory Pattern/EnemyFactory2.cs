using FactoryMedthodPattern;
using StrategyPattern;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace AbstractFactory
{
    public interface IEnemyFactory
    {
        // ���� ���� ���� ��ȯ
        IEnemy CreateMelee();
        // ���Ÿ� ���� ���� ��ȯ
        IEnemy CreateRanged();
    }

    public class GoblinFactory : IEnemyFactory
    {
        // ��� ����
        public IEnemy CreateMelee()
        {
            return new GoblinWarrior();
        }

        // ��� �ü�
        public IEnemy CreateRanged()
        {
            return new GoblinArcher();
        }
    }

    public class TrollFactory : IEnemyFactory
    {
        // Ʈ�� ����
        public IEnemy CreateMelee()
        {
            return new TrollWarrior();
        }

        // Ʈ�� �ü�
        public IEnemy CreateRanged()
        {
            return new TrollArcher();
        }
    }
}
