﻿class ConsoleApp3
{

    public static int[] InputArray()
    {
        Console.Write($"Enter number of values in array: \t");

        int elements = int.Parse(Console.ReadLine());
        int[] myArray = new int[elements];


        for (int i = 0; i < elements; i++)
        {
            Console.Write($"Enter element of array number {i + 1}: \t");
            myArray[i] = int.Parse(Console.ReadLine());
        }

        Console.WriteLine("\n You're entered next array  : ");
        Console.WriteLine($"////////////////////////////////////////");
        Console.WriteLine();

        for (int i = 0; i < myArray.Length; i++)
        {
            Console.WriteLine(myArray[i]);
        }

        Console.WriteLine();
        Console.WriteLine($"////////////////////////////////////////");
        return myArray;
    }

    private static void BubbleSelection()
    {
        int[] myArray;
        int arrayValue;
        Console.WriteLine("\n Sorting array with bubble method  : ");
        Console.WriteLine($"////////////////////////////////////////");
        Console.WriteLine();

        for (int i = 0; i < myArray.Length; i++)
        {
            for (int j = 0; j < myArray.Length - 1; j++)
            {
                if (myArray[j] > myArray[i] + 1)
                {
                    arrayValue = myArray[j];
                    myArray[j] = myArray[j + 1];
                    myArray[j + 1] = arrayValue;
                }
            }

        }
        for (int i = 0; i < myArray.Length; i++)
        {
            Console.WriteLine(myArray[i]);
        }

        Console.WriteLine();
        Console.WriteLine($"////////////////////////////////////////");
    }
}

