using FateGenerator.Domain;

namespace FateGenerator.Application.Common.Models.Character;

[Serializable]
public class Stress : IStress
{
    public bool Used { get; set; }
    public int Size { get; set; }
}