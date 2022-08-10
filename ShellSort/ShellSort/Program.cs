using System;
namespace ShellSort
    {
public class Shell
    {
        int[] arr = new int[5] { 12, 34, 54, 2, 3 };
        public int interval = 1, valueToInsert, inner;
        public void Sort()
        {
            while(interval < arr.Length / 3)
            {
                interval = interval * 3 + 1;
            }
            while (interval > 0)
            {
                for(int outer = interval; outer < arr.Length; outer++)
                {
                    valueToInsert = arr[outer];
                    inner = outer;
                    while(inner > interval - 1 && arr[inner - interval] >= valueToInsert)
                    {
                        arr[inner] = arr[inner - interval];
                        inner = inner - interval;
                    }
                    arr[inner] = valueToInsert;

                }
                interval = (interval - 1) / 3;
            }
            for (int outer = interval; outer < arr.Length; outer++)
            {
                Console.WriteLine("Sorted Arrays: " + arr[outer]);

            }
        }
    }





public class Program
{
    public static void Main(string[] args)
    {
            Shell obj = new Shell();
            obj.Sort();
    }
}
}