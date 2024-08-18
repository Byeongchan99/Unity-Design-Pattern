using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace FactoryPattern
{
    public class FP_GameManager : MonoBehaviour
    {
        [SerializeField] private ConcreteFactory factory;

        private void Start()
        {
            
        }

        private void Update()
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                
            }
        }
    }
}
