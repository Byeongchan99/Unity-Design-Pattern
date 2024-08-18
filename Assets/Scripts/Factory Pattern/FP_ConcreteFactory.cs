using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace FactoryPattern
{
    public class ConcreteFactory : Factory
    {
        [SerializeField] private ProductA productPrefab;

        public override IProduct GetProduct(Vector3 position)
        {
            // ������ �ν��Ͻ� ���� �� ��ǰ ������Ʈ ��������
            GameObject instance = Instantiate(productPrefab.gameObject, position, Quaternion.identity);
            ProductA newProduct = instance.GetComponent<ProductA>();
            // �� ��ǰ�� ��ü ������ ����
            newProduct.Initialize();
            return newProduct;
        }
    }
}
