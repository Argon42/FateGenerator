using FateGenerator.Domain;

namespace FateGenerator.Application.Common.Models.Character;

[Serializable]
public class QuantitativeAspect : Aspect, IQuantitativeAspect
{
    public int FreeUseCount { get; set; }
}