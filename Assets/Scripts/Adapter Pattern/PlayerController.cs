using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace AdapterPattern
{
    public class PlayerController : MonoBehaviour
    {
        private IPlayerInput _inputHandler;
        private Rigidbody2D _rb;
        public float jumpForce = 5f; // ���� �� ����
        public float jumpCooldown = 1.5f; // ���� ��Ÿ�� 1.5��
        private float nextJumpTime; // ���� ������ ������ �ð�
        private int currentInputMode = 1; // ���� �Է� ���
        public Text text;

        void Start()
        {
            _inputHandler = new InputAdapter();  // ����� �ν��Ͻ�ȭ
            _rb = GetComponent<Rigidbody2D>();
        }

        void Update()
        {
            // text�� ���� currentInputMode�� ����
            text.text = currentInputMode == 1 ? "Keyboard" : "Gamepad";

            Vector2 movement = _inputHandler.GetMovementDirection(currentInputMode);
            bool jump = _inputHandler.JumpRequested(currentInputMode);

            // ĳ���� �̵�
            transform.Translate(movement * Time.deltaTime);

            // ĳ���� ����
            if (jump && Time.time >= nextJumpTime)
            {
                _rb.AddForce(Vector2.up * jumpForce, ForceMode2D.Impulse);
                nextJumpTime = Time.time + jumpCooldown;  // ���� ���� ���� �ð� ������Ʈ
            }
            
            if (Input.GetKeyDown(KeyCode.LeftShift))
            {
                currentInputMode *= -1; // �Է� ��� ����
            }
        }
    }
}
