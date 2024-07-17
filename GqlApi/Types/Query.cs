using GqlApi.Models;
using GqlApi.Models.Animal;
using GqlApi.Models.Enums;
using GqlApi.Models.Mammal;
using Models.EnityFramework;

namespace GqlApi.Types;

[QueryType]
public class Query
{
    public string SayHello(string name = "World") => $"Hello {name}!";

    public IEnumerable<string> GetNames() => ["Alice", "Bob", "Charlie"];

    // GraphQL Object Type
    public Book GetBook() => new Book("The Hobbit", new Author("J.R.R. Tolkien"));

    // GraphQL Interface Type
    public IEnumerable<IPet> GetPets() => new List<IPet>
    {
        new Dog("Buddy", "Golden Retriever"),
        new Cat("Snowball", true, CatLives.Nine),
        new Cat("Snowball 2", true, CatLives.Eight),
        new Cat("Snowball 3", true, CatLives.Nine),
        new Parrot("Iago", true)
    };

    // GraphQL Union Type (set of types)
    private bool _dog;

    public IMammal GetCatOrDog()
    {
        _dog = !_dog;
        return _dog ? new Dog("Buddy", "Golden Retriever") : new Cat("Snowball", true, CatLives.Nine);
    }

    public IEnumerable<Cat> GetAllCats(CatLives? catLives)
    {
        if (catLives is not null)
        {
            return GetPets().OfType<Cat>().Where(c => c.Lives == catLives);
        }

        return GetPets().OfType<Cat>();
    }

    public string GetDogName(Dog dog) => dog.Name;

    // GraphQL Input Object Type
    // Name is non-nullable, Surname is nullable
    public string GetPersonName(Person person) => person.Name;

    public string GetDogOrCatName(DogOrCat catOrDog)
        => catOrDog.Cat?.Name ?? catOrDog.Dog?.Name!;
}
