using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;


namespace DSA;

class BubbleSortGeneric<T>
{
    private List<T> elements;

    public BubbleSortGeneric(List<T> elements)
    {
        this.elements = elements;
    }

    public void Sort()
    {
        Sort(Comparer<T>.Default);
    }
    public void Sort(IComparer<T> comparer)
    {
        for(int i=elements.Count-1; i>=0; i--)
        {
            for(int j=0; j<i; j++)
            {
                int comparison = comparer.Compare(elements[j], elements[j + 1]);
                
                if(comparison > 0)
                {
                    T temp = elements[j];
                    elements[j] = elements[j + 1];
                    elements[j + 1] = temp;
                }
            }
        }
    }
}
