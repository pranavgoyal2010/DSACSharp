using System;
using System.Collections.Generic;


namespace DSA;

class MergeSortGeneric<T>
{
    private T[] elements;

    public MergeSortGeneric(T[] elements)
    {
        this.elements = elements; 
    }


    public void Sort()
    {
        T[] temp = new T[elements.Length];
        Sort(elements, 0, elements.Length - 1, temp, Comparer<T>.Default);        
    }
    public void Sort(T[] elements, int left, int right, T[] temp, IComparer<T> comparer)
    {
        if (left >= right)
            return;
        int mid = (left + right) / 2;
        Sort(elements, left, mid, temp, comparer);
        Sort(elements, mid+1, right, temp, comparer);
        Merge(elements, left, right, mid, temp, comparer);
    }
    private void Merge(T[] elements, int left, int right, int mid, T[] temp, IComparer<T> comparer)
    {
        int start1 = left;
        int start2 = mid+1;
        int n1 = mid + 1 - left;
        int n2 = right - mid;


        for(int index = 0; index<n1; index++)
        {
            temp[start1 + index] = elements[start1 + index];
        }

        for(int index = 0; index<n2; index++)
        {
            temp[start2 + index] = elements[start2 + index];
        }

        int i = 0, j = 0, k = 0;

        while(i<n1 && j<n2)
        {
            int comparison = comparer.Compare(temp[start1 + i], temp[start2 + j]);

            if(comparison > 0)
            {
                elements[start1 + k++] = temp[start2 + j++];
            }
            else
            {
                elements[start1 + k++] = temp[start1 + i++];
            }
        }

        while(i < n1)
        {
            elements[start1 + k++] = temp[start1 + i++];
        }

        while(j < n2)
        {
            elements[start1 + k++] = temp[start2 + j++];
        }

    }
    

}
