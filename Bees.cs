namespace BSSCalculator;

[Serializable]
public class Bees
{
    [NonSerialized]
    private static readonly string PATH = "bees.json";

    [Flags]
    private enum BeeTypes : byte { Basic = 0x1, Bomber, Brave, Bumble, Cool, Hasty, Looker, Rad, Rascal, Stubborn, Bubble, Bucko, Commander, Demo, Exhausted, Fire, Frosty, Honey, Rage, Riley, Shocked, Baby, Carpenter, Demon, Diamond, Lion, Music, Ninja, Shy, Buoyant, Fuzzy, Precise, Spicy, Tadpole, Vector, Bear, Cobalt, Crimson, Digital, Festive, Gummy, Photon, Puppy, Tabby, Vicious, Windy }

    private Dictionary<int, string> Create() => Enum.GetValues(typeof(BeeTypes)).Cast<BeeTypes>().ToDictionary(t => (int)t, t => t.ToString());
    public Dictionary<int, string> BeesDict { get; private set; }
    private List<BeesBase> beesBase;
    internal Bees()
    {
        beesBase = new List<BeesBase>();

        BeesDict = Create();
        // for (int i = 0; i < BeesDict.Count; i++)
        // beesBase.Add(new BeesBase(new KeyValuePair<int, string>(BeesDict.Keys.ToList()[0], BeesDict.Values.ToList()[0]), BeesBase.BeeColour.ColourLess, 20, 14, 1, 10, 80));
        // beesBase.Add(new BeesBase(new KeyValuePair<int, string>(BeesDict.Keys.ToList()[1], BeesDict.Values.ToList()[1]), BeesBase.BeeColour.ColourLess, 20, 15.4, 2, 10, 120));

    }

    public void ListFull()
    {
        for (int i = (int)default(BeeTypes); i < beesBase.Count; i++)
            beesBase[i].ListBee();
    }
    internal void Save()
    {
        var serialized = JsonSerializer.Serialize<List<BeesBase>>(beesBase);
        File.WriteAllText(PATH, serialized);
    }
    internal void Load()
    {
        var contents = File.ReadAllText(PATH);
        var deserialized = JsonSerializer.Deserialize<List<BeesBase>>(contents);
        foreach (var entry in deserialized)
        {
            beesBase.Add(entry);
        }
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

    ~Bees() => Console.WriteLine($"{this} Was disposed");

}