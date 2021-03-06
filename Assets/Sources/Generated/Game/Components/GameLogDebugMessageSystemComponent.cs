//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class GameEntity {

    public LogDebugMessageSystemComponent logDebugMessageSystem { get { return (LogDebugMessageSystemComponent)GetComponent(GameComponentsLookup.LogDebugMessageSystem); } }
    public bool hasLogDebugMessageSystem { get { return HasComponent(GameComponentsLookup.LogDebugMessageSystem); } }

    public void AddLogDebugMessageSystem(LogDebugMessageSystem newValue) {
        var index = GameComponentsLookup.LogDebugMessageSystem;
        var component = CreateComponent<LogDebugMessageSystemComponent>(index);
        component.value = newValue;
        AddComponent(index, component);
    }

    public void ReplaceLogDebugMessageSystem(LogDebugMessageSystem newValue) {
        var index = GameComponentsLookup.LogDebugMessageSystem;
        var component = CreateComponent<LogDebugMessageSystemComponent>(index);
        component.value = newValue;
        ReplaceComponent(index, component);
    }

    public void RemoveLogDebugMessageSystem() {
        RemoveComponent(GameComponentsLookup.LogDebugMessageSystem);
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

    static Entitas.IMatcher<GameEntity> _matcherLogDebugMessageSystem;

    public static Entitas.IMatcher<GameEntity> LogDebugMessageSystem {
        get {
            if (_matcherLogDebugMessageSystem == null) {
                var matcher = (Entitas.Matcher<GameEntity>)Entitas.Matcher<GameEntity>.AllOf(GameComponentsLookup.LogDebugMessageSystem);
                matcher.componentNames = GameComponentsLookup.componentNames;
                _matcherLogDebugMessageSystem = matcher;
            }

            return _matcherLogDebugMessageSystem;
        }
    }
}
