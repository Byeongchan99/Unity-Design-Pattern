using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace FactoryPattern
{
    public interface IProduct
    {
        string ProductName { get; set; }
        void Initialize();
    }
}
