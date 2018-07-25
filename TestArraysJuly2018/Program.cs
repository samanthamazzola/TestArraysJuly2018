using System;

namespace TestArraysJuly2018
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            // create arrays

            int numberOfStudents = 5;

            // create an arracy that has 15 elements that are all initialized to 0s (so you don't need to put a 0 in each on. think boxes)
            // int x = 10; int[] ages = new int [15];  fifteen would be a fixed number but it can also be a variable!
            // can do this where it can be a variable(numOfStudents)..... int numOfStudents = 15; int[] ages = new int [numOfStudents]; 
            int[] ages = new int[numberOfStudents];




            // initialize an array
            // for loop to go through the array to go to get the values of the ages
            int sum = 0; // sum variable equal to 0
            for (int i = 0; i < ages.Length; i++) // .Length will give you how many elements... which would be 15
            {
                Console.WriteLine("Please enter your age:");
                ages[i] = int.Parse(Console.ReadLine());
                // array name ages, then to access use the [], i always refers to the index (or the number of the cell so you can get the "info" inside the cell)
                // looking for elements you need the array name and square brackets.... so ages [i]
                sum = sum + ages[i]; //finds the number from each index in the array
            }

            Console.WriteLine($"Average = {sum / ages.Length}");

            // find the max in the array (need to scan the whole thing to see if you have the max element)
            // go through each and see if the next one is larger than the one you have, if so keep going and comparing til max
            int max = ages[0]; //assume max is the first element [0] 
            for (int i = 0; i < ages.Length; i++)
            {
                if (ages[i] > max) // comparing the apple with the next one, to see if the new one is bigger. //compare the next element to the max
                {
                    max = ages[i]; // so max will now be equal to the age of i <-- i will be whatever is bigger
                }
            } 
     
            // creates an array (for interest rates) and fills it with elements (initializes)
            // double[] interestRates = { 12.3, 16.7, 20.1 };
                //OR
            // double[] interestRates = new double { 12.3, 16.7, 20.1 };
        
        


            // access array elements

        }
    }
}
