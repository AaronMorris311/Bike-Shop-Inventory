﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MorrisAaron_C968_Task1
{
    abstract class Part
    {
        public int partID { get; set; }
        public string name { get; set; }
        public double price { get; set; }
        public int inStock { get; set; }
        public int min { get; set; }
        public int max { get; set; }


       
    }
}
