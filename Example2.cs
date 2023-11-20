using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dictionary
{
    class Example2
    {

        public void Add()
        {
            Dictionary<int, string> n = new Dictionary<int, string>();
            n.Add(1, "alamin");
        }
      public void removee()
        {
            Dictionary<int, string> R = new Dictionary<int, string>();
            {
                R.Add(1, "alamin");
                R.Add(2,"jamal");
                R.Add(3, "rakib");

                Dictionary<int, string>.KeyCollection keys = R.Keys;

                foreach(string item in keys)
                {
                    Console.WriteLine(" ",item);
                }


                foreach(KeyValuePair<int,string> item in R)
                {
                    Console.WriteLine($"key={item} and value={item}");
                }


                if (R.ContainsKey(1) == true)
                {
                    Console.WriteLine("key is found");
                }
                else
                {
                    Console.WriteLine("key is not found");
                }

                R.Remove(1);//key delete
                foreach(KeyValuePair<int,string>c in R)
                {
                    Console.WriteLine($"key={c}and value={c}");
                }
                R.Clear();
                Console.WriteLine("total number of key and value"+"pair present in R{0}",R.Count);

            }
        }
    }
}
