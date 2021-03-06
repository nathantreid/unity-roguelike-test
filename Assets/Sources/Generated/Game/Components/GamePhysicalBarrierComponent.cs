//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class GameEntity {

    static readonly PhysicalBarrierComponent physicalBarrierComponent = new PhysicalBarrierComponent();

    public bool isPhysicalBarrier {
        get { return HasComponent(GameComponentsLookup.PhysicalBarrier); }
        set {
            if (value != isPhysicalBarrier) {
                var index = GameComponentsLookup.PhysicalBarrier;
                if (value) {
                    var componentPool = GetComponentPool(index);
                    var component = componentPool.Count > 0
                            ? componentPool.Pop()
                            : physicalBarrierComponent;

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

    static Entitas.IMatcher<GameEntity> _matcherPhysicalBarrier;

    public static Entitas.IMatcher<GameEntity> PhysicalBarrier {
        get {
            if (_matcherPhysicalBarrier == null) {
                var matcher = (Entitas.Matcher<GameEntity>)Entitas.Matcher<GameEntity>.AllOf(GameComponentsLookup.PhysicalBarrier);
                matcher.componentNames = GameComponentsLookup.componentNames;
                _matcherPhysicalBarrier = matcher;
            }

            return _matcherPhysicalBarrier;
        }
    }
}
