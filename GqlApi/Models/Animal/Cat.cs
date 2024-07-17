using GqlApi.Models.Enums;
using GqlApi.Models.Mammal;

namespace GqlApi.Models.Animal;

public class Cat(string Name, bool IsEvil, CatLives Lives) : IPet, IMammal
{
    public string Name { get; } = Name;
    public bool IsEvil { get; } = IsEvil;
    public CatLives Lives { get; } = Lives;
}