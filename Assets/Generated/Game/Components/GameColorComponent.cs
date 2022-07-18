//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class GameEntity {

    public ColorComponent color { get { return (ColorComponent)GetComponent(GameComponentsLookup.Color); } }
    public bool hasColor { get { return HasComponent(GameComponentsLookup.Color); } }

    public void AddColor(UnityEngine.Color newValue) {
        var index = GameComponentsLookup.Color;
        var component = (ColorComponent)CreateComponent(index, typeof(ColorComponent));
        component.Value = newValue;
        AddComponent(index, component);
    }

    public void ReplaceColor(UnityEngine.Color newValue) {
        var index = GameComponentsLookup.Color;
        var component = (ColorComponent)CreateComponent(index, typeof(ColorComponent));
        component.Value = newValue;
        ReplaceComponent(index, component);
    }

    public void RemoveColor() {
        RemoveComponent(GameComponentsLookup.Color);
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

    static Entitas.IMatcher<GameEntity> _matcherColor;

    public static Entitas.IMatcher<GameEntity> Color {
        get {
            if (_matcherColor == null) {
                var matcher = (Entitas.Matcher<GameEntity>)Entitas.Matcher<GameEntity>.AllOf(GameComponentsLookup.Color);
                matcher.componentNames = GameComponentsLookup.componentNames;
                _matcherColor = matcher;
            }

            return _matcherColor;
        }
    }
}
