using System;
using System.Collections.Generic;


namespace DSA;

class InsertionSortRunner
{
    static void Main(string[] args)
    {
        //string[] words = {"hello", "how", "are", "you", "today", "evening", "it", "is", "sunny", "today"};

        Console.WriteLine("Enter size of input array : ");
        int size = int.Parse(Console.ReadLine());

        string[] words = new string[size];
        for (int i = 0; i < size; i++)
        {
            Console.WriteLine("Enter array element");
            words[i] = Console.ReadLine();
        }

        Console.WriteLine();

        InsertionSort insertionSort = new InsertionSort(words);
        insertionSort.Sort();

        foreach(string word in words)
            Console.WriteLine(word);
    }
}
