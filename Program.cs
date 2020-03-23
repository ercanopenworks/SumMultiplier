using System;

namespace SumMultiplier
{
    class Program
    {
        //    public static bool SumMultiplier(int[] arr)
        //    {

        //        // code goes here
        //        bool result = false;
        //        int sumArr = 0;
        //        foreach (var item in arr)
        //        {
        //            sumArr += item;

        //        }
        //        sumArr *= 2;

        //        for(int i = 0; i < arr.Length - 1; i++)
        //        {
        //            for(int j = i + 1; j < arr.Length; j++)
        //            {
        //                if (arr[i] * arr[j] > sumArr)
        //                {
        //                    result = true;
        //                    return result;
        //                }
        //            }
        //        }
        //        result = false;

        //        return result;

        //    }


        //        // keep this function call here

        //    static void Main(string[] args)
        //    {
        ////int[] itemArr = Array.ConvertAll(Console.ReadLine().Split(' '), aTemp => Convert.ToInt32(aTemp));
        ////itemArr = Array.ConvertAll("1, 1, 2, 10, 3, 1, 12".Split(','), aTemp => Convert.ToInt32(aTemp));

        //        int[] itemArr;
        //        itemArr = Array.ConvertAll(Console.ReadLine().ToString().Split(','), aTemp => Convert.ToInt32(aTemp));
        //        Console.WriteLine(SumMultiplier(itemArr));
        //        Console.ReadLine();
        //    }
        //}

        public static bool SumMultiplier(int[] arr)
        {

            // code goes here
            bool result = false;
            int sumArr = 0;
            foreach (var item in arr)
            {
                sumArr += item;

            }
            sumArr *= 2;

            for (int i = 0; i < arr.Length - 1; i++)
            {
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[i] * arr[j] > sumArr)
                    {
                        result = true;
                        return result;
                    }
                }
            }
            result = false;

            return result;

        }

        static void Main()
        {
            // keep this function call here
            //Console.WriteLine(SumMultiplier(Console.ReadLine()));

            int[] itemArr = Array.ConvertAll(Console.ReadLine().ToString().Split(','), aTemp => Convert.ToInt32(aTemp));
            Console.WriteLine(SumMultiplier(itemArr));
            Console.ReadLine();

        }

    }
}
