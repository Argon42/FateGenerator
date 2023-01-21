namespace FateGenerator.Domain;

public interface ISkill : ISkillObserver
{
    new string Name { set; get; }
    new Overcome? Overcome { set; get; }
    new CreateAnAdvantage? CreateAnAdvantage { set; get; }
    new Attack? Attack { set; get; }
    new Defend? Defend { set; get; }
}

public interface ISkillObserver
{
    string Name { get; }
    ICharacterActionObserver? Overcome { get; }
    ICharacterActionObserver? CreateAnAdvantage { get; }
    ICharacterActionObserver? Attack { get; }
    ICharacterActionObserver? Defend { get; }
}