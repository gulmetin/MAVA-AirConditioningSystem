using System;
using System.Collections.Generic;
using System.Text;

namespace MAVA.Entitys
{
    public class Page
    {
        public int id { get; set; }
        public int modulid { get; set; }
        public string moduladi { get; set; }
        public string adi { get; set; }
        public bool ekle { get; set; }
        public bool cikar { get; set; }
        public bool guncelle { get; set; }
    }

}
