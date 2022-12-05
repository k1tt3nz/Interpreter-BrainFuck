using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interpreter_BrainFuck
{
    public class ConsoleIO
    {
        

        public static void StartingConsole()
        {
            _initializingSettings();
            _printLogo();
            _printNickname();
            _new();
        }

        private static void _initializingSettings()
        {
            Console.Title = "Interpreter BrainFuck";
        }

        private static void _inputBFCode()
        {
            Console.WriteLine("Введите код на языке BrainFuck:");
            Console.ForegroundColor = ConsoleColor.Green;

            Buffer.InitCode();

            Console.ForegroundColor = ConsoleColor.White;
        }

        private static void _new()
        {
            _inputBFCode();
            Parser.ParseCode();

            _nextCommand();
        }

        private static void _nextCommand()
        {
            Console.WriteLine();
            string command = Console.ReadLine();
            command.ToLower();
            switch (command)
            {
                case "exit": Environment.Exit(0);break;
                case "next": _new();break;
            }
        }

        private static void _printLogo()
        {
            string str1 = "░░░░░░░░░░░░░░░░░░░░░░░░░▄░░░░░░░░░░▄░\r\n";
            string str2 = "░░░░░░░░░░░░░░░░░░░░░░▄███░░░░░░░▄▄█░░\r\n";
            string str3 = "░░░░░░░░░░░▀██████████████░░░░▄▄██▀░░░\r\n";
            string str4 = "░░░░░░░▄▄▄▄▄▄█████████████▄░░███▀░░░░░\r\n";
            string str5 = "░░░░░░░▀████████████████████▄░▀▀░░░░░░\r\n";
            string str6 = "░░░░▄█████████████████████████░░░░░░░░\r\n";
            string str7 = "░░░░▄▄████████████████████████▄░░░░░░░\r\n";
            string str8 = "░░▀████████████████████████████▄░░░░░░\r\n";
            string str9 = "░▄▄██████████████████████████████░░░░░\r\n";
            string str10 = "▀▀████████████████████████████████▄░░░\r\n";
            string str11 = "████████████████████████████████████▄░\r\n";
            string str12 = "▀█████████████████▀░▀█████████████████\r\n";
            string str13 = "░░██████████████▀░░░░░▀███████████████\r\n";
            string str14 = "░░░▀████████████░░░░░░░░░░░░░▀████████\r\n";
            string str15 = "░░░░░███████████░░░░░░░░░░░░░░░▀▀███▀▀\r\n";
            string str16 = "░░░░░░▀█████████▄░░░░░░░░░░░░░░░░░░░░░\r\n";
            string str17 = "░░░░░░░░▀████████░░░░░░░░░░░░░░░░░░░░░\r\n";
            string str18 = "░░░░░░░░░░▀██████░░░░░░░░░░░░░░░░░░░░░";

            string[] logo = { str1, str2, str3, str4, str5, str6, str7, str8, str9, str10, str11, str12, str13, str14, str15, str16, str17, str18 };
            int colour = 1;
            for (int i = 0; i < logo.Length; i++)
            {
                if (i == 14) colour = 1;
                else colour++;

                Console.ForegroundColor = (ConsoleColor)colour;
                Console.Write(logo[i]);

            }
            Console.ForegroundColor = (ConsoleColor)ConsoleColor.White;
        }

        private static void _printNickname()
        {
            Console.WriteLine();

            Console.Write("Software Developer: ");
            int colour = 8;
            string[] nickname = { "k", "1", "t", "t", "3", "n", "z" };
            nickname.ToArray();
            for (int i = 0; i < nickname.Length; i++)
            {
                if (i == 14) colour = 9;
                else colour++;
                Console.ForegroundColor = (ConsoleColor)colour;
                Console.Write(nickname[i]);
            }

            for (int i = 0; i < 3; i++)
                Console.WriteLine();
        }
    }
}
