using FateGenerator.Domain;

namespace FateGenerator.Application;

public interface IGenerator
{
    IAspect CreateAspect(params string[] tags);
    IEnumerable<IAspect> CreateAspects(int count, params string[] tags);
    ICharacter CreateCharacter(Power good, params string[] tags);
    IEnumerable<ICharacter> CreateCharacters(int count, Power power, params string[] tags);
}