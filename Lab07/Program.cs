using System.Runtime.CompilerServices;

namespace Lab07
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const int MonsterHP = 20;
            const int MonsterAtk = 20;
            const int HeroHp = 100;


            Console.Write("Monster Defense: ");
            int.TryParse(Console.ReadLine(), out int monsterDefense);
            Console.WriteLine($"A Slime appears! HP {MonsterHP}, DEF {monsterDefense}");

            Console.WriteLine("===BATTLE MENU===");
            Console.WriteLine("1) Attack");
            Console.WriteLine("2) Fire Magic");
            Console.WriteLine("3) Defend");
            Console.WriteLine("4) Run");
            Console.WriteLine("5) Use Ultimate");
            Console.Write("Choose (1-5): ");
            int.TryParse(Console.ReadLine(), out int command);

            switch (command)
            {
                case 1:
                    Console.WriteLine("Hero swing the sword!");
                    break;
                case 2:
                    Console.WriteLine("Hero casts Fire!");
                    break;
                case 3:
                    Console.WriteLine("Hero raises the shield.");
                    break;
                case 4:
                    Console.WriteLine("Hero look for a way out...");
                    break;
                case 5:
                    Console.WriteLine("Hero Use Ultimate");
                    break;
                default:
                    Console.WriteLine("Hero hesitates. Invalid command!");
                    break;
            }

            int power = command switch
            {
                1 => 50,
                2 => 33,
                5 => 120,
                _ => 0,
             
            };
            int damage = Math.Max(0, power - MonsterHP);
            Console.WriteLine($"Damage: {damage}");

            string critRating = damage switch
            {
                >= 100 => "OVER KILL",
                >= 21 => "Fracture Hit",
                >= 6 => "Solid Hit",
                > 0 => "No action",
                _ => "Nothing",
            };
            Console.WriteLine($"Damage deal to monster: {critRating}");

            string monsterStatus = damage >= MonsterHP ? "Monster Defeated" : "Still Alive";
            Console.WriteLine($"Slime: {monsterStatus}");

            Console.Write("Run Away?(y/n): ");
            string answer = Console.ReadLine();

            switch (answer)
            {
                case "y":
                case "Y":
                    Console.WriteLine("You Escape");
                    break;
                    
                case "n":
                case "N":
                    Console.WriteLine("You Still Fighting");
                    break;
                    
            }





        }
    
    }
}
