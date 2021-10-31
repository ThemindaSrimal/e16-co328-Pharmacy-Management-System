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
    public partial class UC_P_AddMedicine : UserControl
    {
        String currentUser = "";
        function fn = new function();
        String query;
        public UC_P_AddMedicine()
        {
            InitializeComponent();
        }
        public String ID
        {
            set { currentUser = value; }
        }
        private void btnAddUser_Click(object sender, EventArgs e)
        {
            if(txtAgentName.Text!="" && txtBrandName.Text!="" && txtCostPerUnit.Text != ""&& txtExpireDate.Text!=""&& txtGenericName.Text!=""&& txtManufactDate.Text!="" && txtManufacturer.Text!="" && txtMedicineID.Text!=""&& txtQuantity.Text!=""&& txtType.Text!=""&&TxtSalespricePerUnit.Text!="")
            {
                String medicineID = txtMedicineID.Text;
                String medicineBrand = txtManufacturer.Text;
                String GenericName = txtGenericName.Text;
                String BrandName = txtBrandName.Text;
                String Agent = txtAgentName.Text;
                String MedicineType = txtType.Text;
                int Quantity = int.Parse(txtQuantity.Text);
                Decimal costperUnit = Decimal.Parse(txtCostPerUnit.Text);
                Decimal salePriceperUnit = Decimal.Parse(TxtSalespricePerUnit.Text);
                String ManufacturingDate = txtManufactDate.Text;
                String ExpireDate = txtExpireDate.Text;
                String AddedPharmacist = currentUser;

                query = "insert into medicine (MedicineID,MedicineBrand,GenericName,BrandName,Agent,MedicineType,Quantity,CostPerUnit,SalePricePerUnit,ManufactureDate,ExpiingeDate,AddedPharmacist) values ('" + medicineID + "','" + BrandName + "','" + GenericName + "','" + medicineBrand + "','" + Agent + "','" + MedicineType + "','" + Quantity + "','" + costperUnit + "','" + salePriceperUnit + "','" + ManufacturingDate + "','" + ExpireDate + "','" + AddedPharmacist + "')";
                fn.setData(query, "Medicine Successfully Added");
            }
            else
            {
                MessageBox.Show("Enter All Data", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void txtMedicineID_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtManufacturer_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtGenericName_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtBrandName_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtQuantity_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtCostPerUnit_TextChanged(object sender, EventArgs e)
        {

        }

        private void TxtSalespricePerUnit_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnResetAddMedicine_Click(object sender, EventArgs e)
        {
            txtAgentName.Clear();
            txtBrandName.Clear();
            txtCostPerUnit.Clear();
            txtGenericName.Clear();
            txtManufacturer.Clear();
            txtMedicineID.Clear();
            txtQuantity.Clear();
            TxtSalespricePerUnit.Clear();
        }
    }
}
