using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WineStore.Data.Enums;

namespace WineStore.Data.Entities
{
    public class Order
    {
        public int id { get; set; }
        public DateTime order_date { get; set; }
        public decimal total_price { get; set; }
        public string ship_name { get; set; }
        public string ship_address { get; set; }
        public string ship_email { get; set; }
        public string ship_phone { get; set; }
        public OrderStatus status { get; set; }
        public int user_id { get; set; }

        public List<OrderDetail> orderDetails { get; set; }
    }
}
