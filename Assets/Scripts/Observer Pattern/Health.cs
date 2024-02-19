using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ObserverPattern
{
    public interface IObserver
    {
        // 주체(Subject)의 상태가 변할 때 호출
        void UpdateObserver();
    }

    public interface ISubject
    {
        // 옵저버 추가, 제거, 알림
        void Attach(IObserver observer);
        void Detach(IObserver observer);
        void Notify();
    }

    public class Health : MonoBehaviour, ISubject
    {
        private List<IObserver> observers = new List<IObserver>();
        private int health = 10;

        // 체력 프로퍼티
        public int HealthValue
        {
            get => health;
            set
            {
                health = value;
                Notify();
            }
        }

        // 옵저버 추가
        public void Attach(IObserver observer)
        {
            observers.Add(observer);
        }

        // 옵저버 제거
        public void Detach(IObserver observer)
        {
            observers.Remove(observer);
        }

        // 모든 옵저버에게 알림
        public void Notify()
        {
            observers.ForEach(observer => observer.UpdateObserver());
        }
    }
}
