using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomList
{
    class Program
    {
        static void Main(string[] args)
        {
            ListB<int> newlist = new ListB<int>();
            newlist.Add(24);
            newlist.Add(12);
            newlist.Add(56);
            newlist.Remove(99);








            Console.WriteLine(newlist.Count);
            Console.ReadLine();

        }
    }
}
