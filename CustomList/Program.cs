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
            newlist.Add(18);
            newlist.Add(6);
            newlist.Add(32);
            newlist.Add(1);







            ListB<int> newlist2 = new ListB<int>();
            newlist.Add(4);
            newlist.Add(8);
            newlist.Add(16);
            newlist.Add(32);
            newlist.Add(64);
            newlist.Add(128);
            

            ListB<int> combinedList = new ListB<int>();
            combinedList = newlist + newlist2;
            Console.WriteLine(combinedList.ToString());
            Console.ReadLine();

        }
    }
}
