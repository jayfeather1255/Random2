using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_20180412
{
    class Program
    {
        static void Main(string[] args)
        {
            // 建立一個空的List
            List<int> number = new List<int>();

            // 在List裡放入1~42的數字       
            for (int i = 1; i < 43; i++)
            {
                number.Add(i);
            }

            // 產生亂數物件
            Random rand = new Random();            
            for (int i = 0; i < 6; i++)
            {
                // 隨機挑選"剩下的"其中一個印出
                int r = rand.Next(1, number.Count);
                Console.Write(number[r]+" ");
                
                // 從List中刪除
                number.RemoveAt(r);                                  
            }

            // 暫停畫面
            Console.Read();
        }
    }
}
