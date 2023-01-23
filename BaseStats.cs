namespace BSSCalculator;
public static class BaseStats
{
    private enum BeeTypes : byte { Basic, Bomber, Brave, Bumble, Cool, Hasty, Looker, Rad, Rascal, Stubborn, Bubble, Bucko, Commander, Demo, Exhausted, Fire, Frosty, Honey, Rage, Riley, Shocked, Baby, Carpenter, Demon, Diamond, Lion, Music, Ninja, Shy, Buoyant, Fuzzy, Precise, Spicy, Tadpole, Vector, Bear, Cobalt, Crimson, Digital, Festive, Gummy, Photon, Puppy, Tabby, Vicious, Windy }
    public static void MainForNow()
    {
        var dict = Enum.GetValues(typeof(BeeTypes)).Cast<BeeTypes>().ToDictionary(t => (int)t, t => t.ToString());
        foreach (var test in dict)
        {
            Console.WriteLine(test);
        }
    }
}