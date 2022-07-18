using Code.Services;
using Entitas;

namespace Code.Systems
{
    public class EmitInputSystem : IInitializeSystem, IExecuteSystem 
    {    
        Contexts _contexts;
        IInputService _inputService; 
        InputEntity _inputEntity;
        
        public EmitInputSystem (Contexts contexts, IInputService inputService) 
        {
            _contexts = contexts;
            _inputService= inputService;
        }

        public void Initialize() 
        {
            _contexts.input.isInputManger = true;
            _inputEntity = _contexts.input.inputMangerEntity;
        }
        
        public void Execute () 
        {
            _inputEntity.isButtonAInput = _inputService.action1IsPressed;
            _inputEntity.ReplaceLeftStickInput(_inputService.leftStick);
        }
    }
}