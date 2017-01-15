using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.ArrayLogic
{
    public static class ArrayIO
    {
        public static void PrintArray(object array, StreamWriter writer = null)
        {
            if (typeof(int[][]) == array.GetType())
            {
                //Type pointer for easy method reading/ usage
                int[][] typedArray = (int[][])array;

                for (int i = 0; i < typedArray.Length; i++)
                {
                    if (writer != null)
                    {
                        writer.WriteLine(string.Join("", typedArray[i]));
                    }

                    Console.WriteLine(string.Join("", typedArray[i]));
                }

                if (writer != null)
                {
                    writer.WriteLine();
                }

                Console.WriteLine();
            }
        }
    }
}
