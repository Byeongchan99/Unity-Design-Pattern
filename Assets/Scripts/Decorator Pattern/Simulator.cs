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

            // 기본 무기
            basicWeapon.Attack();
            // 화염 속성 무기
            fireWeapon.Attack();
        }
    }
}