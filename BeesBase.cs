namespace BSSCalculator;

public partial class BeesBase
{
    public KeyValuePair<int, string>? BeeEnum { get; protected set; }
    [Flags]
    public enum BeeColour : byte { ColourLess, Red, Blue }
    [Flags]
    public enum BeeRarity : byte { Common, Rare, Epic, Legendary, Mythic, Event }

    public BeeRarity Rarity { get; protected set; }
    public BeeColour Colour { get; protected set; }
    public double BaseEnergy { get; protected set; }
    public double BaseSpeed { get; protected set; }
    public double BaseAttack { get; protected set; }
    public double BaseGather { get; protected set; }
    // Todo: Implement
    public int BaseGatherSpeed { get; protected set; }
    public double BaseProduction { get; protected set; }
    // Todo: Implement
    public int BaseProductionSpeed { get; protected set; }

    public BeesBase(KeyValuePair<int, string>? beeEnum, BeeRarity rarity, BeeColour colour, double baseEnergy, double baseSpeed, double baseAttack, double baseGather, double baseProduction)
    {
        BeeEnum = beeEnum;
        Colour = colour;
        Rarity = rarity;
        BaseEnergy = baseEnergy;
        BaseSpeed = baseSpeed;
        BaseAttack = baseAttack;
        BaseGather = baseGather;
        BaseProduction = baseProduction;
    }
    public void ListBee() => Console.WriteLine($"{BeeEnum!.Value} {Colour} {BaseEnergy} {BaseSpeed} {BaseAttack} {BaseGather} {BaseProduction}");

}