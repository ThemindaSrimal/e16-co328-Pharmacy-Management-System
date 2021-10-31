using DGVPrinterHelper;
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
    public partial class UC_P_SellMedicine : UserControl
    {
        function fn = new function();
        String query;
        DataSet ds;
        String currentUser = "";
        public UC_P_SellMedicine()
        {
            InitializeComponent();
        }

        public String ID
        {
            set { currentUser = value; }
        }

        private void txtType_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void viewMedicineGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void totalMedicine_Click(object sender, EventArgs e)
        {

        }

        private void medicineListbox_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtNoOfUnits.Text = "0";
            txtMedicineName.Clear();
            txtBrandName.Clear();
            txtExpireDate.ResetText();
            txtPricePerUnit.Clear();
            txtTotalPrice.Text ="0";

            String name = medicineListbox.GetItemText(medicineListbox.SelectedItem);

            txtMedicineName.Text = name;

            query = "select BrandName,ExpiingeDate,SalePricePerUnit from medicine where GenericName = '" + name + "'";
            ds = fn.GetData(query);

            txtMedicineName.Text = name ;
            txtBrandName.Text = ds.Tables[0].Rows[0][0].ToString() ;
            txtExpireDate.Text = ds.Tables[0].Rows[0][1].ToString();
            txtPricePerUnit.Text = ds.Tables[0].Rows[0][2].ToString();
        }

        private void txtsearchbyMedicineName_TextChanged(object sender, EventArgs e)
        {
            medicineListbox.Items.Clear();
            query = "select * from medicine where Quantity > 0 and GenericName like '%"+txtsearchbyMedicineName.Text+"%'";
            ds = fn.GetData(query);
            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                medicineListbox.Items.Add(ds.Tables[0].Rows[i][3].ToString());
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void UC_P_SellMedicine_Load(object sender, EventArgs e)
        {
            medicineListbox.Items.Clear();
            //query = "select GenericName from medicine where ExpiingeDate >= getDate() and Quantity > 0 ; need to fix problem with how to store dates

            query = "select * from medicine where Quantity > 0" ;
            ds = fn.GetData(query);
            
            for(int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                medicineListbox.Items.Add(ds.Tables[0].Rows[i][3].ToString());
            }

        }

        private void btnSync_Click(object sender, EventArgs e)
        {
            UC_P_SellMedicine_Load(this, null);
        }

        private void txtBrandName_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtNoOfUnits_TextChanged(object sender, EventArgs e)
        {
            if(txtNoOfUnits.Text != "")
            {
                try
                {
                    Decimal unitPrice = Decimal.Parse(txtPricePerUnit.Text);
                    Decimal noOfUnits = Decimal.Parse(txtNoOfUnits.Text);
                    Decimal totalAmount = unitPrice * noOfUnits;
                    txtTotalPrice.Text = totalAmount.ToString();
                }
                catch(Exception)
                {
                    MessageBox.Show("Please enter unit in numbers", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtNoOfUnits.Text = "0";
                }
            }
            else
            {
                txtTotalPrice.Clear();
            }
        }

        protected int n,quantity = 0, newQuantity = 0;
        protected Decimal totalAmount = 0;


        Decimal valueAmount; //total price in a row
        String medicinename;
        protected int NoOfUnits;
        private void viewCartGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (viewCartGridView.Rows[e.RowIndex].Cells[5].Value != null)
                {
                    valueAmount = Decimal.Parse(viewCartGridView.Rows[e.RowIndex].Cells[5].Value.ToString());
                    medicinename = viewCartGridView.Rows[e.RowIndex].Cells[0].Value.ToString();
                    NoOfUnits = int.Parse(viewCartGridView.Rows[e.RowIndex].Cells[4].Value.ToString());
                }
            }
            catch (Exception)
            {

            }
        }

        private void btnRemoveFromCart_Click(object sender, EventArgs e)
        {
            if (medicinename != null && totalMedicineLabel.Text != "0.00")
            {
                try
                {
                    viewCartGridView.Rows.RemoveAt(this.viewCartGridView.SelectedRows[0].Index);
                }
                catch (Exception)
                {

                }
                finally
                {
                    query = "select Quantity from medicine where GenericName = '" + medicinename + "'";
                    ds = fn.GetData(query);
                    int quantity = int.Parse(ds.Tables[0].Rows[0][0].ToString());
                    newQuantity = quantity + NoOfUnits;

                    query = "update medicine set Quantity = '" + newQuantity + "' where GenericName = '" + medicinename + "'";
                    fn.setData(query, "Medicine removed from cart.");
                    totalAmount = totalAmount - valueAmount;
                    totalMedicineLabel.Text = totalAmount.ToString();
                }
                UC_P_SellMedicine_Load(this, null);
            }
        }

        

        private void btnAddtoCart_Click(object sender, EventArgs e)
        {
            if(txtMedicineName.Text != "")
            {
                query = "select Quantity from medicine where GenericName = '" + txtMedicineName.Text + "'";
                ds = fn.GetData(query);

                quantity = int.Parse(ds.Tables[0].Rows[0][0].ToString());
                newQuantity = quantity - int.Parse(txtNoOfUnits.Text);
                /*
                if (viewCartGridView.Columns.Count == 0)
                {
                    viewCartGridView.Columns.Add("MedicineName", "Medicine Name");
                    viewCartGridView.Columns.Add("BrandName", "Brand Name");
                    viewCartGridView.Columns.Add("ExpireDate", "Expire Date");
                    viewCartGridView.Columns.Add("PricPperUnit", "Price per Unit");
                    viewCartGridView.Columns.Add("NoOfUnits", "No Of Units");
                    viewCartGridView.Columns.Add("Total Price", "Total Price");
                }*/

                if (newQuantity >= 0)
                {
                    if (txtNoOfUnits.Text != "0")
                    {
                        
                        n = viewCartGridView.Rows.Add();
                        viewCartGridView.Rows[n].Cells[0].Value = txtMedicineName.Text;
                        viewCartGridView.Rows[n].Cells[1].Value = txtBrandName.Text;
                        viewCartGridView.Rows[n].Cells[2].Value = txtExpireDate.Text;
                        viewCartGridView.Rows[n].Cells[3].Value = txtPricePerUnit.Text;
                        viewCartGridView.Rows[n].Cells[4].Value = txtNoOfUnits.Text;
                        viewCartGridView.Rows[n].Cells[5].Value = txtTotalPrice.Text;

                        totalAmount = totalAmount + Decimal.Parse(txtTotalPrice.Text);
                        totalMedicineLabel.Text = /*"Rss. " +*/ totalAmount.ToString();

                        query = "update medicine set Quantity = '" + newQuantity + "' where GenericName = '" + txtMedicineName.Text + "'";
                        fn.setData(query, "Medicine record updated");
                    }
                    else
                    {
                        MessageBox.Show("Please add no of units", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    MessageBox.Show("Out of Stock.Only '" + quantity + "' available.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                clearAll();
                UC_P_SellMedicine_Load(this, null);
            }
            else
            {
                MessageBox.Show("Select medicine first", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnPrintPurchase_Click(object sender, EventArgs e) //might be needed to add a customer name
        {
            DGVPrinter print = new DGVPrinter();
            print.Title = "Medicine Bill";
            print.SubTitle = String.Format("Date:- {0}", DateTime.Now.Date);
            print.SubTitleFormatFlags = StringFormatFlags.LineLimit | StringFormatFlags.NoClip;
            print.PageNumbers = true;
            print.PageNumberInHeader = false;
            print.PorportionalColumns = true;
            print.HeaderCellAlignment = StringAlignment.Near;
            print.Footer = "PMS solutions";
            print.SubTitle = "Total Payable amount : " + totalMedicineLabel.Text;
            print.FooterSpacing = 15;
            print.PrintDataGridView(viewCartGridView);

            for (int i = 0; i < viewCartGridView.RowCount; i++)
            {
                if (viewCartGridView.Rows[n].Cells[3].Value != null)
                {
                    query = "insert into medicineSales (medicineGenericName,PricepPerUnit,brandName,NoOfUnitsSold,totalPrice,pharmacist) values('" + viewCartGridView.Rows[i].Cells[0].Value + "','" + viewCartGridView.Rows[n].Cells[3].Value + "','" + viewCartGridView.Rows[n].Cells[1].Value + "','" + viewCartGridView.Rows[n].Cells[4].Value + "','" + viewCartGridView.Rows[n].Cells[5].Value + "','" + currentUser + "');";
                    fn.setData(query, "Sales record added");
                }
            }

            totalAmount = 0;
            totalMedicineLabel.Text = "0.00";
            viewCartGridView.DataSource = 0;



        }

        private void clearAll()
        {
            txtNoOfUnits.Text = "0";
            txtMedicineName.Clear();
            txtBrandName.Clear();
            txtExpireDate.ResetText();
            txtPricePerUnit.Clear();
            txtTotalPrice.Text = "0";
        }
    }
}
