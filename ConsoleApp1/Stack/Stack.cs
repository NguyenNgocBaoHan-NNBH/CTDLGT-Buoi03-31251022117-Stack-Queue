using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Stack
{
    internal class Stack
    {
        static int[] NhietDoHangNgay(int[] a)
        {
            int n = a.Length;
            int[] result = new int[n];
            Stack<int> stack = new Stack<int>();

            for (int i = 0; i < n; i++)
            {
                while (stack.Count > 0 && a[i] > a[stack.Peek()])
                {
                    int ngay = stack.Pop();
                    result[ngay] = i - ngay;
                }
                stack.Push(i);
            }
            return result;
        }
        private static void Main(string[] args)
        {
            int[] a = { 73, 74, 75, 71, 69, 72, 76, 73 };
            int[] result = NhietDoHangNgay(a);
            Console.WriteLine("Ket qua: " + string.Join(" ", result));
        }
    }
}