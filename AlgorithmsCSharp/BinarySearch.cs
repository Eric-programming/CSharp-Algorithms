using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmsCSharp
{
    class BinarySearch
    {
        private int _value;
        private int[] _arr;
        public BinarySearch(int value, int[] arr)
        {
            if(arr.Length < 1)
            {
                throw new Exception("Arr can't be empty");

            }
            else
            {
                _value = value;
                _arr = arr;
            }
        }
        public int FindIndex()
        {
            
            int midIndex;
            int minIndex = 0;
            int maxIndex = _arr.Length - 1;

            while (minIndex <= maxIndex)
            {
                midIndex = Decimal.ToInt32(Decimal.Round((minIndex + maxIndex) / 2));
                if(_arr[midIndex] == _value)    
                {
                    return midIndex;
                }
                else if (_arr[midIndex] > _value)
                {
                    maxIndex = midIndex - 1;
                }
                else if(_arr[midIndex] < _value)
                {
                    minIndex = midIndex + 1;
                }
            }
            throw new Exception("Doesn't exist");
           
        }
    }
}
