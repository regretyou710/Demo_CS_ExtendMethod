using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_CS_ExtendMethod
{
    /*
     在程式碼已經封閉的情況下想再添加方法，則使用擴展方法
     步驟:
     1. 定義靜態類
     2. 定義靜態方法
     3. 使用this關鍵字指示實例化對象
     */
    class MyList3 : IEnumerable<int>
        
    {
        public IEnumerator<int> GetEnumerator()
        {
            yield return 1;
            yield return 9;
            yield return 5;
            yield return 6;
            yield return 3;
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return null;
        }
    }
}
