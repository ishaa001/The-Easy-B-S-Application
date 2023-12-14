using System;
using System.Collections.Generic;
using System.Text;

namespace OnlineBuySell.Models
{
    public class UserImageModel
    {
        public string imageUrl { get; set; }

        public string FullImagePath => $"http://buysellapp.azurewebsites.net/{imageUrl}";
    }
}
