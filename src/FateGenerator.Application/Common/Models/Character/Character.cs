using FateGenerator.Domain;

namespace FateGenerator.Application.Common.Models.Character;

[Serializable]
public class Character : ICharacter
{
    public required ICharacterName Name { get; set; }
    public string? Description { get; set; }
    public int FatePointRefreshes { get; set; }
    public int FatePoints { get; set; }
    public required List<IAspect> Aspects { get; init; }
    public List<IQuantitativeAspect>? Boosts { get; init; }
    public List<IQuantitativeAspect>? SituationAspects { get; init; }
    public List<IStunt>? Stunts { get; init; }
    public List<IExtra>? Extras { get; init; }
    public List<IStressTrack>? StressTracks { get; init; }
    public List<IConsequence>? Consequences { get; init; }


    ICharacterNameObserver ICharacterObserver.Name => Name;
    IReadOnlyList<IAspectObserver> ICharacterObserver.Aspects => Aspects;
    IReadOnlyList<IQuantitativeAspectObserver>? ICharacterObserver.Boosts => Boosts;
    IReadOnlyList<IQuantitativeAspectObserver>? ICharacterObserver.SituationAspects => SituationAspects;
    IReadOnlyList<IStuntObserver>? ICharacterObserver.Stunts => Stunts;
    IReadOnlyList<IExtraObserver>? ICharacterObserver.Extras => Extras;
    IReadOnlyList<IStressTrackObserver>? ICharacterObserver.StressTracks => StressTracks;
    IReadOnlyList<IConsequenceObserver>? ICharacterObserver.Consequences => Consequences;
}