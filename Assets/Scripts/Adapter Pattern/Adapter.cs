using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Target Interface ����
public interface IPlayerInput
{
    Vector2 GetMovementDirection(int c); // �̵� �Է�
    bool JumpRequested(int c); // ���� �Է�
}

// Adaptees ����
public class KeyboardInputHandler
{
    // AŰ�� ������ ����������, DŰ�� ������ �������� �̵�
    public Vector2 ReadKeys()
    {
        float x = Input.GetKey(KeyCode.D) ? 1.0f : Input.GetKey(KeyCode.A) ? -1.0f : 0.0f;
        float y = 0;
        return new Vector2(x, y);
    }

    // �����̽��ٸ� ������ ����
    public bool IsJumpPressed()
    {
        return Input.GetKey(KeyCode.Space);
    }
}

public class GamepadInputHandler
{
    // ���̽�ƽ�� �¿�� �����̸� �¿�� �̵�
    public Vector2 ReadJoystick()
    {
        float x = Input.GetAxis("Horizontal");
        float y = 0;
        return new Vector2(x, y);
    }

    // Y ��ư�� ������ ���� - ���� ���� �е�� Y ��ư�� ������ ���
    public bool IsJumpPressed()
    {
        return Input.GetButton("Jump");
    }
}

// Adapter ����
public class InputAdapter : IPlayerInput
{
    private KeyboardInputHandler _keyboardHandler = new KeyboardInputHandler(); // Ű����
    private GamepadInputHandler _gamepadHandler = new GamepadInputHandler(); // ���� �е�

    // LeftShift Ű�� ������ ���� �е��, �׷��� ������ Ű����� �Է��� ó��
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
