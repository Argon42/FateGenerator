namespace FateGenerator.Domain;

public interface IStress
{
    bool Used { get; }
    int Size { get; }
}