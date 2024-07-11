namespace GqlApi.Models.Animal;

public class Parrot : IPet
{
    public string Name { get; }
    public bool CanTalk { get; }

    public Parrot(string name, bool canTalk)
    {
        Name = name;
        CanTalk = canTalk;
    }
}