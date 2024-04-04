using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ObjectPoolPattern
{
    public class ClickSpawner : MonoBehaviour
    {
        public float objectLifetime = 1.0f; // 오브젝트가 사라지기까지의 시간

        private void Update()
        {
            if (Input.GetMouseButtonDown(0)) // 마우스 왼쪽 버튼 클릭
            {
                SpawnObjectAtMousePosition();
            }
        }

        void SpawnObjectAtMousePosition()
        {
            Vector3 mousePos = Input.mousePosition; // 마우스 위치
            mousePos.z = 10.0f; // 카메라와 오브젝트 사이의 거리
            Vector3 worldPosition = Camera.main.ScreenToWorldPoint(mousePos); // 월드 위치로 변환

            GameObject obj = ObjectPool.Instance.GetObject(); // 오브젝트 풀에서 오브젝트 가져오기
            obj.transform.position = worldPosition; // 클릭한 위치에 오브젝트 배치

            ObjectPool.Instance.ReturnObject(obj, objectLifetime); // 설정한 시간 후 오브젝트를 풀로 반환
        }
    }
}
