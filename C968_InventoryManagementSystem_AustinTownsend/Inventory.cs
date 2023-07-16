using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C968_InventoryManagementSystem_AustinTownsend
{
    public static class Inventory
    {
        public static BindingList<Product> Products { get; set; }
        public static BindingList<Part> AllParts { get; set; }

        private static int nextPartID = 1;
        private static int nextProductID = 1;

        static Inventory()
        {
            Products = new BindingList<Product>();
            AllParts = new BindingList<Part>();

            //Add initial parts to binding list for testing
            var inhousePart = new Inhouse { PartID = 1, Name = "Street Tire", Price = 59.99M, InStock = 20, Min = 5, Max = 50, MachineID = 8928 };
            var outsourcedPart = new Outsourced { PartID = 2, Name = "Off-Road Tire", Price = 69.99M, InStock = 10, Min = 5, Max = 50, CompanyName = "Jeffs Offroad" };

            AllParts.Add(inhousePart);
            AllParts.Add(outsourcedPart);
            nextPartID += 2;
            //Add initial products to binding list for testing
            var associatedParts1 = new BindingList<Part> { inhousePart };
            var associatedParts2 = new BindingList<Part> { outsourcedPart };

            Products.Add(new Product { ProductId = 1, Name = "Street Bike", Price = 599.99M, InStock = 15, Min = 5, Max = 50, AssociatedParts = associatedParts1 });
            Products.Add(new Product { ProductId = 2, Name = "Off-Road Bike", Price = 799.99M, InStock = 25, Min = 5, Max = 50, AssociatedParts = associatedParts2 });
            nextProductID += 2;
        }

        public static void AddProduct(Product product)
        {
            product.ProductId = nextProductID++;
            Products.Add(product);
        }

        public static bool RemoveProduct(int productId)
        {
            var product = LookupProduct(productId);
            if (product != null)
            {
                Products.Remove(product);
                return true;
            }

            return false;
        }

        public static Product LookupProduct(int productId)
        {
            return Products.FirstOrDefault(p => p.ProductId == productId);
        }

        public static void UpdateProduct(int productId, Product updatedProduct)
        {
            var product = LookupProduct(productId);
            if (product != null)
            {
                int index = Products.IndexOf(product);
                Products[index] = updatedProduct;
            }
        }


        public static void AddPart(Part part)
        {
            part.PartID = nextPartID++;
            AllParts.Add(part);
        }

        public static bool DeletePart(Part part)
        {
            return AllParts.Remove(part);
        }

        public static Part LookupPart(int partId)
        {
            return AllParts.FirstOrDefault(p => p.PartID == partId);
        }

        public static void UpdatePart(int partId, Part updatedPart)
        {
            var part = LookupPart(partId);
            if (part != null)
            {
                int index = AllParts.IndexOf(part);
                AllParts[index] = updatedPart;
            }
        }
    }
}
