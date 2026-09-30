

/*
 * Student ID : 1690703275
 * Name       : Hussaluk Sriprasert
 * Section    : 129C
 * No.        : 31
 * Course     : GI113 Computer Programming (GI)
 */
namespace Assignment02
{
    internal class Program
    {
        static void Main(string[] args)
        {

            const double smeltRate = 0.3;
            const double salvageRate = 0.5;
            const double maxBatch = 100;
            const double lowerestNumber = 1;

            Console.WriteLine("========================");
            Console.WriteLine("   ---> The Forge <---  ");
            Console.WriteLine("========================");
            Console.WriteLine("Iron smelting: 0.3 / savage 0.5");
            Console.WriteLine(" Key 'S' for Smelt (Ore -> Ingot)");
            Console.WriteLine(" Key 'B' for Savage (Ingot -> Bar)");
            Console.Write("Choose S OR B : ");

            bool ore = char.TryParse(Console.ReadLine(), out char material);
            if (material == 'S')
            {
                if (material == 'S')
                {
                    Console.Write("How much would you like. : ");
                    double.TryParse(Console.ReadLine(), out double ironAmount);
                    if (ironAmount <= maxBatch && ironAmount >= lowerestNumber)
                    {
                        double foolgold = ironAmount * smeltRate;
                        Console.WriteLine($"You got {foolgold} iron bar");
                    }
                    else
                    {
                        Console.WriteLine("Invalid Number, Try again");
                    }
                }
            }
            else if (material == 'B')
            {
                if (material == 'B')
                {
                    Console.Write("How much would you like. : ");
                    double.TryParse(Console.ReadLine(), out double goldAmount);
                    if (goldAmount <= maxBatch && goldAmount >= lowerestNumber)
                    {
                        double gold = goldAmount / salvageRate;
                        Console.WriteLine($"You got {gold} gold bar");
                    }
                    else
                    {
                        Console.WriteLine("Invalid Number, Try again");
                    }
                }

            }
            else
            {
                Console.WriteLine("Out of option");  
            }
        }
    }
}
