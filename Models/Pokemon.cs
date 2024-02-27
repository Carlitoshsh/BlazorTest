// Pokemon.cs
namespace Models;

public class PokemonResults {
    public List<Pokemon> results { get; set; }
}

public class Pokemon
{
    public int Id { get; set; }
    public string Name { get; set; }
    public int Weight { get; set; }
    public string Url { get; set; }
    public int Height { get; set; }
    public Sprites Sprites { get; set; }
    public List<StatP> Stats { get; set; }
    public List<TypeP> Types { get; set; }
}

public class Sprites
{
    public string FrontDefault { get; set; }
    // Add other sprite properties as needed
}

public class StatP
{
    public int BaseStat { get; set; }
    public int Effort { get; set; }
    public Stat2 Stat { get; set; }
}

public class Stat2
{
    public string Name { get; set; }
    public string Url { get; set; }
}

public class TypeP
{
    public int Slot { get; set; }
    public Type2 Type { get; set; }
}

public class Type2
{
    public string Name { get; set; }
    public string Url { get; set; }
}
