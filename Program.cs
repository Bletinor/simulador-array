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
            Console.WriteLine(readTableCell(tableArr, 2, 4));
        }

        static int[] declareTable(int rows, int columns)
        {
            int size = rows * columns;
            int[] tableArr = new int[size];
            for (int i = 0; i < size; i++)
            {
                tableArr[i] = i;
            }
            return tableArr;
        }

        static int readTableCell(int[] array, int row, int column)
        {
            return array[row * column];
        }

        /*static writeTableCell()
        {

        }*/
    }
}
