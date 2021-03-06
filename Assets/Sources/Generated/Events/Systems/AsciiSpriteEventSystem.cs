//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.EventSystemGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public sealed class AsciiSpriteEventSystem : Entitas.ReactiveSystem<GameEntity> {

    readonly System.Collections.Generic.List<IAsciiSpriteListener> _listenerBuffer;

    public AsciiSpriteEventSystem(Contexts contexts) : base(contexts.game) {
        _listenerBuffer = new System.Collections.Generic.List<IAsciiSpriteListener>();
    }

    protected override Entitas.ICollector<GameEntity> GetTrigger(Entitas.IContext<GameEntity> context) {
        return Entitas.CollectorContextExtension.CreateCollector(
            context, Entitas.TriggerOnEventMatcherExtension.Added(GameMatcher.AsciiSprite)
        );
    }

    protected override bool Filter(GameEntity entity) {
        return entity.hasAsciiSprite && entity.hasAsciiSpriteListener;
    }

    protected override void Execute(System.Collections.Generic.List<GameEntity> entities) {
        foreach (var e in entities) {
            var component = e.asciiSprite;
            _listenerBuffer.Clear();
            _listenerBuffer.AddRange(e.asciiSpriteListener.value);
            foreach (var listener in _listenerBuffer) {
                listener.OnAsciiSprite(e, component.value);
            }
        }
    }
}
