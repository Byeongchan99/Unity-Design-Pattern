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
        public float jumpForce = 5f; // 점프 힘 설정
        public float jumpCooldown = 1.5f; // 점프 쿨타임 1.5초
        private float nextJumpTime; // 다음 점프가 가능한 시간
        private int currentInputMode = 1; // 현재 입력 모드
        public Text text;

        void Start()
        {
            _inputHandler = new InputAdapter();  // 어댑터 인스턴스화
            _rb = GetComponent<Rigidbody2D>();
        }

        void Update()
        {
            // text의 값을 currentInputMode로 설정
            text.text = currentInputMode == 1 ? "Keyboard" : "Gamepad";

            Vector2 movement = _inputHandler.GetMovementDirection(currentInputMode);
            bool jump = _inputHandler.JumpRequested(currentInputMode);

            // 캐릭터 이동
            transform.Translate(movement * Time.deltaTime);

            // 캐릭터 점프
            if (jump && Time.time >= nextJumpTime)
            {
                _rb.AddForce(Vector2.up * jumpForce, ForceMode2D.Impulse);
                nextJumpTime = Time.time + jumpCooldown;  // 다음 점프 가능 시간 업데이트
            }
            
            if (Input.GetKeyDown(KeyCode.LeftShift))
            {
                currentInputMode *= -1; // 입력 모드 변경
            }
        }
    }
}
