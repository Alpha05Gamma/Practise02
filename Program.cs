namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("F5-F6: переключение октав");
            
            int chosenOctawe = 1;
            ConsoleKeyInfo key;
            do
            {
                key = Console.ReadKey();
                switch (key.Key)
                {
                    case ConsoleKey.Q: 
                        Sound(chosenOctawe, 1);
                        break;
                    case ConsoleKey.W:
                        Sound(chosenOctawe, 2);
                        break;
                    case ConsoleKey.E:
                        Sound(chosenOctawe, 3);
                        break;
                    case ConsoleKey.R:
                        Sound(chosenOctawe, 4);
                        break;
                    case ConsoleKey.T:
                        Sound(chosenOctawe, 5);
                        break;
                    case ConsoleKey.Y:
                        Sound(chosenOctawe, 6);
                        break;
                    case ConsoleKey.U:
                        Sound(chosenOctawe, 7);
                        break;
                    case ConsoleKey.I:
                        Sound(chosenOctawe, 8);
                        break;
                    case ConsoleKey.O:
                        Sound(chosenOctawe, 9);
                        break;
                    case ConsoleKey.P:
                        Sound(chosenOctawe, 10);
                        break;
                    case ConsoleKey.K:
                        Sound(chosenOctawe, 11);
                        break;
                    case ConsoleKey.L:
                        Sound(chosenOctawe, 12);
                        break;
                    case ConsoleKey.F5 : chosenOctawe++;
                        if (chosenOctawe == 0)
                        {
                            chosenOctawe = 9;
                        }
                        else if (chosenOctawe == 10)
                        {
                            chosenOctawe = 1;
                        }
                        Console.WriteLine("Октава " + chosenOctawe);
                        break;
                    case ConsoleKey.F6: chosenOctawe--;
                        if (chosenOctawe == 0)
                        {
                            chosenOctawe = 9;
                        }
                        else if (chosenOctawe == 10)
                        {
                            chosenOctawe = 1;
                        }
                        Console.WriteLine("Октава " + chosenOctawe);
                        break;
                }
                

            } while (key.Key != ConsoleKey.F9);
        }

        static int[] OctawesSwitcher(int OctaveNum = 1)
        {
            int[] FirstOctave = new int[12] { 16, 17, 18, 19, 20, 21, 23, 24, 25, 27, 29, 30 };
            int[] SecondOctave = new int[12] { 32, 34, 36, 38, 41, 43, 46, 49, 51, 55, 58, 61 };
            int[] ThirdOctave = new int[12] { 65, 69, 73, 77, 82, 87, 92, 98, 103, 110, 116, 123 };
            int[] FourthOctave = new int[12] { 130, 138, 146, 155, 164, 174, 185, 196, 207, 220, 233, 246 };
            int[] FivethsOctave = new int[12] { 261, 277, 293, 311, 329, 349, 370, 392, 415, 440, 466, 593 };
            int[] SixthOctave = new int[12] { 523, 554, 587, 622, 659, 698, 740, 784, 830, 880, 932, 987 };
            int[] SeventhOctave = new int[12] { 1047, 1109, 1175, 1245, 1319, 1397, 1480, 1568, 1661, 1760, 1865, 1976 };
            int[] EightOctave = new int[12] { 2093, 2217, 2349, 2489, 2637, 2794, 2960, 3136, 3322, 3520, 3729, 3951 };
            int[] NinethOctave = new int[12] { 4186, 4435, 4699, 4978, 5274, 5588, 5920, 6272, 6645, 7040, 7459, 7902 };

            switch (OctaveNum)
            {
                case 1: return FirstOctave;
                case 2: return SecondOctave;
                case 3: return ThirdOctave;
                case 4: return FourthOctave;
                case 5: return FivethsOctave;
                case 6: return SixthOctave;
                case 7: return SeventhOctave;
                case 8: return EightOctave;
                case 9: return NinethOctave;
                default: return FirstOctave;
            }
        }

        static void Sound(int OctaveNum = 1, int note_num=1)
        {
            int[] soundbar = OctawesSwitcher(OctaveNum);
            int soundLevel = soundbar[note_num];
            if (soundLevel < 37)
            {
                soundLevel = 37;
            }
            Console.Beep(soundLevel, 500);
        }

    }

        
}