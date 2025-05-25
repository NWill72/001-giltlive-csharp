// See https://aka.ms/new-console-template for more information

using System;

namespace OhmsLaw
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("===============================");
            Console.WriteLine("A BASIC OHMS LAW CALCULATOR");
            Console.WriteLine("===============================");
            Console.WriteLine("SELECT CHOICE FROM MENU ITEMS");
            Console.WriteLine("1. CALCULATE VOLTAGE");
            Console.WriteLine("2. CALCULATE CURRENT");
            Console.WriteLine("3. CALCULATE RESISTANCE");
            Console.WriteLine("===============================");
            Console.WriteLine();
            Console.WriteLine("Press ESC to stop");

            char select;
            do
            {
                select = Console.ReadKey(true).KeyChar; // Read key without displaying it
                Console.WriteLine(); // Ensures a newline for better readability
                MenuSelect(select);
            }
            while (select != (char)ConsoleKey.Escape); // Exit when Escape key is pressed

            Console.WriteLine();
            Console.WriteLine("Escape Key Pressed ... !!!");
            Console.WriteLine("Exiting Application ... !!!");
            Console.WriteLine("Goodbye ... !!!");
        }

        static void MenuSelect(char selection)
        {
            // double volts = 0, amps = 0, resistance = 0;
            switch (selection)
            {
                case '1': // Calculate Voltage
                {
                        Console.WriteLine("CALCULATE VOLTAGE");
                        Console.Write("Enter The Current Value in Amps: ");
                        if (!double.TryParse(Console.ReadLine(), out double amps) || amps < 0)
                        {
                            Console.WriteLine("Invalid input! Please enter a valid positive number.");
                            return;
                        }

                        Console.Write("Enter The Resistance Value in Ohms: ");
                        if (!double.TryParse(Console.ReadLine(), out double ohms) || ohms < 0)
                        {
                            Console.WriteLine("Invalid input! Please enter a valid positive number.");
                            return;
                        }

                        Console.WriteLine($"The Voltage is: {amps * ohms} Volts.");
                        break;
                }

                case '2': // Calculate Current
                    {
                        Console.WriteLine("CALCULATE CURRENT");
                        Console.Write("Enter The Voltage Value in Volts: ");
                        if (!double.TryParse(Console.ReadLine(), out double volts) || volts < 0)
                        {
                            Console.WriteLine("Invalid input! Please enter a valid positive number.");
                            return;
                        }

                        Console.Write("Enter The Resistance Value in Ohms: ");
                        if (!double.TryParse(Console.ReadLine(), out double ohms) || ohms <= 0)
                        {
                            Console.WriteLine("Invalid input! Resistance should be greater than zero.");
                            return;
                        }

                        Console.WriteLine($"The Current is: {volts / ohms} Amps.");
                        break;
                 }

                case '3': // Calculate Resistance
                    {
                        Console.WriteLine("CALCULATE RESISTANCE");
                        Console.Write("Enter The Voltage Value in Volts: ");
                        if (!double.TryParse(Console.ReadLine(), out double volts) || volts < 0)
                        {
                            Console.WriteLine("Invalid input! Please enter a valid positive number.");
                            return;
                        }

                        Console.Write("Enter The Current Value in Amps: ");
                        if (!double.TryParse(Console.ReadLine(), out double amps) || amps <= 0)
                        {
                            Console.WriteLine("Invalid input! Current should be greater than zero.");
                            return;
                        }

                        Console.WriteLine($"The Resistance is: {volts / amps} Ohms.");
                        break;
                }

                default:
                {
                        // Console.WriteLine("Invalid Selection! Try Again.");
                        break;
                }
            }
        }
    }
}


