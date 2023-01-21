namespace FateGenerator.Domain;

public interface IQuantitativeAspect : IQuantitativeAspectObserver
{
    new int FreeUseCount { set; get; }
}


public interface IQuantitativeAspectObserver : IAspect
{
    int FreeUseCount { get; }
}