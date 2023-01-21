namespace FateGenerator.Domain;

public interface IConsequence : IConsequenceObserver
{
    new ConsequenceType Type { set; get; }
    new IAspect? Aspect { set; get; }
}

public interface IConsequenceObserver
{
    ConsequenceType Type { get; }
    IAspectObserver? Aspect { get; }
}