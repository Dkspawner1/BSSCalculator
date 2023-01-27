namespace BSSCalculator;

public partial class BeesBase
{
    public double BaseEnergy { get; protected set; }
    public double BaseSpeed { get; protected set; }
    public double BaseAttack { get; protected set; }
    public double BaseGather { get; protected set; }
    public double BaseProduction { get; protected set; }
    public BeesBase(double baseEnergy, double baseSpeed, double baseAttack, double baseGather, double baseProduction)
    {
        BaseEnergy = baseEnergy;
        BaseSpeed = baseSpeed;
        BaseAttack = baseAttack;
        BaseGather = baseGather;
        BaseProduction = baseProduction;
    }


}