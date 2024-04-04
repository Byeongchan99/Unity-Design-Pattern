using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Pool;

namespace ObjectPoolPattern
{
    public class ObjectPool : MonoBehaviour
    {
        // �̱��� �ν��Ͻ�
        public static ObjectPool Instance { get; private set; }

        public GameObject objectPrefab; // Ǯ���� ���� ������Ʈ ������
        private ObjectPool<GameObject> pool;
        public Transform objectParent; // ������ ������Ʈ�� �θ� �� Ʈ������

        private void Awake()
        {
            if (Instance == null) Instance = this;
            else Destroy(gameObject);

            // ������Ʈ Ǯ ���� �� �ʱ�ȭ
            pool = new ObjectPool<GameObject>(
                createFunc: () => {
                    var newObj = Instantiate(objectPrefab, objectParent);
                    newObj.SetActive(false);
                    return newObj;
                },
                actionOnGet: (obj) => obj.SetActive(true), // Ǯ���� ������Ʈ�� ������ �� ����Ǵ� �׼�
                actionOnRelease: (obj) => obj.SetActive(false), // ������Ʈ�� Ǯ�� ��ȯ�� �� ����Ǵ� �׼�
                actionOnDestroy: (obj) => Destroy(obj), // Ǯ�� �ִ� ũ�⸦ �ʰ��Ͽ� ������Ʈ�� �ı��� �� ����Ǵ� �׼�
                collectionCheck: false, // ������Ʈ�� Ǯ�� ��ȯ�� ��, �̹� Ǯ�� �ش� ������Ʈ�� �ִ��� �˻����� ���θ� ����
                defaultCapacity: 10, // ������Ʈ Ǯ�� �ʱ� �뷮�ִ� �뷮
                maxSize: 20 // ������Ʈ Ǯ�� �ִ� �뷮
            );
        }

        // ������Ʈ Ǯ���� ��������
        public GameObject GetObject()
        {
            return pool.Get();
        }

        // ������Ʈ Ǯ�� ��ȯ
        public void ReturnObject(GameObject obj, float delay)
        {
            StartCoroutine(ReturnAfterDelay(obj, delay));
        }

        // ������ ���� ��ȯ
        private IEnumerator ReturnAfterDelay(GameObject obj, float delay)
        {
            yield return new WaitForSeconds(delay);
            pool.Release(obj);
        }
    }
}
