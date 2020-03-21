using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmsCSharp
{
    class MyQueue
    {
        private int _maxSize;
        private long[] _myQueue;
        public int Count = 0;

        public MyQueue(int size)
        {
            _maxSize = size;
            _myQueue = new long[size];
        }

        public void Insert(long j)
        {
            if (!isFull())
            {
                _myQueue[Count] = j;
                Count += 1;
            }

        }

        public long Remove()
        {
            if (!isEmpty())
            {
                Count -= 1;
                long item = _myQueue[0];
                for (int i = 0; i <= Count; i++)
                {
                    _myQueue[i] = _myQueue[i + 1];
                }
                return item;
            }
            else
            {
                return -1;
            }

        }

        public long Peek()
        {
            if (!isEmpty())
            {
                return _myQueue[0];
            }
            else
            {
                return -1;
            }
        }

        public bool isEmpty()
        {
            if(Count == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private bool isFull()
        {
            if(Count == _maxSize)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void View()
        {
            int index = 0;
            for (int i = 0; i < Count; i++)
            {
                Console.WriteLine("Index {0} is {1}", index, _myQueue[i]);
                    index += 1;
            }
        }
    }
}
