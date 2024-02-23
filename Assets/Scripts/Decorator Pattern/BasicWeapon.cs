using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace DecoratorPattern
{
   public class BasicWeapon : Weapon
    {
       public override void Attack()
        {
           Debug.Log("Basic Attack");
       }
   }
}