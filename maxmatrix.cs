using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task22
{
    internal class Program
    {


        class Program1
        {
            static void Main()
            {
                int[,] matrix = new int[3, 3];

                Console.WriteLine("Enter the values for the 3x3 array:");

                // Read user input for each element of the array
                for (int i = 0; i < 3; i++)
                {
                    for (int j = 0; j < 3; j++)
                    {
                        Console.Write($"Enter value for element [{i},{j}]: ");
                        int input = Convert.ToInt32(Console.ReadLine());
                        matrix[i, j] = input;
                    }
                }

                // Find the maximum number in the array
                int maxNumber = matrix[0, 0];
                for (int i = 0; i < 3; i++)
                {
                    for (int j = 0; j < 3; j++)
                    {
                        if (matrix[i, j] > maxNumber)
                        {
                            maxNumber = matrix[i, j];
                        }
                    }
                }
                for 

                Console.WriteLine("The maximum number in the array is: " + maxNumber);
            }
        }

    }
}






