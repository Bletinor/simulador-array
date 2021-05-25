using System;

namespace simulador_array
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] tableArr = declareTable(2, 5);
            foreach (var item in tableArr)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine(readTableCell(tableArr, 2, 3));
            Console.WriteLine(writeTableCell(tableArr, 2, 3, 25));
            foreach (var item in tableArr)
            {
                Console.WriteLine(item);
            }
        }

        static int[] declareTable(int row, int column)
        {
            int size = row * column;
            int[] tableArr = new int[size];
            for (int i = 0; i < size; i++)
            {
                tableArr[i] = i;
            }
            return tableArr;
        }

        static int readTableCell(int[] array, int row, int column)
        {
            return array[(2 * row) + column];
        }

        static int writeTableCell(int[] array,  int row, int column, int value)
        {
            int placeHolder = array[(2 * row) + column];
            array[(2 * row) + column] = value;
            return placeHolder;
        }
    }
}
