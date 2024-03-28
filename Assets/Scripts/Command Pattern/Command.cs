using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace CommandPattern
{
    public interface ICommand
    {
        void Execute();
    }

    public class MoveCommand : ICommand
    {
        private Vector3 direction;
        private Transform playerTransform;

        // 생성자를 통해 플레이어의 위치와 이동 방향을 받아옴
        public MoveCommand(Transform playerTransform, Vector3 direction)
        {
            this.playerTransform = playerTransform;
            this.direction = direction;
        }

        // 이동 명령을 실행
        public void Execute()
        {
            playerTransform.Translate(direction);
        }
    }
}
