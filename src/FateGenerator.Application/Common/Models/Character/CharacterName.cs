using FateGenerator.Domain;

namespace FateGenerator.Application.Common.Models.Character;

[Serializable]
public class CharacterName : ICharacterName
{
    public required string FullName { set; get; }

    public override string ToString() => FullName;
}