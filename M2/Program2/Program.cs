using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
using System.Diagnostics; //for using stopwatch to time quicksort algo
using System.IO; //for files

namespace Program2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string filepath = "case8.in";
            string[] file_input = File.ReadAllLines(filepath);

            int size = int.Parse(file_input[0]);

            float[] numArray = new float[size];
            string[] inputArray = file_input[1].Split(' ');

            for (int i = 0; i < size; i++)
            {
                numArray[i] = float.Parse(inputArray[i]);
            }

            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            Quicksort(numArray, 0, size - 1);

            stopwatch.Stop();

            //comment this for loop to not see the full sorted array and just the running time (it will print 5000 numbers to your console)
            for (int i = 0; i < size; i++) 
            {
                Write(numArray[i] + " ");
            }
            WriteLine("");
            WriteLine("The total time for the algorithm to sort was: " + stopwatch.ElapsedMilliseconds + "milliseconds, which is less than 1 second running time.");

        }

        //Standard Quicksort Algorithm, O(nlogn)
        static void Quicksort(float[] array, int low, int high)
        {
            if (low < high)
            {
                int partitionIndex = Partition(array, low, high);

                Quicksort(array, low, partitionIndex - 1);
                Quicksort(array, partitionIndex + 1, high);
            }
        }

        static int Partition(float[] array, int low, int high)
        {
            float pivot = array[high];
            int i = low - 1;

            for (int j = low; j < high; j++)
            {
                if (array[j] <= pivot)
                {
                    i++;
                    Swap(array, i, j);
                }
            }

            Swap(array, i + 1, high);
            return i + 1;
        }

        static void Swap(float[] array, int i, int j)
        {
            float temp = array[i];
            array[i] = array[j];
            array[j] = temp;
        }


    }
}
