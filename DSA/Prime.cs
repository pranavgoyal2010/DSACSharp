using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace DSA;

class Prime
{
    public static void Main(string[] args)
    {
        List<int> ints = allPrime();

        foreach (int i in ints)
        {
            Console.WriteLine(i);
        }
    }
    public static List<int> allPrime()
    {
        List<int> list = new List<int>();
        int flag = 0;
        for (int number = 0; number <= 1000; number++)
        {
            if (number == 0 || number == 1)
                continue;

            for (int i = 2; i * i <= number; i++)
            {
                if (number % i == 0)
                {
                    flag = 1;
                    break;
                }                    
            }

            if (flag == 0)
                list.Add(number);
            else if (flag == 1)
                flag = 0;
        }
        return list;
    }
}
