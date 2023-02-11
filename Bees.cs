using System.Linq;

namespace BSSCalculator;

[Serializable]
public class Bees
{
    [NonSerialized]
    private static readonly string PATH = "bees.json";

    [Flags]
    private enum BeeTypes : byte { Basic = 0x1, Bomber, Brave, Bumble, Cool, Hasty, Looker, Rad, Rascal, Stubborn, Bubble, Bucko, Commander, Demo, Exhausted, Fire, Frosty, Honey, Rage, Riley, Shocked, Baby, Carpenter, Demon, Diamond, Lion, Music, Ninja, Shy, Buoyant, Fuzzy, Precise, Spicy, Tadpole, Vector, Bear, Cobalt, Crimson, Digital, Festive, Gummy, Photon, Puppy, Tabby, Vicious, Windy }
    /// <returns></returns>
    private Dictionary<int, string> Create() => Enum.GetValues(typeof(BeeTypes)).Cast<BeeTypes>().ToDictionary(t => (int)t, t => t.ToString());
    public Dictionary<int, string> BeesDict { get; private set; }
    private List<BeesBase> beesBase;
    internal Bees()
    {
        beesBase = new List<BeesBase>();

        BeesDict = Create();
        // TODO: each bee has their own time for conversion and production so I have to make each time accurate I.E most bees run convert/produce every 4 seconds 
        // for (int i = 0; i < BeesDict.Count; i++)
    }
    public void PopulateBees()
    {
        #region Common
        beesBase.Add(new BeesBase(new KeyValuePair<int, string>(BeesDict.Keys.ToList()[0], BeesDict.Values.ToList()[0]), BeesBase.BeeRarity.Common, BeesBase.BeeColour.ColourLess, 20, 14, 1, 10, 80));
        #endregion Common
        #region Rare
        beesBase.Add(new BeesBase(new KeyValuePair<int, string>(BeesDict.Keys.ToList()[1], BeesDict.Values.ToList()[1]), BeesBase.BeeRarity.Rare, BeesBase.BeeColour.ColourLess, 20, 15.4, 2, 10, 120));
        beesBase.Add(new BeesBase(new KeyValuePair<int, string>(BeesDict.Keys.ToList()[2], BeesDict.Values.ToList()[2]), BeesBase.BeeRarity.Rare, BeesBase.BeeColour.ColourLess, 30, 16.8, 5, 10, 200));
        beesBase.Add(new BeesBase(new KeyValuePair<int, string>(BeesDict.Keys.ToList()[3], BeesDict.Values.ToList()[3]), BeesBase.BeeRarity.Rare, BeesBase.BeeColour.Blue, 40, 10.5, 1, 18, 80));
        beesBase.Add(new BeesBase(new KeyValuePair<int, string>(BeesDict.Keys.ToList()[4], BeesDict.Values.ToList()[4]), BeesBase.BeeRarity.Rare, BeesBase.BeeColour.Blue, 20, 14, 2, 10, 120));
        beesBase.Add(new BeesBase(new KeyValuePair<int, string>(BeesDict.Keys.ToList()[5], BeesDict.Values.ToList()[5]), BeesBase.BeeRarity.Rare, BeesBase.BeeColour.ColourLess, 20, 19.6, 1, 10, 80));
        beesBase.Add(new BeesBase(new KeyValuePair<int, string>(BeesDict.Keys.ToList()[6], BeesDict.Values.ToList()[6]), BeesBase.BeeRarity.Rare, BeesBase.BeeColour.ColourLess, 20, 14, 1, 13, 160));
        beesBase.Add(new BeesBase(new KeyValuePair<int, string>(BeesDict.Keys.ToList()[7], BeesDict.Values.ToList()[7]), BeesBase.BeeRarity.Rare, BeesBase.BeeColour.Red, 20, 14, 1, 13, 80));
        beesBase.Add(new BeesBase(new KeyValuePair<int, string>(BeesDict.Keys.ToList()[8], BeesDict.Values.ToList()[8]), BeesBase.BeeRarity.Rare, BeesBase.BeeColour.Red, 20, 16.1, 3, 10, 80));
        beesBase.Add(new BeesBase(new KeyValuePair<int, string>(BeesDict.Keys.ToList()[9], BeesDict.Values.ToList()[9]), BeesBase.BeeRarity.Rare, BeesBase.BeeColour.ColourLess, 20, 11.9, 2, 10, 80));
        #endregion Rare
        #region Epic
        beesBase.Add(new BeesBase(new KeyValuePair<int, string>(BeesDict.Keys.ToList()[10], BeesDict.Values.ToList()[10]), BeesBase.BeeRarity.Epic, BeesBase.BeeColour.Blue, 20, 16.1, 3, 10, 160));
        beesBase.Add(new BeesBase(new KeyValuePair<int, string>(BeesDict.Keys.ToList()[11], BeesDict.Values.ToList()[11]), BeesBase.BeeRarity.Epic, BeesBase.BeeColour.Blue, 30, 15.4, 5, 17, 80));
        beesBase.Add(new BeesBase(new KeyValuePair<int, string>(BeesDict.Keys.ToList()[12], BeesDict.Values.ToList()[12]), BeesBase.BeeRarity.Epic, BeesBase.BeeColour.ColourLess, 30, 14, 4, 15, 80));
        beesBase.Add(new BeesBase(new KeyValuePair<int, string>(BeesDict.Keys.ToList()[13], BeesDict.Values.ToList()[13]), BeesBase.BeeRarity.Epic, BeesBase.BeeColour.ColourLess, 20, 16.8, 3, 10, 200));
        beesBase.Add(new BeesBase(new KeyValuePair<int, string>(BeesDict.Keys.ToList()[14], BeesDict.Values.ToList()[14]), BeesBase.BeeRarity.Epic, BeesBase.BeeColour.ColourLess, 0, 10.5, 1, 10, 240));
        beesBase.Add(new BeesBase(new KeyValuePair<int, string>(BeesDict.Keys.ToList()[15], BeesDict.Values.ToList()[15]), BeesBase.BeeRarity.Epic, BeesBase.BeeColour.Red, 25, 11.2, 4, 10, 80));
        beesBase.Add(new BeesBase(new KeyValuePair<int, string>(BeesDict.Keys.ToList()[16], BeesDict.Values.ToList()[16]), BeesBase.BeeRarity.Epic, BeesBase.BeeColour.Blue, 25, 11.2, 1, 10, 80));
        beesBase.Add(new BeesBase(new KeyValuePair<int, string>(BeesDict.Keys.ToList()[17], BeesDict.Values.ToList()[17]), BeesBase.BeeRarity.Epic, BeesBase.BeeColour.ColourLess, 20, 14, 1, 10, 360));
        beesBase.Add(new BeesBase(new KeyValuePair<int, string>(BeesDict.Keys.ToList()[18], BeesDict.Values.ToList()[18]), BeesBase.BeeRarity.Epic, BeesBase.BeeColour.Red, 20, 15.4, 4, 10, 80));
        beesBase.Add(new BeesBase(new KeyValuePair<int, string>(BeesDict.Keys.ToList()[19], BeesDict.Values.ToList()[19]), BeesBase.BeeRarity.Epic, BeesBase.BeeColour.Red, 25, 15.4, 5, 10, 140));
        beesBase.Add(new BeesBase(new KeyValuePair<int, string>(BeesDict.Keys.ToList()[20], BeesDict.Values.ToList()[20]), BeesBase.BeeRarity.Epic, BeesBase.BeeColour.ColourLess, 20, 19.6, 2, 10, 80));
        #endregion Epic

    }

    public void ListFull()
    {
        foreach (var bee in beesBase)
            bee.ListBee();
    }
    public void ListSingle([Optional] string beeValue, [Optional] int beeKey)
    {
        if (beeKey is not 0)
            beesBase[beeKey].ListBee();
        //TODO: implement value search
    }
    internal void Save()
    {
        var serialized = JsonSerializer.Serialize<List<BeesBase>>(beesBase);
        File.WriteAllText(PATH, serialized);
    }
    internal bool Load()
    {
        var contents = File.ReadAllText(PATH);
        var deserialized = JsonSerializer.Deserialize<List<BeesBase>>(contents);
        beesBase.AddRange(deserialized!);
        if (beesBase.Any(i => i.Equals(null) || i.Equals(string.Empty)))
            return false;
        return true;
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