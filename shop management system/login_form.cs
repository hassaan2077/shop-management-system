﻿using FontAwesome.Sharp;
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
    public partial class login_form : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-J7GK37B;Initial Catalog=shop_management_DB;Integrated Security=True");

        public login_form()
        {
            InitializeComponent();
            //Custom start position
            StartPosition = FormStartPosition.Manual;
            Left = 650;
            Top = 250;
            //
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void employee_button_login_form_Click(object sender, EventArgs e)
        {

            if (cnic_textbox_login_form.Text == "" || password_textbox_login_form.Text == "")
            {
                MessageBox.Show("Please Fill out all the fields");
            }
            else
            {
                con.Open();
                DataTable dt = new DataTable();

                try
                {
                    SqlDataAdapter da = new SqlDataAdapter("select count(*) from employee_tb where employee_cnic = '" + cnic_textbox_login_form.Text + "'", con);

                    da.Fill(dt);

                    if (dt.Rows[0][0].ToString() == "1")
                    {
                        SqlDataAdapter sda_1 = new SqlDataAdapter("SELECT employee_password from employee_tb where employee_cnic = '" + cnic_textbox_login_form.Text + "'", con);
                        DataTable dt_1 = new DataTable();
                        sda_1.Fill(dt_1);

                        string real_password = dt_1.Rows[0][0].ToString();

                        if (password_textbox_login_form.Text == real_password)
                        {

                            employee_form ep = new employee_form(cnic_textbox_login_form.Text);

                            ep.Show();
                            this.Hide();
                        }

                        else
                        {
                            MessageBox.Show("Invalid Credentials");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Invalid Credentials");
                    }


                }

                catch (Exception ex)
                {
                    MessageBox.Show("Please enter integers only in the CNIC field");
                }

                con.Close();
            

            }
        }

        private void admin_button_login_form_Click(object sender, EventArgs e)
        {
            if (cnic_textbox_login_form.Text == "" || password_textbox_login_form.Text == "")
            {
                MessageBox.Show("Please Fill out all the fields");
            }
            else
            {
                con.Open();
                DataTable dt = new DataTable();
                try
                {
                    SqlDataAdapter sda = new SqlDataAdapter("select count(*) from admin_tb where admin_cnic='" + cnic_textbox_login_form.Text + "'", con);
                    
                    sda.Fill(dt);


                    if (dt.Rows[0][0].ToString() == "1")
                    {

                        SqlDataAdapter sda_1 = new SqlDataAdapter("SELECT admin_password from admin_tb where admin_cnic = '" + cnic_textbox_login_form.Text + "'", con);
                        DataTable dt_1 = new DataTable();
                        sda_1.Fill(dt_1);

                        string real_password = dt_1.Rows[0][0].ToString();

                        if (password_textbox_login_form.Text == real_password)
                        {
                            main_form mf = new main_form(cnic_textbox_login_form.Text);
                            mf.Show();
                            this.Hide();
                        }

                        else
                        {
                            MessageBox.Show("Invalid Credentials");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Invalid Credentials");
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Please enter integers only in the CNIC field");
                }
                
                con.Close();
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            signup_form sf = new signup_form();
            this.Hide();
            sf.Show();
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            forgot_password_form ff = new forgot_password_form();
            ff.Show();
        }
    }
}
