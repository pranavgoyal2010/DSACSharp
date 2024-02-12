using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA;
class BinarySearch
{
    private string[] words;

    public BinarySearch(string[] words)
    {
        this.words = words;
    }

    public int Search(string target)
    {

        Array.Sort(this.words);
        Console.WriteLine();
        Console.WriteLine("After sorting the words are : ");
        
        foreach (string word in this.words)
        {
            Console.WriteLine(word);
        }

        int start = 0, end = this.words.Length-1;
        
        while(start<=end)
        {
            int mid = start + ((end - start) / 2);
            
            string wordAtMid = this.words[mid];
            int compare = string.Compare(wordAtMid, target);
            //int compare = wordAtMid.CompareTo(target);
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



