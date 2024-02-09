// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

//Bubble Sort

namespace DSA;

class BubbleSort
{
    private int[] numbers;

    public BubbleSort(int[] numbers)
    {
        this.numbers = numbers;
    }

    public int[] Sort()
    {
        for(int i=this.numbers.Length-1; i>=0; i--)
        {
            for(int j=0; j<i; j++)
            {
                if (this.numbers[j] > this.numbers[j+1])
                {
                    int temp = this.numbers[j];
                    this.numbers[j] = this.numbers[j + 1];
                    this.numbers[j + 1] = temp;
                }
            }
                
        }

        return this.numbers;
    }
}

class Runner
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter size of input array : ");
        int size = int.Parse(Console.ReadLine());

        int[] numbers = new int[size];
        for(int i=0; i < size; i++)
        {
            Console.WriteLine("Enter array element");
            numbers[i] = int.Parse(Console.ReadLine());
        }

        Console.WriteLine();

        BubbleSort bubbleSort = new BubbleSort(numbers);
        int[] sortedNumbers = bubbleSort.Sort();

        foreach(int element in sortedNumbers)
        {
            Console.WriteLine(element);
        }
        
    }
}