/*
 * Student ID :1690703275
 * Name       :Hussaluk Sriprasert
 * Section    :129C
 * No.        :31
 * Course     : GI113 Computer Programming (GI)
 */
namespace assignment01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const string GameName = "====-Overclocked-====";
            var character = "boy";
            var level = 1;
            int sanity = 20;
            float health = 1.5f;
            double speed = 1.0;
            bool IsHuman = true;

            Console.WriteLine("============Your Stats============");
            Console.WriteLine("============         =============");
            Console.WriteLine($"Welcome to {GameName}!");
            Console.WriteLine($"Character: {character}");
            Console.WriteLine($"level: {level}");
            Console.WriteLine($"Sanity: {sanity}");
            Console.WriteLine($"Health: {health}");
            Console.WriteLine($"Speed: {speed}");
            Console.WriteLine($"Human: {IsHuman}");
            Console.WriteLine("==================================");
            Console.WriteLine("");

            Console.WriteLine("============Your Stats In Game============");
            double sanityasdouble = sanity; // impicit
            Console.WriteLine($"Your base sanity : {sanityasdouble}");
            int healthBar = (int)health; // explicit 
            int healthCore = Convert.ToInt32(health); // convert float
            Console.WriteLine($"Your health in game: {healthBar}");
            Console.WriteLine($"Your health correctly: {healthCore}");
            Console.WriteLine("==========================================");


        }
    }
}
