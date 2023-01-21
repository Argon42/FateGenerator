namespace FateGenerator.Domain;

public sealed class Attack : CharacterAction
{
    public override CharacterActionType Type => CharacterActionType.Attack;
}