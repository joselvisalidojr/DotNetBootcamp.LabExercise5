using System;
using System.Threading;

namespace CSharp.LabExercise5
{
    class Program
    {
        static void Main()
        {
            Console.Title = "Lab Exercise 5 Solutions";

            MainMenu myMainMenu = new();
            myMainMenu.Start();
        }
    }

    internal class Menu
    {
        private int SelectedIndex;
        private string[] Options;
        private string Prompt;

        public Menu(string prompt, string[] options)
        {
            this.Prompt = prompt;
            this.Options = options;
            SelectedIndex = 0;
        }

        private void DisplayOptions()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(Prompt + "\n");
            Console.ResetColor();

            for (int i = 0; i < Options.Length; i++)
            {
                string currentOption = Options[i];
                string prefixL;
                string prefixR;

                if (i == SelectedIndex)
                {
                    prefixL = ">>";
                    prefixR = "<<";
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.BackgroundColor = ConsoleColor.White;
                }
                else
                {
                    prefixL = "  ";
                    prefixR = "  ";
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.BackgroundColor = ConsoleColor.Black;
                }

                Console.WriteLine($"{prefixL}[ {currentOption} ]{prefixR}");
            }

            Console.ResetColor();
        }

        public int Run()
        {
            ConsoleKey keyPressed;
            do
            {
                Console.Clear();
                DisplayOptions();

                ConsoleKeyInfo keyInfo = Console.ReadKey();
                keyPressed = keyInfo.Key;

                if (keyPressed == ConsoleKey.UpArrow)
                {
                    SelectedIndex--;
                    if (SelectedIndex < 0)
                    {
                        SelectedIndex = Options.Length - 1;
                    }
                }
                else if (keyPressed == ConsoleKey.DownArrow)
                {
                    SelectedIndex++;
                    if (SelectedIndex == Options.Length)
                    {
                        SelectedIndex = 0;
                    }
                }
            } while (keyPressed != ConsoleKey.Enter);

            return SelectedIndex;
        }

    }

    internal class MainMenu
    {
        public void Start()
        {
            RunMainMenu();
            Console.ReadLine();
        }
        private static void RunMainMenu()
        {
            string prompt = @"

██╗      █████╗ ██████╗                                                
██║     ██╔══██╗██╔══██╗                                               
██║     ███████║██████╔╝                                               
██║     ██╔══██║██╔══██╗                                               
███████╗██║  ██║██████╔╝                                               
╚══════╝╚═╝  ╚═╝╚═════╝                                                
                                                                       
███████╗██╗  ██╗███████╗██████╗  ██████╗██╗███████╗███████╗    ███████╗
██╔════╝╚██╗██╔╝██╔════╝██╔══██╗██╔════╝██║██╔════╝██╔════╝    ██╔════╝
█████╗   ╚███╔╝ █████╗  ██████╔╝██║     ██║███████╗█████╗      ███████╗
██╔══╝   ██╔██╗ ██╔══╝  ██╔══██╗██║     ██║╚════██║██╔══╝      ╚════██║
███████╗██╔╝ ██╗███████╗██║  ██║╚██████╗██║███████║███████╗    ███████║
╚══════╝╚═╝  ╚═╝╚══════╝╚═╝  ╚═╝ ╚═════╝╚═╝╚══════╝╚══════╝    ╚══════╝                                                            
 ____  _  _    ____  ____ __  __          __  ____ ____  __  __                              
 || )) \\//      // ||    ||\ ||          || ||    || \\ ||  ||                              
 ||=)   )/      //  ||==  ||\\||          || ||==  ||_// ||==||                              
 ||_)) //      //__ ||___ || \|| //    |__|| ||___ ||    ||  || //                           
                                                                                             
   ___   ___  ____           __  ___  ____          ___  __  __ ____         __   ___    ____
  // \\ // \\ || ))          || // \\ || \\        // \\ ||\ || || \\        ||  // \\  ||   
 (( ___ ||=|| ||=)           || ||=|| ||  ))       ||=|| ||\\|| ||  ))       || ((   )) ||== 
  \\_|| || || ||_)) //    |__|| || || ||_//  //    || || || \|| ||_//     |__||  \\_//  ||___
    
Use UP or DOWN ARROW key to toggle. Press Enter to select a menu...";

            string[] options = {
                "List Person Names",
                "Person Student Teacher",
                "Student Teacher Override",
                "Drive a Vehicle",
                "Pet an Animal",
                "Exit" };
            Menu mainMenu = new(prompt, options);
            int selectedIndex = mainMenu.Run();

            switch (selectedIndex)
            {
                case 0:
                    ListPersonName();
                    break;
                case 1:
                    PersonStudentTeacher();
                    break;
                case 2:
                    StudentTeacherOverride();
                    break;
                case 3:
                    DriveVehicle();
                    break;
                case 4:
                    FeedDog();
                    break;
                case 5:
                    ExitProgram();
                    break;
            }
        }

        private static void ExitProgram()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(@"

 ██████╗  ██████╗  ██████╗ ██████╗ ██████╗ ██╗   ██╗███████╗██╗
██╔════╝ ██╔═══██╗██╔═══██╗██╔══██╗██╔══██╗╚██╗ ██╔╝██╔════╝██║
██║  ███╗██║   ██║██║   ██║██║  ██║██████╔╝ ╚████╔╝ █████╗  ██║
██║   ██║██║   ██║██║   ██║██║  ██║██╔══██╗  ╚██╔╝  ██╔══╝  ╚═╝
╚██████╔╝╚██████╔╝╚██████╔╝██████╔╝██████╔╝   ██║   ███████╗██╗
 ╚═════╝  ╚═════╝  ╚═════╝ ╚═════╝ ╚═════╝    ╚═╝   ╚══════╝╚═╝
");
            Thread.Sleep(900);
            Environment.Exit(0);
        }

        private static void ListPersonName()
        {
            Solution1.ListPersonNames _ = new();
        }
        private static void PersonStudentTeacher()
        {
            Solution2.PersonStudentTeacher _ = new();
        }
        private static void StudentTeacherOverride()
        {
            Solution3.StudentTeacherOverride _ = new();
        }
        private static void DriveVehicle()
        {
            Solution4.DriveVehicle driveVehicle = new();
            driveVehicle.Start();
        }
        private static void FeedDog()
        {
            Solution5.FeedDog _ = new();
        }
    }
}
