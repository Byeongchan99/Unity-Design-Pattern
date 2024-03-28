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
            // 커맨드 매니저 할당
            commandManager = FindObjectOfType<CommandManager>();
        }

        private void Update()
        {
            // 스페이스바를 누르면 리플레이 시작
            if (Input.GetKeyDown(KeyCode.Space))
            {
                commandManager.StartReplay();
                return;
            }

            ICommand command = null;

            // 방향키 입력에 따라 이동 커맨드 생성
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
