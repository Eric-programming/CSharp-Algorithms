using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmsCSharp
{
    class MyStack
    {
        private int[] _array;
        private int _index;
        public MyStack(int size)
        {
            _array = new int[size];
            _index = 0;
        }
        public void PushItem(int value)
        {
            if (!_IsFull())
            {
                _array[_index] = value;
                _index += 1;
            }
        }
        public int PopItem()
        {
            if (!_IsEmpty())
            {
                _index -= 1;
                return _array[_index];
            }
            else
            {
                return 0;
            }
        }
        public void PrintStack()
        {
            for (int i = 0; i < _index; i++)
            {
                Console.WriteLine("Index at {0} is {1}", i, _array[i]);
            }
        }
        private bool _IsEmpty()
        {
            return _index == 0;
        }
        private bool _IsFull()
        {
            return _index == _array.Length - 1;
        }
    }
}
