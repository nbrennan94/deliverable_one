using System;

public class Program
{
    public static void Main(string[]args)
    {

        string input;
        bool valid = false;

        while (!valid)
        {
            Console.WriteLine("How many people are we making PB&J sandwiches for?");
            int people = int.Parse(Console.ReadLine());

            int slices = people * 2;
            int pb = people * 2;
            int jelly = people * 4;

            Console.WriteLine("\nYou need:\n" + slices + " slices of bread\n" + pb + " tablespoons of peanut butter\n" + jelly + " teaspoons of jelly");

            int loaves = (int)Math.Ceiling((double)slices / 28);
            int pbj = (int)Math.Ceiling((double)pb / 32);
            int jj = (int)Math.Ceiling((double)jelly / 48);

            Console.WriteLine("\nWhich is:\n" + loaves + " loaves of bread\n" + pbj + " jars of peanut butter\n" + jj + " jars of jelly");

            Console.WriteLine("\nWould you like to restart? Please enter yes or y to continue, or enter any other key to exit.");
            input = Console.ReadLine();
            if (input == "yes")
            {
                Console.WriteLine("\nOk.\n");
            }
            else if (input == "y")
            {
                Console.WriteLine("\nOk.\n");
            }
            else
            {
                Console.WriteLine("\nGoodbye!\n");
                break;
            }
        } 
    }
}

