using System;

namespace ExponentLabRemake
{
    class Program
    {
        static void Main(string[] args)
        {

            bool goOn = true;
            while (goOn)
            {
            //1.  Get user Input: 
                 int result = Convert.ToInt32(GetInput("Enter an Integer"));

           

            //2. Check for validation:
                if (result < 0)
                {
                    Console.WriteLine("Invalid please try again!");
                } else
                {
                    //3. For Loop insterted:

                    Console.WriteLine("\nNumber\t\tSquared\t\tCubed");
                    Console.WriteLine("=======\t\t=======\t\t=======");

                    for (int i =1; i <= result; i++)
                {
                    int squareNumber = GetSquare(i);
                    int cubeNumber = GetCube(i); 
                    Console.WriteLine(i + "\t\t"+ squareNumber + "\t\t" + cubeNumber);


                    }


                }
                

                //3 Continuation Recursion: 

                goOn = Continue(); 


            }


        }

        public static string GetInput(string prompt)
        {
            Console.WriteLine(prompt);
            string output = Console.ReadLine();

            return output; 
        }

        public static bool Continue()
        {
            string answer = GetInput("Would you like to continue? y/n");
            if (answer == "y")
            {
                return true; 
            } else if (answer == "n")
            {
                Console.WriteLine("Goodbye!");
                return false; 
            } else
            {
                Console.WriteLine("I'm sorry I didn't understand");
                Console.WriteLine("Let's try again.");

                // This is recursion, calling a method inside itself
                return Continue();
            }
        }

        public static int GetSquare(int square)
        {

            int number = square * square;
            return number; 
            
        }

        public static int GetCube(int cube)
        {
            int number1 = cube * cube * cube;
            return number1; 
        }

    }
}
