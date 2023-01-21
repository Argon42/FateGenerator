using FateGenerator.Application.Common.Models.Character;
using FateGenerator.Domain;

namespace FateGenerator.Application;

public class RandomGenerator : IGenerator
{
    private readonly IDataSource _dataSource;

    public RandomGenerator(IDataSource dataSource)
    {
        _dataSource = dataSource;
    }

    public IAspect CreateAspect(params string[] tags)
    {
        return _dataSource.FindAllWithTags<Aspect>(tags)
                   .SelectMany(pair => pair.Value)
                   .Distinct()
                   .MinBy(_ => Guid.NewGuid()) ??
               throw new InvalidOperationException();
    }

    public IEnumerable<IAspect> CreateAspects(int count, params string[] tags)
    {
        return count switch
        {
            < 0 => throw new ArgumentOutOfRangeException(nameof(count), "Negative value"),
            0 => new List<Aspect>(),
            _ => _dataSource.FindAllWithTags<Aspect>(tags)
                .SelectMany(pair => pair.Value)
                .Distinct()
                .OrderBy(_ => Guid.NewGuid())
                .Take(count),
        };
    }

    public ICharacter CreateCharacter(Power power, params string[] tags)
    {
        CharacterName name = _dataSource.FindAllWithTags<CharacterName>(tags)
            .SelectMany(pair => pair.Value)
            .OrderBy(_ => Guid.NewGuid())
            .First();
        List<IAspect> aspects = CreateAspects(Math.Max((int)power, 0), tags).ToList();

        return new Character
        {
            Name = name,
            Aspects = aspects,
        };
    }

    public IEnumerable<ICharacter> CreateCharacters(int count, Power power, params string[] tags)
    {
        for (int i = 0; i < count; i++) yield return CreateCharacter(power, tags);
    }
}