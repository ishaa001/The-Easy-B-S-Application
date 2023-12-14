﻿using System;
using System.Collections.Generic;
using System.Text;

namespace OnlineBuySell.Models
{
    public class HotAndNewAd
    {
        public int id { get; set; }
        public string title { get; set; }
        public double price { get; set; }
        public string model { get; set; }
        public string company { get; set; }
        public bool isFeatured { get; set; }
        public string imageUrl { get; set; }
        public string FullImageUrl => $"http://buysellapp.azurewebsites.net/{imageUrl}";
    }
}
