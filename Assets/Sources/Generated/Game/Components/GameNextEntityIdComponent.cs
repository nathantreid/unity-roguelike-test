//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentContextApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class GameContext {

    public GameEntity nextEntityIdEntity { get { return GetGroup(GameMatcher.NextEntityId).GetSingleEntity(); } }
    public NextEntityIdComponent nextEntityId { get { return nextEntityIdEntity.nextEntityId; } }
    public bool hasNextEntityId { get { return nextEntityIdEntity != null; } }

    public GameEntity SetNextEntityId(string newValue) {
        if (hasNextEntityId) {
            throw new Entitas.EntitasException("Could not set NextEntityId!\n" + this + " already has an entity with NextEntityIdComponent!",
                "You should check if the context already has a nextEntityIdEntity before setting it or use context.ReplaceNextEntityId().");
        }
        var entity = CreateEntity();
        entity.AddNextEntityId(newValue);
        return entity;
    }

    public void ReplaceNextEntityId(string newValue) {
        var entity = nextEntityIdEntity;
        if (entity == null) {
            entity = SetNextEntityId(newValue);
        } else {
            entity.ReplaceNextEntityId(newValue);
        }
    }

    public void RemoveNextEntityId() {
        nextEntityIdEntity.Destroy();
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

    public NextEntityIdComponent nextEntityId { get { return (NextEntityIdComponent)GetComponent(GameComponentsLookup.NextEntityId); } }
    public bool hasNextEntityId { get { return HasComponent(GameComponentsLookup.NextEntityId); } }

    public void AddNextEntityId(string newValue) {
        var index = GameComponentsLookup.NextEntityId;
        var component = CreateComponent<NextEntityIdComponent>(index);
        component.value = newValue;
        AddComponent(index, component);
    }

    public void ReplaceNextEntityId(string newValue) {
        var index = GameComponentsLookup.NextEntityId;
        var component = CreateComponent<NextEntityIdComponent>(index);
        component.value = newValue;
        ReplaceComponent(index, component);
    }

    public void RemoveNextEntityId() {
        RemoveComponent(GameComponentsLookup.NextEntityId);
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

    static Entitas.IMatcher<GameEntity> _matcherNextEntityId;

    public static Entitas.IMatcher<GameEntity> NextEntityId {
        get {
            if (_matcherNextEntityId == null) {
                var matcher = (Entitas.Matcher<GameEntity>)Entitas.Matcher<GameEntity>.AllOf(GameComponentsLookup.NextEntityId);
                matcher.componentNames = GameComponentsLookup.componentNames;
                _matcherNextEntityId = matcher;
            }

            return _matcherNextEntityId;
        }
    }
}
