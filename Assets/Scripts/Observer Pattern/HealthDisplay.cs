using ObserverPattern;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ObserverPattern
{
    public class HealthDisplay : MonoBehaviour, IObserver
    {
        private Health subject;

        // ���� ���� �� �ڽ��� 'Health' ��ü�� �������� ���
        void Start()
        {
            subject = FindObjectOfType<Health>();
            Debug.Log("HealthDisplay ��ü ����");
            subject.Attach(this);
        }

        // ��ü(Subject)�� ���°� ���� �� ȣ��
        public void UpdateObserver()
        {
            Debug.Log($"ü�� ������Ʈ: {subject.HealthValue}");
        }

        // ��ü�� �ı��� �� ������ ��Ͽ��� ����
        void OnDestroy()
        {
            Debug.Log("HealthDisplay ��ü �ı�");
            subject.Detach(this);
        }
    }
}