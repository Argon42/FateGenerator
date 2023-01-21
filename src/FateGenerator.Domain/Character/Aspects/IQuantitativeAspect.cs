namespace FateGenerator.Domain;

public interface IQuantitativeAspect : IAspect
{
    int FreeUseCount { get; }
}