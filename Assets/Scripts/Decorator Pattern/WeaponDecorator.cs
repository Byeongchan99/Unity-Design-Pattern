using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace DecoratorPattern
{
    public abstract class WeaponDecorator : Weapon
    {
        protected Weapon weapon;

        public WeaponDecorator(Weapon weapon)
        {
            this.weapon = weapon;
        }

        public override void Attack()
        {
            weapon.Attack();
        }
    }
}