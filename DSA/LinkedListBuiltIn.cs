namespace DSA;

class LinkedListBuiltIn
{
    static void Main1()
    {
        // Test case 1: Creating a LinkedList of integers
        LinkedList<int> list1 = new LinkedList<int>();

        // Adding elements to list1
        list1.AddLast(10);
        list1.AddLast(20);
        list1.AddLast(30);

        // Displaying contents of list1
        Console.WriteLine("Contents of list1:");
        foreach (int item in list1)
        {
            Console.WriteLine(item);
        }
        Console.WriteLine();

        // Test case 2: Creating a LinkedList of strings
        LinkedList<string> list2 = new LinkedList<string>();

        // Adding elements to list2
        list2.AddLast("One");
        list2.AddLast("Two");
        list2.AddLast("Three");

        // Displaying contents of list2
        Console.WriteLine("Contents of list2:");
        foreach (string item in list2)
        {
            Console.WriteLine(item);
        }
        Console.WriteLine();

        // Test case 3: Accessing elements by index
        Console.WriteLine("Element at index 1 in list1: " + list1.ElementAt(1));
        Console.WriteLine();

        // Test case 4: Checking if an element exists
        int element = 20;
        if (list1.Contains(element))
        {
            Console.WriteLine("Element {0} exists in list1.", element);
        }
        else
        {
            Console.WriteLine("Element {0} does not exist in list1.", element);
        }
        Console.WriteLine();

        // Test case 5: Removing elements from the list
        list1.Remove(20);
        Console.WriteLine("Contents of list1 after removing 20:");
        foreach (int item in list1)
        {
            Console.WriteLine(item);
        }
        Console.WriteLine();

        // Test case 6: Counting the number of elements in the list
        Console.WriteLine("Number of elements in list2: " + list2.Count);
        Console.WriteLine();

        // Test case 7: Clearing all elements from the list
        list2.Clear();
        Console.WriteLine("list2 cleared. Number of elements in list2: " + list2.Count);


        // Test case 6: Adding an element at the beginning of the list
        list1.AddFirst(5);
        Console.WriteLine("Contents of the list after adding 5 at the beginning:");
        foreach (int item in list1)
        {
            Console.WriteLine(item);
        }
        Console.WriteLine();

        // Test case 7: Adding an element after a specified node
        LinkedListNode<int> node = list1.Find(10);
        list1.AddAfter(node, 25);
        Console.WriteLine("Contents of the list after adding 25 after node with value 10:");
        foreach (int item in list1)
        {
            Console.WriteLine(item);
        }
        Console.WriteLine();

        list1.RemoveLast();
        Console.WriteLine("Contents of list1 after removing 30:");
        foreach (int item in list1)
        {
            Console.WriteLine(item);
        }
        Console.WriteLine();

        list1.RemoveFirst();
        Console.WriteLine("Contents of list1 after removing 5:");
        foreach (int item in list1)
        {
            Console.WriteLine(item);
        }
        Console.WriteLine();
    }
}
