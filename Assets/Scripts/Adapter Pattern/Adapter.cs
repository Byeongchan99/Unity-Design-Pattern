using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Target Interface 구현
public interface IPlayerInput
{
    Vector2 GetMovementDirection(int c); // 이동 입력
    bool JumpRequested(int c); // 점프 입력
}

// Adaptees 구현
public class KeyboardInputHandler
{
    // A키를 누르면 오른쪽으로, D키를 누르면 왼쪽으로 이동
    public Vector2 ReadKeys()
    {
        float x = Input.GetKey(KeyCode.D) ? 1.0f : Input.GetKey(KeyCode.A) ? -1.0f : 0.0f;
        float y = 0;
        return new Vector2(x, y);
    }

    // 스페이스바를 누르면 점프
    public bool IsJumpPressed()
    {
        return Input.GetKey(KeyCode.Space);
    }
}

public class GamepadInputHandler
{
    // 조이스틱을 좌우로 움직이면 좌우로 이동
    public Vector2 ReadJoystick()
    {
        float x = Input.GetAxis("Horizontal");
        float y = 0;
        return new Vector2(x, y);
    }

    // Y 버튼을 누르면 점프 - 현재 게임 패드는 Y 버튼을 점프로 사용
    public bool IsJumpPressed()
    {
        return Input.GetButton("Jump");
    }
}

// Adapter 구현
public class InputAdapter : IPlayerInput
{
    private KeyboardInputHandler _keyboardHandler = new KeyboardInputHandler(); // 키보드
    private GamepadInputHandler _gamepadHandler = new GamepadInputHandler(); // 게임 패드

    // LeftShift 키를 누르면 게임 패드로, 그렇지 않으면 키보드로 입력을 처리
    public Vector2 GetMovementDirection(int currentInputMode)
    {
        if (currentInputMode == 1)
            return _keyboardHandler.ReadKeys();
        else
            return _gamepadHandler.ReadJoystick();
    }

    public bool JumpRequested(int currentInputMode)
    {
        if (currentInputMode == 1)
            return _keyboardHandler.IsJumpPressed();
        else
            return _gamepadHandler.IsJumpPressed();
    }
}
