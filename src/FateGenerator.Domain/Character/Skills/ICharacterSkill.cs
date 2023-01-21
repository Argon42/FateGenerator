namespace FateGenerator.Domain;

public interface ICharacterSkill : ICharacterSkillObserver
{
    new ISkill Skill { set; get; }
    new Power Power { set; get; }
}

public interface ICharacterSkillObserver
{
    ISkillObserver Skill { get; }
    Power Power { get; }
}