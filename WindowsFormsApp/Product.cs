using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp
{
    public class Product
    {
        public string Category { get; set; }
        public string Name { get; set; }

        public Product(string name, string category)
        {
            Name = name;
            Category = category;
        }

        public override string ToString()
        {
            return Name;
        }
    }
}
