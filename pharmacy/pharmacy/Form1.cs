using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace pharmacy
{
    public partial class Form1 : Form
    {
        private DataTable medicineTable = new DataTable();

        public Form1()
        {
            InitializeComponent();
            InitializeMedicineTable();
            BindGrid();

        }

        private void BindGrid()
        {
            dataGridViewMedicines.DataSource = medicineTable;
        }


        private void btnAdd_Click(object sender, EventArgs e)
        {
            medicineTable.Rows.Add(
            txtMedicineID.Text,
               txtName.Text,
               txtManufacturer.Text,
               txtCategory.Text,
               txtQuantity.Text,
               txtUnitPrice.Text,
               dtpExpiryDate.Value.ToShortDateString()
           );
            ClearFields();

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (dataGridViewMedicines.SelectedRows.Count > 0)
            {
                var row = dataGridViewMedicines.SelectedRows[0];
                row.Cells["MedicineID"].Value = txtMedicineID.Text;
                row.Cells["Name"].Value = txtName.Text;
                row.Cells["Manufacturer"].Value = txtManufacturer.Text;
                row.Cells["Category"].Value = txtCategory.Text;
                row.Cells["Quantity"].Value = txtQuantity.Text;
                row.Cells["UnitPrice"].Value = txtUnitPrice.Text;
                row.Cells["ExpiryDate"].Value = dtpExpiryDate.Value.ToShortDateString();
                ClearFields();
            }

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dataGridViewMedicines.SelectedRows.Count > 0)
            {
                dataGridViewMedicines.Rows.Remove(dataGridViewMedicines.SelectedRows[0]);
                ClearFields();
            }

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {

        }

        private void btnCheckExpiry_Click(object sender, EventArgs e)
        {

        }
    }
}
