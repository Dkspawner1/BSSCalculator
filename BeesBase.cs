namespace BSSCalculator;

public partial class BeesBase
{
    public KeyValuePair<int, string>? BeeEnum { get; protected set; }
    [Flags]
    public enum BeeColour : byte { ColourLess, Red, Blue }
    public double BaseEnergy { get; protected set; }
    public double BaseSpeed { get; protected set; }
    public double BaseAttack { get; protected set; }
    public double BaseGather { get; protected set; }
    public double BaseProduction { get; protected set; }

    public BeeColour Colour { get; protected set; }
    public BeesBase(KeyValuePair<int, string>? beeEnum, BeeColour colour, double baseEnergy, double baseSpeed, double baseAttack, double baseGather, double baseProduction)
    {
        BeeEnum = beeEnum;
        Colour = colour;
        BaseEnergy = baseEnergy;
        BaseSpeed = baseSpeed;
        BaseAttack = baseAttack;
        BaseGather = baseGather;
        BaseProduction = baseProduction;
    }
    public void ListBee() => Console.WriteLine($"{BeeEnum.Value} {Colour} {BaseEnergy} {BaseSpeed} {BaseAttack} {BaseGather} {BaseProduction}");

}