namespace FateGenerator.Application;

public interface IDataSource
{
    Dictionary<string, List<T>> FindAllWithTags<T>(params string[] tags);
    void Save<T>(List<T> elements, params string[] tags);
    void Save<T>(T element, params string[] tags);
}