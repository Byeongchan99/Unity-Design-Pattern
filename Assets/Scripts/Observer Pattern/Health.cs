using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ObserverPattern
{
    public interface IObserver
    {
        // ��ü(Subject)�� ���°� ���� �� ȣ��
        void UpdateObserver();
    }

    public interface ISubject
    {
        // ������ �߰�, ����, �˸�
        void Attach(IObserver observer);
        void Detach(IObserver observer);
        void Notify();
    }

    public class Health : MonoBehaviour, ISubject
    {
        private List<IObserver> observers = new List<IObserver>();
        private int health = 10;

        // ü�� ������Ƽ
        public int HealthValue
        {
            get => health;
            set
            {
                health = value;
                Notify();
            }
        }

        // ������ �߰�
        public void Attach(IObserver observer)
        {
            observers.Add(observer);
        }

        // ������ ����
        public void Detach(IObserver observer)
        {
            observers.Remove(observer);
        }

        // ��� ���������� �˸�
        public void Notify()
        {
            observers.ForEach(observer => observer.UpdateObserver());
        }
    }
}
