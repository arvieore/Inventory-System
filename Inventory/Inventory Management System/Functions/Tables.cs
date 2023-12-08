using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Inventory_Management_System.Forms;
using Inventory_Management_System.Functions;
using Inventory_Management_System.Models;
using Inventory_Management_System.UserControls;

namespace Inventory_Management_System.Functions
{
    public class Tables
    {
        public static void DisplayProducts(DataGridView dgv)
        {
            if (dgv != null && dgv.Columns != null)
            {
                // Modify the column headers if the column exists
                ModifyColumnHeader(dgv, "productID", "ID");
                ModifyColumnHeader(dgv, "product_Name", "Product Name");
                ModifyColumnHeader(dgv, "product_Sku", "SKU");
                ModifyColumnHeader(dgv, "product_Quantity", "Quantity");
                ModifyColumnHeader(dgv, "product_Price", "Price");
                ModifyColumnHeader(dgv, "product_Description", "Description");

                dgv.Columns["productID"].Width = 30;
                dgv.Columns["product_Name"].Width = 180;
                dgv.Columns["product_Sku"].Width = 180;
                dgv.Columns["product_Quantity"].Width = 80;
                dgv.Columns["product_Price"].Width = 100;
                // dgv.Columns["product_Description"].Width = 210;
            }
        }

        private static void ModifyColumnHeader(DataGridView dgv, string columnName, string newHeaderText)
        {
            var column = dgv.Columns[columnName];

            // Check if the column is not null
            if (column != null)
            {
                column.HeaderText = newHeaderText;
            }
        }
    }
}
