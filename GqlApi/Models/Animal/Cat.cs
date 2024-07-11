using GqlApi.Models.Enums;
using GqlApi.Models.Mammal;

namespace GqlApi.Models.Animal;

//????? WTF???
//public class Cat : IPet, IMammal
//{
//    public string Name { get; }
//    public bool IsEvil { get; }
//    public CatLives Lives { get; }

//    public Cat(string name, bool isEvil, CatLives catLives)
//    {
//        Name = name;
//        IsEvil = isEvil;
//        Lives = catLives;
//    }
//}


public class Cat(string Name, bool IsEvil, CatLives Lives) : IPet, IMammal
{
    public string Name { get; } = Name;
    public bool IsEvil { get; } = IsEvil;
    public CatLives Lives { get; } = Lives;
}