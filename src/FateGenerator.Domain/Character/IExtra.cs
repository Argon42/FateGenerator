namespace FateGenerator.Domain;

public interface IExtra
{
    string Title { get; }
    string Permissions { get; }
    string Cost { get; }
    string Description { get; }
}