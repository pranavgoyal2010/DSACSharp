using System;

namespace DSA;

class Stack<T>
{
    private T[] array;
    private int top;

    public Stack()
    {
        array = new T[10];
        top = -1;
    }

    public int Size()
    {
        if (top == -1)
            return -1;
        else
            return top+1; 
    }

    public bool IsEmpty()
    { 
        return top == -1; 
    }

    public void push(T item) 
    {
        if (top == 9)
            Console.WriteLine("stack is full");
        else
            array[++top] = item;
    }

    public void pop() 
    {
        if (top == -1)        
            Console.WriteLine("stack is empty");                                
        else
            top--;        
    }

    public T peek()
    {
        return array[top];
    }
}


class StackRunner
{
    static void Main(string[] args)
    {
        Stack<int> stack = new Stack<int>();                
        stack.push(10);        
        stack.push(20);
        Console.WriteLine("Current size of stack : " + stack.Size());
        Console.WriteLine("Get the element from stack : " + stack.peek());        
        stack.pop();
        Console.WriteLine("Stack is empty : " + stack.IsEmpty());

        Console.WriteLine(stack.Size());
    }
    
}
