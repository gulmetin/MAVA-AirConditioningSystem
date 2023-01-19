using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace MAVA.Entitys
{
    public class Device
    {
        public int id { get; set; }
        public string odano { get; set; }
        public string cihazno { get; set; }
        public string cihazport { get; set; }
        public string klimano { get; set; }
       
    }

    public class ButonDevice : Device
    {
        public Color renk { get; internal set; }
        public int satisid { get; internal set; }
        public string durum { get; set; }
    }
}
