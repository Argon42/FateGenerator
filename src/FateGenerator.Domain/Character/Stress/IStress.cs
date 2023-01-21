namespace FateGenerator.Domain;

public interface IStress : IStressObserver
{
    new bool Used { set; get; }
    new int Size { set; get; }
}


public interface IStressObserver
{
    bool Used { get; }
    int Size { get; }
}