using System;
using System.Collections;
using System.Collections.Generic;


namespace DSA;

class BinarySearchGeneric<T>
{
    
    private List<T> elements;

    public BinarySearchGeneric(List<T> elements)
    {
        this.elements = elements;
    }

    public int Search(T itemToSearch)
    {
        return Search(Comparer<T>.Default, itemToSearch);
    }

    public int Search(IComparer<T> comparer, T itemToSearch)
    {
        BubbleSortGeneric<T> bubbleSortGeneric = new BubbleSortGeneric<T>(this.elements); 
        bubbleSortGeneric.Sort();

        int start = 0, end = this.elements.Count-1;
        
        while (start <= end)
        {
            int mid = (start + end) / 2;
            int comparison = comparer.Compare(elements[mid], itemToSearch);

            if(comparison==0)
            {
                return mid;
            }
            else if(comparison > 0)
            {
                end = mid - 1;
            }
            else
            {
                start = mid + 1;
            }

        }

        return -1;
        
    }

}
