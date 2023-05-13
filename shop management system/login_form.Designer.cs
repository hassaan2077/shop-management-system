namespace shop_management_system
{
    partial class login_form
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.login_page_label = new System.Windows.Forms.Label();
            this.username_label_login_form = new System.Windows.Forms.Label();
            this.cnic_textbox_login_form = new System.Windows.Forms.TextBox();
            this.password_textbox_login_form = new System.Windows.Forms.TextBox();
            this.password_label_login_form = new System.Windows.Forms.Label();
            this.employee_button_login_form = new FontAwesome.Sharp.IconButton();
            this.admin_button_login_form = new FontAwesome.Sharp.IconButton();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.linkLabel2 = new System.Windows.Forms.LinkLabel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MidnightBlue;
            this.panel1.Controls.Add(this.login_page_label);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(185, 535);
            this.panel1.TabIndex = 3;
            // 
            // login_page_label
            // 
            this.login_page_label.AutoSize = true;
            this.login_page_label.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.login_page_label.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.login_page_label.Location = new System.Drawing.Point(52, 226);
            this.login_page_label.Name = "login_page_label";
            this.login_page_label.Size = new System.Drawing.Size(71, 26);
            this.login_page_label.TabIndex = 5;
            this.login_page_label.Text = "Login";
            // 
            // username_label_login_form
            // 
            this.username_label_login_form.AutoSize = true;
            this.username_label_login_form.Font = new System.Drawing.Font("Mongolian Baiti", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.username_label_login_form.Location = new System.Drawing.Point(237, 158);
            this.username_label_login_form.Name = "username_label_login_form";
            this.username_label_login_form.Size = new System.Drawing.Size(52, 18);
            this.username_label_login_form.TabIndex = 6;
            this.username_label_login_form.Text = "CNIC";
            // 
            // cnic_textbox_login_form
            // 
            this.cnic_textbox_login_form.Location = new System.Drawing.Point(354, 154);
            this.cnic_textbox_login_form.Name = "cnic_textbox_login_form";
            this.cnic_textbox_login_form.Size = new System.Drawing.Size(150, 22);
            this.cnic_textbox_login_form.TabIndex = 7;
            // 
            // password_textbox_login_form
            // 
            this.password_textbox_login_form.Location = new System.Drawing.Point(354, 227);
            this.password_textbox_login_form.Name = "password_textbox_login_form";
            this.password_textbox_login_form.PasswordChar = '*';
            this.password_textbox_login_form.Size = new System.Drawing.Size(150, 22);
            this.password_textbox_login_form.TabIndex = 9;
            // 
            // password_label_login_form
            // 
            this.password_label_login_form.AutoSize = true;
            this.password_label_login_form.Font = new System.Drawing.Font("Mongolian Baiti", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.password_label_login_form.Location = new System.Drawing.Point(237, 229);
            this.password_label_login_form.Name = "password_label_login_form";
            this.password_label_login_form.Size = new System.Drawing.Size(83, 18);
            this.password_label_login_form.TabIndex = 8;
            this.password_label_login_form.Text = "Password";
            // 
            // employee_button_login_form
            // 
            this.employee_button_login_form.BackColor = System.Drawing.Color.Gainsboro;
            this.employee_button_login_form.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.employee_button_login_form.IconChar = FontAwesome.Sharp.IconChar.None;
            this.employee_button_login_form.IconColor = System.Drawing.Color.Black;
            this.employee_button_login_form.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.employee_button_login_form.Location = new System.Drawing.Point(367, 284);
            this.employee_button_login_form.Name = "employee_button_login_form";
            this.employee_button_login_form.Size = new System.Drawing.Size(105, 41);
            this.employee_button_login_form.TabIndex = 10;
            this.employee_button_login_form.Text = "employee";
            this.employee_button_login_form.UseVisualStyleBackColor = false;
            this.employee_button_login_form.Click += new System.EventHandler(this.employee_button_login_form_Click);
            // 
            // admin_button_login_form
            // 
            this.admin_button_login_form.BackColor = System.Drawing.Color.Gainsboro;
            this.admin_button_login_form.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.admin_button_login_form.IconChar = FontAwesome.Sharp.IconChar.None;
            this.admin_button_login_form.IconColor = System.Drawing.Color.Black;
            this.admin_button_login_form.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.admin_button_login_form.Location = new System.Drawing.Point(367, 357);
            this.admin_button_login_form.Name = "admin_button_login_form";
            this.admin_button_login_form.Size = new System.Drawing.Size(105, 41);
            this.admin_button_login_form.TabIndex = 11;
            this.admin_button_login_form.Text = "admin";
            this.admin_button_login_form.UseVisualStyleBackColor = false;
            this.admin_button_login_form.Click += new System.EventHandler(this.admin_button_login_form_Click);
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 24;
            this.bunifuElipse1.TargetControl = this;
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.linkLabel1.Location = new System.Drawing.Point(327, 424);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(191, 16);
            this.linkLabel1.TabIndex = 12;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Don\'t have an account? Signup";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // linkLabel2
            // 
            this.linkLabel2.AutoSize = true;
            this.linkLabel2.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.linkLabel2.Location = new System.Drawing.Point(364, 462);
            this.linkLabel2.Name = "linkLabel2";
            this.linkLabel2.Size = new System.Drawing.Size(116, 16);
            this.linkLabel2.TabIndex = 13;
            this.linkLabel2.TabStop = true;
            this.linkLabel2.Text = "Forgot Password?";
            this.linkLabel2.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel2_LinkClicked);
            // 
            // login_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(743, 537);
            this.Controls.Add(this.linkLabel2);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.admin_button_login_form);
            this.Controls.Add(this.employee_button_login_form);
            this.Controls.Add(this.password_textbox_login_form);
            this.Controls.Add(this.password_label_login_form);
            this.Controls.Add(this.cnic_textbox_login_form);
            this.Controls.Add(this.username_label_login_form);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "login_form";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label login_page_label;
        private System.Windows.Forms.Label username_label_login_form;
        private System.Windows.Forms.TextBox cnic_textbox_login_form;
        private System.Windows.Forms.TextBox password_textbox_login_form;
        private System.Windows.Forms.Label password_label_login_form;
        private FontAwesome.Sharp.IconButton employee_button_login_form;
        private FontAwesome.Sharp.IconButton admin_button_login_form;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.LinkLabel linkLabel2;
    }
}