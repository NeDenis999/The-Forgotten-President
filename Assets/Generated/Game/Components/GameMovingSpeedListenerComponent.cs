//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class GameEntity {

    public MovingSpeedListenerComponent movingSpeedListener { get { return (MovingSpeedListenerComponent)GetComponent(GameComponentsLookup.MovingSpeedListener); } }
    public bool hasMovingSpeedListener { get { return HasComponent(GameComponentsLookup.MovingSpeedListener); } }

    public void AddMovingSpeedListener(System.Collections.Generic.List<IMovingSpeedListener> newValue) {
        var index = GameComponentsLookup.MovingSpeedListener;
        var component = (MovingSpeedListenerComponent)CreateComponent(index, typeof(MovingSpeedListenerComponent));
        component.value = newValue;
        AddComponent(index, component);
    }

    public void ReplaceMovingSpeedListener(System.Collections.Generic.List<IMovingSpeedListener> newValue) {
        var index = GameComponentsLookup.MovingSpeedListener;
        var component = (MovingSpeedListenerComponent)CreateComponent(index, typeof(MovingSpeedListenerComponent));
        component.value = newValue;
        ReplaceComponent(index, component);
    }

    public void RemoveMovingSpeedListener() {
        RemoveComponent(GameComponentsLookup.MovingSpeedListener);
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

    static Entitas.IMatcher<GameEntity> _matcherMovingSpeedListener;

    public static Entitas.IMatcher<GameEntity> MovingSpeedListener {
        get {
            if (_matcherMovingSpeedListener == null) {
                var matcher = (Entitas.Matcher<GameEntity>)Entitas.Matcher<GameEntity>.AllOf(GameComponentsLookup.MovingSpeedListener);
                matcher.componentNames = GameComponentsLookup.componentNames;
                _matcherMovingSpeedListener = matcher;
            }

            return _matcherMovingSpeedListener;
        }
    }
}

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.EventEntityApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class GameEntity {

    public void AddMovingSpeedListener(IMovingSpeedListener value) {
        var listeners = hasMovingSpeedListener
            ? movingSpeedListener.value
            : new System.Collections.Generic.List<IMovingSpeedListener>();
        listeners.Add(value);
        ReplaceMovingSpeedListener(listeners);
    }

    public void RemoveMovingSpeedListener(IMovingSpeedListener value, bool removeComponentWhenEmpty = true) {
        var listeners = movingSpeedListener.value;
        listeners.Remove(value);
        if (removeComponentWhenEmpty && listeners.Count == 0) {
            RemoveMovingSpeedListener();
        } else {
            ReplaceMovingSpeedListener(listeners);
        }
    }
}
