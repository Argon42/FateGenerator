﻿namespace Generator.Core;

public interface ISkill
{
    string Name { get; }
    Overcome? Overcome { get; }
    CreateAnAdvantage? CreateAnAdvantage { get; }
    Attack? Attack { get; }
    Defend? Defend { get; }
}