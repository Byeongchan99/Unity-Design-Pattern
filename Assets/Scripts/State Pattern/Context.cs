using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace StatePattern
{
    public class Context
    {
        private IState state;

        // 생성자
        public Context(IState initialState)
        {
            this.state = initialState;
        }

        // 상태 설정
        public void SetState(IState newState)
        {
            this.state = newState;
        }

        // 상태 행동
        public void Request()
        {
            state.Handle(this);
        }
    }
}
