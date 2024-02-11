using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;


namespace DSA;

class InsertionSortGeneric<T>
{
    private T[] elements;

    public InsertionSortGeneric(T[] elements)
    {
        this.elements = elements;
    }

    public void Sort()
    {
        Sort(Comparer<T>.Default);
    }

    public void Sort(IComparer<T> comparer)
    {

        for(int i=1; i<this.elements.Length; i++)
        {
            T element = this.elements[i];
            int currIndex = i;
            while(currIndex>0)
            {
                int comparison = comparer.Compare(element, elements[currIndex-1]);

                if(comparison < 0)
                {
                    this.elements[currIndex] = this.elements[currIndex-1];
                }
                else
                {
                    break;
                }
                currIndex--;
            }

            this.elements[currIndex] = element;
        }

        
    }
}
