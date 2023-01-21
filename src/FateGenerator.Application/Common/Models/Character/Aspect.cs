using FateGenerator.Domain;

namespace FateGenerator.Application.Common.Models.Character;

[Serializable]
public class Aspect : IAspect
{
    public required string Name { get; set; }
    public string? Description { get; set; }
}