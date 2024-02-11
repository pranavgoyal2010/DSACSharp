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

        //InsertionSort insertionSort = new InsertionSort(words);
        //insertionSort.Sort();

        InsertionSortGeneric<string> insertionSortGeneric1 = new InsertionSortGeneric<string>(words); 
        insertionSortGeneric1.Sort();

        foreach(string word in words)
            Console.WriteLine(word);


        Student s1 = new Student { Sid = 103, Name = "Ajay", Class = 10, Marks = 575.00f };
        Student s2 = new Student { Sid = 106, Name = "stuart", Class = 10, Marks = 535.00f };
        Student s3 = new Student { Sid = 104, Name = "Williams", Class = 10, Marks = 592.00f };
        Student s4 = new Student { Sid = 102, Name = "venkat", Class = 10, Marks = 453.00f };
        Student s5 = new Student { Sid = 101, Name = "david", Class = 10, Marks = 512.00f };
        Student s6 = new Student { Sid = 105, Name = "John", Class = 10, Marks = 498.00f };


        Student[] Students = { s1, s2, s3, s4, s5, s6 };

        InsertionSortGeneric<Student> insertionSortGeneric2 = new InsertionSortGeneric<Student>(Students);
        insertionSortGeneric2.Sort();

        foreach (Student S in Students)
        {
            Console.WriteLine(S.Sid + " " + S.Name + " " + S.Class + " " + S.Marks);
        }
    }
}
