namespace FateGenerator.Domain;

public interface ICharacter : ICharacterObserver
{
    new string Name { set; get; }
    new string? Description { set; get; }
    new int FatePointRefreshes { set; get; }
    new int FatePoints { set; get; }
    new List<IAspect> Aspects { get; }
    new List<IQuantitativeAspect>? Boosts { get; }
    new List<IQuantitativeAspect>? SituationAspects { get; }
    new List<IStunt>? Stunts { get; }
    new List<IExtra>? Extras { get; }
    new List<IStressTrack>? StressTracks { get; }
    new List<IConsequence>? Consequences { get; }
}

public interface ICharacterObserver
{
    string Name { get; }
    string? Description { get; }
    int FatePointRefreshes { get; }
    int FatePoints { get; }
    IReadOnlyList<IAspectObserver> Aspects { get; }
    IReadOnlyList<IQuantitativeAspectObserver>? Boosts { get; }
    IReadOnlyList<IQuantitativeAspectObserver>? SituationAspects { get; }
    IReadOnlyList<IStuntObserver>? Stunts { get; }
    IReadOnlyList<IExtraObserver>? Extras { get; }
    IReadOnlyList<IStressTrackObserver>? StressTracks { get; }
    IReadOnlyList<IConsequenceObserver>? Consequences { get; }
}