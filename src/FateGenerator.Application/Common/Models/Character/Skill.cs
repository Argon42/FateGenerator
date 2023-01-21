using FateGenerator.Domain;

namespace FateGenerator.Application.Common.Models.Character;

[Serializable]
public class Skill : ISkill
{
    public required string Name { get; set; }
    public Overcome? Overcome { get; set; }
    public CreateAnAdvantage? CreateAnAdvantage { get; set; }
    public Attack? Attack { get; set; }
    public Defend? Defend { get; set; }

    ICharacterActionObserver? ISkillObserver.Overcome => Overcome;
    ICharacterActionObserver? ISkillObserver.CreateAnAdvantage => CreateAnAdvantage;
    ICharacterActionObserver? ISkillObserver.Attack => Attack;
    ICharacterActionObserver? ISkillObserver.Defend => Defend;
}