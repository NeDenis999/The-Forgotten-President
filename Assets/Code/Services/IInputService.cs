using UnityEngine;

namespace Code.Services
{
    public interface IInputService
    {
        Vector2 leftStick {get;}
        Vector2 rightStick {get;}
        bool action1WasPressed {get;}
        bool action1IsPressed {get;}
        bool action1WasReleased {get;}
        float action1PressedTime {get;}
    }
}