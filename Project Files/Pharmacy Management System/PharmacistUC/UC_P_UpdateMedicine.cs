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
    
    public partial class UC_P_UpdateMedicine : UserControl
    {
        function fn = new function();
        String query;
        DataSet ds;
        String currentUser = "";
        public UC_P_UpdateMedicine()
        {
            InitializeComponent();
        }
        public String ID
        {
            set { currentUser = value; }
        }
        private void btnSearchMedicine_Click(object sender, EventArgs e)
        {
            if (txtMedicineName.Text != "")
            {
                query = "select * from medicine where GenericName = '"+txtMedicineName.Text+"' ";
                ds = fn.GetData(query);
                if (ds.Tables[0].Rows.Count != 0)
                {
                    txtAgentName.Text = ds.Tables[0].Rows[0][5].ToString();
                    txtBrandName.Text = ds.Tables[0].Rows[0][4].ToString();
                    txtCostPerUnit.Text = ds.Tables[0].Rows[0][8].ToString();
                    txtExpireDate.Text = ds.Tables[0].Rows[0][10].ToString();
                    txtManufactDate.Text = ds.Tables[0].Rows[0][10].ToString();
                    txtManufacturer.Text = ds.Tables[0].Rows[0][11].ToString();
                    txtMedicineID.Text = ds.Tables[0].Rows[0][1].ToString();
                    txtQuantityAvailable.Text = ds.Tables[0].Rows[0][7].ToString();
                    txtType.Text = ds.Tables[0].Rows[0][6].ToString();
                    TxtSalespricePerUnit.Text = ds.Tables[0].Rows[0][9].ToString();
                }
                else
                {
                    MessageBox.Show("No medicine with name : " + txtMedicineName.Text,"Info",MessageBoxButtons.OK,MessageBoxIcon.Information);
                    clearAll();
                }
            }
            else
            {
                clearAll();
            }
        }

        private void clearAll()
        {
            txtAgentName.Clear();
            txtBrandName.Clear();
            txtCostPerUnit.Clear();
            txtExpireDate.ResetText();
            txtManufactDate.ResetText();
            txtManufacturer.Clear();
            txtMedicineID.Clear();
            txtQuantityAvailable.Clear();
            txtType.StartIndex = -1;
            TxtSalespricePerUnit.Clear();
            txtAddquantity.Text = "0";
        }

        private void btnResetUpdateMedicine_Click(object sender, EventArgs e)
        {
            clearAll();
            txtMedicineName.Clear();
        }
        int totalQuantity = 0;
        private void btnUpdateMedicine_Click(object sender, EventArgs e)
        {
            String medicineID = txtMedicineID.Text;
            String medicineBrand = txtManufacturer.Text;
            String GenericName = txtMedicineName.Text;
            String BrandName = txtBrandName.Text;
            String Agent = txtAgentName.Text;
            String MedicineType = txtType.Text;
            int Quantity = int.Parse(txtQuantityAvailable.Text);
            Decimal costperUnit = Decimal.Parse(txtCostPerUnit.Text);
            Decimal salePriceperUnit = Decimal.Parse(TxtSalespricePerUnit.Text);
            String ManufacturingDate = txtManufactDate.Text;
            String ExpireDate = txtExpireDate.Text;
            totalQuantity = int.Parse(txtQuantityAvailable.Text) + int.Parse(txtAddquantity.Text);
            String addedPharmacist = currentUser;

            query = "update medicine set MedicineID = '"+medicineID+"',MedicineBrand='"+medicineBrand+ "',GenericName = '"+GenericName+ "',BrandName = '"+BrandName+ "',Agent='"+Agent+ "',MedicineType='"+MedicineType+ "',Quantity='"+totalQuantity+ "',CostPerUnit='"+costperUnit+ "',SalePricePerUnit='"+salePriceperUnit+ "',ManufactureDate='"+ManufacturingDate+ "',ExpiingeDate='"+ExpireDate+ "',AddedPharmacist='"+addedPharmacist+"' where GenericName = '"+GenericName+"'" ;
            fn.setData(query, "Medicine Successfully Updated");
        }
    }
}
