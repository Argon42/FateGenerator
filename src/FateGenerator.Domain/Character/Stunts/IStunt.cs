namespace FateGenerator.Domain;

public interface IStunt : IStuntObserver
{
    new IAspect Aspect { set; get; }
    new ISkill? Skill { set; get; }
    new bool RequiresFatePoint { set; get; }

    new StuntType Type { set; get; }

    new Overcome? Overcome { set; get; }
    new CreateAnAdvantage? CreateAnAdvantage { set; get; }
    new Attack? Attack { set; get; }
    new Defend? Defend { set; get; }

    new Power BonusShift { set; get; }
    new bool RollSkill { set; get; }
}

public interface IStuntObserver
{
    IAspectObserver Aspect { get; }
    ISkillObserver? Skill { get; }
    bool RequiresFatePoint { get; }

    StuntType Type { get; }

    ICharacterActionObserver? Overcome { get; }
    ICharacterActionObserver? CreateAnAdvantage { get; }
    ICharacterActionObserver? Attack { get; }
    ICharacterActionObserver? Defend { get; }

    Power BonusShift { get; }
    bool RollSkill { get; }
}