namespace Code.Common
{
    public class StaticCleaners
    {
        public static GameContext Game() => Contexts.sharedInstance.game;
    }
}