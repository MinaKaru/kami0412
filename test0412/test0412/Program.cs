using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test0412
{
    class Program
    {
        static void Main(string[] args)
        {
            // 設定字的顏色
            Console.ForegroundColor = ConsoleColor.Blue;
            
            // 設定底色
            Console.BackgroundColor = ConsoleColor.Black;
          
            //設Rand亂數
            Random Rand = new Random();

            //產生Number的list
            List<int> Numbers = new List<int>();

            //Numbers中加入數字1-42
            for (int i = 1; i <= 43; i++)
            {
                Numbers.Add(i);
            }

            //執行六次
            for (int i = 0; i < 6; i++)
            {
                //產生名為r的數(範圍:1-number的數量)
                int rand = Rand.Next(1, Numbers.Count);

                //寫下number中的第r個數字
                Console.Write(Numbers[rand]);
                Console.Write(",");

                //刪除使用過的數字
                Numbers.RemoveAt(rand);
            }

            Console.ReadLine();
        }
    }
}
