using System;
namespace BubbleSort
{




public class Bubble
{
    int[] arr = new int[5] { 50, 40, 20, 30, 10 };
        public int temp;
        public void Sort()
        {
            for (int i = 0; i < 5; i++)
            {
                for (int j = i + 1; j < 5; j++)
                {
                    if (arr[j] < arr[i])
                    {
                        temp = arr[i];
                        arr[i] = arr[j];
                        arr[j] = temp;

                    }

                }
            }
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Bubble Sorting: "+arr[i]);
            }
        }

}
public class Program
{
    public static void Main (string[] args)
    {
            Bubble obj = new Bubble();
            obj.Sort();

    }
}
}