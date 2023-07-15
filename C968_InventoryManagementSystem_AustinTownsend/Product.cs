using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C968_InventoryManagementSystem_AustinTownsend
{
    public class Product
    {
        public BindingList<Part> AssociatedParts { get; set; }
        public int ProductId { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int InStock { get; set; }
        public int Min { get; set; }
        public int Max { get; set; }

        public Product()
        {
            AssociatedParts = new BindingList<Part>();
        }

        public void AddAssociatedPart(Part part)
        {
            AssociatedParts.Add(part);
        }

        public bool RemoveAssociatedPart(int partID)
        {
            var part = LookupAssociatedPart(partID);
            if (part != null)
            {
                AssociatedParts.Remove(part);
                return true;
            }
            return false;
        }

        public Part LookupAssociatedPart(int partID)
        {
            return AssociatedParts.FirstOrDefault(p => p.PartID == partID);
        }
    }
}
