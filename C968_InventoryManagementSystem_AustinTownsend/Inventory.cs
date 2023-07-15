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
        public static BindingList<Inhouse> InHouseParts { get; set; }
        public static BindingList<Outsourced> OutsourcedParts { get; set; }

        private static int nextPartID = 1;
        private static int nextProductID = 1;

        static Inventory()
        {
            Products = new BindingList<Product>();
            InHouseParts = new BindingList<Inhouse>();
            OutsourcedParts = new BindingList<Outsourced>();
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

        public static void AddPart(Inhouse part)
        {
            part.PartID = nextPartID++;
            InHouseParts.Add(part);
        }

        public static void AddPart(Outsourced part)
        {
            part.PartID = nextPartID++;
            OutsourcedParts.Add(part);
        }

        public static bool DeletePart(Inhouse part)
        {
            return InHouseParts.Remove(part);
        }

        public static bool DeletePart(Outsourced part)
        {
            return OutsourcedParts.Remove(part);
        }

        public static Part LookupPart(int partId)
        {
            Part foundPart = InHouseParts.FirstOrDefault(p => p.PartID == partId);

            if (foundPart == null)
            {
                foundPart = OutsourcedParts.FirstOrDefault(p => p.PartID == partId);
            }
            return foundPart;
        }

        public static void UpdatePart(int partId, Inhouse updatedPart)
        {
            var part = InHouseParts.FirstOrDefault(p => p.PartID == partId);
            if (part != null)
            {
                int index = InHouseParts.IndexOf(part);
                InHouseParts[index] = updatedPart;
            }
        }

        public static void UpdatePart(int partId, Outsourced updatedPart)
        {
            var part = OutsourcedParts.FirstOrDefault(p => p.PartID == partId);
            if (part != null)
            {
                int index = OutsourcedParts.IndexOf(part);
                OutsourcedParts[index] = updatedPart;
            }
        }
    }
}
