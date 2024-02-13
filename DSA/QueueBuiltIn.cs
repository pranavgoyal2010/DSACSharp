namespace DSA
{
    class QueueBuiltIn
    {
        static void Main(string[] args)
        {
            Queue<int> queue = new Queue<int>();

            queue.Enqueue(10);
            queue.Enqueue(20);
            queue.Enqueue(30);

            // Displaying contents of the queue
            Console.WriteLine("Contents of the queue:");
            foreach (int item in queue)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();

            // Dequeueing an element from the queue
            int dequeuedItem = queue.Dequeue();
            Console.WriteLine("Dequeued item: " + dequeuedItem);
            Console.WriteLine();

            // Peeking at the front element of the queue
            int frontElement = queue.Peek();
            Console.WriteLine("Front element of the queue: " + frontElement);
            Console.WriteLine();

            // Checking if the queue contains an element
            int element = 20;
            if (queue.Contains(element))
            {
                Console.WriteLine("Element {0} exists in the queue.", element);
            }
            else
            {
                Console.WriteLine("Element {0} does not exist in the queue.", element);
            }
        }
    }
}
