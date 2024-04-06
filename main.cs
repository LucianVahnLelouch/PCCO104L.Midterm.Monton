using System;
using static System.Runtime.InteropServices.JavaScript.JSType;

class Program
{
    public static void Main(string[] args)
    {
        int fan;
        string word = "";
        int base_speed = 10;
        int speed;
        do
        {
            SelectFan();
            void SelectFan()
            {
                Console.WriteLine("Enter Fan Speed (1, 2, or 3): ");
                fan = Convert.ToInt32(Console.ReadLine());

                if (fan >= 4)
                {
                    Console.WriteLine("Invalid Fan speed " + fan + " If you wish to turn the fan off enter '0'");
                    SelectFan();
                }
            }
            if (fan != 0) { 
            SelectOscillate();
            void SelectOscillate()
                {
                    Console.WriteLine("Oscillate the Fan? (Y/N): ");
                    word = Console.ReadLine();

                    if (word != "Y" && word != "y" && word != "N" && word != "n")
                    {
                        Console.WriteLine("please enter Y or N");
                        SelectOscillate();
                    }
                }
            }
            speed = base_speed * fan;

            if (word == "N" || word == "n")
            {
                for (int o = 0; o < speed; o++)
                {
                    for (int f = 0; f < speed; f++)
                        Console.Write("~");

                    Console.WriteLine();
                }
            }
            else
            {
                for (int i = 1; i <= speed; i++)
                {
                    for (int k = 0; k <= fan * i - 1; k++)
                    {
                        Console.Write("~");
                    }
                    Console.WriteLine();
                }
                for (int j = speed; j > 0 - 1; j--)
                {
                    for (int i = 0; i < (fan * j - 1) + 1; i++)
                    { 
                        Console.Write("~"); 
                    }
                    Console.WriteLine();
                }
            }
        } while(fan != 0);

        Console.WriteLine("Turning the fan off...");
    }

}