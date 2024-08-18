using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace FactoryPattern
{
    public abstract class Factory : MonoBehaviour
    {
        public abstract IProduct GetProduct(Vector3 position);

        // 모든 팩토리와 공유되는 메서드
    }
}
