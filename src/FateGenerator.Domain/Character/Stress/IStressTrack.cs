namespace FateGenerator.Domain;

public interface IStressTrack : IStressTrackObserver
{
    new string Name { set; get; }
    new ISkill? Skill { set; get; }
    new List<IStress> Stresses { get; }
}

public interface IStressTrackObserver
{
    string Name { get; }
    ISkillObserver? Skill { get; }
    IReadOnlyList<IStress> Stresses { get; }
}