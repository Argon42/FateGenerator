using FateGenerator.Application;
using FateGenerator.Application.Common.Models.Character;
using FateGenerator.Domain;
using FateGenerator.Infrastructure;

var localData = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
string path = Path.Combine(localData, "FateGenerator", "GeneratorData");
IDataSource filesSource = new FilesDataSource(path);
IGenerator randomGenerator = new RandomGenerator(filesSource);


// SaveAspects(filesSource);
// SaveNames(filesSource);

CreateAspect(randomGenerator);
CreateAspects(randomGenerator);
CreateCharacter(randomGenerator);
CreateCharacters(randomGenerator);


void SaveAspects(IDataSource dataSource)
{
    dataSource.Save(new List<Aspect>()
    {
        new() { Name = "Силач" },
        new() { Name = "Избивающий даже камни" },
        new() { Name = "Похотливый зелёный стручёк" },
        new() { Name = "Ученый на пол ставки" },
        new() { Name = "Бывший вышибала" },
    }, "character", "ork", "warrior");

    dataSource.Save(new Aspect() { Name = "Огромный бугай" }, "character", "ork");
}

void SaveNames(IDataSource dataSource)
{
    dataSource.Save(new List<CharacterName>()
    {
        new() { FullName = "Грог 1" },
        new() { FullName = "Грог 2" },
        new() { FullName = "Грог 3" },
        new() { FullName = "Грог 4" },
        new() { FullName = "Грог 5" },
    }, "character", "ork", "warrior");

    dataSource.Save(new CharacterName() { FullName = "Могучий Грог" }, "character", "ork");
}

void CreateAspect(IGenerator generator)
{
    IAspect characterAspect = generator.CreateAspect("character", "ork");

    Console.WriteLine(characterAspect.Name);
}

void CreateAspects(IGenerator generator)
{
    int count = 3;
    IList<IAspect> characterAspects = generator.CreateAspects(count, "character", "ork").ToList();

    foreach (IAspect aspect in characterAspects)
    {
        Console.WriteLine(aspect.Name);
    }
}

void CreateCharacter(IGenerator generator)
{
    ICharacter character = generator.CreateCharacter(Power.Good, "character", "ork", "warrior");
    Console.WriteLine(character.Name);
}

void CreateCharacters(IGenerator generator)
{
    int charactersCount = 3;
    IList<ICharacter> characters =
        generator.CreateCharacters(charactersCount, Power.Good, "character", "ork", "warrior").ToList();

    foreach (ICharacter newCharacter in characters)
    {
        Console.WriteLine(newCharacter.Name);
    }
}