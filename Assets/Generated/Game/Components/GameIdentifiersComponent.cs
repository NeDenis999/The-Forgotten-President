//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentContextApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class GameContext {

    public GameEntity identifiersEntity { get { return GetGroup(GameMatcher.Identifiers).GetSingleEntity(); } }
    public Identifiers identifiers { get { return identifiersEntity.identifiers; } }
    public bool hasIdentifiers { get { return identifiersEntity != null; } }

    public GameEntity SetIdentifiers(Code.Services.IIdentifierService newValue) {
        if (hasIdentifiers) {
            throw new Entitas.EntitasException("Could not set Identifiers!\n" + this + " already has an entity with Identifiers!",
                "You should check if the context already has a identifiersEntity before setting it or use context.ReplaceIdentifiers().");
        }
        var entity = CreateEntity();
        entity.AddIdentifiers(newValue);
        return entity;
    }

    public void ReplaceIdentifiers(Code.Services.IIdentifierService newValue) {
        var entity = identifiersEntity;
        if (entity == null) {
            entity = SetIdentifiers(newValue);
        } else {
            entity.ReplaceIdentifiers(newValue);
        }
    }

    public void RemoveIdentifiers() {
        identifiersEntity.Destroy();
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
public partial class GameEntity {

    public Identifiers identifiers { get { return (Identifiers)GetComponent(GameComponentsLookup.Identifiers); } }
    public bool hasIdentifiers { get { return HasComponent(GameComponentsLookup.Identifiers); } }

    public void AddIdentifiers(Code.Services.IIdentifierService newValue) {
        var index = GameComponentsLookup.Identifiers;
        var component = (Identifiers)CreateComponent(index, typeof(Identifiers));
        component.Value = newValue;
        AddComponent(index, component);
    }

    public void ReplaceIdentifiers(Code.Services.IIdentifierService newValue) {
        var index = GameComponentsLookup.Identifiers;
        var component = (Identifiers)CreateComponent(index, typeof(Identifiers));
        component.Value = newValue;
        ReplaceComponent(index, component);
    }

    public void RemoveIdentifiers() {
        RemoveComponent(GameComponentsLookup.Identifiers);
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

    static Entitas.IMatcher<GameEntity> _matcherIdentifiers;

    public static Entitas.IMatcher<GameEntity> Identifiers {
        get {
            if (_matcherIdentifiers == null) {
                var matcher = (Entitas.Matcher<GameEntity>)Entitas.Matcher<GameEntity>.AllOf(GameComponentsLookup.Identifiers);
                matcher.componentNames = GameComponentsLookup.componentNames;
                _matcherIdentifiers = matcher;
            }

            return _matcherIdentifiers;
        }
    }
}
