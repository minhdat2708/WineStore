using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WineStore.Data.Entities
{
    public class Product
    {
        public int id { get; set; }
        public string name { get; set; }
        public string description { get; set; }
        public DateTime mfg { get; set; }
        public string brand { get; set; }
        public int capacity { get; set; }
        public string origin { get; set; }
        public int concentration { get; set; }
        public int current_quantity { get; set; }
        public decimal original_price { get; set; }
        public int category_id { get; set; }

        public Category Category { get; set; }

        public List<OrderDetail> orderDetails { get; set; }

        public List<Cart> Carts { get; set; }
    }
}
