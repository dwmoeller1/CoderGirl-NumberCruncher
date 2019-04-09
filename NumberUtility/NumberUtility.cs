using System;
using System.Collections.Generic;
using System.Text;

namespace NumberUtility
{
    public static class NumberUtility
    {
        private int _numbers;
        public int Numbers
        {
            get { return _numbers; }
            set
            {
                if (_numbers % 2 == 0)
                {
                    _numbers = value;
                }
            }
        }

        //create a static method SumOfEvenNumbers
        public static List<NumberUtility> SumOfEvenNumbers(List<NumberUtility> evens)
        {
            return evens
                .Add(even => even.Numbers).ToList();
        }
        //it should take a list of ints and returns the sum of all even number in that list
    }
}
