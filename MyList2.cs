using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_CS_ExtendMethod
{
    class MyList2 : IEnumerable<int>
    {
        public IEnumerator<int> GetEnumerator()
        {
            yield return 11;
            yield return 2;
            yield return 15;
            yield return 26;
            yield return 18;
            yield return 20;
            yield return 3;
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        //建立一個取得集合中元素個數方法
        public int GetCount()
        {
            int count = 0;

            //方式一
            //foreach (var i in this)
            //{
            //    count++;
            //}

            //方式二:使用迭代器
            var elements = this.GetEnumerator();
            while (elements.MoveNext())
            {
                count++;
            }
            return count;
        }


        //建立一個返回集合中最大值的方法
        public int GetMaxValue()
        {
            int max = int.MinValue;
            var elements = this.GetEnumerator();
            while (elements.MoveNext())
            {
                if (elements.Current > max)
                {
                    max = elements.Current;
                }
            }
            return max;
        }
    }
}
