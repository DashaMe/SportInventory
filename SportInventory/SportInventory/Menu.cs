using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportInventory
{
    class Menu
    {
        RentInventory inventory;

        public Menu()
        {
            inventory = new RentInventory();
        }

        public void MainMenu()
        {
            Console.Clear();

            StringBuilder mainMenu = new StringBuilder();
            mainMenu.AppendLine("---Main Menu---");
            mainMenu.AppendLine("1 - See all inventory");
            mainMenu.AppendLine("2 - Add a Hard inventory");
            mainMenu.AppendLine("3 - Add a Light inventory");
            mainMenu.AppendLine("4 - Exit");
            Console.WriteLine(mainMenu);
            Console.WriteLine("Please, make your choice");
            string choice = Console.ReadLine();
            switch (choice)
            {
                case "1": inventory.ViewAllInvent(); MainMenu(); break;
                case "2": HardInvMenu(); break;
                case "3": LightInvMenu(); break;
                case "4": Environment.Exit(0); break;
                default: break;
            }
        }

        void HardInvMenu()
        {
            Console.Clear();

            StringBuilder hardMenu = new StringBuilder();
            hardMenu.AppendLine("---Hard Inventory Menu---");
            hardMenu.AppendLine("1 - Add a dumbbell");
            hardMenu.AppendLine("2 - Add an apparat");
            hardMenu.AppendLine("3 - Back to main menu");
            Console.WriteLine(hardMenu);
            Console.WriteLine("\nPlease, make your choice");
            string choice = Console.ReadLine();
            switch (choice)
            {
                case "1": inventory.DumbbellCreation(); HardInvMenu(); break;
                case "2": inventory.ApparatCreation(); HardInvMenu(); break;
                case "3": MainMenu(); break;
                default: break;

            }
        }

        void LightInvMenu()
        {
            Console.Clear();

            StringBuilder lightMenu = new StringBuilder();
            lightMenu.AppendLine("---Light Inventory Menu---");
            lightMenu.AppendLine("1 - Add a fitball");
            lightMenu.AppendLine("2 - Add a rubber");
            lightMenu.AppendLine("3 - Back to the main menu");
            Console.WriteLine(lightMenu);
            Console.WriteLine("\nPlease, make your choice");
            string choice = Console.ReadLine();
            switch (choice)
            {
                case "1": inventory.FitBallCreation(); LightInvMenu(); break;
                case "2": inventory.RubberCreation(); LightInvMenu(); break;
                case "3": MainMenu(); break;
                default: break;
            }
        }


    }
}
