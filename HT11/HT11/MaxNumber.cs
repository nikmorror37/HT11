using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HT11
{
    public class MaxNumber<T> where T: IComparable
    {
        public static T MaxValue(T value1, T value2, T value3)
        {
            if (value1.CompareTo(value2) > 0)
            {
                if (value1.CompareTo(value3) > 0) 
                    return value1;
                else 
                    return value3;
            }
            else if (value2.CompareTo(value3) > 0) 
                return value2;
            else 
                return value3;

        }
    }

}
