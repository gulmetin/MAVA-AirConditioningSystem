using System;
using System.Collections.Generic;
using System.Text;

namespace MAVA.Entitys
{
    public class Price
    {
        public int id { get; set; }
        public int gun { get; set; }
        public float tl { get; set; }
        public float gbp { get; set; }
        public float euro { get; set; }
        public float usd { get; set; }
        public string baslik { get; set; }
    }
}
