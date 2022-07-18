using Code.Services;
using Entitas;
using UnityEngine;

namespace Code.Systems
{
    public class RegisterInputServiceSystem : IInitializeSystem
    {
        private readonly InputContext _input;
        private readonly IInputService _inputService;

        public RegisterInputServiceSystem(InputContext input, IInputService inputService)
        {
            _input = input;

            Debug.Log(inputService);
            _inputService = inputService;
        }

        public void Initialize()
        {
            _input.isInputManger = true;
            _input.ReplaceInputService(_inputService);
            //_input.inputService.Value = _inputService;
            /*_input. = true;
            _input.isKeyboard = true;*/
        }
    }
}