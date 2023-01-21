namespace FateGenerator.Domain;

public interface ICharacterName : ICharacterNameObserver
{
}

public interface ICharacterNameObserver
{
    string FullName { get; }
}