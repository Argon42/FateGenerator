namespace Generator.Core;

public interface IQuantitativeAspect : IAspect
{
    int FreeUseCount { get; }
}