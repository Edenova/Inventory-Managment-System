using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eden_Piatnichko
{
    //This is a subclass of Part and has Company Name as a string
    class OutsourcedPart : Part
    {
        public string CompanyName { get; set; }

        public OutsourcedPart(int partID, string name, int inStock, decimal price, int max, int min, string compName) {
            PartID = partID;
            Name = name;
            InStock = inStock;
            Price = price;
            Max = max;
            Min = min;
            CompanyName = compName;

        }
        
    }
}
