/*
 * Student ID : 1690703275
 * Name       : Hussaluk Sriprasert
 * Section    : 129C
 * No.        : 31
 * Course     : GI113 Computer Programming (GI)
 */
namespace Lab04
{
    internal class Program
    {
        static void Main(string[] args)
        {
         Console.WriteLine("+---------------------------+"); 
         Console.WriteLine("|        NEW ADVENTURE      |");
         Console.WriteLine("+---------------------------+");
         Console.Write("Name your hero: ");
         string playername = Console.ReadLine();   // (Console.ReadLine) ปอน input จากตัวผู้เล่นและเก็บไว้ในตัวแปร playername ใช้แค่ String เก็บเป็นตัวอักษรเท่านั้น
         Console.WriteLine($"\nWelcome, {playername}. Your journey begin...\"");

         Console.WriteLine("+---------------------------+");
         Console.WriteLine("|        ITEM SHOP          |");
         Console.WriteLine("+---------------------------+");
         Console.Write ("How many potion? ");
         bool isValid = int.TryParse(Console.ReadLine(), out int quanlity); // (int.TryParse) แปลงค่า string เป็น int และเก็บไว้ในตัวแปร quanlity และเก็บค่าความถูกต้องของการแปลงไว้ในตัวแปร isValid
         Console.WriteLine($"Valid input: {isValid}");
         Console.WriteLine($"Quanlity: {quanlity}");

         Console.WriteLine("+------------------------------+");
         Console.WriteLine("|          SET VOLUME           |");
         Console.WriteLine("+------------------------------+");
         Console.Write("Set volume (0.0 - 1.0 ): ");
         bool volumeOK = double.TryParse(Console.ReadLine(), out double volume);
         Console.WriteLine($"Valid input: {volumeOK}");
         Console.WriteLine($"Volume: {volume}");

         Console.WriteLine("+------------------------------+");
         Console.WriteLine("|         NEW SAVE FILE         |");
         Console.WriteLine("+------------------------------+");
         Console.Write("Enter save name: ");
         string saveName = Console.ReadLine();
         Console.Write("Choose your save slot(1 - 3): ");
         bool slotOK = int.TryParse(Console.ReadLine(), out int saveSlot);
         Console.WriteLine($"Save Name : {saveName}");
         Console.WriteLine($"Valid input : {saveSlot}");
         Console.WriteLine($"slot: {slotOK}");

         //Console.WriteLine("+---------------------------+");
         //Console.WriteLine("|    DIFFICULTY SELECT     |");
         //Console.WriteLine("+---------------------------+");
         //Console.Write("Choose difficulty (1-3): ");
         //int difficulty = Convert.ToInt32(Console.ReadLine()); // แปลงค่า string เป็น int ด้วย Convert.ToInt32() และเก็บไว้ในตัวแปร difficulty
         //Console.WriteLine($"\nDifficulty {difficulty} selected. Good luck out there...");

         //   Console.WriteLine("+---------------------------+");
         //Console.WriteLine("|      CHARACTER CREATION    |");
         //Console.WriteLine("+---------------------------+");
         //Console.Write("Name your Ccharacter: ");
         //String charName = Console.ReadLine();
         //Console.Write("Choose a Class (1-3): ");
         //bool classOk = int.TryParse(Console.ReadLine(), out int classNum);
         //Console.Write("Starting luck (0.0-10.0): ");
         //bool luckOk = double.TryParse(Console.ReadLine(), out double Luck);
         //Console.WriteLine($"{charName} is a Class {classNum} Adventure enter the dungeon. {Luck} Luck");
        }
    }
}

