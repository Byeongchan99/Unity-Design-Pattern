using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace StatePattern
{
    public class Context
    {
        private IState state;

        // ������
        public Context(IState initialState)
        {
            this.state = initialState;
        }

        // ���� ����
        public void SetState(IState newState)
        {
            this.state = newState;
        }

        // ���� �ൿ
        public void Request()
        {
            state.Handle(this);
        }
    }
}
