/*
 * Student ID :1690703275
 * Name       :Hussaluk Sriprasert
 * Section    :129C
 * No.        :N/A
 * Course     : GI113 Computer Programming (GI)
 */
using System.Collections;

namespace Lab03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const int MaxLevel = 10;

            var bossName = "Kirin";   // ต้องประกาศด้วย var ห้ามเขียน string ตรงๆ
            var rank = 'S';            // ต้องประกาศด้วย var ห้ามเขียน char ตรงๆ
            int level = 7;
            int maxHp = 240;
            int currentHp = 115;       // ค่าตั้งต้นของ Lab นี้คือ HP "หลังโดนโจมตี" จาก Lab 2 แล้ว ไม่ใช่ 175
            float attackPower = 42.5f;
            double critMultiplier = 1.75;
            bool isBoss = true;

            Console.WriteLine("===== KIRIN SAVE CONVERTER ====="); 
            Console.WriteLine($"Name: {bossName}" +
                $"\nRank: {rank}" +
                $"\nLevel: {level} / {MaxLevel}" +
                $"\nHp: {currentHp} / {maxHp}" +
                $"\nAttack Power: {attackPower}" +
                $"\nCritical Multiplier: {critMultiplier}" +
                $"\nIs Boss: {isBoss}");

            // 1. Implicit Conversatioin int (HP) ----> double
            Console.WriteLine("\n----- Implicit Conversion: HP as double -----");
            double currentHpDouble = currentHp;
            Console.WriteLine($"HP Percent (exact): {currentHpDouble}");

            // 2. Calculate Percentage
            Console.WriteLine("\n-----Exact HP Percent (no integer truncation) -----");
            double hpPercentExact = currentHpDouble * 100 / maxHp;
            Console.WriteLine($"HP Percent (exact): {hpPercentExact}");

            // 3. Explicit Cast: Attack Power -> Display Int
            Console.WriteLine("\n----- Explicit Cast: Attack Power -> Display Int -----");
            int AttackDisplay = (int)attackPower;
            Console.WriteLine($"Attack Power(int cast): {AttackDisplay}");

            // 4. Cast vs Convert: Crit Multiplier
            Console.WriteLine("\n----- Cast vs Convert: Crit Multiplier -----");
            int critCast = (int)critMultiplier;
            int critConvert = Convert.ToInt32(critMultiplier);
            Console.WriteLine($"Critical Multiplier (int Cast): {critCast}");
            Console.WriteLine($"Critical Multiplier (Convert rounded): {critConvert}");


        }
    }
}
