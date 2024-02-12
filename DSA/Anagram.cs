using System;
using System.Collections.Generic;


namespace DSA;

class Anagram
{
    static void Main(string[] args)
    {
        string s1 = Console.ReadLine();
        string s2 = Console.ReadLine();

        Console.WriteLine(isAnagram(s1, s2));
    }

    public static bool isAnagram(string word1, string word2)
    {
        char[] freq = new char[256];
        
        for(int i=0; i<word1.Length; i++)
        {
            freq[word1[i]]++;
        }

        for (int i = 0; i < word2.Length; i++)
        {
            freq[word2[i]]--;
        }

        for (int i = 0; i < 256; i++)
        {
            if(freq[i]!=0)
                return false;
        }

        return true;
    }

}
