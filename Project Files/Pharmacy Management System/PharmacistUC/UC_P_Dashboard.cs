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
    public partial class UC_P_Dashboard : UserControl
    {
        function fn = new function();
        String query;
        DataSet ds;
        int count;

        public UC_P_Dashboard()
        {
            InitializeComponent();
        }

        private void UC_P_Dashboard_Load(object sender, EventArgs e)
        {
            loadChart();
        }

        public void loadChart()    
        {
            query = "select count(MedicineID) from medicine where Quantity > 0";
            ds = fn.GetData(query);
            count = int.Parse(ds.Tables[0].Rows[0][0].ToString());
            this.MedicineSaleChart.Series["In Stock"].Points.AddXY("", count);

            query = "select count(MedicineGenericName) from medicineSales";
            ds = fn.GetData(query);
            count = int.Parse(ds.Tables[0].Rows[0][0].ToString());
            this.MedicineSaleChart.Series["Sold"].Points.AddXY("", count);
        }


        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            MedicineSaleChart.Series["In Stock"].Points.Clear();
            MedicineSaleChart.Series["Sold"].Points.Clear(); 
            loadChart();
        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }
    }
}
