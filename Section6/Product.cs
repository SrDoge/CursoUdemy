using System;
using System.Collections.Generic;
using System.Text;

namespace Section6
{
    class Product
    {
        public string Name { get; set; }
        public double Price { get; set; }

        public static implicit operator double(Product v)
        {
            throw new NotImplementedException();
        }
    }
}
