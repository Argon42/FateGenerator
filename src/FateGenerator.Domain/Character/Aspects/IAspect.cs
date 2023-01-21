namespace FateGenerator.Domain;

public interface IAspect : IAspectObserver
{
    new string Name { set; get; }
    new string? Description { set; get; }
}

public interface IAspectObserver
{
    string Name { get; }
    string? Description { get; }
}