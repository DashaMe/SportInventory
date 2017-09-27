using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportInventory
{
    class RentInventory
    {
        AllInventory[] rentList = new AllInventory[0];

        public void AddInventory(AllInventory obj)
        {
            AllInventory[] rentListPlus = new AllInventory[rentList.Length + 1];
            for (int i = 0; i < rentList.Length; i++)
            {

                rentListPlus[i] = rentList[i];
            }

            rentListPlus[rentList.Length] = obj;

            rentList = rentListPlus;
        }

        public void FitBallCreation()
        {
            Console.Clear();
            try
            {
                Console.WriteLine("Enter fitball name");
                string name = Console.ReadLine();

                Console.WriteLine("\nEnter fitball rent price");
                float rentPrice = float.Parse(Console.ReadLine());

                Console.WriteLine("\nEnter fitball weight");
                double weight = double.Parse(Console.ReadLine());

                Console.WriteLine("\nEnter fitball diameter");
                float diameter = float.Parse(Console.ReadLine());

                Console.WriteLine("\nEnter fitball elasticity level");
                int elasticity = int.Parse(Console.ReadLine());

                AddInventory(new FitBalls(name, rentPrice, weight, diameter, elasticity));
                Console.Clear();
                Console.WriteLine("\nNew fitball successfully added.\n\nPlease, press any key to return to the menu.");
                Console.ReadKey();
            }
            catch (Exception)
            {
                Console.Clear();
                Console.WriteLine("\nIncorrect input detected.\n\nPress any key to return to the menu and try again");
                Console.ReadKey();
            }
        }

        public void RubberCreation()
        {
            Console.Clear();
            try
            {
                Console.WriteLine("Enter rubber's name");
                string name = Console.ReadLine();

                Console.WriteLine("\nEnter rubber's rent price");
                float rentPrice = float.Parse(Console.ReadLine());

                Console.WriteLine("\nEnter rubber's weight");
                double weight = double.Parse(Console.ReadLine());

                Console.WriteLine("\nEnter rubber's width");
                int width = int.Parse(Console.ReadLine());

                Console.WriteLine("\nEnter rubber's hardness level");
                int hardness = int.Parse(Console.ReadLine());

                Console.WriteLine("\nEnter rubber's color");
                string color = Console.ReadLine();

                AddInventory(new Rubbers(name, rentPrice, weight, width, hardness, color));
                Console.Clear();
                Console.WriteLine("\nNew rubber successfully added.\n\nPlease, press any key to return to the menu.");
                Console.ReadKey();
            }
            catch (Exception)
            {
                Console.Clear();
                Console.WriteLine("\nIncorrect input detected.\n\nPress any key to return to the menu and try again");
                Console.ReadKey();
            }
        }

        public void DumbbellCreation()
        {
            Console.Clear();
            try
            {
                Console.WriteLine("Enter dumbbell's name");
                string name = Console.ReadLine();

                Console.WriteLine("\nEnter dumbbell's rent price");
                float rentPrice = float.Parse(Console.ReadLine());

                Console.WriteLine("\nEnter dumbbell's professional level");
                string level = Console.ReadLine();

                Console.WriteLine("\nEnter dumbbell's material");
                string material = Console.ReadLine();

                Console.WriteLine("\nEnter dumbbell's weight");
                int weight = int.Parse(Console.ReadLine());

                AddInventory(new Dumbbells(name, rentPrice, level, material, weight));
                Console.Clear();
                Console.WriteLine("\nNew dumbbell successfully added.\n\nPlease, press any key to return to the menu.");
                Console.ReadKey();
            }
            catch (Exception)
            {
                Console.Clear();
                Console.WriteLine("\nIncorrect input detected.\n\nPress any key to return to the menu and try again");
                Console.ReadKey();
            }
        }

        public void ApparatCreation()
        {
            Console.Clear();
            try
            {
                Console.WriteLine("Enter apparat's name");
                string name = Console.ReadLine();

                Console.WriteLine("\nEnter apparat's rent price");
                float rentPrice = float.Parse(Console.ReadLine());

                Console.WriteLine("\nEnter apparat's professional level");
                string level = Console.ReadLine();

                Console.WriteLine("\nEnter apparat's producer");
                string producer = Console.ReadLine();

                Console.WriteLine("\nEnter apparat's muscles category");
                string category = Console.ReadLine();

                AddInventory(new Apparatus(name, rentPrice, level, producer, category));
                Console.Clear();
                Console.WriteLine("\nNew apparat successfully added.\n\nPlease, press any key to return to the menu.");
                Console.ReadKey();
            }
            catch (Exception)
            {
                Console.Clear();
                Console.WriteLine("\nIncorrect input detected.\n\nPress any key to return to the menu and try again");
                Console.ReadKey();
            }
        }

        public void ViewAllInvent()
        {
            Console.Clear();

            if (rentList.Length == 0)
            {
                Console.WriteLine("There are no rent inventory available at the moment");
            }
            else
            {
                foreach (AllInventory item in rentList)
                {
                    Console.WriteLine(item.AllInventInfo());
                }
            }
  
            Console.WriteLine("\nPress any key to return to the main menu");
            Console.ReadKey();
        }
    }
}
