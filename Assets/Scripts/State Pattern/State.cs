using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEditor.Timeline.TimelinePlaybackControls;

namespace StatePattern
{
    public interface IState
    {
        void Handle(Context context);
    }

    // ��� ����
    public class StandingState : IState
    {
        public void Handle(Context context)
        {
            Debug.Log("���");
        }
    }

    // �̵� ����
    public class MovingState : IState
    {
        public void Handle(Context context)
        {
            Debug.Log("�̵�");
        }
    }

    // ���� ����
    public class JumpingState : IState
    {
        public void Handle(Context context)
        {
            Debug.Log("����");
        }
    }
}
