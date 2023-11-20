using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dictionary
{
    class Example
    {
        IDictionary<int, string> str = new Dictionary<int, string>();
        IReadOnlyCollection<KeyValuePair<int, string>> str1 =
            new Dictionary<int, string>();
        IReadOnlyDictionary<int, string> str2 = new Dictionary<int, string>();
        IDictionary<int ,string> //interface
       (IDictionary<int,string>, IEqualityComparer<int>)str3=new Dictionary<int,string>();
        (IEqualityComparer<int>)


    }
}
