using System.Drawing;
using System.Reflection.Metadata;

namespace MethodsExercise
{
    public class Program
    {
        public static void ShortStory()
        {
            Console.WriteLine("What is your name?"); // output 
            string userName = Console.ReadLine(); // input 

            Console.WriteLine("What is your favorite color"); // output
            string color = Console.ReadLine(); //input

            Console.WriteLine("What is your favorite animal?"); //output
            string animal = Console.ReadLine(); // input

            Console.WriteLine("What is your favorite band? "); //output
            string band = Console.ReadLine(); // input


            Console.WriteLine($"There was a girl named {userName}.");
            Console.WriteLine($"{userName}'s favorite color is {color}.");
            Console.WriteLine($"{userName}'s favorite animal is {animal}.");
            Console.WriteLine($"{userName}'s favorite band is {band}.");





        }

        static void Main(string[] args)
        {
            //ShortStory();

            int added = add(2, 4);
            Console.WriteLine(added);

            int subtracted = Subtract(4, 2);
            Console.WriteLine(subtracted);

            int multiply = Program.multiply(2, 10);
            Console.WriteLine(multiply);

            int division = Division(3, 6);
            Console.WriteLine(division);
        }

        public static int add(int numOne, int numTwo)
        {
            return numOne + numTwo;
        }

        public static int Subtract(int numOne, int numTwo)
        {
            return numOne - numTwo;
        }

        public static int multiply(int numOne, int numTwo)
        {
            return numOne * numTwo;
        }

        public static int Division(int numOne, int numTwo)
        {
            return numOne / numTwo;
        }

    }
}
