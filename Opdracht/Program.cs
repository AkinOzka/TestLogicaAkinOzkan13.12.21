using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opdracht
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] Left = new int[] {1,3,2,6,9};
            int[] Right = new int[] { 0, 0, 0, 0, 0 };

            for (int i = 0; i < Left.Length; i++)
            {
                Console.WriteLine(Right.CopyTo(Left[]));
            }
        }
    }
}
