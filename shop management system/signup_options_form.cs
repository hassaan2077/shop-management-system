using FontAwesome.Sharp;
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
    public partial class signup_options_form : Form
    {


        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-J7GK37B;Initial Catalog=shop_management_DB;Integrated Security=True");

        string cnic, name, address, email, phone, password, dob;
        public signup_options_form()
        {
            InitializeComponent();
        }

        public signup_options_form(string cnic_passed, string name_passed, string address_passed, string email_passed, string phone_passed, string password_passed, string dob_passed)
        {
            InitializeComponent();
            cnic = cnic_passed; name = name_passed; address = address_passed; email = email_passed; phone = phone_passed; dob = dob_passed; password = password_passed ; //setting values
        }

        private void employee_button_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();

                SqlCommand cmd = new SqlCommand("insert into employee_tb (employee_cnic, employee_name, employee_address, employee_email, employee_password, employee_dob)values(@eid, @ename , @eaddress, @email, @epass, @edob)", con);

                cmd.Parameters.AddWithValue("@ename", name);
                cmd.Parameters.AddWithValue("@eid", cnic);
                cmd.Parameters.AddWithValue("@eaddress", address);
                cmd.Parameters.AddWithValue("@email", email);
                cmd.Parameters.AddWithValue("@epass", password);
                cmd.Parameters.AddWithValue("@edob", dob);



                cmd.ExecuteNonQuery();
                MessageBox.Show("Employee added successfully");


                //fetch customer id to insert customer phone
                //FK used


                SqlCommand cmd_2 = new SqlCommand("INSERT INTO employee_phone(employee_cnic, phone)VALUES(@e_id, @ephone)", con);
                cmd_2.Parameters.AddWithValue("@e_id", cnic);
                cmd_2.Parameters.AddWithValue("@ephone", phone);

                cmd_2.ExecuteNonQuery();

                con.Close();

            }
            catch (Exception Ex)
            {
                MessageBox.Show("The CNIC already exists");
            }

        }

        private void customer_button_Click(object sender, EventArgs e)
        {

            try
            {
                con.Open();

                SqlCommand cmd = new SqlCommand("insert into customer_tb (customer_cnic, customer_name, customer_address, customer_email, customer_password, customer_dob)values(@cid, @cname , @caddress, @cmail, @cpass, @cdob)", con);

                cmd.Parameters.AddWithValue("@cname", name);
                cmd.Parameters.AddWithValue("@cid", cnic);
                cmd.Parameters.AddWithValue("@caddress", address);
                cmd.Parameters.AddWithValue("@cmail", email);
                cmd.Parameters.AddWithValue("@cpass", password);
                cmd.Parameters.AddWithValue("@cdob", dob);

                cmd.ExecuteNonQuery();
                MessageBox.Show("Customer added successfully");


                //fetch customer id to insert customer phone
                //FK used

                
                SqlCommand cmd_2 = new SqlCommand("INSERT INTO customer_phone(customer_id, phone)VALUES(@c_id, @cphone)", con);
                cmd_2.Parameters.AddWithValue("@c_id", cnic);
                cmd_2.Parameters.AddWithValue("@cphone", phone);

                cmd_2.ExecuteNonQuery();

                con.Close();

            }
            catch (Exception Ex)
            {
                MessageBox.Show("The CNIC already exists");
            }
        }
    }
}
