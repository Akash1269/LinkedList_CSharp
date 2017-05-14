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
            Console.WriteLine("\nPlease enter numbers to be inserted into the list in space separated format");

            string[] temp = Console.ReadLine().Split(' ');
            int[] values = Array.ConvertAll(temp, int.Parse);

            LinkedList list = new LinkedList();

            foreach (int item in values)
            {
                list.InsertAtStart(item);
            }
            int option = 1;
            int d;
            while (option != 0)
            {
                switch (option)
                {
                    case 0:
                        Console.WriteLine("Exiting!!!");
                        break;
                    case 1:
                        list.PrintList();
                        break;
                    case 2:
                        Console.WriteLine(list.GetSize());
                        break;
                    case 3:
                        list.EmptyList();
                        Console.WriteLine("List deleted successfully");
                        break;
                    case 4:
                        Console.WriteLine("Please enter the intger value for the element to be inserted : ");
                        d = int.Parse(Console.ReadLine());
                        list.InsertAtStart(d);
                        break;
                    case 5:
                        list.DeleteAtStart();
                        Console.WriteLine("Element at the start of the list deleted successfully");
                        break;
                    case 6:
                        Console.WriteLine("Please enter the intger value for the element to be inserted : ");
                        d = int.Parse(Console.ReadLine());
                        list.InsertAtEnd(d);
                        break;
                    case 7:
                        list.DeleteAtEnd();
                        Console.WriteLine("Element at the end of the list deleted successfully");
                        break;
                    case 8:
                        Console.WriteLine("Please enter the the value to be searched");
                        d = int.Parse(Console.ReadLine());
                        Console.WriteLine("The element present at address - " + list.Find(d));
                        break;
                    case 9:
                        list.RemoveDuplicates();
                        Console.WriteLine("Remvoed duplicates successfully");
                        break;
                    case 10:
                        list.Reverse();
                        Console.WriteLine("List has been reversed successfully");
                        break;
                    case 11:
                        list.Sort();
                        Console.WriteLine("List has been sorted successfully");
                        break;
                    case 12:
                        d = int.Parse(Console.ReadLine());
                        list.InsertInSortedList(d);
                        Console.WriteLine("element inserted successfully");
                        break;
                    default:
                        Console.WriteLine("Invalid options, Please enter the Correct choice Again");
                        break;
                }
                list.PrintList();

                Console.WriteLine(@"
                    Plese select option from the menu
                    0.Exit
                    1.Print List
                    2.Get Size
                    3.Delete List
                    4.Insert At Start
                    5.Delete At Start
                    6.Insert At End
                    7.Delete At End
                    8.Find
                    9.Remove Duplicates
                    10.Reverse
                    11.Sort
                    12.Insert in sorted array (please sort before inserting)
                    ");

                option = int.Parse(Console.ReadLine());
            }
        }
    }
}
