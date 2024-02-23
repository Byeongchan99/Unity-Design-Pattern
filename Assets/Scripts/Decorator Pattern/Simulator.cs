using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace DecoratorPattern
{
    public class Simulator : MonoBehaviour
    {
        void Start()
        {
            Weapon basicWeapon = new BasicWeapon();
            Weapon fireWeapon = new FireAttackDecorator(basicWeapon);

            // �⺻ ����
            basicWeapon.Attack();
            // ȭ�� �Ӽ� ����
            fireWeapon.Attack();
        }
    }
}