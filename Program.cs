namespace BSSCalculator;

public class Program
{
    private enum Selection : sbyte { Energy = 0x1, MS, Attack, Gather, Production, NONE }
    public static void Main(string[] args)
    {
        Bees bees = new Bees();
        if (!bees.Load())
            bees.PopulateBees();
        bees.ListFull();

        int offset = 1;
        bool finished = false;
        do
        {
            Console.WriteLine("Would you like to calculate:");
            IList list = Enum.GetValues(typeof(Selection));
            for (int i = 0; i < list.Count; i++)
            {
                if (i == (int)Selection.NONE - offset)
                    continue;
                object? c = list[i];
                Console.WriteLine($"({i + offset}) {c}");
            }
            var valid = int.TryParse(Console.ReadLine(), out int select);

            switch ((Selection)select)
            {
                case Selection.Energy:
                    var energy = CalculateEnergy(bees);
                    Console.WriteLine(energy);
                    break;
                case Selection.MS:
                    break;
                case Selection.Attack:
                    break;
                case Selection.Gather:
                    break;
                case Selection.Production:
                    break;
                //  Default catch clause 
                case Selection.NONE:
                default:
                    Console.WriteLine("Invalid Selection");
                    valid = false;
                    break;
            }
        }
        while (!finished);

        // Base Bee Movespeed * (1 + .03 * (Level - 1)) * (1 + Ninja Bee Hive Bonus + Playtime Badge Bonus)
        // The formula for a bee's Attack is: (Base Attack Damage + Attack Buffs) * Attack multiplier (* 1.5 If the bee is gifted)
        // The formula for Gather Amount is: Base Gather Amount * (1 + .10 * (Level - 1)) * Gifted Multiplier
        // The formula for Production Amount is: (Base Production Amount + Production Amount) * (1 + .10 * (Level - 1)) * Conversion Rate * Gifted Multiplier
    }

    /// <summary>
    /// The formula for energy is: Base Energy * (1 + .05 * (Level - 1)) * Polar Power + Energy Mutation
    /// </summary>
    /// <returns>Calculated energy, if there's mutation will add and convert percentage to total</returns>
    private static double CalculateEnergy(Bees bees)
    {
        string beeName = string.Empty;


        // The formula for energy is: Base Energy * (1 + .05 * (Level - 1)) * Polar Power + Energy Mutation
        Console.WriteLine("Please enter your desired bee or enter (list) for a list of bees!");
        string answer = Console.ReadLine()!;


        if (answer.Equals("list", StringComparison.InvariantCultureIgnoreCase))
        {
            bees.ListFull();
            Console.Write("Please select a bees index: ");
            bool validIndex = int.TryParse(Console.ReadLine(), out int beesI);
        }

        else
        {
            beeName = bees.BeesDict.FirstOrDefault(x => x.Key.Equals(answer)).Value;
            Console.WriteLine($"{beeName} Bee");
        }



        Console.Write($"Please enter your {beeName}'s level: ");
        bool validLevel = int.TryParse(Console.ReadLine(), out int level);
        Console.Write($"Please enter your polar power: ");
        var polarPower = ConvertPolarPower();
        Console.Write($"Bee's energy mutation (Enter 0 if N/A): ");
        bool validMutation = double.TryParse(Console.ReadLine(), out double energyMutation);

        var result = 5 * (1 + .05 * (level - 1)) * polarPower;

        if (energyMutation is 0)
            return result;

        return CalculatePercentage(result, energyMutation);


    }

    private static double CalculatePercentage([Optional] double result, [Optional] double energyMutation) => Ceiling(result + Round((Convert.ToDouble(energyMutation) / 100) * Convert.ToDouble(result)));

    private static double ConvertPolarPower()
    {
        Console.Write("Please Enter Your PP Level: ");
        bool validPP = double.TryParse(Console.ReadLine(), out double pp);

        double result = 1.00;
        for (int i = 0; i < pp; i++)
            result += 1.05;

        result = Round(RemoveFirstDigit(result), 2);
        return result;
    }
    private static double RemoveFirstDigit(double d) => d % (double)Pow(10, Floor(Log10(d)));
}
