using GqlApi.Models.Enums;
using GqlApi.Models.Mammal;

namespace GqlApi.Models.Animal;

public class Dog(string Name, string breed) : IPet, IMammal
{
    public string Name { get; } = Name;
    public string Breed { get; } = breed;    
}