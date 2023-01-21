using FateGenerator.Domain;

namespace FateGenerator.Application.Common.Models.Character;

[Serializable]
public class Consequence : IConsequence
{
    public ConsequenceType Type { get; set; }
    public IAspect? Aspect { get; set; }

    IAspectObserver? IConsequenceObserver.Aspect => Aspect;
}