namespace FateGenerator.Domain;

public abstract class CharacterAction: ICharacterAction
{
    public abstract CharacterActionType Type { get; }
    public required string Description { get; set; }
}

public interface ICharacterAction : ICharacterActionObserver
{
    new string Description { get; set; }
}

public interface ICharacterActionObserver
{
    CharacterActionType Type { get; }
    string Description { get; }
}