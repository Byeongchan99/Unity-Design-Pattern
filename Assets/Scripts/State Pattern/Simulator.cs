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
            // 스페이스바 눌렀을 때
            if (Input.GetKeyDown(KeyCode.Space))
            {
                // 점프 상태로 전환
                Context character = new Context(new JumpingState());
                character.Request();
            }
            // W키 눌렀을 때
            else if (Input.GetKeyDown(KeyCode.W))
            {
                // 이동 상태로 전환
                Context character = new Context(new MovingState());
                character.Request();
            }
            // S키 눌렀을 때
            else if (Input.GetKeyDown(KeyCode.S))
            {
                // 대기 상태로 전환
                Context character = new Context(new StandingState());
                character.Request();
            }
        }
    }
}
