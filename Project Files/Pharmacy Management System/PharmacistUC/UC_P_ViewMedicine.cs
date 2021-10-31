using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pharmacy_Management_System.PharmacistUC
{
    public partial class UC_P_ViewMedicine : UserControl
    {
        function fn = new function();
        String query;
        DataSet ds;

        public UC_P_ViewMedicine()
        {
            InitializeComponent();
        }

        private void btnDeleteMedicine_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Are you Sure?","Delete Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                query = "delete from medicine where MedicineID = '"+medicineID+"'";
                fn.setData(query,"Medicine record deleted");
                UC_P_ViewMedicine_Load(this, null);
            }
        }

        private void txtsearchbyMedicineName_TextChanged(object sender, EventArgs e)
        {
            query = "select MedicineID as MID, GenericName as MedicineName, BrandName as BrandName,Quantity as Quantity,CostPerUnit as Cost,SalePricePerUnit as Sale,ExpiingeDate from medicine where GenericName like '%"+txtsearchbyMedicineName.Text+"%'";
            setDataGridView(query);
        }

        private void UC_P_ViewMedicine_Load(object sender, EventArgs e)
        {
            query = "select MedicineID as MID, GenericName as MedicineName, BrandName as BrandName,Quantity as Quantity,CostPerUnit as Cost,SalePricePerUnit as Sale,ExpiingeDate from medicine";
            setDataGridView(query);
            query = "select count(MedicineID) from medicine";
            ds = fn.GetData(query);
            totalMedicine.Text = ds.Tables[0].Rows[0][0].ToString();
        }

        public void setDataGridView(String query)
        {
            ds = fn.GetData(query);
            viewMedicineGridView.DataSource = ds.Tables[0];
        }

        String medicineID;
        private void viewMedicineGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                medicineID = viewMedicineGridView.Rows[e.RowIndex].Cells[0].Value.ToString();
            }
            catch
            {

            }
        }
    }
}
