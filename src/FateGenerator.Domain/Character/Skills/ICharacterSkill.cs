namespace FateGenerator.Domain;

public interface ICharacterSkill
{
    ISkill Skill { get; }
    Power Power { get; }
}