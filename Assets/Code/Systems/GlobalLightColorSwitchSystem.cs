using Entitas;
using UnityEngine;

namespace Code.Systems
{
    public class GlobalLightColorSwitchSystem : IExecuteSystem
    {
        private readonly IGroup<GameEntity> _game;

        public GlobalLightColorSwitchSystem(GameContext game)
        {
            _game = game.GetGroup(GameMatcher.AllOf(GameMatcher.GlobalLight, GameMatcher.Light, GameMatcher.Color, GameMatcher.ColorState, GameMatcher.Time));
        }

        public void Execute()
        {
            foreach (GameEntity game in _game)
            {
                var currentColor = game.color.Value;
                var colorState = game.colorState.Value;
                var time = game.time.Value;
                
                var color1 = new Color(1, 0.9f, 0.9f, 1);
                var color2 = new Color(0.9f, 0.9f, 1, 1);
                var color3 = new Color(0.9f, 1, 0.9f, 1);
                var color4 = new Color(1, 1, 0.9f, 1);
                var speed = 0.01f;

                switch (colorState)
                {
                    case 0:
                        currentColor = Color.Lerp (currentColor, color1, Mathf.Abs(Mathf.Sin(time)));

                        if (currentColor == color1)
                        {
                            game.ReplaceColorState(colorState + 1);
                            game.ReplaceTime(0);
                        }
                        else
                        {
                            game.ReplaceTime(time + speed * Time.deltaTime);
                        }
                            
                        
                        break;
                    case 1:
                        currentColor = Color.Lerp (currentColor, color2, Mathf.Abs(Mathf.Sin(time)));
                        
                        if (currentColor == color2)
                        {
                            game.ReplaceColorState(colorState + 1);
                            game.ReplaceTime(0);
                        }
                        else
                        {
                            game.ReplaceTime(time + speed * Time.deltaTime);
                        }
                        
                        break;
                    case 2:
                        currentColor = Color.Lerp (currentColor, color3, Mathf.Abs(Mathf.Sin(time)));
                        
                        if (currentColor == color3)
                        {
                            game.ReplaceColorState(colorState + 1);
                            game.ReplaceTime(0);
                        }
                        else
                        {
                            game.ReplaceTime(time + speed * Time.deltaTime);
                        }

                        break;
                    case 3:
                        currentColor = Color.Lerp (currentColor, color4, Mathf.Abs(Mathf.Sin(time)));
                        
                        if (currentColor == color4)
                        {
                            game.ReplaceColorState(0);
                            game.ReplaceTime(0);
                        }
                        else
                        {
                            game.ReplaceTime(time + speed * Time.deltaTime);
                        }
                        
                        break;
                }
                
                game.ReplaceColor(currentColor);
                game.light.Value.color = currentColor;
            }
        }
    }
}