/*
using System;

namespace OhmsLaw
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(@"===============================");
            Console.WriteLine(@"A BASIC OHMS LAW CALCULATOR");
            Console.WriteLine(@"===============================");
            Console.WriteLine(@"SELECT CHOICE FROM MENU ITEMS");
            Console.WriteLine(@"1. CALCULATE VOLTAGE");
            Console.WriteLine(@"2. CALCULATE CURRENT");
            Console.WriteLine(@"3. CALCULATE RESISTANCE");
            Console.WriteLine(@"===============================");
            Console.WriteLine(@"");
            Console.WriteLine(@"Press ESC to stop");

  
            char select;

            do
            {
                select = Console.ReadKey(true).KeyChar; // Read key without displaying it
                Console.WriteLine(); // Ensures a newline for better readability
                MenuSelect(select);
            }
            while (select != (char)ConsoleKey.Escape); // Exit when Escape key is pressed

            Console.WriteLine(@"");
            Console.WriteLine(@"Escape Key Pressed ... !!!");
            Console.WriteLine(@"Exiting Application ... !!!");
            Console.WriteLine(@"Goodbye ... !!!");
        }
        static void MenuSelect(char selection)
        {
            switch (selection)
            {
                case '1':
                    {
                        Console.Write($"Enter The Current Value in Amps: ");
                        bool ampsValid = int.TryParse(Console.ReadLine(), out int amps);
                        Console.Write($"Enter The Resistance Value in Ohms: ");
                        bool ohmsValid = int.TryParse(Console.ReadLine(), out int ohms);
                        Console.WriteLine($"");
                        Console.WriteLine($@"The Voltage is : {amps * ohms} Volts.");
                        break;
                    }

                case '2':
                    {
                        Console.Write($"Enter The Voltage Value in Volts: ");
                        bool voltsValid = int.TryParse(Console.ReadLine(), out int volts);
                        Console.Write($"Enter The Resistance Value in Ohms: ");
                        bool ohmsValid = int.TryParse(Console.ReadLine(), out int ohms);
                        Console.WriteLine(@"");
                        Console.WriteLine($@"The Current is : {volts / ohms} Amps.");
                        break;
                    }

                case '3':
                    {
                        Console.Write($"Enter The Voltage Value in Volts: ");
                        bool voltsValid = int.TryParse(Console.ReadLine(), out int volts);
                        Console.Write($"Enter The Current Value in Amps: ");
                        bool ampsValid = int.TryParse(Console.ReadLine(), out int amps);
                        Console.WriteLine(@"");
                        Console.WriteLine($@"The Resistance is : {volts / amps} Volts.");
                        break;
                    }

                default:
                    {
                        // Console.WriteLine($"Invalid Selection Try Again !!!");
                        break;
                    }


            }
        }
    }
}
*/

/*
Console.WriteLine("Press ESC to stop");
do {
    while (!Console.KeyAvailable) 
    {
        selection = Console.ReadKey();
        Console.WriteLine(@"");
        MenuSelect(selection);
    }
} while (Console.ReadKey(true).Key != ConsoleKey.Escape);

void MenuSelect(char selection)
{
    switch (selection)
    {
        case = '1':
            Console.WriteLine($"Enter The Current Value in Amps: ");
            amps = Read();
            Console.WriteLine($"Enter The Resistance Value in Ohms: ");
            ohms = Read();
            Console.WriteLine($"The Voltage is : {amps * ohms} Volts.");
            break;

        case = '2':
            Console.WriteLine($"Enter The Voltage Value in Volts: ");
            volts = Read();
            Console.WriteLine($"Enter The Resistance Value in Ohms: ");
            ohms = Read();
            Console.WriteLine($"The Current is : { volts / ohms} Amps.");
            break;

        case = '3':
            Console.WriteLine($"Enter The Voltage Value in Volts: ");
            volts = Read();
            Console.WriteLine($"Enter The Current Value in Amps: ");
            amps = Read();
            Console.WriteLine($"The Voltage is : {volts / amps} Volts.");
            break;

        default:
            Console.WriteLine($"Invalid Selection Try Again !!!");
            break;
    }
}
*/