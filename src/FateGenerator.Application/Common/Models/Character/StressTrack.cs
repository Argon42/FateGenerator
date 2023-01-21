using FateGenerator.Domain;

namespace FateGenerator.Application.Common.Models.Character;

[Serializable]
public class StressTrack : IStressTrack
{
    public required string Name { get; set; }
    public ISkill? Skill { get; set; }
    public required List<IStress> Stresses { get; init; }

    ISkillObserver? IStressTrackObserver.Skill => Skill;
    IReadOnlyList<IStress> IStressTrackObserver.Stresses => Stresses;
}