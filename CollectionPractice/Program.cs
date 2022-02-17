using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionPractice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Collections Practice programs\n");
            Console.WriteLine("Choose an option: \n1. ArrayList \n2. List \n3. Dictionary \n4. Stack \n5. Queue \n6. HashSet \n7. Sortedist");
            int option = Convert.ToInt32(Console.ReadLine());
            switch (option)
            {
                case 1:
                    Collection.ArrayListDemo();
                    break;
                case 2:
                    Collection.ListDemo();
                    break;
                case 3:
                    Collection.DictionaryDemo();
                    break;
                case 4:
                    Collection.Stackdemo();
                    break;
                case 5:
                    Collection.Queuedemo();
                    break;
                case 6:
                    Collection.HashSetDemo();
                    break;
                case 7:
                    Collection.SortedListDemo();
                    break;
                default:
                    Console.WriteLine("Please Choose the correct program");
                    break;
            }
            Console.ReadLine();
        }
    }
}
