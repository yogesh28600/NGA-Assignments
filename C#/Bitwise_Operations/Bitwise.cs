using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bitwise_Operations
{
    public class Bitwise
    {
        public int convert_to_binary(int number)
        {
            List<int> bits= new List<int>();
            return helper(bits,number);
        }
        
        private int helper(List<int> ints, int number)
        {
            if (number <= 1)
            {
                ints.Add(number);
                int result = 0;
                for(int i = 0; i < ints.Count; i++)
                {
                    result += ints[i]* (int)Math.Pow(10,i);
                }
                return result;
            }
            ints.Add(number%2);
            return helper(ints, number/2);
        }

        public int find_set_bits(int number)
        {
            int set_bits = 0;
            while (number > 0)
            {
                if ((number & 1) == 1)
                {
                    set_bits++;
                }
                number >>= 1;
            }
            return set_bits;

        }

        public int swap_in_binary(int number, int a, int b)
        {
            int bit1 = (number >> a) & 1;
            int bit2 = (number >> b) & 1;
            if( bit1 != bit2)
            {
                number ^= (1 << a);
                number ^= (1 << b);
            }
            return convert_to_binary(number);
        }

        public int[] find_unique_non_repeating(int[] arr)
        {
            int[] result = new int[2];
            int xor = 0;
            foreach (int i in arr)
            {
                xor ^= arr[i];
            }
            int setBit = xor & -xor;
            int a = 0;
            int b = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                if ((arr[i]&setBit) != 0)
                {
                    a ^= arr[i];
                }
                else
                {
                    b ^= arr[i];
                }
            }
            result[0] = a;
            result[1] = b;
            return result;
        }


    }
}
