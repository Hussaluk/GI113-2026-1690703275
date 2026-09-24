namespace Assignment02
{
    internal class Program
    {
        static void Main(string[] args)
        {

            double smeltRate = 0.2500;
            double savageRate = 0.3000;

            Console.WriteLine("========================");
            Console.WriteLine("   ---> The Forge <---  ");
            Console.WriteLine("========================");
            Console.WriteLine("Iron smelting: 0.25 / savage 0.3");
            Console.WriteLine(" Key 'S' for Smelt (Ore -> Ingot)");
            Console.WriteLine(" Key 'B' for Savage (Ingot -> Bar)");
            Console.WriteLine("Choose S OR B");

            bool ore = char.TryParse(Console.ReadLine(), out char ingot);

            if (ingot == 'S')
            {
                Console.WriteLine("How mouch would you like");
                if (double.TryParse(Console.ReadLine(), out double ingotamout))
                {
                    double Iron = ingotamout * smeltRate;
                    Console.WriteLine($"You got {Iron}");
                }
                else
                {
                    Console.WriteLine("Invalid value, Please try again later.");
                }
            }
            else if (ingot == 'B')
            {
                Console.WriteLine("How mouch would you like");
                if (double.TryParse(Console.ReadLine(), out double ingotamout))
                {
                    double gold = ingotamout * savageRate;
                    Console.WriteLine($"You got {gold}");
                }
                else
                {
                    Console.WriteLine("Invalid value, Please try again.");
                }

            }







            }
        }
    }
