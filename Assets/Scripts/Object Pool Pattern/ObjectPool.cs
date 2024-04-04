using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Pool;

namespace ObjectPoolPattern
{
    public class ObjectPool : MonoBehaviour
    {
        // 싱글톤 인스턴스
        public static ObjectPool Instance { get; private set; }

        public GameObject objectPrefab; // 풀링할 게임 오브젝트 프리팹
        private ObjectPool<GameObject> pool;
        public Transform objectParent; // 생성된 오브젝트의 부모가 될 트랜스폼

        private void Awake()
        {
            if (Instance == null) Instance = this;
            else Destroy(gameObject);

            // 오브젝트 풀 설정 및 초기화
            pool = new ObjectPool<GameObject>(
                createFunc: () => {
                    var newObj = Instantiate(objectPrefab, objectParent);
                    newObj.SetActive(false);
                    return newObj;
                },
                actionOnGet: (obj) => obj.SetActive(true), // 풀에서 오브젝트를 가져올 때 실행되는 액션
                actionOnRelease: (obj) => obj.SetActive(false), // 오브젝트를 풀로 반환할 때 실행되는 액션
                actionOnDestroy: (obj) => Destroy(obj), // 풀의 최대 크기를 초과하여 오브젝트가 파괴될 때 실행되는 액션
                collectionCheck: false, // 오브젝트를 풀로 반환할 때, 이미 풀에 해당 오브젝트가 있는지 검사할지 여부를 결정
                defaultCapacity: 10, // 오브젝트 풀의 초기 용량최대 용량
                maxSize: 20 // 오브젝트 풀의 최대 용량
            );
        }

        // 오브젝트 풀에서 가져오기
        public GameObject GetObject()
        {
            return pool.Get();
        }

        // 오브젝트 풀에 반환
        public void ReturnObject(GameObject obj, float delay)
        {
            StartCoroutine(ReturnAfterDelay(obj, delay));
        }

        // 딜레이 이후 반환
        private IEnumerator ReturnAfterDelay(GameObject obj, float delay)
        {
            yield return new WaitForSeconds(delay);
            pool.Release(obj);
        }
    }
}
