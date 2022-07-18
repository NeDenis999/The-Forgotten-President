//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class GameEntity {

    public TimeComponent time { get { return (TimeComponent)GetComponent(GameComponentsLookup.Time); } }
    public bool hasTime { get { return HasComponent(GameComponentsLookup.Time); } }

    public void AddTime(float newValue) {
        var index = GameComponentsLookup.Time;
        var component = (TimeComponent)CreateComponent(index, typeof(TimeComponent));
        component.Value = newValue;
        AddComponent(index, component);
    }

    public void ReplaceTime(float newValue) {
        var index = GameComponentsLookup.Time;
        var component = (TimeComponent)CreateComponent(index, typeof(TimeComponent));
        component.Value = newValue;
        ReplaceComponent(index, component);
    }

    public void RemoveTime() {
        RemoveComponent(GameComponentsLookup.Time);
    }
}

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentMatcherApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public sealed partial class GameMatcher {

    static Entitas.IMatcher<GameEntity> _matcherTime;

    public static Entitas.IMatcher<GameEntity> Time {
        get {
            if (_matcherTime == null) {
                var matcher = (Entitas.Matcher<GameEntity>)Entitas.Matcher<GameEntity>.AllOf(GameComponentsLookup.Time);
                matcher.componentNames = GameComponentsLookup.componentNames;
                _matcherTime = matcher;
            }

            return _matcherTime;
        }
    }
}
