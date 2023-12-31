﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace C968_InventoryManagementSystem_AustinTownsend
{
    public partial class ModifyPart : Form
    {
        private Part partToModify;
        public ModifyPart(Part part)
        {
            InitializeComponent();
            this.partToModify = part;
        }

        private void ModifyPartInHouseRadio_CheckedChanged(object sender, EventArgs e)
        {
            if (ModifyPartInHouseRadio.Checked)
            {
                ModifyPartMachineIDLabel.Text = "Machine ID";
            }
        }

        private void ModifyPart_Load_1(object sender, EventArgs e)
        {
            if (partToModify != null)
            {
                ModifyPartIDTextbox.Text = partToModify.PartID.ToString();
                ModifyPartNameTextbox.Text = partToModify.Name;
                ModifyPartInventoryTextbox.Text = partToModify.InStock.ToString();
                ModifyPartPriceTextbox.Text = partToModify.Price.ToString();
                ModifyPartMaxTextbox.Text = partToModify.Max.ToString();
                ModifyPartMinTextbox.Text = partToModify.Min.ToString();

                if (partToModify is Inhouse)
                {
                    ModifyPartInHouseRadio.Checked = true;
                    ModifyPartMachineIDTextbox.Text = ((Inhouse)partToModify).MachineID.ToString();
                }
                else
                {
                    ModifyPartOutsourcedRadio.Checked = true;
                    ModifyPartMachineIDTextbox.Text = ((Outsourced)partToModify).CompanyName;
                }
            }
        }

        private void ModifyPartOutsourcedRadio_CheckedChanged(object sender, EventArgs e)
        {
            if (ModifyPartOutsourcedRadio.Checked)
            {
                ModifyPartMachineIDLabel.Text = "Company Name";
            }
        }

        private void ModifyPartCancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ModifyPartSaveButton_Click(object sender, EventArgs e)
        {
            try
            {
                // Detect non-numeric values in textboxes that expect numeric values
                if (!decimal.TryParse(ModifyPartPriceTextbox.Text, out decimal price))
                    throw new ArgumentException("Please enter a numeric value for the price.");

                if (!int.TryParse(ModifyPartInventoryTextbox.Text, out int inStock))
                    throw new ArgumentException("Please enter a numeric value for the inventory level.");

                if (!int.TryParse(ModifyPartMinTextbox.Text, out int min))
                    throw new ArgumentException("Please enter a numeric value for the minimum value.");

                if (!int.TryParse(ModifyPartMaxTextbox.Text, out int max))
                    throw new ArgumentException("Please enter a numeric value for the maximum value.");

                // Min should be less than Max; and Inv should be between those two values
                if (min >= max)
                    throw new ArgumentException("Minimum value should be less than maximum value.");

                if (inStock < min || inStock > max)
                    throw new ArgumentException("Inventory level should be between minimum and maximum values.");

                if (ModifyPartInHouseRadio.Checked)
                {
                    if (!int.TryParse(ModifyPartMachineIDTextbox.Text, out int machineID))
                        throw new ArgumentException("Please enter a numeric value for the machine ID.");
                }

                // Detect if the type of the part needs to be changed
                if (ModifyPartInHouseRadio.Checked && partToModify is Outsourced)
                {
                    // The part is currently Outsourced but should be Inhouse
                    int partID = partToModify.PartID; // Save the old part's ID
                    Inventory.DeletePart(partToModify);
                    partToModify = new Inhouse
                    {
                        PartID = partID,
                        Name = ModifyPartNameTextbox.Text,
                        InStock = inStock,
                        Price = price,
                        Max = max,
                        Min = min,
                        MachineID = int.Parse(ModifyPartMachineIDTextbox.Text)
                    };
                    Inventory.AddPart(partToModify, partID); // Add the new part to the inventory

                }
                else if (ModifyPartOutsourcedRadio.Checked && partToModify is Inhouse)
                {
                    // The part is currently Inhouse but should be Outsourced
                    int partID = partToModify.PartID; // Save the old part's ID
                    Inventory.DeletePart(partToModify);
                    partToModify = new Outsourced
                    {
                        PartID = partID,
                        Name = ModifyPartNameTextbox.Text,
                        InStock = inStock,
                        Price = price,
                        Max = max,
                        Min = min,
                        CompanyName = ModifyPartMachineIDTextbox.Text
                    };
                    Inventory.AddPart(partToModify, partID); // Add the new part to the inventory
                }
                else
                {
                    // No part type change, just update the fields
                    partToModify.Name = ModifyPartNameTextbox.Text;
                    partToModify.InStock = inStock;
                    partToModify.Price = price;
                    partToModify.Max = max;
                    partToModify.Min = min;

                    if (ModifyPartInHouseRadio.Checked)
                    {
                        ((Inhouse)partToModify).MachineID = int.Parse(ModifyPartMachineIDTextbox.Text);
                    }
                    else
                    {
                        ((Outsourced)partToModify).CompanyName = ModifyPartMachineIDTextbox.Text;
                    }

                    // Update the part in the inventory
                    Inventory.UpdatePart(partToModify.PartID, partToModify);
                }

                // Close the form
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
