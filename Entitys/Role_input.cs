using System;
using System.Collections.Generic;
using System.Text;

namespace MAVA.Entitys
{
    public class Role_input
    {
        public int id { get; set; }
        public string input_on { get; set; }
        public string input_off { get; set; }
        public string no { get; set; }

    }

    public class Role_input_kontrol : Role_input
    {
        public string role { get; set; }
        public string port { get; set; }
        public string ip { get; set; }
    }
}
