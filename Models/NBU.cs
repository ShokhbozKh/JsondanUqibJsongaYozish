﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4.Models
{
    
    // Root myDeserializedClass = JsonConvert.DeserializeObject<List<Root>>(myJsonResponse);
    public class NBU
    {
        public string title { get; set; }
        public string code { get; set; }
        public string cb_price { get; set; }
        public string nbu_buy_price { get; set; }
        public string nbu_cell_price { get; set; }
        public string date { get; set; }
    }
}
