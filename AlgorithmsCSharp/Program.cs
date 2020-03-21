using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmsCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            //Program.LinkListFunc();
            //Program.LinkListFeature();
            //Program.MyStackFunc();
            //Program.StackFeature();
            //Program.BinarySearchFunc();
            //Program.BinarySearchFeature();
            //Program.QueueFeature();
            Program.MyQueueFunc();
            Console.ReadKey();

        }
        public static void MyQueueFunc()
        {
            MyQueue q = new MyQueue(10);
            q.Insert(-3);
            q.Insert(10);
            q.Insert(9);
            q.View();
            Console.WriteLine(q.Remove());
            q.View();
            Console.WriteLine(q.Peek());
            

        }
        public static void QueueFeature()
        {
            Queue DefaultQueue = new Queue();
            DefaultQueue.Enqueue(1);//Add an item
            DefaultQueue.Enqueue(2);
            DefaultQueue.Enqueue(3);
            DefaultQueue.Enqueue(4);

            DefaultQueue.Dequeue(); //Remove the first item
            foreach(var item in DefaultQueue)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine(DefaultQueue.Count); //See how the length
            Console.WriteLine(DefaultQueue.Peek()); //Look at the first item
        }
        public static void BinarySearchFeature()
        {
            int theValue = 43;
            int[] array = new int[] { 11, 22, 43, 54, 57, 59, 62, 78 };
            int index = Array.BinarySearch(array, theValue);
            Console.WriteLine("The index is " + index);
        }
        public static void BinarySearchFunc()
        {
            int theValue = 43;
            int[] array = new int[] { 11, 22, 43, 54, 57, 59, 62, 78 };
            BinarySearch bs = new BinarySearch(theValue, array);
            Console.WriteLine("Index is {0}", bs.FindIndex());
        }
        public static void MyStackFunc()
        {
            MyStack s = new MyStack(4);
            s.PushItem(10);
            s.PushItem(20);
            s.PrintStack();
            Console.WriteLine("=====================Pop Item=============");
            s.PopItem();
            s.PrintStack();

            
        }
        public static void StackFeature()
        {
            Stack<string> s = new Stack<string>();
            s.Push("Apple");
            s.Push("Bear");
            s.Push("Canada");
            Console.WriteLine(s.Peek());
            var index = 0;
            Console.WriteLine("Print all Items=========================");

            foreach (var item in s)
            {
                Console.WriteLine("Index at {0} is {1}", index, item);
                index += 1;
            }
            index = 0;
            s.Pop();
            Console.WriteLine("Pop one item=========================");

            foreach (var item in s)
            {

                Console.WriteLine("Index at {0} is {1}", index, item);
                index += 1;
            }
        }
        public static void LinkListFeature()
        {
            LinkedList<string> sentence = new LinkedList<string>();
            sentence.AddFirst("First");
            sentence.AddFirst("Second");
            Display(sentence, "The link list values:");
            sentence.RemoveLast();
            Display(sentence, "new  link list values:");

        }

        private static void Display(LinkedList<string> sentence, string v)
        {
            Console.WriteLine(v + ":");
            foreach(string word in sentence)
            {
                Console.WriteLine(word);
            }
        }

        public static void LinkListFunc()
        {
            Console.WriteLine("Linked List C#");
            LinkedList ll = new LinkedList();
            ll.AddNode(10);
            ll.AddNode(20);
            ll.AddNode(30);
            ll.AddNode(40);
            ll.PrintNodes();
            Console.WriteLine("===========================Delete One Item-------------------------");
            ll.DeleteNode(2);
            ll.PrintNodes();
            Console.WriteLine("===========================Search One Item-------------------------");
            int searchIndex = 2;
            Console.WriteLine("Search index {0} is {1}", searchIndex, ll.SearchNode(searchIndex));
        }
    }
}
