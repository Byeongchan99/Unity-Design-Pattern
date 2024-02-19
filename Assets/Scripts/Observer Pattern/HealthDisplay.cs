using ObserverPattern;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ObserverPattern
{
    public class HealthDisplay : MonoBehaviour, IObserver
    {
        private Health subject;

        // 게임 시작 시 자신을 'Health' 객체의 옵저버로 등록
        void Start()
        {
            subject = FindObjectOfType<Health>();
            Debug.Log("HealthDisplay 객체 생성");
            subject.Attach(this);
        }

        // 주체(Subject)의 상태가 변할 때 호출
        public void UpdateObserver()
        {
            Debug.Log($"체력 업데이트: {subject.HealthValue}");
        }

        // 객체가 파괴될 때 옵저버 목록에서 제거
        void OnDestroy()
        {
            Debug.Log("HealthDisplay 객체 파괴");
            subject.Detach(this);
        }
    }
}