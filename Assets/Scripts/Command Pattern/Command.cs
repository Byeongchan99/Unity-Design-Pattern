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

        // �����ڸ� ���� �÷��̾��� ��ġ�� �̵� ������ �޾ƿ�
        public MoveCommand(Transform playerTransform, Vector3 direction)
        {
            this.playerTransform = playerTransform;
            this.direction = direction;
        }

        // �̵� ����� ����
        public void Execute()
        {
            playerTransform.Translate(direction);
        }
    }
}
