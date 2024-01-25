using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace M2Notes
{
    internal class Program
    {
        private static void IncreaseValue(int x)
        {
            x = x + 25;
        }
        static void Main(string[] args)
        {
            int[] nums = { 2, 3, 4, 5 };
            for (int x = 3; x >= 0; --x)

                Write(nums[x]);
        }
    }
}
