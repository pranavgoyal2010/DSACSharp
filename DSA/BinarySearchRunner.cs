using System;
using System.Collections.Generic;

namespace DSA;

class BinarySearchRunner
{
    static void Main(string[] args)
    {
        string filePath = "words.txt";

        string lines = File.ReadAllText(filePath);
        string[] words = lines.Split(",");


        Console.WriteLine("Words stored in Array");
        for (int i = 0; i < words.Length; i++)
        {
            Console.WriteLine(words[i]);
        }

        Console.WriteLine();

        BinarySearch binarySearch = new BinarySearch(words);

        Console.WriteLine("Enter word to search");

        string target = Console.ReadLine();

        int index = binarySearch.Search(target);
        Console.WriteLine();
        if (index == -1)
        {
            Console.WriteLine("String not found");
        }
        else
        {
            Console.WriteLine("String found at index : " + index);
        }
    }
}
