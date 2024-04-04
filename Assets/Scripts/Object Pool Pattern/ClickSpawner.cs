using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ObjectPoolPattern
{
    public class ClickSpawner : MonoBehaviour
    {
        public float objectLifetime = 1.0f; // ������Ʈ�� ������������ �ð�

        private void Update()
        {
            if (Input.GetMouseButtonDown(0)) // ���콺 ���� ��ư Ŭ��
            {
                SpawnObjectAtMousePosition();
            }
        }

        void SpawnObjectAtMousePosition()
        {
            Vector3 mousePos = Input.mousePosition; // ���콺 ��ġ
            mousePos.z = 10.0f; // ī�޶�� ������Ʈ ������ �Ÿ�
            Vector3 worldPosition = Camera.main.ScreenToWorldPoint(mousePos); // ���� ��ġ�� ��ȯ

            GameObject obj = ObjectPool.Instance.GetObject(); // ������Ʈ Ǯ���� ������Ʈ ��������
            obj.transform.position = worldPosition; // Ŭ���� ��ġ�� ������Ʈ ��ġ

            ObjectPool.Instance.ReturnObject(obj, objectLifetime); // ������ �ð� �� ������Ʈ�� Ǯ�� ��ȯ
        }
    }
}
