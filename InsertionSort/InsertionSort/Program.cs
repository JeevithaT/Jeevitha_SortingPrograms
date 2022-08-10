using System;
namespace InsertionSort
{
    public class Insertion
    {
        int[] array = new int[5] {12, 11, 13, 5, 6};
        public int holePosition;
        public int valueToInsert;

        public void Sort()
        {
            for(int i = 1; i < array.Length; i++)
            {
                valueToInsert = array[i];
                holePosition = i;
                while(holePosition > 0 && array[holePosition - 1] > valueToInsert)
                {
                    array[holePosition] = array[holePosition - 1];
                    holePosition = holePosition - 1;
                }
                array[holePosition] = valueToInsert;
            }
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine("Insertion Sort: "+array[i]);
            }


        }
    }


    public class Program
    {
        public static void Main(string[] args)
        {
            Insertion obj = new Insertion();
            obj.Sort();
        }
    }
}
