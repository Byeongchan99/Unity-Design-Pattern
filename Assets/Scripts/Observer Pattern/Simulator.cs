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
            // ü�� ��ü�� ������ ���� ����
            if (playerHealth == null)
            {
                playerHealth = gameObject.AddComponent<Health>();
            }
       
            // ü�� ��ȭ�� �ùķ��̼��ϱ� ���� �ڷ�ƾ ����
            StartCoroutine(ChangeHealthEverySecond(Random.Range(0, 6)));
        }

        IEnumerator ChangeHealthEverySecond(int change)
        {
            // �� �ʸ��� ü���� ����
            while (playerHealth.HealthValue > 0) 
            {
                playerHealth.HealthValue -= change; // ü�� ����
                Debug.Log("���� ü��: " + playerHealth.HealthValue);
                yield return new WaitForSeconds(1); // 1�� ���
            }
            Debug.Log("�÷��̾� ���");
            yield return null;
        }
    }
}
