using FateGenerator.Application;
using Newtonsoft.Json;

namespace FateGenerator.Infrastructure;

public class FilesDataSource : IDataSource
{
    private const string FileNameFormat = "{0}.json";
    private readonly string _path;

    public FilesDataSource(string path)
    {
        _path = path;
    }

    public Dictionary<string, List<T>> FindAllWithTags<T>(params string[] tags)
    {
        return FindAll<T>(tags, GetFileName<T>());
    }

    public void Save<T>(List<T> elements, params string[] tags)
    {
        string folder = Path.Combine(_path, Path.Combine(tags));
        var path = Path.Combine(folder, GetFileName<T>());
        if (File.Exists(path))
        {
            List<T> list = DeserializeFile<T>(path);
            list.AddRange(elements);
            SerializeFile(list, folder, path);
        }
        else
        {
            SerializeFile(elements, folder, path);
        }
    }

    public void Save<T>(T element, params string[] tags)
    {
        string folder = Path.Combine(_path, Path.Combine(tags));
        var path = Path.Combine(folder, GetFileName<T>());
        if (File.Exists(path))
        {
            List<T> list = DeserializeFile<T>(path);
            list.Add(element);
            SerializeFile(list, folder, path);
        }
        else
        {
            SerializeFile(new List<T> { element }, folder, path);
        }
    }

    private static List<T> DeserializeFile<T>(string path)
    {
        var text = File.ReadAllText(path);
        return JsonConvert.DeserializeObject<List<T>>(text) ??
               throw new InvalidOperationException($"Incorrect json file of type {typeof(T)} on path {path}");
    }

    private Dictionary<string, List<T>> FindAll<T>(string[] tags, string fileName)
    {
        var files = SearchRecursive(new DirectoryInfo(_path), fileName).ToList();
        var result = new Dictionary<string, List<T>>();

        // TODO добавить удаление корневого пути
        foreach (string tag in tags)
        foreach (FileInfo fileInfo in files.Where(fileInfo => fileInfo.FullName.Contains(tag)))
        {
            if (result.ContainsKey(tag) == false)
                result[tag] = new List<T>();
            result[tag].AddRange(DeserializeFile<T>(fileInfo.FullName));
        }

        return result;
    }

    private static string GetFileName<T>() => GetFileName(typeof(T).Name);

    private static string GetFileName(string name) => string.Format(FileNameFormat, name);

    private static IEnumerable<FileInfo> SearchRecursive(DirectoryInfo root, string searchPattern)
    {
        FileInfo[]? files = null;

        try
        {
            files = root.GetFiles(searchPattern);
        }
        catch (UnauthorizedAccessException e)
        {
            Console.WriteLine(e.Message);
        }
        catch (DirectoryNotFoundException e)
        {
            Console.WriteLine(e.Message);
        }

        if (files == null) yield break;

        foreach (FileInfo file in files) yield return file;

        DirectoryInfo[] subDirectories = root.GetDirectories();
        foreach (DirectoryInfo directoryInfo in subDirectories)
        foreach (FileInfo fileInfo in SearchRecursive(directoryInfo, searchPattern))
            yield return fileInfo;
    }

    private static void SerializeFile<T>(List<T> elements, string folder, string fileName)
    {
        Directory.CreateDirectory(folder);
        var path = Path.Combine(folder, fileName);

        using FileStream stream = File.Exists(path) ? File.OpenWrite(path) : File.Create(path);
        using StreamWriter writer = new(stream);

        var json = JsonConvert.SerializeObject(elements);
        writer.WriteLine(json);
    }
}