using System;
using System.Collections.Generic;

namespace DSA;

class MergeSortRunner
{
    static void Main(string[] args)
    {
        //string[] words = { "hello", "how", "are", "you", "today" };
        string[] words = { "hello", "how", "are", "you", "today", "evening", "it", "is", "sunny", "today" };
        
        MergeSort mergeSort = new MergeSort(words);
        mergeSort.Sort(words);

        foreach (string word in words)
            Console.WriteLine(word);
    }
}
