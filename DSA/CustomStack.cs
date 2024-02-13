using System;

namespace DSA;

class CustomStack<T>
{
    private T[] array;
    private int top;

    public CustomStack()
    {
        array = new T[10];
        top = -1;
    }

    public int Size()
    {
        if (top == -1)
            return 0;
        else
            return top+1; 
    }

    public bool IsEmpty()
    { 
        return top == -1; 
    }

    public bool IsFull()
    {
        return top == 9;
    }

    public void Push(T item) 
    {
        if (top == 9)
            Console.WriteLine("stack is full");
        else
            array[++top] = item;
    }

    public T Pop() 
    {
        if (top == -1)
        {
            Console.WriteLine("stack is empty");
            return default;
        }                                          
        else
        {
            return array[top--];
        }
                   
    }

    public T Peek()
    {
        if (top == -1)
            return default;
        else
            return array[top];
    }
}


class StackRunner
{
    static void Main1(string[] args)
    {
        /*Stack<int> stack = new Stack<int>();
        stack.Peek();
        stack.Push(10);
        Console.WriteLine(stack.Peek());
        stack.Push(20);
        Console.WriteLine("Current size of stack : " + stack.Size());
        Console.WriteLine("Get the element from stack : " + stack.Peek());        
        stack.Pop();
        Console.WriteLine("Stack is empty : " + stack.IsEmpty());
        Console.WriteLine("Current size of stack : " + stack.Size());*/


        CustomStack<int> intStack = new CustomStack<int>();

        Console.WriteLine("Testing stack of integers:");
        Console.WriteLine("Is stack empty? " + intStack.IsEmpty()); // True
        Console.WriteLine("Size of stack: " + intStack.Size()); // 0

        // Pushing items beyond capacity to test stack overflow
        for (int i = 0; i < 11; i++)
        {
            intStack.Push(i * 10);
        }

        Console.WriteLine("Is stack empty? " + intStack.IsEmpty()); // False
        Console.WriteLine("Size of stack: " + intStack.Size()); // 10

        // Popping items from the stack to test stack underflow
        for (int i = 0; i < 11; i++)
        {
            int poppedItem = intStack.Pop();
            if (poppedItem != 0)
            {
                Console.WriteLine("Popped item from stack: " + poppedItem); // Display popped items except for the first one (0)
            }
        }

        Console.WriteLine("Is stack empty? " + intStack.IsEmpty()); // True
        Console.WriteLine("Size of stack: " + intStack.Size()); // 0

        // Trying to peek when the stack is empty
        int peekedItem = intStack.Peek();
        Console.WriteLine("Peeked item from stack: " + peekedItem); // 0 (default value for int)

        Console.WriteLine();

        // Test stack of strings
        CustomStack<string> stringStack = new CustomStack<string>();

        Console.WriteLine("Testing stack of strings:");
        Console.WriteLine("Is stack empty? " + stringStack.IsEmpty()); // True
        Console.WriteLine("Size of stack: " + stringStack.Size()); // 0

        // Pushing items to the stack
        stringStack.Push("hello");
        stringStack.Push("world");

        Console.WriteLine("Is stack empty? " + stringStack.IsEmpty()); // False
        Console.WriteLine("Size of stack: " + stringStack.Size()); // 2

        // Popping items from the stack
        string poppedString = stringStack.Pop();
        Console.WriteLine("Popped item from stack: " + poppedString); // "world"
        Console.WriteLine("Top item of stack after pop: " + stringStack.Peek()); // "hello"

        // Trying to push items beyond capacity
        for (int i = 0; i < 11; i++)
        {
            stringStack.Push("item" + i);
        }

        Console.WriteLine("Is stack empty? " + stringStack.IsEmpty()); // False
        Console.WriteLine("Size of stack: " + stringStack.Size()); // 10

        // Trying to push one more item beyond capacity
        stringStack.Push("item11"); // This will exceed the capacity

        Console.WriteLine("Is stack empty? " + stringStack.IsEmpty()); // False
        Console.WriteLine("Size of stack: " + stringStack.Size()); // 10 (capacity)
        Console.WriteLine("Top item of stack: " + stringStack.Peek()); // "item8" (Last item pushed before exceeding capacity)

    }
    
}
