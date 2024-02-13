namespace DSA
{
    class StackBuiltIn
    {
        static void Main()
        {
            // Creating a stack of integers
            Stack<int> stack = new Stack<int>();

            // Pushing elements onto the stack
            stack.Push(10);
            stack.Push(20);
            stack.Push(30);

            // Displaying contents of the stack
            Console.WriteLine("Contents of the stack:");
            foreach (int item in stack)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();

            // Popping an element from the stack
            int poppedItem = stack.Pop();
            Console.WriteLine("Popped item: " + poppedItem);
            Console.WriteLine();

            // Peeking at the top element of the stack
            int topElement = stack.Peek();
            Console.WriteLine("Top element of the stack: " + topElement);
            Console.WriteLine();

            // Checking if the stack contains an element
            int element = 20;
            if (stack.Contains(element))
            {
                Console.WriteLine("Element {0} exists in the stack.", element);
            }
            else
            {
                Console.WriteLine("Element {0} does not exist in the stack.", element);
            }
        }
    }
}
