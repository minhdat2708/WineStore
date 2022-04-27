﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WineStore.Data.Entities
{
    public class Category
    {
        public int id { get; set; }
        public string name { get; set; }

        public List<Product> Products { get; set; }
    }
}
