using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryManagementSystemPro
{
    internal class Products
    {
        public int priceId {  get; set; }
        public string productName { get; set; }

        public string productNumber {  get; set; }
        public bool producttaken { get; set; }=false;
        public Products() {
        
        }
        public Products(int price,string name,string productnumber)
        {
            priceId = price;
            productName = name;
            productNumber = productnumber;
        }
    }
}
