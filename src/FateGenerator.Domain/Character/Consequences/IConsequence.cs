namespace FateGenerator.Domain;

public interface IConsequence
{
    ConsequenceType Type { get; }
    IAspect? Aspect { get; }
}