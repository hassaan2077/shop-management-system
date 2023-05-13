using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;
using FontAwesome.Sharp;

namespace shop_management_system
{
    public partial class main_form : Form
    {


        private IconButton currentbutton;
        public main_form()
        {
            InitializeComponent();

            //Custom start position
            StartPosition = FormStartPosition.Manual;
            Left = 400;
            Top = 200;
            //
        }


        private void mainform_Load(object sender, EventArgs e)
        {

        }




        //the following method is used for coloring of activated button
        private void ActivateButton(object senderBtn, Color color)
        {
            if (senderBtn != null)
            {
                //Button
                reset();
                currentbutton = (IconButton)senderBtn; //As I am using font awesome, i have to convert to btn
                //currentbutton.BackColor = Color.FromArgb(37, 36, 81);
                currentbutton.ForeColor = color;
                currentbutton.IconColor = color;
                currentbutton.TextAlign = ContentAlignment.MiddleRight;
                currentbutton.TextImageRelation = TextImageRelation.TextBeforeImage;
                currentbutton.ImageAlign = ContentAlignment.MiddleRight;
            }
        }

        //colors
        private struct RGBColors //Colors stored by me
        {
            public static Color color1 = Color.FromArgb(172, 126, 241);
            public static Color color2 = Color.FromArgb(249, 118, 176);
            public static Color color3 = Color.FromArgb(253, 138, 114);
            public static Color color4 = Color.FromArgb(95, 77, 221);
            public static Color color5 = Color.FromArgb(249, 88, 155);
            public static Color color6 = Color.FromArgb(24, 161, 251);
        }

        private void DisableButton() //using this to restore original layout of button
        {
            if (currentbutton != null)
            {
                currentbutton.BackColor = Color.MidnightBlue;
                currentbutton.ForeColor = Color.Gainsboro;
                currentbutton.TextAlign = ContentAlignment.MiddleLeft;
                currentbutton.IconColor = Color.Gainsboro;
                currentbutton.TextImageRelation = TextImageRelation.ImageBeforeText;
                currentbutton.ImageAlign = ContentAlignment.MiddleLeft;
            }
        }

        private void addUserControl(UserControl userControl) //Tabs
        {
            userControl.Dock = DockStyle.Fill; //usercontrol is the object
            uc_panel.Controls.Clear();
            uc_panel.Controls.Add(userControl); //Like this.controls.add() but this is for the panel
            userControl.BringToFront();
        }


        //Buttons

        private void dashboard_button_Click(object sender, EventArgs e)
        {
            reset();
            ActivateButton(sender, RGBColors.color1); //To change color
            UC_Dashboard ucd = new UC_Dashboard();
            addUserControl(ucd);

        }
        private void employee_button_Click(object sender, EventArgs e)
        {
            reset();
            ActivateButton(sender, RGBColors.color2);
        }


        private void products_button_Click_1(object sender, EventArgs e)
        {
            reset();
            ActivateButton(sender, RGBColors.color3);
        }

        private void customers_button_Click_1(object sender, EventArgs e)
        {
            reset();
            ActivateButton(sender, RGBColors.color4);
        }

        private void analytics_button_Click(object sender, EventArgs e)
        {
            reset();
            ActivateButton(sender, RGBColors.color5);
        }

        private void settings_button_Click(object sender, EventArgs e)
        {
            reset();
            ActivateButton(sender, RGBColors.color6);
        }



        private void cross_button_Click(object sender, EventArgs e)
        {
            this.Close();
        }




        //To reset colors
        private void reset()
        {
            DisableButton();
        }


        private void main_form_Load(object sender, EventArgs e)
        {

        }

        private void uc_panel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void logout_button_Click(object sender, EventArgs e)
        {
            this.Hide();
            login_form lf = new login_form();
            lf.Show();
        }
    }
}
