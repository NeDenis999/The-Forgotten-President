//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentContextApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class InputContext {

    public InputEntity leftStickInputEntity { get { return GetGroup(InputMatcher.LeftStickInput).GetSingleEntity(); } }
    public LeftStickInput leftStickInput { get { return leftStickInputEntity.leftStickInput; } }
    public bool hasLeftStickInput { get { return leftStickInputEntity != null; } }

    public InputEntity SetLeftStickInput(UnityEngine.Vector2 newValue) {
        if (hasLeftStickInput) {
            throw new Entitas.EntitasException("Could not set LeftStickInput!\n" + this + " already has an entity with LeftStickInput!",
                "You should check if the context already has a leftStickInputEntity before setting it or use context.ReplaceLeftStickInput().");
        }
        var entity = CreateEntity();
        entity.AddLeftStickInput(newValue);
        return entity;
    }

    public void ReplaceLeftStickInput(UnityEngine.Vector2 newValue) {
        var entity = leftStickInputEntity;
        if (entity == null) {
            entity = SetLeftStickInput(newValue);
        } else {
            entity.ReplaceLeftStickInput(newValue);
        }
    }

    public void RemoveLeftStickInput() {
        leftStickInputEntity.Destroy();
    }
}

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class InputEntity {

    public LeftStickInput leftStickInput { get { return (LeftStickInput)GetComponent(InputComponentsLookup.LeftStickInput); } }
    public bool hasLeftStickInput { get { return HasComponent(InputComponentsLookup.LeftStickInput); } }

    public void AddLeftStickInput(UnityEngine.Vector2 newValue) {
        var index = InputComponentsLookup.LeftStickInput;
        var component = (LeftStickInput)CreateComponent(index, typeof(LeftStickInput));
        component.Value = newValue;
        AddComponent(index, component);
    }

    public void ReplaceLeftStickInput(UnityEngine.Vector2 newValue) {
        var index = InputComponentsLookup.LeftStickInput;
        var component = (LeftStickInput)CreateComponent(index, typeof(LeftStickInput));
        component.Value = newValue;
        ReplaceComponent(index, component);
    }

    public void RemoveLeftStickInput() {
        RemoveComponent(InputComponentsLookup.LeftStickInput);
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
public sealed partial class InputMatcher {

    static Entitas.IMatcher<InputEntity> _matcherLeftStickInput;

    public static Entitas.IMatcher<InputEntity> LeftStickInput {
        get {
            if (_matcherLeftStickInput == null) {
                var matcher = (Entitas.Matcher<InputEntity>)Entitas.Matcher<InputEntity>.AllOf(InputComponentsLookup.LeftStickInput);
                matcher.componentNames = InputComponentsLookup.componentNames;
                _matcherLeftStickInput = matcher;
            }

            return _matcherLeftStickInput;
        }
    }
}
