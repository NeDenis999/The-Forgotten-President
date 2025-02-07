//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class GameEntity {

    public LightComponent light { get { return (LightComponent)GetComponent(GameComponentsLookup.Light); } }
    public bool hasLight { get { return HasComponent(GameComponentsLookup.Light); } }

    public void AddLight(UnityEngine.Rendering.Universal.Light2D newValue) {
        var index = GameComponentsLookup.Light;
        var component = (LightComponent)CreateComponent(index, typeof(LightComponent));
        component.Value = newValue;
        AddComponent(index, component);
    }

    public void ReplaceLight(UnityEngine.Rendering.Universal.Light2D newValue) {
        var index = GameComponentsLookup.Light;
        var component = (LightComponent)CreateComponent(index, typeof(LightComponent));
        component.Value = newValue;
        ReplaceComponent(index, component);
    }

    public void RemoveLight() {
        RemoveComponent(GameComponentsLookup.Light);
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

    static Entitas.IMatcher<GameEntity> _matcherLight;

    public static Entitas.IMatcher<GameEntity> Light {
        get {
            if (_matcherLight == null) {
                var matcher = (Entitas.Matcher<GameEntity>)Entitas.Matcher<GameEntity>.AllOf(GameComponentsLookup.Light);
                matcher.componentNames = GameComponentsLookup.componentNames;
                _matcherLight = matcher;
            }

            return _matcherLight;
        }
    }
}
