using Entitas;
using UnityEngine;

namespace Code.Systems.Game.Hero
{
    public class MoveHeroSystem : IExecuteSystem
    {
        private const float Speed = 1.5f;
        
        private readonly GameContext _game;
        private readonly InputContext _input;
        private readonly IGroup<GameEntity> _heroes;
        private readonly IGroup<InputEntity> _inputs;

        public MoveHeroSystem(GameContext game, InputContext input)
        {
            _game = game;
            _input = input;
            
            _heroes = game.GetGroup(GameMatcher.AllOf(GameMatcher.Hero, GameMatcher.Direction, GameMatcher.Rigidbody, GameMatcher.MovingSpeed).NoneOf(GameMatcher.Dead));
            _inputs = input.GetGroup(InputMatcher.AllOf(InputMatcher.LeftStickInput));
        }
        
        public void Execute()
        {
            foreach (GameEntity hero in _heroes)
            {
                var speedX = _input.leftStickInput.Value.x;
                
                if (Mathf.Abs(speedX) > 0)
                {
                    var direction = new Vector2(speedX, 0);
                    Move(hero, @in: direction);
                }
                else
                {
                    hero.isMoving = false;
                    hero.isStoppedMoving = true;
                }
                
                hero.ReplaceMovingSpeed(Mathf.Abs(speedX));
            }
        }

        private static Vector2 Direction(float xDistance, float yDistance) => new Vector2(Mathf.Sign(xDistance), Mathf.Sign(yDistance));
        
        private void Move(GameEntity hero, Vector2 @in)
        {
            hero.isMoving = true;
            hero.isStoppedMoving = false;
            hero.rigidbody.Value.position += @in * Speed * Time.deltaTime;
            
            if (hero.direction.Value != @in)
                UpdateDirection(hero, @in);
        }
        
        private static void UpdateDirection(GameEntity hero, Vector2 direction)
        {
            if (hero.direction.Value.x == direction.x && hero.direction.Value.y == direction.y)
                return;

            hero.ReplaceDirection(direction);
        }
    }
}