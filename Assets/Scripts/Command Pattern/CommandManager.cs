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

        // Ŀ�ǵ� ���� �� ����
        public void ExecuteCommand(ICommand command)
        {
            // Ŀ�ǵ� ����
            commands.Add(command);
            // Ŀ�ǵ� ����
            command.Execute();
        }

        // ���÷��� ����
        public void StartReplay()
        {
            if (isReplaying) return;
            isReplaying = true;
            // ���÷��� �ؽ�Ʈ ����
            replayText.text = "���÷��� �ϴ� ��...";
            // ���÷��� �ڷ�ƾ ����
            StartCoroutine(ReplayCommands());
        }

        // ���÷��� �ڷ�ƾ
        private IEnumerator ReplayCommands()
        {
            // �ݺ��� ����
            replayEnumerator = commands.GetEnumerator();
            yield return new WaitForSeconds(1);
            while (replayEnumerator.MoveNext())
            {
                // ���� �ݺ����� Ŀ�ǵ� ����
                replayEnumerator.Current.Execute();
                yield return new WaitForSeconds(1);
            }
            isReplaying = false;
            // ���÷��� �ؽ�Ʈ ����
            replayText.text = "���÷��� �Ϸ�";
            yield return new WaitForSeconds(1);
            replayText.text = "�����̽��ٸ� ���� ���÷���";
        }
    }
}
