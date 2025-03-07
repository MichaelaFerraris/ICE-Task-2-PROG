/*
 * Michaela Ferraris
 * ST10325652
 * PROG6211 POE part 1
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Media;
using System.IO;


namespace ICE_Task_2 
{
    class Program
    {

        static void Main(string[] args)
        {
            bool played1 = false, played2 = false, played3 = false;

            for (int i = 0; i <= 3; i++)
            {
                string path1 = Path.Combine(Directory.GetCurrentDirectory(), "C:\\Users\\User\\source\\repos\\ICE Task 2\\ICE Task 2\\batman_music_sfx.wav");
                string path2 = Path.Combine(Directory.GetCurrentDirectory(), "C:\\Users\\User\\source\\repos\\ICE Task 2\\ICE Task 2\\batman_theme_x.wav");
                string path3 = Path.Combine(Directory.GetCurrentDirectory(), "C:\\Users\\User\\source\\repos\\ICE Task 2\\ICE Task 2\\watch_out.wav");

                Console.WriteLine("Enter which wav file you would like to play");

                if (played1) Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("1) Batman music");
                Console.ResetColor();

                if (played2) Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("2) Batman theme song");
                Console.ResetColor();

                if (played3) Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("3) Watch out");
                Console.ResetColor();

                int input = Convert.ToInt32(Console.ReadLine());

                if (input == 1)
                {
                    SoundPlayer player = new SoundPlayer(path1);
                    player.PlaySync(); // Play the sound infinite
                    played1 = true;

                }
                else if (input == 2)
                {
                    SoundPlayer player = new SoundPlayer(path2);
                    player.PlaySync(); // Play the sound infinite
                    played2 = true;

                }
                else if (input == 3)
                {
                    SoundPlayer player = new SoundPlayer(path3);
                    player.PlaySync(); // Play the sound infinite
                    played3 = true;

                }
                else
                {
                    Console.WriteLine("Invalid choice");
                }
            }


        }
    }
}
