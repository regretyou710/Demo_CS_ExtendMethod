using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_CS_ExtendMethod
{
    static class MyList_ExtendMethod
    {
        //擴展一個取得集合中元素個數方法
        //this MyList3:表示想給哪一個對象進行擴展實例方法
        public static int GetCount(this MyList3 list)

        {
            int count = 0;
            var elements = list.GetEnumerator();
            while (elements.MoveNext())
            {
                count++;
            }
            return count;
        }


        //對IEnumerable<T>擴展一個ForEach方法
        //同時自訂類MyList3也實作IEnumerable<T>類，等於MyList3擴展了ForEach方法(多型)        
        public static void ForEach<T>(this IEnumerable<T> source, Action<T> func)
        {
            foreach (var item in source)
            {
                func(item);
            }
        }


        //針對不同類給予擴展方法
        public static int GetMinValue(this IEnumerable<int> list)            
        {            
            var elements = list.GetEnumerator();
            int min = list.First();
            while (elements.MoveNext())
            {
                if (elements.Current < min)
                {
                    min = elements.Current;
                }
            }
            return min;
        }
    }
}
