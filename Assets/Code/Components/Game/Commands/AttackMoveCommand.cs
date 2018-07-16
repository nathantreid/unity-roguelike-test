
using Entitas;

[Game]
public sealed class AttackMoveCommand : IComponent
{
  public IntVector2 direction;
  public GameBoardElementPosition targetPosition;
}
