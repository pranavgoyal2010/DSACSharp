using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA;

class Runner
{
    //Following Main method is for running bubble sort

    /*static void Main(string[] args)
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

    }*/

    static void Main(string[] args)
    {
        string filePath = "words.txt";

        ArrayList words = new ArrayList();

        using (StreamReader sr = new StreamReader(filePath))
        {
            string word;

            while ((word = sr.ReadLine()) != null)
            {
                words.Add(word);
            }
        }
        
        Console.WriteLine("Words stored in ArrayList");
        for (int i = 0; i < words.Count; i++)
        {
            Console.WriteLine((string)words[i]);
        }

        Console.WriteLine();

        BinarySearch binarySearch = new BinarySearch(words);

        Console.WriteLine("Enter word to search");

        string target = Console.ReadLine();

        int index = binarySearch.Search(target);
        Console.WriteLine();
        if(index == -1)
        {
            Console.WriteLine("String not found");
        }
        else
        {
            Console.WriteLine("String found at index : " + index);
        }
    }
}
