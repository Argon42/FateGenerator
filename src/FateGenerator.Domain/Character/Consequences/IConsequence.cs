namespace Generator.Core;

public interface IConsequence
{
    ConsequenceType Type { get; }
    IAspect? Aspect { get; }
}