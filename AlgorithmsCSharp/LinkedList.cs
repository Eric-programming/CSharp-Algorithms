using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmsCSharp
{
    class LinkedList
    {
        private Node _nextData;
        public LinkedList()
        {
            _nextData = null;
        }
        public void AddNode(int newData)
        {
            Node newNode = new Node(newData, _nextData);
            _nextData = newNode;
        }
        public int SearchNode(int index)
        {
            
            if (index == 0) {
                return _nextData.GetVal();
            }
            Node currentNode = _nextData;
            int init = 0;
            while (init < index)
            {
                currentNode = currentNode.GetNext();
                init += 1;
            }
            return currentNode.GetVal();
        }
        public void DeleteNode(int index)
        {
            if(index == 0)
            {
                _nextData = _nextData.GetNext();
            }
            else
            {
                int init = 0;
                Node initData = _nextData;
                while(init < index)
                {
                    initData.GetNext();
                    init += 1;
                }
                initData.SetNext(initData.GetNext().GetNext());
            }
        }
        public void PrintNodes()
        {
            Node nodes = _nextData;
            int index = 0;
            while(nodes != null)
            {
                Console.WriteLine("Current Value is {0}, the index is {1}", nodes.GetVal(), index);
                index += 1;
                nodes = nodes.GetNext();
            }
            if(index == 0)
            {
                Console.WriteLine("There is nothing in the Linked List");
            }
        }
    }
    class Node
    {
       private int _data;
       private Node _next;

        public Node(int data, Node next)
        {
            _data = data;
            _next = next;
        }
        public void SetNext(Node next)
        {
            _next = next;
        }
        public int GetVal()
        {
            return _data;
        }
        public Node GetNext()
        {
            return _next;
        }
    }
}
