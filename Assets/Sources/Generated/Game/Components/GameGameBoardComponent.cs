//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentContextApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class GameContext {

    public GameEntity gameBoardEntity { get { return GetGroup(GameMatcher.GameBoard).GetSingleEntity(); } }
    public GameBoardComponent gameBoard { get { return gameBoardEntity.gameBoard; } }
    public bool hasGameBoard { get { return gameBoardEntity != null; } }

    public GameEntity SetGameBoard(int newLevelId, int newColumns, int newRows) {
        if (hasGameBoard) {
            throw new Entitas.EntitasException("Could not set GameBoard!\n" + this + " already has an entity with GameBoardComponent!",
                "You should check if the context already has a gameBoardEntity before setting it or use context.ReplaceGameBoard().");
        }
        var entity = CreateEntity();
        entity.AddGameBoard(newLevelId, newColumns, newRows);
        return entity;
    }

    public void ReplaceGameBoard(int newLevelId, int newColumns, int newRows) {
        var entity = gameBoardEntity;
        if (entity == null) {
            entity = SetGameBoard(newLevelId, newColumns, newRows);
        } else {
            entity.ReplaceGameBoard(newLevelId, newColumns, newRows);
        }
    }

    public void RemoveGameBoard() {
        gameBoardEntity.Destroy();
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

    public GameBoardComponent gameBoard { get { return (GameBoardComponent)GetComponent(GameComponentsLookup.GameBoard); } }
    public bool hasGameBoard { get { return HasComponent(GameComponentsLookup.GameBoard); } }

    public void AddGameBoard(int newLevelId, int newColumns, int newRows) {
        var index = GameComponentsLookup.GameBoard;
        var component = CreateComponent<GameBoardComponent>(index);
        component.levelId = newLevelId;
        component.columns = newColumns;
        component.rows = newRows;
        AddComponent(index, component);
    }

    public void ReplaceGameBoard(int newLevelId, int newColumns, int newRows) {
        var index = GameComponentsLookup.GameBoard;
        var component = CreateComponent<GameBoardComponent>(index);
        component.levelId = newLevelId;
        component.columns = newColumns;
        component.rows = newRows;
        ReplaceComponent(index, component);
    }

    public void RemoveGameBoard() {
        RemoveComponent(GameComponentsLookup.GameBoard);
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

    static Entitas.IMatcher<GameEntity> _matcherGameBoard;

    public static Entitas.IMatcher<GameEntity> GameBoard {
        get {
            if (_matcherGameBoard == null) {
                var matcher = (Entitas.Matcher<GameEntity>)Entitas.Matcher<GameEntity>.AllOf(GameComponentsLookup.GameBoard);
                matcher.componentNames = GameComponentsLookup.componentNames;
                _matcherGameBoard = matcher;
            }

            return _matcherGameBoard;
        }
    }
}
