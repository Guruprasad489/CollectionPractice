using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionPractice
{
    public class Collection
    {
        public static void ArrayListDemo()                  //ArrayList
        {
            Console.WriteLine("\nArrayList Demo");
            ArrayList arraylist = new ArrayList();
            arraylist.Add("Virat");
            arraylist.Add(100);
            arraylist.Add(23.64);
            arraylist.Add("Dhoni");
            arraylist.Add("Rahul");
            Console.WriteLine("Capacity: "+arraylist.Capacity);
            arraylist.TrimToSize();
            Console.WriteLine("Capacity after trim to size: "+ arraylist.Capacity);
            foreach (var element in arraylist)
            {
                Console.Write(element + " ");
            }
            arraylist.Remove("Rahul");
            Console.WriteLine("\nAfter removing Rahul: ");
            foreach (var element in arraylist)
            {
                Console.Write(element + " ");
            }
        }

        public static void ListDemo()                       //List
        {
            Console.WriteLine("\nList Demo");
            List<string> list = new List<string>();
            list.Add("Virat");
            list.Add("Rohit");
            list.Add("Sachin");
            list.Add("Dhoni");
            list.Add("Rahul");
            Console.WriteLine(list.Capacity);
            list.TrimExcess();
            Console.WriteLine(list.Capacity);
            foreach (var element in list)
            {
                Console.Write(element +" ");
            }
        }

        public static void DictionaryDemo()                   //Dictionary
        {
            Console.WriteLine("\nIn DictionaryDemo");

            Dictionary<int, string> dictionary = new Dictionary<int, string>();
            dictionary.Add(2, "Viral");
            dictionary.Add(3, "Rahul");
            dictionary.Add(1, "ABD");

            Console.WriteLine("Access value using key(key=1):" + dictionary[1]);
            Console.WriteLine("\nIterating Dictionary:");
            foreach (var element in dictionary)
            {
                Console.WriteLine("Key = " + element.Key + " & Value = " + element.Value);
            }
        }

        public static void Stackdemo()                     //Stack
        {
            Console.WriteLine("\nIn Stackdemo");
            Stack<string> stack = new Stack<string>();
            stack.Push("amit");
            stack.Push("aakash");
            stack.Push("amit");
            stack.Push("naveen");
            string pop = stack.Pop();
            foreach (var element in stack)
            {
                Console.WriteLine(element); 
            }
            Console.WriteLine("Poped element:" + pop);
        }

        public static void Queuedemo()                       //Queue
        {
            Console.WriteLine("\nIn Queuedemo");
            Queue<string> queue = new Queue<string>();
            queue.Enqueue("Virat");
            queue.Enqueue("Chahal");
            queue.Enqueue("ABD");
            Console.WriteLine("Head:" + queue.Peek());

            Console.WriteLine("\nIterating the queue elements:");
            foreach (var element in queue)
            {
                Console.WriteLine(element);
            }
            string dequeue = queue.Dequeue();
            Console.WriteLine("Dequeue element:" + dequeue);

            Console.WriteLine("\nIterating the queue elements after dequeue one element:");

            Queue<string>.Enumerator enumerator = queue.GetEnumerator();
            while (enumerator.MoveNext())
            {
                Console.WriteLine(enumerator.Current);
            }
        }
        public static void HashSetDemo()                            //HashSet
        {
            var set = new HashSet<string>();
            set.Add("Ravi");
            set.Add("Raj");
            set.Add("Rajesh");
            set.Add("Rakesh");

            HashSet<string>.Enumerator enumerator = set.GetEnumerator();
            while (enumerator.MoveNext())
            {
                Console.WriteLine(enumerator.Current);
            }
        }

        public static void SortedListDemo()                   //SortedListDemo
        {
            Console.WriteLine("\nIn SortedListDemo");

            SortedList<int, string> sortedlist = new SortedList<int, string>();
            sortedlist.Add(2, "Viral");
            sortedlist.Add(3, "Rahul");
            sortedlist.Add(1, "ABD");

            Console.WriteLine("Access value using key(key=1):" + sortedlist[1]);
            Console.WriteLine("\nIterating SortedList:");
            foreach (var element in sortedlist)
            {
                Console.WriteLine("Key = " + element.Key + " & Value = " + element.Value);
            }
        }
    }
}
