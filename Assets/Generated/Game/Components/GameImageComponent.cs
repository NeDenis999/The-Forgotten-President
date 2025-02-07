//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class GameEntity {

    public ImageComponent image { get { return (ImageComponent)GetComponent(GameComponentsLookup.Image); } }
    public bool hasImage { get { return HasComponent(GameComponentsLookup.Image); } }

    public void AddImage(UnityEngine.UI.Image newValue) {
        var index = GameComponentsLookup.Image;
        var component = (ImageComponent)CreateComponent(index, typeof(ImageComponent));
        component.Value = newValue;
        AddComponent(index, component);
    }

    public void ReplaceImage(UnityEngine.UI.Image newValue) {
        var index = GameComponentsLookup.Image;
        var component = (ImageComponent)CreateComponent(index, typeof(ImageComponent));
        component.Value = newValue;
        ReplaceComponent(index, component);
    }

    public void RemoveImage() {
        RemoveComponent(GameComponentsLookup.Image);
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

    static Entitas.IMatcher<GameEntity> _matcherImage;

    public static Entitas.IMatcher<GameEntity> Image {
        get {
            if (_matcherImage == null) {
                var matcher = (Entitas.Matcher<GameEntity>)Entitas.Matcher<GameEntity>.AllOf(GameComponentsLookup.Image);
                matcher.componentNames = GameComponentsLookup.componentNames;
                _matcherImage = matcher;
            }

            return _matcherImage;
        }
    }
}
