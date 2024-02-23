using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace DecoratorPattern
{
    public class FireAttackDecorator : WeaponDecorator
    {
        public FireAttackDecorator(Weapon weapon) : base(weapon) { }

        // 추가 화염 공격 실행
        public override void Attack()
        {
            base.Attack();
            Debug.Log("Fire Attack");
        }
    }
}