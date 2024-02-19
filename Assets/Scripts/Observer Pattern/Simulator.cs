using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ObserverPattern
{
    public class Simulator : MonoBehaviour
    {
        public Health playerHealth;

        void Start()
        {
            // 체력 객체가 없으면 새로 생성
            if (playerHealth == null)
            {
                playerHealth = gameObject.AddComponent<Health>();
            }
       
            // 체력 변화를 시뮬레이션하기 위해 코루틴 시작
            StartCoroutine(ChangeHealthEverySecond(Random.Range(0, 6)));
        }

        IEnumerator ChangeHealthEverySecond(int change)
        {
            // 매 초마다 체력을 변경
            while (playerHealth.HealthValue > 0) 
            {
                playerHealth.HealthValue -= change; // 체력 감소
                Debug.Log("현재 체력: " + playerHealth.HealthValue);
                yield return new WaitForSeconds(1); // 1초 대기
            }
            Debug.Log("플레이어 사망");
            yield return null;
        }
    }
}
