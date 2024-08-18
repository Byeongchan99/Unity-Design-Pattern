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
            // 프리팹 인스턴스 생성 및 제품 컴포넌트 가져오기
            GameObject instance = Instantiate(productPrefab.gameObject, position, Quaternion.identity);
            ProductA newProduct = instance.GetComponent<ProductA>();
            // 각 제품은 자체 로직을 가짐
            newProduct.Initialize();
            return newProduct;
        }
    }
}
