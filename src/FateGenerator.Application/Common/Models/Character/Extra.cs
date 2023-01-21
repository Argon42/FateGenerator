using FateGenerator.Domain;

namespace FateGenerator.Application.Common.Models.Character;

[Serializable]
public class Extra : IExtra
{
    public required string Title { get; set; }
    public required string Permissions { get; set; }
    public required string Cost { get; set; }
    public required string Description { get; set; }
}