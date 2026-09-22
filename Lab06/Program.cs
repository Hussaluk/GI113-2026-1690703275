/*
 * Student ID : 1690703275
 * Name       : Hussaluk Sriprasert
 * Section    : 129C
 * No.        : 31
 * Course     : GI113 Computer Programming (GI)
 */
using System.Net.Sockets;
using System.Runtime.CompilerServices;

namespace Lab06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int live = 0;

            //if (live == 0) // ใส่เงื่อนไขต้องเช็ค ค่าที่ได้ต้องเป็น bool ได้แค่ true หรือ false เท่านั้น
            //{
            // Console.WriteLine("Game Over!"); // จะรันได้ท้า If เป็นจริงเท่านั้น
            //}
            //else
            //{
            // Console.WriteLine("Keep Fighting!"); // จะรันได้ต้องมี If เป็นเท็จเท่านั้น/ใช้ได้ต้องมี If เท่านั้น")  
            //}
            // ถ้า if ทำงานเสสร็จแล้ว หรือ เป็น false จะทำงานต่อบรนทัดด้านนอกทันที่
            //Console.WriteLine("Continue Codes");
            //int Level = 10;
            // เมื่อใช้เงือนไขหลายเชค ให้มากไปน้อยเสมอ มาก --> น้อย
            //if (Level >= 5)
            //bool haskey = false;
            //
            //Console.Write("Your level (1-99): ");
            //
            //bool inputValid = int.TryParse(Console.ReadLine(), out int level);
            //
            //if (!inputValid || level < 1 || level > 99)
            //{
            // Console.WriteLine("Invalid Level");
            //}
            //else if (level >= 10 && haskey)
            //{
            //    Console.WriteLine("Boss floor unlocked");
            //}
            //
            //else if (level >= 5) // เงือนไข 2 ถ้ายังไม่ตรงเงือนไข If
            //{
            //    if (haskey == true)
            //    { 
            //    Console.WriteLine("The doors open");
            //    }
            //    else
            //    {
            //        Console.WriteLine("Locked, Find as Key.");
            //    }
            //}
            //else // เมิอไม่ตริงเงือนใดเลย จะทำงานใน else ทันที
            //{
            //    Console.WriteLine("The doors is shut.");
            //}
            //*bool isPoisoned = true;
            //if (isPoisoned == true)
            //{
            //    Console.WriteLine("You Died.");
            //}
            //else
            //{
            //   Console.WriteLine("You live.");
            // }
            int playerHP = 100;
            int atk = 20;
            int dragonHp = 200;
            int counterDmg = 15;
            int dodge = -20;
            int dragonAtk = 20;

            Console.WriteLine("===< Chase the dragon >===");
            Console.WriteLine("You are attacking the dragon!");
            Console.WriteLine("Attack = Monster Take damage = 1");
            Console.WriteLine("Counter = Player Deal slightly damage = 2");
            Console.WriteLine("Dodge = Player Take less damage = 3");

            Console.WriteLine("\nChoose your action between 1 or 3 attack: ");
            bool action = int.TryParse(Console.ReadLine(), out int playerAction);

            if (!action || (playerAction < 1 || playerAction > 3) )
            {
                if (playerAction < 1 || playerAction > 3)
                {
                    Console.WriteLine("Choose between 1 or 2 only");
                }
                else
                {
                    Console.WriteLine("Seriously, 1 or 2 only");
                }
            }
            else if (playerAction == 1)
            {
                dragonHp -= atk;
                if (dragonHp <= 0)
                {
                    Console.WriteLine("Dragon is defeated");
                }
                else
                {
                    Console.WriteLine($" Dragon has {dragonHp} left");

                }
            }
            else if (playerAction == 2)
            {
                dragonHp -= counterDmg;
                if (dragonHp <= 0)
                {
                    Console.WriteLine("dragonHp is defeated");
                }
                else
                {
                    Console.WriteLine($"Dragon has{dragonHp} left");
                }
            }

            else if (playerAction == 3)
            {
                dragonAtk += dodge;
                if (dragonHp <= 0)
                {
                    Console.WriteLine("dragonHp is defeated");
                }
                else
                {
                    Console.WriteLine($"You dodge DragonAttack, You take {dragonAtk} Damage");
                }
            }

        }
    }
}    