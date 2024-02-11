using System;
using System.Collections;


namespace DSA;

class BubbleSortRunner
{
    //Following Main method is for running bubble sort

    static void Main1(string[] args)
    {
        Console.WriteLine("Enter size of input array : ");
        int size = int.Parse(Console.ReadLine());

        int[] numbers = new int[size];
        for (int i = 0; i < size; i++)
        {
            Console.WriteLine("Enter array element");
            numbers[i] = int.Parse(Console.ReadLine());
        }

        Console.WriteLine();

        BubbleSort bubbleSort = new BubbleSort(numbers);
        int[] sortedNumbers = bubbleSort.Sort();

        foreach (int element in sortedNumbers)
        {
            Console.WriteLine(element);
        }

    }

}
