namespace App.Extensions
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public static class IEnumerableExtensionMethods
    {
        public static double SumOf<T>(this IEnumerable<T> collection, Func<T, double> selector)
            where T : IComparable, IFormattable, IConvertible
        {
            double sum = default(double);

            foreach (var item in collection)
            {
                sum += Convert.ToDouble(item);
            }

            return sum;
        }
        public static decimal ProductOf<T>(this IEnumerable<T> collection, Func<T, decimal> selector)
            where T : IComparable, IFormattable, IConvertible
        {
            decimal product = 1m;

            foreach (var item in collection)
            {
                product *= Convert.ToDecimal(item);
            }

            return product;
        }
        public static T MinOf<T>(this IEnumerable<T> collection)
            where T : IComparable<T>, IEquatable<T>
        {
            T min = default(T);
            int itemsCount = 0;

            foreach (var item in collection)
            {
                if (itemsCount == 0 || min.CompareTo(item) > 0)
                {
                    min = item;
                }

                itemsCount++;
            }

            return min;
        }
        public static T MaxOf<T>(this IEnumerable<T> collection)
            where T : IComparable<T>, IEquatable<T>
        {
            T max = default(T);
            int itemsCount = 0;

            foreach (var item in collection)
            {
                if (itemsCount == 0 || max.CompareTo(item) < 0)
                {
                    max = item;
                }

                itemsCount++;
            }

            return max;
        }
        public static double AverageOf<T>(this IEnumerable<T> collection, Func<T, double> selector)
            where T : IComparable, IFormattable, IConvertible
        {
            double avg = default(double);
            double sum = 0.0;
            int itemsCount = 0;

            foreach (var item in collection)
            {
                sum += Convert.ToDouble(item);
                itemsCount++;
            }

            return avg = sum / itemsCount;
        }
        public static string ToString<T>(this IEnumerable<T> collection)
        {
            StringBuilder builder = new StringBuilder();
            builder.Append("{ ");

            foreach (var item in collection)
            {
                builder.Append(item);
                builder.Append(", ");
            }

            builder.Remove(builder.Length - 2, 2);
            builder.Append(" }");

            return builder.ToString();
        }
    }
}