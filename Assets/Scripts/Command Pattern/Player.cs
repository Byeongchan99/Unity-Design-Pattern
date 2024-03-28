using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace CommandPattern
{
    public class Player : MonoBehaviour
    {
        private CommandManager commandManager;

        private void Start()
        {
            // Ŀ�ǵ� �Ŵ��� �Ҵ�
            commandManager = FindObjectOfType<CommandManager>();
        }

        private void Update()
        {
            // �����̽��ٸ� ������ ���÷��� ����
            if (Input.GetKeyDown(KeyCode.Space))
            {
                commandManager.StartReplay();
                return;
            }

            ICommand command = null;

            // ����Ű �Է¿� ���� �̵� Ŀ�ǵ� ����
            if (Input.GetKeyDown(KeyCode.UpArrow))
            {
                command = new MoveCommand(this.transform, Vector3.up);
            }
            else if (Input.GetKeyDown(KeyCode.DownArrow))
            {
                command = new MoveCommand(this.transform, Vector3.down);
            }
            else if (Input.GetKeyDown(KeyCode.LeftArrow))
            {
                command = new MoveCommand(this.transform, Vector3.left);
            }
            else if (Input.GetKeyDown(KeyCode.RightArrow))
            {
                command = new MoveCommand(this.transform, Vector3.right);
            }

            if (command != null && !commandManager.isReplaying)
            {
                commandManager.ExecuteCommand(command);
            }
        }
    }
}
