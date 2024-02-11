using System;
using System.Collections.Generic;


namespace DSA;

class InsertionSort
{
    private string[] words;

    public InsertionSort(string[] words)
    {
        this.words = words;
    }

    public void Sort()
    {
        //int startIndex = 0;

        for(int i=1; i<words.Length; i++)
        {
            string temp = words[i];
            int currIndex = i;
            while(currIndex>0)
            {
                int comparion = string.Compare(temp, words[currIndex-1]);

                if(comparion>=0)
                {
                    break;
                }
                else
                {
                    words[currIndex] = words[currIndex-1];
                }
                currIndex--;
            }
            words[currIndex] = temp;
        }
    }
}
