using GqlApi.Models.Mammal;

namespace GqlApi.Models.Animal;

public class Dog : IPet, IMammal
{
    public string Name { get; }
    public string Breed { get; }

    public Dog(string name, string breed)
    {
        Name = name;
        Breed = breed;
    }
}