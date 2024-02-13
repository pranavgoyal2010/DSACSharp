namespace DSA;

class QueueRunner
{
    static void Main1(string[] args)
    {
        // Test cases
        Queue<int> intQueue = new Queue<int>();
        Queue<string> stringQueue = new Queue<string>();

        // Adding elements to intQueue
        intQueue.Push(10);
        intQueue.Push(20);
        intQueue.Push(30);

        // Adding elements to stringQueue
        stringQueue.Push("One");
        stringQueue.Push("Two");
        stringQueue.Push("Three");

        // Displaying sizes of the queues
        Console.WriteLine("Size of intQueue: " + intQueue.GetSize()); // 3
        Console.WriteLine("Size of stringQueue: " + stringQueue.GetSize()); // 3

        // Popping elements from intQueue
        int poppedInt1 = intQueue.Pop();
        int poppedInt2 = intQueue.Pop();

        // Displaying popped elements from intQueue
        Console.WriteLine("Popped element from intQueue: " + poppedInt1); // 10
        Console.WriteLine("Popped element from intQueue: " + poppedInt2); // 20

        // Peeking into stringQueue
        string peekedString = stringQueue.Peek();

        // Displaying peeked element from stringQueue
        Console.WriteLine("Peeked element from stringQueue: " + peekedString); // One

        // Checking if intQueue is empty
        Console.WriteLine("Is intQueue empty? " + intQueue.IsEmpty()); // False

        // Popping remaining elements from intQueue
        int poppedInt3 = intQueue.Pop();

        // Displaying popped element from intQueue
        Console.WriteLine("Popped element from intQueue: " + poppedInt3); // 30

        // Checking if intQueue is empty after popping all elements
        Console.WriteLine("Is intQueue empty? " + intQueue.IsEmpty()); // True

        Console.WriteLine("Peeked element from intQueue: " + intQueue.Peek()); // queue is empty
    }

}
