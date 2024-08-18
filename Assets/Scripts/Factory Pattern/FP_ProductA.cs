using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Pool;

namespace FactoryPattern
{
    public class ProductA : MonoBehaviour, IProduct
    {
        [SerializeField] private string productName = "ProductA";
        public string ProductName { get => productName; set => productName = value; }
        private ParticleSystem productParticleSystem;

        public void Initialize()
        {
            // �� ��ǰ�� ���� ���� ����
            gameObject.name = productName;
            productParticleSystem = GetComponentInChildren<ParticleSystem>();
            productParticleSystem?.Stop();
            productParticleSystem?.Play();
        }
    }
}
