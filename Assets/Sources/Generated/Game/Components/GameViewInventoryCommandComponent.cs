//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class GameEntity {

    static readonly ViewInventoryCommand viewInventoryCommandComponent = new ViewInventoryCommand();

    public bool hasViewInventoryCommand {
        get { return HasComponent(GameComponentsLookup.ViewInventoryCommand); }
        set {
            if (value != hasViewInventoryCommand) {
                var index = GameComponentsLookup.ViewInventoryCommand;
                if (value) {
                    var componentPool = GetComponentPool(index);
                    var component = componentPool.Count > 0
                            ? componentPool.Pop()
                            : viewInventoryCommandComponent;

                    AddComponent(index, component);
                } else {
                    RemoveComponent(index);
                }
            }
        }
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

    static Entitas.IMatcher<GameEntity> _matcherViewInventoryCommand;

    public static Entitas.IMatcher<GameEntity> ViewInventoryCommand {
        get {
            if (_matcherViewInventoryCommand == null) {
                var matcher = (Entitas.Matcher<GameEntity>)Entitas.Matcher<GameEntity>.AllOf(GameComponentsLookup.ViewInventoryCommand);
                matcher.componentNames = GameComponentsLookup.componentNames;
                _matcherViewInventoryCommand = matcher;
            }

            return _matcherViewInventoryCommand;
        }
    }
}
