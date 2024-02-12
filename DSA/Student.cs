using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA;

class Student : IComparable<Student>
{
    public int Sid { get; set; }
    public string Name { get; set; }
    public int Class { get; set; }
    public float Marks { get; set; }

    public int CompareTo(Student other)
    {
        /*if (this.Sid > other.Sid)
            return 1;
        else if (this.Sid < other.Sid)
            return -1;
        else
            return 0;*/

        return this.Name.CompareTo(other.Name);
    }
}
