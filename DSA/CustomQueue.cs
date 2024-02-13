namespace DSA;

class CustomQueue<T>
{
    private Linkedlist<T> queue;

    public CustomQueue()
    {
        queue = new Linkedlist<T>();
    }

    public void Push(T item)
    {
        queue.Add(item);
    }

    public T Pop()
    {
        return queue.RemoveFirst();
    }

    public T Peek()
    {
        if (IsEmpty())
        {
            Console.WriteLine("queue is empty");
            Console.WriteLine("Following line will return the default value of the data type with which this queue is initialized.");
            return default;
        }
        return queue.GetHead();
    }

    public bool IsEmpty()
    {
        return queue.GetSize() == 0;
    }

    public int GetSize()
    {
        return queue.GetSize();
    }

}
