using System;

namespace AbstractFactory 
{
    class Program 
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Galaxy Store!");
            Console.WriteLine("Please choose a brand: 1. Apple 2. Samsung");
            int choice = int.Parse(Console.ReadLine());

            IGadgetFactory factory = null;

            switch (choice) 
            {
                case 1:
                    factory = new AppleFactory();
                    break;
                case 2:
                    factory = new SamsungFactory();
                    break;
                default:
                    Console.WriteLine("Invalid choice");
                    return;
            }

            GalaxayStore store = new GalaxayStore(factory);
            store.DisplayGadgets();
        }
    }
}
