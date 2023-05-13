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
    public partial class UC_Dashboard : UserControl
    {
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-J7GK37B;Initial Catalog=C:\USERS\AHTIS\ONEDRIVE\DOCUMENTS\SHOP_MANAGEMENT_SYSTEM_DB.MDF;Integrated Security=True");
        public UC_Dashboard()
        {
            InitializeComponent();
            update_progress_employee();
            update_food_and_beverages();
            update_beauty();
            update_clothing();
        }

        private void UC_Dashboard_Load(object sender, EventArgs e)
        {

        }

        private void update_progress_employee()
        {

            con.Open();
            SqlDataAdapter da = new SqlDataAdapter("select count(*) from employee_tb", con);
            DataTable dt = new DataTable();

            da.Fill(dt);

            string number_of_employees;


            number_of_employees = dt.Rows[0][0].ToString();

            employee_circle_progress_bar_home_page.Text = number_of_employees;

            con.Close();
        }

        private void update_food_and_beverages()
        {
            con.Open();
            SqlDataAdapter da = new SqlDataAdapter("select count(*) from products_tb where product_category = 'food and beverages'", con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            string number_of_food_and_beverages = dt.Rows[0][0].ToString();
            count_food_and_beverages_main_home_page.Text = number_of_food_and_beverages;
            con.Close();
        }

        private void update_beauty()
        {
            con.Open();
            SqlDataAdapter da = new SqlDataAdapter("select count(*) from products_tb where product_category = 'beauty'", con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            string number_of_food_and_beverages = dt.Rows[0][0].ToString();
            count_beauty_main_home_page.Text = number_of_food_and_beverages;
            con.Close();
        }

        private void update_clothing()
        {
            con.Open();
            SqlDataAdapter da = new SqlDataAdapter("select count(*) from products_tb where product_category = 'clothing'", con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            string number_of_food_and_beverages = dt.Rows[0][0].ToString();
            count_clothing_main_home_page.Text = number_of_food_and_beverages;
            con.Close();
        }

    }
}
