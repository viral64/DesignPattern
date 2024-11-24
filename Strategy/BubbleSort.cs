using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    public class BubbleSort:SortingStrategy
    {
        public void sort(int[] arr)
        {
            Console.WriteLine("Bubble Sort performing");
        }
    }
}
