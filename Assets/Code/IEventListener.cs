using Entitas;

namespace Code
{
    public interface IEventListener
    {
        void RegisterEventListeners(IEntity entity);
        void UnregisterListeners(IEntity with);
    }
}