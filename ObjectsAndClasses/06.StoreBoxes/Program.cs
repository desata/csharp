using System;

namespace _06.StoreBoxes
{
    public class Item
    {
        //Define a class Item, which contains these properties: Name and Price.

        public string ItemName { get; set; }

        public double ItemPrice { get; set; }

        
    }
    public class Box 
    {
        //Define a class Box, which contains these properties: Serial Number, Item, Item Quantity, and Price for a Box.

        public int BoxSerialNumber { get; set; }

        public string BoxItem { get; set; }

        public int BoxItemQty { get; set; }

        public double BoxPrice { get; set; }
    }   


    internal class Program
    {
        static void Main(string[] args)
        {

        }
    }
}
