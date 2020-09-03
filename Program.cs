using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_CS_ExtendMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            var list1 = new MyList1();
            Console.WriteLine(list1.GetCount());
            Console.WriteLine(list1.GetMaxValue());


            Console.WriteLine("------------------");


            var list2 = new MyList2();
            Console.WriteLine(list2.GetCount());
            Console.WriteLine(list2.GetMaxValue());


            Console.WriteLine("------------------");


            var list3 = new MyList3();
            Console.WriteLine(list3.GetCount());
            list3.ForEach(i => Console.WriteLine(i));


            Console.WriteLine("------------------");


            //因為都實作IEnumerable所以都有GetMinValue方法
            Console.WriteLine(list1.GetMinValue());
            Console.WriteLine(list2.GetMinValue());
            Console.WriteLine(list3.GetMinValue());


            Console.WriteLine("---------Linq擴展方法操作---------");


            var patent = PatentData.Patents;
            //因為陣列有實作IEnumerable<T>，所以有Where擴展方法
            var result1 = patent.Where(p => Convert.ToInt32(p.YearOfPublication) < 1850);
            Print(result1);


            Console.WriteLine("---------Linq擴展方法操作---------");


            //Select擴展方法使用
            //取得目錄下的檔案名稱
            var filePaths = Directory.GetFiles(@"C:\");
            var result2 = filePaths.Select(delegate (string filePath)
                {
                    var fileInfo = new FileInfo(filePath);
                    //使用匿名類返回，裡面有檔案的名稱和大小的屬性
                    return new { fileInfo.Name, fileInfo.Length };
                }
            );
            Print(result2);


            Console.WriteLine("---------Linq擴展方法操作---------");


            //Count擴展方法使用
            //查詢出19世紀的專利個數
            Console.WriteLine(patent.Count(p => p.YearOfPublication.StartsWith("18")));


            Console.WriteLine("---------Linq擴展方法操作---------");


            //OrderBy、ThenBy擴展方法使用
            //將發明家按照國家排序再按人名排序
            var inventors = PatentData.Inventors;
            var result3 = inventors.OrderBy(i => i.Country).ThenBy(i => i.Name);
            Print(result3);


            Console.WriteLine("---------Linq擴展方法操作---------");


            //GroupBy擴展方法使用
            //將發明家按國家分組
            var groups = inventors.GroupBy(p => p.Country);
            foreach (var g in groups)
            {
                Console.WriteLine($"{g.Key}組個數:{g.Count()}");
                foreach (var elements in g)
                {
                    Console.WriteLine("\t" + elements.Name);
                }
            };


            Console.WriteLine("---------Linq擴展方法操作---------");


            //Join擴展方法使用
            //專利中有發明家的ID，找出名字+專利
            var result4 = patent.Join(inventors, p => p.InventorIds[0], i => i.Id, (p, i) => new { i.Name, p.Title });
            Print(result4);


            Console.ReadKey();
        }
        public static void Print<T>(IEnumerable<T> source)
        {
            foreach (T item in source)
            {
                Console.WriteLine(item);
            }
        }
    }

}
