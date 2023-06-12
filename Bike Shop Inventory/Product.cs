using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MorrisAaron_C968_Task1
{
    class Product
    {
        public int productID { get; set; }

        public string name { get; set; }

        public double price { get; set; }

        public int inStock { get; set; }

        public int min { get; set; }

        public int max { get; set; }

        public static BindingList<Part> AssociatedParts = new BindingList<Part>();


        //void addAssociatedPart(Part);
        //bool removeAssociatedPart(int);
        //Part lookupAssociatedPart(int);
    }
}
