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

    // 대기 상태
    public class StandingState : IState
    {
        public void Handle(Context context)
        {
            Debug.Log("대기");
        }
    }

    // 이동 상태
    public class MovingState : IState
    {
        public void Handle(Context context)
        {
            Debug.Log("이동");
        }
    }

    // 점프 상태
    public class JumpingState : IState
    {
        public void Handle(Context context)
        {
            Debug.Log("점프");
        }
    }
}
