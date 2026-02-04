using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace p511_oop
{
    internal class SettingsManager
    {
        private ConsoleColor _originalColor = Console.ForegroundColor;

        private void ColorWrite(string message, ConsoleColor color)
        {
            Console.ForegroundColor = color;
            Console.WriteLine(message);
            Console.ForegroundColor = _originalColor;
        }

        public void PrintSettingsValues(Settings settings)
        {
            Console.WriteLine($"\n\t\tLanguage: {settings.Language}");
            Console.WriteLine($"\n\t\tVolume level: {settings.VolumeLevel}");
            Console.WriteLine($"\n\t\tBrightness: {settings.Brightness}");
            Console.WriteLine($"\n\t\tText size: {settings.TextSize}");
            Console.WriteLine($"\n\t\tIs dark mode: {settings.IsDarkMode}");
        }

        public void SetLanguage(Settings settings)
        {
            Console.WriteLine("\n\t\t0: English");
            Console.WriteLine("\n\t\t1: Russian");
            Console.WriteLine("\n\t\t2: Italian");

            Console.Write("\n\n\t\tSelect a language: ");
            string input = Console.ReadLine();

            switch (input)
            {
                case "0":
                    settings.Language = "English";
                    ColorWrite("\n\t\tThe language has been changed to English", ConsoleColor.Green);
                    break;

                case "1":
                    settings.Language = "Russian";
                    ColorWrite("\n\t\tЯзык был изменён на русский", ConsoleColor.Green);
                    break;

                case "2":
                    settings.Language = "Italian";
                    ColorWrite("\n\t\tLa lingua è stata cambiata in italiano", ConsoleColor.Green);
                    break;

                default:
                    ColorWrite("\n\t\tError: Incorrect input", ConsoleColor.Red);
                    break;
            }
        }

        public void SetVolume(Settings settings)
        {
            Console.Write("\n\t\tEnter the volume level (0-100): ");
            try
            {
                int input = Convert.ToInt32(Console.ReadLine());

                if (input >= 0 && input <= 100) settings.VolumeLevel = input;
                else if (input < 0) settings.VolumeLevel = 0;
                else if (input > 100) settings.VolumeLevel = 100;

                ColorWrite($"\n\t\tVolume level: {settings.VolumeLevel}", ConsoleColor.Green);
            }
            catch (Exception)
            {
                ColorWrite("\n\t\tError: Incorrect input", ConsoleColor.Red);
            }
        }

        public void SetBrightness(Settings settings)
        {
            Console.Write("\n\t\tEnter the brightness (1-100): ");
            try
            {
                int input = Convert.ToInt32(Console.ReadLine());

                if (input >= 1 && input <= 100) settings.Brightness = input;
                else if (input < 1) settings.Brightness = 1;
                else if (input > 100) settings.Brightness = 100;

                ColorWrite($"\n\t\tBrightness: {settings.Brightness}", ConsoleColor.Green);
            }
            catch (Exception)
            {
                ColorWrite("\n\t\tError: Incorrect input", ConsoleColor.Red);
            }
        }

        public void SetTextSize(Settings settings)
        {
            Console.Write("\n\t\tEnter the text size (1-25): ");
            try
            {
                int input = Convert.ToInt32(Console.ReadLine());

                if (input >= 1 && input <= 25) settings.TextSize = input;
                else if (input < 1) settings.TextSize = 1;
                else if (input > 25) settings.TextSize = 25;

                ColorWrite($"\n\t\tText size: {settings.TextSize}", ConsoleColor.Green);
            }
            catch (Exception)
            {
                ColorWrite("\n\t\tError: Incorrect input", ConsoleColor.Red);
            }
        }

        public void SwitchDarkMode(Settings settings)
        {
            Console.WriteLine("\n\t\t0: On dark mode");
            Console.WriteLine("\n\t\t1: Off dark mode");

            Console.Write("\n\n\t\tSelect an option: ");
            string input = Console.ReadLine();

            switch (input)
            {
                case "0":
                    settings.IsDarkMode = true;
                    ColorWrite("\n\t\tThe dark theme is turned on", ConsoleColor.Green);
                    break;

                case "1":
                    settings.IsDarkMode = false;
                    ColorWrite("\n\t\tThe dark theme is turned off", ConsoleColor.Green);
                    break;

                default:
                    ColorWrite("\n\t\tError: Incorrect input", ConsoleColor.Red);
                    break;
            }
        }

        public Settings ResetToDefault()
        {
            ColorWrite("\n\t\tThe settings have been reset", ConsoleColor.Green);
            return new Settings();
        }

        public void Save(Settings settings)
        {
            try
            {
                Console.Write("\n\t\tEnter the file path: ");
                string filePath = Console.ReadLine();

                string json = JsonSerializer.Serialize(settings);
                File.WriteAllText(filePath, json);

                ColorWrite($"\n\t\tSaved in {filePath}", ConsoleColor.Green);
            }
            catch (Exception ex)
            {
                ColorWrite(ex.Message, ConsoleColor.Red);
            }
        }

        public Settings Load()
        {
            try
            {
                Console.Write("\n\t\tEnter the file path: ");
                string filePath = Console.ReadLine();

                if (!File.Exists(filePath))
                {
                    ColorWrite("\n\t\tFile not found", ConsoleColor.Red);
                    return new Settings();
                }
                else
                {
                    string json = File.ReadAllText(filePath);
                    Settings settings = JsonSerializer.Deserialize<Settings>(json);

                    ColorWrite($"\n\t\tLoaded from {filePath}", ConsoleColor.Green);
                    return settings;
                }
            }
            catch (Exception ex)
            {
                ColorWrite(ex.Message, ConsoleColor.Red);
                ColorWrite("\n\t\tThe settings have been reset", ConsoleColor.Yellow);
                return new Settings();
            }
        }
    }
}
