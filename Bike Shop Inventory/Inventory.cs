using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MorrisAaron_C968_Task1
{
    static class Inventory
    {

        public static BindingList<Product> Products = new BindingList<Product>();

        public static BindingList<Part> AllParts = new BindingList<Part>();

        static Inventory()
        {
            AllParts.Add(
                new Inhouse { partID = 0, name = "Wheel", inStock = 15, price = 12.11, min = 5, max = 25 }
                );
            AllParts.Add(
                new Inhouse { partID = 1, name = "Pedal", inStock = 11, price = 8.22, min = 5, max = 25 }
                );
            AllParts.Add(
                new Inhouse { partID = 2, name = "Chain", inStock = 12, price = 8.33, min = 5, max = 25 }
                );
            AllParts.Add(
                new Inhouse { partID = 3, name = "Seat", inStock = 8, price = 4.55, min = 2, max = 15 }
                );
            Products.Add(
                new Product { productID = 0, name = "Red Bicycle", inStock = 15, price = 11.44, min = 1, max = 25}
                );
            Products.Add(
                new Product { productID = 1, name = "Yellow Bicycle", inStock = 19, price = 9.66, min = 1, max = 20 }
                );
            Products.Add(
                new Product { productID = 2, name = "Blue Bicycle", inStock = 5, price = 12.77, min = 1, max = 25 }
                );
        }




        //void addProduct(Product)
        // bool removeProduct(int)
        // Product lookupProduct(int)
        // void updateProduct(int, Product)
        static public void addPart(Part newPart)
        {
            AllParts.Add(
               newPart 
               );
        } 
     
        //bool deletePart(Part)
        //Part lookupPart(int)
        //void updatePart(int, Part)
    }
}
