using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.queue
{
    internal class Queue
    {
        static int[] GiaiBaiVongTron(int n, int k)
        {
            Queue<int> q = new Queue<int>();
            int[] result = new int[n];
            int index = 0;

            for (int i = 1; i < n; i++)
            {
                q.Enqueue(i);
            }
            while (q.Count > 0)
            {
                for (int i = 1; i < k; i++)
                {
                    q.Enqueue(q.Dequeue());
                }
                result[index++] = q.Dequeue();
            }
            return result;
        }
        private static void Main1(string[] args)
        {
            int n = 7;
            int k = 3;
            int[] kq = GiaiBaiVongTron(n, k);
            Console.WriteLine("Thu tu loai: ");
            for (int i = 0; i < n - 1; i++)
            {
                Console.WriteLine(kq[i]);
            }
            Console.WriteLine("Nguoi cuoi cung con lai: " + kq[n - 1]);
        }
    }
}