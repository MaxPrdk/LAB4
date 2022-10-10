using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThirdTask
{
    public class Tech
    {
        public int Price { get; set; }
        public int Performance { get; set; }

        public virtual void ShowPoperties()
        {
            Console.WriteLine(GetType().Name);
            foreach (var propertyInfo in GetType().GetProperties())
            {
                Console.WriteLine($"{propertyInfo.PropertyType} {propertyInfo.Name}");
            }
            Console.WriteLine();
        }
    }
}