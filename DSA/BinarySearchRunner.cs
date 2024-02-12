using System;
using System.Collections;
using System.Collections.Generic;

namespace DSA;

class BinarySearchRunner
{
    static void Main1(string[] args)
    {
        /*string filePath = "words.txt";

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
        }*/

        List<string> strings = new List<string>();
        strings.Add("Good");
        strings.Add("Morning");
        strings.Add("today");
        strings.Add("is");
        strings.Add("Monday");
        strings.Add("how");
        strings.Add("are");
        strings.Add("you");

        BinarySearchGeneric<string> binarySearchGeneric1 = new BinarySearchGeneric<string>(strings);
        int index = binarySearchGeneric1.Search("is");

        Console.WriteLine("Words in sorted order");
        for (int i = 0; i < strings.Count; i++)
        {
            Console.WriteLine(strings[i]);
        }


        if (index == -1)
            Console.WriteLine("string not found");
        else
            Console.WriteLine("string found at index : " + index);


        List<char> chars = new List<char>();
        chars.Add('N');
        chars.Add('z');
        chars.Add('a');
        chars.Add('h');
        chars.Add('P');

        BinarySearchGeneric<char> binarySearchGeneric2 = new BinarySearchGeneric<char>(chars);
        index = binarySearchGeneric2.Search('P');

        Console.WriteLine("Chars in sorted order");
        for (int i = 0; i < chars.Count; i++)
        {
            Console.WriteLine(chars[i]);
        }


        if (index == -1)
            Console.WriteLine("char not found");
        else
            Console.WriteLine("char found at index : " + index);



        Student s1 = new Student { Sid = 103, Name = "Ajay", Class = 10, Marks = 575.00f };
        Student s2 = new Student { Sid = 106, Name = "stuart", Class = 10, Marks = 535.00f };
        Student s3 = new Student { Sid = 104, Name = "Williams", Class = 10, Marks = 592.00f };
        Student s4 = new Student { Sid = 102, Name = "venkat", Class = 10, Marks = 453.00f };
        Student s5 = new Student { Sid = 101, Name = "david", Class = 10, Marks = 512.00f };
        Student s6 = new Student { Sid = 105, Name = "John", Class = 10, Marks = 498.00f };


        List<Student> Students = new List<Student> { s1, s2, s3, s4, s5, s6 };

        //BinarySearchGeneric<Student> binarySearchGeneric3 = new BinarySearchGeneric<Student>(Students);
        //index = binarySearchGeneric3.Search(s6);


        index = Search(Students, s6);


        foreach (Student S in Students)
        {
            Console.WriteLine(S.Sid + " " + S.Name + " " + S.Class + " " + S.Marks);
        }

        if (index == -1)
            Console.WriteLine("student not found");
        else
            Console.WriteLine("student found at index : " + index);
    }

    public static int Search<T>(List<T> elements, T itemToSearch) where T : IComparable<T>
    {
        elements.Sort();
        int start = 0, end = elements.Count - 1;

        while (start <= end)
        {
            int mid = (start + end) / 2;
            int comparison = elements[mid].CompareTo(itemToSearch);

            if (comparison == 0)
            {
                return mid;
            }
            else if (comparison > 0)
            {
                end = mid - 1;
            }
            else
            {
                start = mid + 1;
            }

        }

        return -1;
    }
}
