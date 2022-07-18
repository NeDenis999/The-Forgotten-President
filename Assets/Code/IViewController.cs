using Entitas;
using UnityEngine;

namespace Code
{
    public interface IViewController
    {
        IViewController InitializeView(GameContext @in, IEntity @with);
        void DestroyView();
        GameEntity Entity { get; }
    }
}