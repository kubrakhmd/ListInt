using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListInt_Struct
{
     internal class ListInt
    {
        private int[] _arr;

        public int Length
        {
            get
            {
                return _arr.Length;
            }

        }
        public int this[int index]
        {
            get
            {
                if (index >= _arr.Length)
                {
                    return _arr[_arr.Length - 1];
                }
                return _arr[index];
            }
            set
            {
                if (index < _arr.Length)
                {
                    _arr[index] = value;
                }

            }
        }
        public ListInt()
        {
            _arr = new int[0];
        }
        public ListInt(int length)
        {
            _arr = new int[length];

        }
        public ListInt(params int[] nums)
        {
            _arr = nums;
        }


        public void Add(int value)
        {
            Array.Resize(ref _arr, _arr.Length + 1);
            _arr[_arr.Length - 1] = value;
        }
        public override string ToString()
        {
            return string.Join(", ", _arr);
        }
        public int Sum()
        {
            int sum = 0;
            foreach (var num in _arr)
            {
                sum += num; 
            }

            return sum;
        //    int sum = 0;
        //for (int i = 0; i < _arr.Length; i++)
        //{
        //    sum += _arr[i];
        //}
        //return sum;
        }
        public void AddRange(params int[] nums)
        {
            int oldLength = _arr.Length;
            Array.Resize(ref _arr, oldLength + nums.Length); 

            for (int i = 0; i < nums.Length; i++)
            {
                _arr[oldLength + i] = nums[i]; 
            }
        }

        public bool Contains(int num)
        {
            for (int i = 0; i < _arr.Length; i++)
            {
                if (_arr[i] == num)
                {
                    return true;
                }
            }
            return false;
        }
        public bool Remove(int num)
        {
            int index = Array.IndexOf(_arr, num);
            if (index >= 0)
            {
                int[] newArray = new int[_arr.Length - 1]; 

                for (int i = 0, j = 0; i < _arr.Length; i++)
                {
                    if (i != index)                     {
                        newArray[j] = _arr[i];
                        j++;
                    }
                }

                _arr = newArray; 
                return true;
            }
            return false;
        }
        public void RemoveRange(params int[] nums)
        {
            for (int i = 0; i < nums.Length; i++)
            {
                Remove(nums[i]); 
            }
        }
    }
}
    
    

    

