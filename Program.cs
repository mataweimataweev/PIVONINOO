using System;

namespace ConsoleApp13
{
    class Program
    {
        static int[] DO = new int[] { 132, 262, 523, 1046, 2094,4187};
        static int[] DOdies = new int[] { 138, 277, 554, 1108, 2217, 4434 };
        static int[] RE = new int[] { 147, 294, 587, 1174, 2350,4699};
        static int[] REdies = new int[] { 155, 311, 622, 1244, 2489, 4978 };
        static int[] MI = new int[] { 165, 330, 659, 1318, 2638,5274};
        static int[] FA = new int[] { 175, 349, 698, 1396, 2794,5587};
        static int[] FAdies = new int[] { 185, 367, 740, 1480, 2960, 5919 };
        static int[] SOl = new int[] { 196, 392, 784, 1568, 3136,6272};
        static int[] SOldies = new int[] { 207, 415, 830, 1661, 3322, 6644 };
        static int[] LA = new int[] { 220, 440, 880, 1760, 3520,7040};
        static int[] LAdies = new int[] { 233, 466, 932, 1864, 3729, 7458 };
        static int[] SI = new int[] { 247, 494, 988, 1976, 3952,7902};

        static void Main(string[] args)
        {
            Console.WriteLine("Для переключения между октавами нажмите F1 или F2 или F3 или F4");
            Console.WriteLine("Нажмите Ё для Выхода");
            int octava = 5;

            while (true)
            {
                ConsoleKey key = Console.ReadKey(true).Key;

                switch (key)
                {
                    case ConsoleKey.Q:
                        Console.Beep(DO[octava], 150);
                        break;
                    case ConsoleKey.W:
                        Console.Beep(RE[octava], 150);
                        break;
                    case ConsoleKey.E:
                        Console.Beep(MI[octava], 150);
                        break;
                    case ConsoleKey.R:
                        Console.Beep(FA[octava], 150);
                        break;
                    case ConsoleKey.T:
                        Console.Beep(SOl[octava], 150);
                        break;
                    case ConsoleKey.Y:
                        Console.Beep(LA[octava], 150);
                        break;
                    case ConsoleKey.U:
                        Console.Beep(SI[octava], 150);
                        break;
                    case ConsoleKey.A:
                        Console.Beep(DOdies[octava], 150);
                        break;
                    case ConsoleKey.B:
                        Console.Beep(REdies[octava], 150);
                        break;
                    case ConsoleKey.O:
                        Console.Beep(FAdies[octava], 150);
                        break;
                    case ConsoleKey.M:
                        Console.Beep(SOldies[octava], 150);
                        break;
                    case ConsoleKey.K:
                        Console.Beep(LAdies[octava], 150);
                        break;

                    case ConsoleKey.F1:
                        octava = 0;
                        Console.Write("Октава 0");
                        break;
                    case ConsoleKey.F2:
                        octava = 1;
                        Console.Write("Октава 1");
                        break;
                    case ConsoleKey.F3:
                        octava = 2;
                        Console.Write("Октава 2");
                        break;
                    case ConsoleKey.F4:
                        octava = 3;
                        Console.Write("Октава 3");
                        break;
                    case ConsoleKey.F5:
                        octava = 4;
                        Console.Write("Октава 4");
                        break;
                    case ConsoleKey.F6:
                        octava = 5;
                        Console.Write("Октава 5");
                        break;


                    case ConsoleKey Ё:
                        return;
                }
            }
        }
    }
}