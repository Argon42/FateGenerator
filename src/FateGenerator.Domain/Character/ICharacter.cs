namespace FateGenerator.Domain;

public interface ICharacter
{
    string Name { get; }
    string? Description { get; }
    int FatePointRefreshes { get; }
    int FatePoints { get; }
    IReadOnlyList<IAspect> Aspects { get; }
    IReadOnlyList<IQuantitativeAspect>? Boosts { get; }
    IReadOnlyList<IQuantitativeAspect>? SituationAspects { get; }
    IReadOnlyList<IStunt>? Stunts { get; }
    IReadOnlyList<IExtra>? Extras { get; }
    IReadOnlyList<IStressTracks>? StressBars { get; }
    IReadOnlyList<IConsequence>? Consequences { get; }
}