using FateGenerator.Domain;

namespace FateGenerator.Application.Common.Models.Character;

[Serializable]
public class Stunt : IStunt
{
    public ISkill? Skill { get; set; }
    public required IAspect Aspect { get; set; }
    public bool RequiresFatePoint { get; set; }

    public StuntType Type { get; set; }
    public Overcome? Overcome { get; set; }
    public CreateAnAdvantage? CreateAnAdvantage { get; set; }
    public Attack? Attack { get; set; }
    public Defend? Defend { get; set; }

    public Power BonusShift { get; set; }

    public bool RollSkill { get; set; }

    IAspectObserver IStuntObserver.Aspect => Aspect;
    ISkillObserver? IStuntObserver.Skill => Skill;
    ICharacterActionObserver? IStuntObserver.Overcome => Overcome;
    ICharacterActionObserver? IStuntObserver.CreateAnAdvantage => CreateAnAdvantage;
    ICharacterActionObserver? IStuntObserver.Attack => Attack;
    ICharacterActionObserver? IStuntObserver.Defend => Defend;
}