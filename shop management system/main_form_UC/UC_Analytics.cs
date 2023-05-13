using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace shop_management_system
{
    public partial class UC_Analytics : UserControl
    {
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-J7GK37B;Initial Catalog=C:\USERS\AHTIS\ONEDRIVE\DOCUMENTS\SHOP_MANAGEMENT_SYSTEM_DB.MDF;Integrated Security=True");

        public UC_Analytics()
        {
            InitializeComponent();


            //chart

            SqlDataAdapter sda = new SqlDataAdapter("Select product_names, total_bill from bill_tb", con);

            DataSet ds  = new DataSet();
            sda.Fill(ds);

            main_chart.DataSource = ds;
            //chart
            main_chart.Series[0].Name = "Sales";
            main_chart.Series["Sales"].XValueMember = "product_names";
            main_chart.Series["Sales"].YValueMembers = "total_bill";
        }

        private void UC_Analytics_Load(object sender, EventArgs e)
        {

        }

        private void main_chart_Click(object sender, EventArgs e)
        {

        }
    }
}
