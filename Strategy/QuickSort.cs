using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    public class QuickSort:SortingStrategy
    {
        public void sort(int[] arr)
        {
            Console.WriteLine("performing quick sort");
        }
    }
}
