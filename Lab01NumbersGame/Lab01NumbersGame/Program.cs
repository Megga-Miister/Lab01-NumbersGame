using System;

namespace Lab01NumbersGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to my game! Let's do some math!");

            try
            {
                //StartSequence();
            }
            catch (Exception ge)
            {
                Console.WriteLine("It looks like you have run into an issue: " + ge.Message);
            }
            finally
            {
                Console.WriteLine("Program is complete.");
            }
        }

        static void StartSequence()
        {
            Console.WriteLine("Enter a number greater than zero");
            string givenString = Console.ReadLine();
            int givenNumber = Convert.ToInt32(givenString);

            int[] userArray = new int[givenNumber];

            try
            {
                //Populate(userArray);
                //GetQuotient(GetProduct(userArray, GetSum(userArray)));
            }
            catch (FormatException fe)
            {
                Console.WriteLine(fe.Message);
            }
            catch (OverflowException oe)
            {
                Console.WriteLine(oe.Message);
            }
        }
    }
}
