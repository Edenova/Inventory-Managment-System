using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eden_Piatnichko
{// UML abstract Part class. Inhouse and Outsource subclasses use this class
   public abstract class Part
    {
      /*  private int partID { get; set; }
        private string name { get; set; }
        private decimal price { get; set; }
        private int inStock { get; set; }
        private int min { get; set; }
        private int max { get; set; } */ 


        public int PartID { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int InStock { get; set; }
        public int Min { get; set; }
        public int Max { get; set; }






    }
}
