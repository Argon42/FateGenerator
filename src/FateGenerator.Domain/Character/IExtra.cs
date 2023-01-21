namespace FateGenerator.Domain;

public interface IExtra : IExtraObserver
{
    new string Title { set; get; }
    new string Permissions { set; get; }
    new string Cost { set; get; }
    new string Description { set; get; }
}

public interface IExtraObserver
{
    string Title { get; }
    string Permissions { get; }
    string Cost { get; }
    string Description { get; }
}