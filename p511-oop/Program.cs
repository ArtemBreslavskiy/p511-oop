using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace p511_oop
{
    internal class Program
    {
        public static void PrintMenu()
        {
            Console.WriteLine("\n\t0: Print settings values");
            Console.WriteLine("\t1: Set language");
            Console.WriteLine("\t2: Set volume");
            Console.WriteLine("\t3: Set brightness");
            Console.WriteLine("\t4: Set text size");
            Console.WriteLine("\t5: On/off dark mode");
            Console.WriteLine("\t6: Reset to default settings");
            Console.WriteLine("\t7: Save settings");
            Console.WriteLine("\t8: Load settings");
            Console.WriteLine("\n\tstop: Close the program");
            Console.WriteLine("\thelp: Bring up a list of options");
        }

        static void Main(string[] args)
        {
            bool stop = false;
            Settings settings = new Settings();
            SettingsManager settingsManager = new SettingsManager();

            PrintMenu();

            while (!stop)
            {
                Console.Write("\n\n\tSelect an option: ");
                string input = Console.ReadLine();

                switch (input)
                {
                    case "0":
                        settingsManager.PrintSettingsValues(settings);
                        break;

                    case "1":
                        settingsManager.SetLanguage(settings);
                        break;

                    case "2":
                        settingsManager.SetVolume(settings);
                        break;

                    case "3":
                        settingsManager.SetBrightness(settings);
                        break;

                    case "4":
                        settingsManager.SetTextSize(settings);
                        break;

                    case "5":
                        settingsManager.SwitchDarkMode(settings);
                        break;

                    case "6":
                        settings = settingsManager.ResetToDefault();
                        break;

                    case "7":
                        settingsManager.Save(settings);
                        break;

                    case "8":
                        settings = settingsManager.Load();
                        break;

                    case "stop":
                        stop = true;
                        Console.Clear();
                        break;

                    case "help":
                        PrintMenu();
                        break;

                    default:
                        ConsoleColor originalColor = Console.ForegroundColor;
                        Console.ForegroundColor = ConsoleColor.Red;

                        Console.WriteLine("\n\tError: Incorrect input");

                        Console.ForegroundColor = originalColor;
                        break;
                }
            }
        }
    }
}
