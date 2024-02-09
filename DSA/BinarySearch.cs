using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA;
class BinarySearch
{
    private ArrayList words;

    public BinarySearch(ArrayList words)
    {
        this.words = words;
    }

    public int Search(string target)
    {

        this.words.Sort();
        Console.WriteLine();
        Console.WriteLine("After sorting the words are : ");
        for (int i=0; i<this.words.Count; i++)
        {
            Console.WriteLine(this.words[i]);
        }

        int start = 0, end = this.words.Count-1;
        
        while(start<=end)
        {
            int mid = start + ((end - start) / 2);
            
            string wordAtMid = (string)this.words[mid];
            int compare = string.Compare(wordAtMid, target);
            
            if (compare==0)
            {
                return mid;
            }
            else if (compare<0)
            {
                start = mid + 1;
            }
            else
            {
                end = mid - 1;
            }
   
        }
        return -1;
    }
}



