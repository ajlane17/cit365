using System;
using System.Globalization;

namespace ConsoleApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            // Req 2: Store two variables: name, location
            string name = "Adrian";
            string location = "Idaho";

            // Req 3: Output the two variables to the console
            Console.WriteLine("My name is " + name + ", I am from " + location + ".");

            // Req 4: Output current date with no time
            DateTime dtNow = DateTime.UtcNow;
            Console.WriteLine("\nCurrent date: " + dtNow.ToString("MM/dd/yyyy"));

            // Req 5: Days until Christmas
            int year;
            year = (dtNow.Month == 12 && dtNow.Day > 24) ? DateTime.UtcNow.Year + 1 : DateTime.UtcNow.Year;
            DateTime nextChristmas = new DateTime(year, 12, 25);
            int daysToNextChristmas = nextChristmas.DayOfYear - dtNow.DayOfYear;
            Console.WriteLine("Days until next Christmas: " + daysToNextChristmas);

            // Req 6: Book 2.1 Example
            double width, height, woodLength, glassArea;
            string widthString, heightString;

            Console.WriteLine("\nWindow Glazer Calculator");
            Console.Write("\nPlease enter the width in feet: ");
            widthString = Console.ReadLine();
            width = double.Parse(widthString);

            Console.Write("Please enter the height in feet: ");
            heightString = Console.ReadLine();
            height = double.Parse(heightString);

            woodLength = 2 * (width + height) * 3.25;
            glassArea = 2 * (width * height);

            Console.WriteLine("\nThe length of the wood is " 
                + woodLength.ToString("N", new CultureInfo("en-US")) + " feet");
            Console.WriteLine("The area of the glass is " 
                + glassArea.ToString("N", new CultureInfo("en-US")) + " square meters");

            // Req 7: Pause to prevent termination
            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }
    }
}
