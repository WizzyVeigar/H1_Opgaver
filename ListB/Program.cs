using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListB
{
    class Program
    {
        static void Main(string[] args)
        {
            #region WithAList
            //List<int> list = new List<int>();
            //List<int> reverseList = new List<int>();

            //for (int i = 0; i < 20; i++)
            //{
            //    if (i % 2 == 0)
            //    {
            //        list.Add(i);                    
            //    }
            //}

            //for (int i = 0; i < list.Count; i++)
            //{
            //    if(list[i] % 3 == 0)
            //    {
            //        list.Remove(list[i]);
            //    }
            //}

            //Console.WriteLine("There are now " + list.Count + " numbers in the list");

            //list[2] = 17;
            //list.Reverse();

            //reverseList = list;

            //foreach (int item in reverseList)
            //{
            //    Console.WriteLine(item);
            //}

            //Console.ReadKey();
            #endregion

            int[] intArr = new int[] { 0, 2, 4, 6, 8, 10, 12, 14, 16, 18, 20 };

            for (int i = 0; i < intArr.Length; i++)
            {
                if(intArr[i] % 3 == 0)
                {
                    intArr[i] = 0;
                }
            }

            intArr[3] = 17;

            Console.WriteLine(intArr.Length);
            for (int i = 0; i < intArr.Length; i++)
            {
                Console.WriteLine(intArr[i]);
            }
            Console.ReadKey();
        }
    }
}
