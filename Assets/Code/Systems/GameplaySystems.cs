using Code.Systems.Game.Hero;

namespace Code.Systems
{
    public class GameplaySystems : Feature
    {
        public GameplaySystems(Contexts contexts) : base(nameof(GameplaySystems))
        {
            Add(new LeftStickInputSystem(contexts.input));
            Add(new MoveHeroSystem(contexts.game, contexts.input));
            Add(new GlobalLightColorSwitchSystem(contexts.game));
            Add(new CameraMoveToTargetSystem(contexts.game));
            Add(new CleanupDestructed(contexts.game));
        }
    }
}