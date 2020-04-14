using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestDLL
{
    public class funzioni
    {
        public static void bubblesort(int[] eletemperature, int num)
        {
            bool scambio = true;
            int y = default(int);
            int x = default(int);
            int temp = default(int);

            while (y < 365 && scambio == true)
            {
                scambio = false;
                x = y + 1;

                while (x < 365)
                {
                    if (eletemperature[y] > eletemperature[x])
                    {
                        temp = eletemperature[y];
                        eletemperature[y] = eletemperature[x];
                        eletemperature[x] = temp;

                        scambio = true;

                    }
                    x = x + 1;
                }
                y = y + 1;

            }

        }

        public static void quicksort(int[] eletemperature, int left, int right)
        {

            var pivot = eletemperature[(left + right) / 2];
            int i = left;
            int j = right;

            while (i <= j)
            {

                while (eletemperature[i] < pivot)
                {
                    i = i + 1;
                }
                while (eletemperature[j] > pivot)
                {
                    j = j - 1;
                }
                if (i <= j)
                {
                    var temp = eletemperature[i];
                    eletemperature[i] = eletemperature[j];
                    eletemperature[j] = temp;

                    i = i + 1;
                    j = j - 1;
                }
            }

            if (left < j)
            {
                quicksort(eletemperature, left, j);
            }
            if (i < right)
            {
                quicksort(eletemperature, i, right);

            }
        }


        public static void selectionsort(int[] eletemperature, int num)
        {
            int x = default(int);
            int y = default(int);
            int temp = default(int);

            while (x < num)
            {
                y = x + 1;

                while (y < num)
                {
                    if (eletemperature[x] > eletemperature[y])
                    {
                        temp = eletemperature[x];
                        eletemperature[x] = eletemperature[y];
                        eletemperature[y] = temp;
                    }
                    y = y + 1;
                }

                x = x + 1;
            }

        }
    }
}

    

