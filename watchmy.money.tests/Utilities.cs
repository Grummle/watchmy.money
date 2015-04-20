using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace watchmy.money.tests
{
    public static class Utilities
    {
        public static string RandyString(this Random randy, int length)
        {
            var chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            var random = new Random();
            return new string(
                Enumerable.Repeat(chars, length)
                          .Select(s => s[randy.Next(s.Length)])
                          .ToArray());
        }

        public static decimal RandyDecimal(this Random randy, decimal min = 0, decimal max = 500, int prec = 2)
        {
            var next = randy.NextDouble();

            var val = (min + (decimal)next * (max - min));

            return decimal.Round(val, prec, MidpointRounding.AwayFromZero);
        }

        public static void ForEach<T>(this IEnumerable<T> source, Action<T> action)
        {
            foreach (T item in source)
                action(item);
        }
    }
}
