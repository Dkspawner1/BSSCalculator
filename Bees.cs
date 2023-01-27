namespace BSSCalculator;

[Serializable]
public class Bees : List<BeesBase>
{

    [Flags]
    private enum BeeTypes : byte { Basic = 0x1, Bomber, Brave, Bumble, Cool, Hasty, Looker, Rad, Rascal, Stubborn, Bubble, Bucko, Commander, Demo, Exhausted, Fire, Frosty, Honey, Rage, Riley, Shocked, Baby, Carpenter, Demon, Diamond, Lion, Music, Ninja, Shy, Buoyant, Fuzzy, Precise, Spicy, Tadpole, Vector, Bear, Cobalt, Crimson, Digital, Festive, Gummy, Photon, Puppy, Tabby, Vicious, Windy }

    private Dictionary<int, string> Create() => Enum.GetValues(typeof(BeeTypes)).Cast<BeeTypes>().ToDictionary(t => (int)t, t => t.ToString());
    public Dictionary<int, string> BeesDict { get; private set; }

    internal Bees()
    {
        BeesDict = Create();
    }
    
    internal void PrintDictionary([Optional] bool listKey, [Optional] bool listValue)
    {
        foreach (var kvp in BeesDict)
        {
            if (listKey & listValue)
                Console.WriteLine($"({kvp.Key}) {kvp.Value}");
            else if (listKey == false && listValue == true)
                Console.WriteLine($"{kvp.Value}");
            else if (listKey == true && listValue == false)
                Console.WriteLine($"{kvp.Key}");
            else throw new ArgumentException($"One or more arugments are invalid...");
        }
    }

    ~Bees()
    {
        Console.WriteLine($"{this} Was disposed");
    }

}