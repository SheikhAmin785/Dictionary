using System;
using System.Collections.Generic;

namespace Dictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            IDictionary<int, string> employees = new Dictionary<int, string>();
            employees.Add(1, "alamin");
            employees.Add(2, "jamal");
            employees.Add(3, "kamal");
            foreach(var item in employees)
            {
                Console.WriteLine("key = {0} and value = {1}",item.Key,item.Value);
            }
            var cities = new Dictionary<string, string>
            {
                { "UK", "london,barminghan,manchester" },
                { "usa", "newyork,miami,california" },
                { "Bangladesh", "dhaka,tangail,chittagong" }
            };
            foreach(var items in cities)
            {
                Console.WriteLine("ky={0} and value={0}",items.Key,items.Value);
            }
    }
}
