using Code.Services;
using Entitas;
using UnityEngine;

namespace Code.Systems
{
    public class LeftStickInputSystem : IInitializeSystem, IExecuteSystem
    {
        private readonly InputContext _input;
        
        public LeftStickInputSystem(InputContext input)
        {
            _input = input;
        }

        public void Initialize()
        {
            _input.ReplaceLeftStickInput(new Vector2(0, 0));
        }

        public void Execute()
        {
            _input.ReplaceLeftStickInput(_input.inputService.Value.leftStick);
        }
    }
}