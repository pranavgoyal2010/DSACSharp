namespace DSA;

class Linkedlist<T>
{
    private Node<T> head;
    private int size;

    public Linkedlist()
    {
        this.head = null;
        this.size = 0;
    }

    public T GetHead()
    {
        if (this.head == null)
            return default;
        else
            return this.head.Data;
    }
    public void AddAt(T item, int index)
    {
        Node<T> newNode = new Node<T>(item, null);

        if (head == null)
        {
            this.head = newNode;

        }
        else if (index == 0)
        {
            newNode.Next = this.head;
            this.head = newNode;
        }

        else
        {
            Node<T> currNode = this.head;
            int currIndex = 0;
            while (currIndex < index - 1)
            {
                currNode = currNode.Next;
                currIndex++;
            }

            Node<T> remaining = currNode.Next;
            currNode.Next = newNode;
            newNode.Next = remaining;
        }
        this.size++;

    }

    public void Add(T item)
    {
        AddAt(item, this.size);
    }

    public void AddFirst(T item)
    {
        AddAt(item, 0);
    }


    public T RemoveAt(int index)
    {
        int currIndex = 0;
        Node<T> currNode = this.head;

        if (this.head == null)
        {
            Console.WriteLine("Error: List is empty");
            Console.WriteLine("Following line will return the default value of the data type with which this linkedlist is initialized.");
            return default;
        }


        if (index == 0)
        {
            this.head = this.head.Next;
            this.size--;
            return currNode.Data;
        }

        while (currIndex < index - 1)
        {
            currNode = currNode.Next;
            currIndex++;
        }

        Node<T> nodeRemoved = currNode.Next;
        currNode.Next = currNode.Next.Next;
        this.size--;
        return nodeRemoved.Data;
    }

    public T RemoveLast()
    {
        return RemoveAt(this.size - 1);
    }

    public T RemoveFirst()
    {
        return RemoveAt(0);
    }

    public int GetSize()
    {
        return this.size;
    }

    public void PrintList()
    {
        Node<T> currNode = this.head;

        while (currNode != null)
        {
            Console.WriteLine(currNode.Data + " ");
            currNode = currNode.Next;
        }
    }

}
