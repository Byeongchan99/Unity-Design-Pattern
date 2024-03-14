using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace StatePattern
{
    public class Simulator : MonoBehaviour
    {       
        void Start()
        {
            Context character = new Context(new StandingState());
            character.Request();
        }

        private void Update()
        {
            // �����̽��� ������ ��
            if (Input.GetKeyDown(KeyCode.Space))
            {
                // ���� ���·� ��ȯ
                Context character = new Context(new JumpingState());
                character.Request();
            }
            // WŰ ������ ��
            else if (Input.GetKeyDown(KeyCode.W))
            {
                // �̵� ���·� ��ȯ
                Context character = new Context(new MovingState());
                character.Request();
            }
            // SŰ ������ ��
            else if (Input.GetKeyDown(KeyCode.S))
            {
                // ��� ���·� ��ȯ
                Context character = new Context(new StandingState());
                character.Request();
            }
        }
    }
}
