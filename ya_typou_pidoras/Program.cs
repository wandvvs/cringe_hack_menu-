using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using Colorful;
using Console = Colorful.Console;
using System.Runtime.InteropServices;
using System.Diagnostics;

namespace Pir;

class Program
{
    
    static void Main(string[] args)
    {
        MainMenu.DrawLogo();
        Console.ReadKey(true);
        MainMenu.Menu();
        



    }
}
public class MainMenu
{
    public static void Exit()
    {
        System.Environment.Exit(-1);
    }
    public static void Creator(string prefix, string message, string xd)
    {
        Console.Write("[");
        Console.Write(prefix, Color.BlueViolet);
        Console.WriteLine("] " + message + xd);
    }
    public static void Inject()
    {
        Console.Clear();
        DrawLogo();
        Console.WriteLine($"Injecting.. 0%");
        Thread.Sleep(500);
        Console.WriteLine($"Injecting.. 7%");
        Thread.Sleep(500);
        Console.WriteLine($"Injecting.. 28%");
        Thread.Sleep(500);
        Console.WriteLine($"Injecting.. 44%");
        Thread.Sleep(500);
        Console.WriteLine($"Injecting.. 75%");
        Thread.Sleep(500);
        Console.WriteLine($"Injecting.. 94%");
        Thread.Sleep(500);
        Console.WriteLine($"Injecting.. 100%");
        Thread.Sleep(100);
        Console.Clear();
        DrawLogo();
        Console.WriteLine("Injected!", Color.LightGreen);
        Thread.Sleep(2000);
        Menu();
    }
    public static void Menu()
    {

        Console.Clear();
        DrawLogo();
        Say("1", "Inject");
        Say("2", "Info");
        Say("3", "Discord server");
        Say("4", "Quit");
        char option = char.Parse(Console.ReadLine());

        if (option == '1')
        {
            Inject();
        }
        else if (option == '2')
        {
            Console.Clear();
            DrawLogo();
            Thread.Sleep(350);
            Creator("+", "Last update: 01.02.2023", "");
            Thread.Sleep(350);
            Creator("+", "Creator: wand#3275", "");
            Thread.Sleep(350);
            Creator("+", "Language: ", "C#");
            string option2 = Console.ReadLine();
            if (option2 == "back")
            {
                Menu();
            }

        }
        else if (option == '3')
        {
            Console.Clear();
            DrawLogo();
            Thread.Sleep(350);
            Console.WriteLine("https://discord.gg/bCuGXxMH", Color.LightPink);
            string option2 = Console.ReadLine();
            if (option2 == "back")
            {
                Menu();
            }


        }
        else if (option == '4')
        {
            Console.Clear();
            Exit();

        }
        else
        {
            Console.Clear();
            Console.WriteLine("Error", Color.Red);
            string option2 = Console.ReadLine();
            if (option2 == "back")
            {
                Menu();
            }
        }






    }

    public static void Say(string prefix, string message)
    {
        Console.Write("[");
        Console.Write(prefix, Color.BlueViolet);
        Console.WriteLine("] " + message);
    }



    public static void DrawLogo()
    {
        string logo = @"  __  __                    _    _            _    
 |  \/  |                  | |  | |          | |   
 | \  / | ___  __ _  __ _  | |__| | __ _  ___| | __
 | |\/| |/ _ \/ _` |/ _` | |  __  |/ _` |/ __| |/ /
 | |  | |  __/ (_| | (_| | | |  | | (_| | (__|   < 
 |_|  |_|\___|\__, |\__,_| |_|  |_|\__,_|\___|_|\_\
               __/ |                               
              |___/      
";

        Console.Write(logo, Color.BlueViolet);


    }
}
