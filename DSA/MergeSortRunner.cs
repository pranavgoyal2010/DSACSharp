using System;
using System.Collections.Generic;

namespace DSA;

class MergeSortRunner
{
    static void Main(string[] args)
    {
        //string[] words = { "hello", "how", "are", "you", "today" };
        string[] words = { "hello", "how", "are", "you", "today", "evening", "it", "is", "sunny", "today" };
        int[] numbers = { 2, 4, 1, 3, 5 };
        //MergeSort mergeSort = new MergeSort(words);
        //mergeSort.Sort();

        MergeSortGeneric<string> mergeSortGeneric1 = new MergeSortGeneric<string>(words);
        mergeSortGeneric1.Sort();
        MergeSortGeneric<int> mergeSortGeneric2 = new MergeSortGeneric<int>(numbers);
        mergeSortGeneric2.Sort();
        MergeSortGeneric<>


        foreach (string word in words)
            Console.WriteLine(word);
        foreach (int num in numbers)
            Console.WriteLine(num);
    }
}
