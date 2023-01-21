namespace FateGenerator.Domain;

public interface IStunt
{
    IAspect Aspect { get; }
    ISkill? Skill { get; }
    bool RequiresFatePoint { get; }

    StuntType Type { get; }

    Overcome? Overcome { get; }
    CreateAnAdvantage? CreateAnAdvantage { get; }
    Attack? Attack { get; }
    Defend? Defend { get; }

    Power BonusShift { get; }
    bool RollSkill { get; }
}