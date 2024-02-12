using System;
using System.Collections;


namespace DSA;

class BubbleSortRunner
{
    //Following Main method is for running bubble sort

    static void Main1(string[] args)
    {
        /*Console.WriteLine("Enter size of input array : ");
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
        }*/

        List<int> ints = new List<int>();
        ints.Add(4);
        ints.Add(3);
        ints.Add(2);
        ints.Add(1);

        List<char> chars = new List<char>();
        chars.Add('N');
        chars.Add('z');
        chars.Add('a');
        chars.Add('h');
        chars.Add('P');

        BubbleSortGeneric<int> bubbleSortGeneric1 = new BubbleSortGeneric<int>(ints);
        bubbleSortGeneric1.Sort();
       

        foreach (int element in ints)
        {
            Console.WriteLine(element);
        }


        BubbleSortGeneric<char> bubbleSortGeneric2 = new BubbleSortGeneric<char>(chars);
        bubbleSortGeneric2.Sort();

        foreach (char element in chars)
        {
            Console.WriteLine(element);
        }

        Student s1 = new Student { Sid = 103, Name = "Ajay", Class = 10, Marks = 575.00f };
        Student s2 = new Student { Sid = 106, Name = "stuart", Class = 10, Marks = 535.00f };
        Student s3 = new Student { Sid = 104, Name = "Williams", Class = 10, Marks = 592.00f };
        Student s4 = new Student { Sid = 102, Name = "venkat", Class = 10, Marks = 453.00f };
        Student s5 = new Student { Sid = 101, Name = "david", Class = 10, Marks = 512.00f };
        Student s6 = new Student { Sid = 105, Name = "John", Class = 10, Marks = 498.00f };


        List<Student> Students = new List<Student>{ s1, s2, s3, s4, s5, s6 };

        BubbleSortGeneric<Student> bubbleSortGeneric3 = new BubbleSortGeneric<Student>(Students);
        bubbleSortGeneric3.Sort();

        foreach (Student S in Students)
        {
            Console.WriteLine(S.Sid + " " + S.Name + " " + S.Class + " " + S.Marks);
        }
    }

}
