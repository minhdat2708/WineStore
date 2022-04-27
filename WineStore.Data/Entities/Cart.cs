using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WineStore.Data.Entities
{
    public class Cart
    {
        public int id { get; set; }
        public int quantity { get; set; }
        public decimal price { get; set; }
        public int product_id { get; set; }

        public Product Product { get; set; }
    }
}
