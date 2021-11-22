using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace Eden_Piatnichko
{
    public class Inventory
    {
        //UML Class diagram Inventory
        public static BindingList<Part> parts = new BindingList<Part>();
        public static BindingList<Product> products = new BindingList<Product>();

        public static void Partslist()
        {
            //Parts used in main screen datagridview

            Part part1 = new InhousePart(0, "Wheel", 15, 12.11m, 25, 5, 0001);
            Part part2 = new InhousePart(1, "Pedal", 11, 8.22m, 25, 5, 0001);
            Part part3 = new InhousePart(2, "Chain", 15, 8.33m, 25, 5, 0001);
            Part part4 = new InhousePart(3, "Seat", 15, 4.55m, 15, 2, 0001);
            Part part5 = new OutsourcedPart(4, "OS Part 1", 10, 11.00m, 25, 5, "BikeShop");
            Part part6 = new OutsourcedPart(5, "OS Part 2", 15, 14.00m, 25, 5, "BikeShop");
            Part part7 = new OutsourcedPart(6, "OS Part 3", 11, 12.00m, 25, 5, "PartrShop");
            Part part8 = new OutsourcedPart(7, "OS Part 4", 10, 13.00m, 25, 5, "Partshop");

            parts.Add(part1);
            parts.Add(part2);
            parts.Add(part3);
            parts.Add(part4);




        }

        public static void Productlist()
        {
            //Products used in main screen datagridview

            Product prod1 = new Product(0, "Red Bicycle", 15, 11.44m, 1, 25);
            Product prod2 = new Product(1, "Yellow Bicycle", 19, 9.66m, 1, 20);
            Product prod3 = new Product(2, "Blue Bicycle", 5, 12.77m, 1, 25);

            products.Add(prod1);
            products.Add(prod2);
            products.Add(prod3);

        }
        // UML Inventory list
        public static void AddProduct(Product product)
        {
            products.Add(product);
        }
        public static bool RemoveProduct(int ProductID)
        {
            foreach (var product in products)
            {
                if (product.ProductID == ProductID)
                {
                    products.Remove(product);
                    return true;
                }
            }
            return false;
        }
        public static Product LookupProduct(int ProductID)
        {
            foreach (var product in products) 
            {
                if (product.ProductID == ProductID)
                {
                    return product;
                }
            }
            return null;
        }
        public static void UpdateProduct(int ProductID, Product product)
        {
            RemoveProduct(ProductID);
            AddProduct(product);
        }
        public static void AddPart(Part part)
        {
            parts.Add(part);
        }
        public static bool DeletePart(Part part)
        {
            try
            {
                parts.Remove(part);
                return true;
            }
            catch 
            {

                return false;
            }
        }
        public static Part LookupPart(int PartID)
        {
            foreach (var part in parts)
            {
                if (part.PartID == PartID)
                {
                    return part;
                }
            }
            return null;
        }
        public static void UpdatePart(int PartID, Part part)
        {
            DeletePart(LookupPart(PartID));
            AddPart(part);
        }
    }
}
