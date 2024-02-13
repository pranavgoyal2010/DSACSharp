namespace DSA;

class LinkedlistRunner
{
    static void Main1(string[] args)
    {
        Linkedlist<int> intList = new Linkedlist<int>();
        intList.Add(10);
        intList.Add(20);
        intList.Add(30);
        intList.PrintList();

        Console.WriteLine("------------------------");

        Linkedlist<string> stringList = new Linkedlist<string>();
        stringList.AddFirst("First");
        stringList.PrintList();

        Console.WriteLine("------------------------");

        stringList.Add("Second");
        stringList.AddFirst("First");
        stringList.PrintList();

        Console.WriteLine("------------------------");

        Linkedlist<char> charList = new Linkedlist<char>();
        charList.Add('A');
        charList.Add('B');
        charList.Add('C');
        charList.AddAt('X', 1); // Insert 'X' at index 1, so the list becomes A -> X -> B -> C
        charList.PrintList();
        Console.WriteLine("Current Size : " + charList.GetSize());
        Console.WriteLine("------------------------");


        Linkedlist<double> doubleList = new Linkedlist<double>();
        double removed = doubleList.RemoveAt(0); // Attempting to remove from an empty list
        doubleList.PrintList();

        Console.WriteLine("------------------------");

        Linkedlist<int> intList1 = new Linkedlist<int>();
        intList1.Add(10);
        intList1.Add(20);
        int removedItem = intList1.RemoveFirst(); // Remove the first element (10)
        intList1.PrintList();

        Console.WriteLine("------------------------");

        intList1.Add(20);
        removedItem = intList1.RemoveLast(); // Remove the last element (20)
        intList1.PrintList();

        Console.WriteLine("------------------------");


        Linkedlist<string> list = new Linkedlist<string>();
        list.Add("Apple");
        list.Add("Banana");
        list.Add("Cherry");
        Console.WriteLine("The size is : " + list.GetSize());
        list.PrintList(); // Should print "Apple Banana Cherry"
    }
}
