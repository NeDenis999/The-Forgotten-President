using Entitas;
using UnityEngine;

namespace Code.Systems
{
    public class CameraMoveToTargetSystem : IExecuteSystem
    {
        private readonly IGroup<GameEntity> _game;

        public CameraMoveToTargetSystem(GameContext game)
        {
            _game = game.GetGroup(GameMatcher.AllOf(GameMatcher.Camera, GameMatcher.Target, GameMatcher.Position));
        }

        public void Execute()
        {
            foreach (GameEntity game in _game)
            {
                var currentPosition = game.position.Value;
                game.ReplacePosition(Vector2.MoveTowards(currentPosition, game.target.Value.position, 1));
            }
        }
    }
}