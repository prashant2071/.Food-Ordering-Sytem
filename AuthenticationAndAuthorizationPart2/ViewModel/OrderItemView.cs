﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AuthenticationAndAuthorizationPart2.ViewModel
{
    public class OrderItemView
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public string photo  { get; set; }
        public  int price  { get; set; }
    }
}