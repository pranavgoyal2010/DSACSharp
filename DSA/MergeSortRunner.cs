using System;
using System.Collections.Generic;

namespace DSA;

class MergeSortRunner
{
    static void Main1(string[] args)
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
       


        foreach (string word in words)
            Console.WriteLine(word);
        foreach (int num in numbers)
            Console.WriteLine(num);




        Student s1 = new Student { Sid = 103, Name = "Ajay", Class = 10, Marks = 575.00f };
        Student s2 = new Student { Sid = 106, Name = "stuart", Class = 10, Marks = 535.00f };
        Student s3 = new Student { Sid = 104, Name = "Williams", Class = 10, Marks = 592.00f };
        Student s4 = new Student { Sid = 102, Name = "venkat", Class = 10, Marks = 453.00f };
        Student s5 = new Student { Sid = 101, Name = "david", Class = 10, Marks = 512.00f };
        Student s6 = new Student { Sid = 105, Name = "John", Class = 10, Marks = 498.00f };


        Student[] Students =  { s1, s2, s3, s4, s5, s6 };

        MergeSortGeneric<Student> mergeSortGeneric3 = new MergeSortGeneric<Student>(Students);
        mergeSortGeneric3.Sort();

        foreach (Student S in Students)
        {
            Console.WriteLine(S.Sid + " " + S.Name + " " + S.Class + " " + S.Marks);
        }
    }
}
