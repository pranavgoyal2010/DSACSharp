using System;
using System.Collections.Generic;
using System.Security.Cryptography;

namespace DSA;

class MergeSort
{
    private string[] words;

    public MergeSort(string[] words)
    {
        this.words = words;
    }

    public void Sort(string[] words)
    {
        
        string[] temp = new string[words.Length];

        Sort(words, 0, words.Length-1, temp);
    }

    public void Sort(string[] words, int left, int right, string[] temp)
    {
        if(left >= right)
            return;

        int mid = (left + right) / 2;

        Sort(words, left, mid, temp);
        Sort(words, mid+1, right, temp);
        Merge(words, left, right, mid, temp);

        //return words;
    }

    private void Merge(string[] words, int left, int right, int mid, string[] temp)        
    {
        int start1 = left;
        int start2 = mid + 1;
        int n1 = mid-left+1;
        int n2 = right-mid;
        
        

        for(int index=0; index<n1; index++)
        {
            temp[start1 + index] = words[start1 + index];
        }

        for(int index=0; index<n2; index++)
        {
            temp[start2 + index] = words[start2 + index];
        }

        int i = 0, j = 0, k = 0;

        while (i<n1 && j<n2)
        {
            int comparison = temp[start1 + i].CompareTo(temp[start2 + j]);

            if(comparison > 0)
            {
                words[start1 + k++] = temp[start2 + j++];                
            }
            else
            {
                words[start1 + k++] = temp[start1 + i++];               
            }
        }

        while(i<n1)
        {
            words[start1 + k++] = temp[start1 + i++];
        }

        while(j<n2)
        {
            words[start1 + k++] = temp[start2 + j++];
        }

    }
}
