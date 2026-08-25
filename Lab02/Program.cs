/*
 * Student ID : 1690703275
 * Name       : Lab02
 * Section    : 129C
 * No.        : N/A
 * Course     : GI113 Computer Programming (GI)
 */

namespace Lab02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string bossName = "Kirin";
            char rank = 'S';
            int level = 7;
            int maxHp = 240;
            int currentHp = 175;
            float attackPower = 42.5f;
            double critMultiplier = 1.75;
            bool isBoss = true;

            Console.WriteLine("===== BOSS STATUS: INITIAL =====");
            Console.WriteLine($"Name: {bossName}");
            Console.WriteLine($"Rank: {rank}");
            Console.WriteLine($"HP: {currentHp}/{maxHp}");
            Console.WriteLine($"Attack power: {attackPower}");
            Console.WriteLine($"Critical multiplier: {critMultiplier}");
            Console.WriteLine($"Is boss: {isBoss}");
            
            Console.WriteLine();
            // คำนวณเปอร์เซ็นต์ HP ของบอส
            int hpPercent = currentHp * 100 / maxHp;
            Console.WriteLine($"HP Percentage: {hpPercent}%");
            Console.WriteLine();
            Console.WriteLine("Kirin takes 60 damage!");
            Console.WriteLine();
            // ลด HP ของบอสลง 60 หน่วย
            currentHp -= 60;
            Console.WriteLine();
            Console.WriteLine("===== BOSS STATUS: AFTER DAMAGE =====");
            Console.WriteLine($"HP: {currentHp}/{maxHp}");
            hpPercent = currentHp * 100 / maxHp;
            Console.WriteLine($"HP Percentage: {hpPercent}%");

            //Lab02 part 2 is here

            // Character Information
            string Player1 = "Choso";
            string Player2 = "Itadori";
            string Player3 = "Todo";
            string Player4 = "Megumi";

            // Character Grade Information
            char SpecialGradeSorcerer = 'S';
            char grade1Sorcerer = 'A';
            char grade2Sorcerer = 'B';
            char specialGradeCurse = 'A';

            //Character HP Information
            int HighmaxHp = 200;
            int midHp = 150;
            int lowHp = 100;

            //Character Speed Information
            int highSpeed = 80;
            int midSpeed = 60;
            int lowSpeed = 40;

            //Character Attack Power Information
            float highAttackPower = 50f;
            float midAttackPower = 40f;
            float lowAttackPower = 30f;

            //Character Curse Energy Information
            double highCurseEnergy = 1.5;
            double midCurseEnergy = 1.0;
            double lowCurseEnergy = 0.5;

            //Character Curse/Sorcerer Information
            bool isCurse = true;
            bool isHuman = false;

            Console.WriteLine();
            Console.WriteLine("=====Characteristics Design=====");

            Console.WriteLine($"Character {Player1}");
            Console.WriteLine($"Grade: {SpecialGradeSorcerer}");
            Console.WriteLine($"HP: {HighmaxHp}");
            Console.WriteLine($"Speed: {highSpeed}");
            Console.WriteLine($"Attack Power: {highAttackPower}");
            Console.WriteLine($"Curse Energy: {highCurseEnergy}");
            Console.WriteLine($"Is Curse: {isCurse}");

            Console.WriteLine();
            Console.WriteLine($"Character {Player2}");
            Console.WriteLine($"Grade: {grade1Sorcerer}");
            Console.WriteLine($"HP: {HighmaxHp}");
            Console.WriteLine($"Speed: {midSpeed}");
            Console.WriteLine($"Attack Power: {midAttackPower}");
            Console.WriteLine($"Curse Energy: {midCurseEnergy}");
            Console.WriteLine($"Is Curse: {isHuman}");

            Console.WriteLine();
            Console.WriteLine($"Character {Player3}");
            Console.WriteLine($"Grade: {grade2Sorcerer}");
            Console.WriteLine($"HP: {midHp}");
            Console.WriteLine($"Speed: {midSpeed}");
            Console.WriteLine($"Attack Power: {midAttackPower}");
            Console.WriteLine($"Curse Energy: {midCurseEnergy}");
            Console.WriteLine($"Is Curse: {isHuman}");

            Console.WriteLine();
            Console.WriteLine($"Character {Player4}");
            Console.WriteLine($"Grade: {specialGradeCurse}");
            Console.WriteLine($"HP: {lowHp}");
            Console.WriteLine($"Speed: {lowSpeed}");
            Console.WriteLine($"Attack Power: {midAttackPower}");
            Console.WriteLine($"Curse Energy: {highCurseEnergy}");
            Console.WriteLine($"Is Curse: {isHuman}");
        }
    }
}






