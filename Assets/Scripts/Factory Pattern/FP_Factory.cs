using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace FactoryPattern
{
    public abstract class Factory : MonoBehaviour
    {
        public abstract IProduct GetProduct(Vector3 position);

        // ��� ���丮�� �����Ǵ� �޼���
    }
}
