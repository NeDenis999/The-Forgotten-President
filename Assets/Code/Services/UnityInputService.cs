using UnityEngine;

namespace Code.Services
{
    public class UnityInputService : IInputService
    {
        public Vector2 leftStick => 
            new(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"));
        
        public Vector2 rightStick { get; }
        public bool action1WasPressed { get; }
        public bool action1IsPressed { get; }
        public bool action1WasReleased { get; }
        public float action1PressedTime { get; }
    }
}