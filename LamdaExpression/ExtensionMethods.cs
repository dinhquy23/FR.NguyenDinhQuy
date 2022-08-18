using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LamdaExpression
{
    public static class ExtensionMethods
    {
        public static IEnumerable<T> Hehe<T>(this  IEnumerable<T> source,Func<T,bool> predicate)
        {
            List<T> result = new List<T>();
            foreach(var item in source)
            {
                if(predicate(item))
                {
                    result.Add(item);
                }
            }
            return result;
        }

        public static T? Haha<T>(this IEnumerable<T> source, Func<T, bool> predicate)
        {
            List<T> result = new List<T>();
            foreach (var item in source)
            {
                if (predicate(item))
                {
                    result.Add(item);
                }
            }
            if(result.Count == 0)
            {
                throw new Exception("no return result exists");
                return default(T);
            }
            else
            {
                return result[0];
            }
        }
        //public static IEnumerable<T> SelectCustom<T>(this List<T> employees, Func<T, bool> selector)
        //{
        //    List<T> result = new List<T>();
        //    foreach (var item in employees)
        //    {
        //        if (selector(item))
        //        {
        //            result.Add(item);
        //        }
        //    }
        //    return result;
        //}
    }
}
