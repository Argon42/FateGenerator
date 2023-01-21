using FateGenerator.Domain;

namespace FateGenerator.Application.Common.Models.Character;

[Serializable]
public class CharacterSkill : ICharacterSkill
{
    public required ISkill Skill { get; set; }
    public Power Power { get; set; }
    ISkillObserver ICharacterSkillObserver.Skill => Skill;
}