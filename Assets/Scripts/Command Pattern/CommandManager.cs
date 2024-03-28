using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace CommandPattern
{
    public class CommandManager : MonoBehaviour
    {
        private List<ICommand> commands = new List<ICommand>();
        private IEnumerator<ICommand> replayEnumerator;
        public bool isReplaying = false;
        public Text replayText;

        // 커맨드 저장 및 실행
        public void ExecuteCommand(ICommand command)
        {
            // 커맨드 저장
            commands.Add(command);
            // 커맨드 실행
            command.Execute();
        }

        // 리플레이 시작
        public void StartReplay()
        {
            if (isReplaying) return;
            isReplaying = true;
            // 리플레이 텍스트 변경
            replayText.text = "리플레이 하는 중...";
            // 리플레이 코루틴 시작
            StartCoroutine(ReplayCommands());
        }

        // 리플레이 코루틴
        private IEnumerator ReplayCommands()
        {
            // 반복자 생성
            replayEnumerator = commands.GetEnumerator();
            yield return new WaitForSeconds(1);
            while (replayEnumerator.MoveNext())
            {
                // 현재 반복자의 커맨드 실행
                replayEnumerator.Current.Execute();
                yield return new WaitForSeconds(1);
            }
            isReplaying = false;
            // 리플레이 텍스트 변경
            replayText.text = "리플레이 완료";
            yield return new WaitForSeconds(1);
            replayText.text = "스페이스바를 눌러 리플레이";
        }
    }
}
