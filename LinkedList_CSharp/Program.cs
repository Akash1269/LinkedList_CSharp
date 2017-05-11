using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList_CSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Linked Program");
            Console.WriteLine("\n\nPlease enter numbers to be inserted into the list in space separated format");

            string[] temp = Console.ReadLine().Split(' ');
            int[] values = Array.ConvertAll(temp, int.Parse);

            LinkedList list = new LinkedList();

            foreach (int item in values)
            {
                list.InsertAtStart(item);
            }
            list.PrintList();
            
            Console.Read();
        }
    }
}
