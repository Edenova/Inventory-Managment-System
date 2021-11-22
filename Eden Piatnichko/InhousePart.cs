using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eden_Piatnichko
{// This is a subclass of Part and has MachineID as an Int
    class InhousePart : Part
    {
        public int MachineID { get; set; }


        public InhousePart(int partID, string name, int inStock, decimal price, int max, int min, int machineID)
        {
            PartID = partID;
            Name = name;
            InStock = inStock;
            Price = price;
            Max = max;
            Min = min;
            MachineID = machineID;



        }
    }
}
