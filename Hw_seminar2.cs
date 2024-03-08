using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*Дан двумерный массив.
732
496
185

Отсортировать данные в нем по возрастанию.
123
456
789

Вывести результат на печать.*/
/*class Program
{
    static void Main(string[] args)
    {
        int[,] a = { { 7, 3, 2 }, { 4, 9, 6 }, { 1, 8, 5 } };
    }
}*/
namespace Immersion_C_
{
    internal class Hw_seminar2
    {
        public void hw_seminar2()
        {
            int[,] a = { { 7, 3, 2 }, { 4, 9, 6 }, { 1, 8, 5 } };

            SortAndPrintArray(a);
        }

        static void SortAndPrintArray(int[,] array)
        {
            int rowCount = array.GetLength(0);
            int colCount = array.GetLength(1);

            int[] tempArray = new int[rowCount * colCount];
            int index = 0;


            for (int i = 0; i < rowCount; i++)
            {
                for (int j = 0; j < colCount; j++)
                {
                    tempArray[index] = array[i, j];
                    index++;
                }
            }

            Array.Sort(tempArray);
            index = 0;

            for (int i = 0; i < rowCount; i++)
            {
                for (int j = 0; j < colCount; j++)
                {
                    array[i, j] = tempArray[index];
                    index++;
                }
            }

            PrintArray(array);
        }

        static void PrintArray(int[,] array)
        {
            int rowCount = array.GetLength(0);
            int colCount = array.GetLength(1);

            for (int i = 0; i < rowCount; i++)
            {
                for (int j = 0; j < colCount; j++)
                {
                    Console.Write(array[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}

