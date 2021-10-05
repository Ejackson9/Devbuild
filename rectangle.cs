using System;

namespace ConsoleApp2
{
    class Program
    {
        public static object DisplayResults { get; private set; }

        static void Main(string[] args)
        {
            //0) ask the user for the radius of a circle 
            //1) get user input (always comes in as a string) 
            //2) Convert the input into a double
            //3) run the formula and store the result 
            //4) print result to the console
            Console.WriteLine(Math.Pow(10, 5));
            Console.WriteLine("Welcome to the circle app");
            Console.WriteLine("Please input a radius");
            Console.WriteLine();
            string input = Console.ReadLine();
            dou

            area = ComputeArea(height, width);
            perimiter = ComputePerimeter(height, width);
            object p = DisplayResults(height, width, area, perimiter);
            Console.ReadKey;
            

        }

        private static double ComputePerimeter(double height, double width)
        {
            throw new NotImplementedException();ble radius = double.Parse(input);
            double result = Math.PI * radius * radius;




            double height, width, area, perimiter;
            height = GetSize("Height");
            width = GetSize("Width");
        }

        private static double ComputeArea(double height, double width)
        {
            throw new NotImplementedException();
        }

        public static double GetSize (string whichONE)
        {
            throw new NotImplementedException();
        }
    }
}
