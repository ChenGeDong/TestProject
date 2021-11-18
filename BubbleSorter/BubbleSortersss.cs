using System;
using System.Collections.Generic;
using System.Text;

namespace BubbleSorter
{

    class BubbleSortersss
    {
        //BubbleSort冒泡算法
        void bubblesort(int[] sortArray)
        {
            bool swapped = true;
            do
            {
                swapped = false;
                for (int i = 0; i < sortArray.Length; i++)
                {
                    if(sortArray[i]>sortArray[i+1])
                    {
                        int temp = sortArray[i];
                        sortArray[i] = sortArray[i + 1];
                        sortArray[i + 1] = temp;
                        swapped = true;
                    }
                }

            } while (swapped);
        }
    }
}
