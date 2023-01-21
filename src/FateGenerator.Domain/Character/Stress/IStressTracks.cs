namespace FateGenerator.Domain;

public interface IStressTracks
{
    string Name { get; }
    ISkill? Skill { get; }
    IReadOnlyList<IStress> Stresses { get; }
}