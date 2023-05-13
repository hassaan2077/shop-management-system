namespace shop_management_system
{
    partial class signup_form
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
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.signup_page_label = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.signup_button = new FontAwesome.Sharp.IconButton();
            this.password_textbox_signup_form = new System.Windows.Forms.TextBox();
            this.password_label_signup_form = new System.Windows.Forms.Label();
            this.cnic_textbox_signup_form = new System.Windows.Forms.TextBox();
            this.username_label_signup_form = new System.Windows.Forms.Label();
            this.name_text_box = new System.Windows.Forms.TextBox();
            this.customer_name_label = new System.Windows.Forms.Label();
            this.address_text_box = new System.Windows.Forms.TextBox();
            this.address_label = new System.Windows.Forms.Label();
            this.phone_text_box = new System.Windows.Forms.TextBox();
            this.phone_label = new System.Windows.Forms.Label();
            this.email_text_box = new System.Windows.Forms.TextBox();
            this.email_label = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dob_label = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 24;
            this.bunifuElipse1.TargetControl = this;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MidnightBlue;
            this.panel1.Controls.Add(this.signup_page_label);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(185, 535);
            this.panel1.TabIndex = 4;
            // 
            // signup_page_label
            // 
            this.signup_page_label.AutoSize = true;
            this.signup_page_label.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signup_page_label.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.signup_page_label.Location = new System.Drawing.Point(52, 226);
            this.signup_page_label.Name = "signup_page_label";
            this.signup_page_label.Size = new System.Drawing.Size(88, 26);
            this.signup_page_label.TabIndex = 5;
            this.signup_page_label.Text = "Signup";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.linkLabel1.Location = new System.Drawing.Point(329, 473);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(205, 16);
            this.linkLabel1.TabIndex = 18;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Already have an account? Sign in";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // signup_button
            // 
            this.signup_button.BackColor = System.Drawing.Color.Gainsboro;
            this.signup_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.signup_button.IconChar = FontAwesome.Sharp.IconChar.None;
            this.signup_button.IconColor = System.Drawing.Color.Black;
            this.signup_button.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.signup_button.Location = new System.Drawing.Point(375, 417);
            this.signup_button.Name = "signup_button";
            this.signup_button.Size = new System.Drawing.Size(105, 41);
            this.signup_button.TabIndex = 17;
            this.signup_button.Text = "Signup";
            this.signup_button.UseVisualStyleBackColor = false;
            this.signup_button.Click += new System.EventHandler(this.signup_button_Click);
            // 
            // password_textbox_signup_form
            // 
            this.password_textbox_signup_form.Location = new System.Drawing.Point(395, 270);
            this.password_textbox_signup_form.Name = "password_textbox_signup_form";
            this.password_textbox_signup_form.Size = new System.Drawing.Size(150, 22);
            this.password_textbox_signup_form.TabIndex = 16;
            // 
            // password_label_signup_form
            // 
            this.password_label_signup_form.AutoSize = true;
            this.password_label_signup_form.Font = new System.Drawing.Font("Mongolian Baiti", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.password_label_signup_form.Location = new System.Drawing.Point(278, 272);
            this.password_label_signup_form.Name = "password_label_signup_form";
            this.password_label_signup_form.Size = new System.Drawing.Size(83, 18);
            this.password_label_signup_form.TabIndex = 15;
            this.password_label_signup_form.Text = "Password";
            // 
            // cnic_textbox_signup_form
            // 
            this.cnic_textbox_signup_form.Location = new System.Drawing.Point(395, 127);
            this.cnic_textbox_signup_form.Name = "cnic_textbox_signup_form";
            this.cnic_textbox_signup_form.Size = new System.Drawing.Size(150, 22);
            this.cnic_textbox_signup_form.TabIndex = 14;
            // 
            // username_label_signup_form
            // 
            this.username_label_signup_form.AutoSize = true;
            this.username_label_signup_form.Font = new System.Drawing.Font("Mongolian Baiti", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.username_label_signup_form.Location = new System.Drawing.Point(278, 131);
            this.username_label_signup_form.Name = "username_label_signup_form";
            this.username_label_signup_form.Size = new System.Drawing.Size(52, 18);
            this.username_label_signup_form.TabIndex = 13;
            this.username_label_signup_form.Text = "CNIC";
            // 
            // name_text_box
            // 
            this.name_text_box.Location = new System.Drawing.Point(395, 172);
            this.name_text_box.Name = "name_text_box";
            this.name_text_box.Size = new System.Drawing.Size(150, 22);
            this.name_text_box.TabIndex = 20;
            // 
            // customer_name_label
            // 
            this.customer_name_label.AutoSize = true;
            this.customer_name_label.Font = new System.Drawing.Font("Mongolian Baiti", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customer_name_label.Location = new System.Drawing.Point(278, 174);
            this.customer_name_label.Name = "customer_name_label";
            this.customer_name_label.Size = new System.Drawing.Size(53, 18);
            this.customer_name_label.TabIndex = 19;
            this.customer_name_label.Text = "Name";
            // 
            // address_text_box
            // 
            this.address_text_box.Location = new System.Drawing.Point(395, 221);
            this.address_text_box.Name = "address_text_box";
            this.address_text_box.Size = new System.Drawing.Size(150, 22);
            this.address_text_box.TabIndex = 22;
            // 
            // address_label
            // 
            this.address_label.AutoSize = true;
            this.address_label.Font = new System.Drawing.Font("Mongolian Baiti", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.address_label.Location = new System.Drawing.Point(278, 223);
            this.address_label.Name = "address_label";
            this.address_label.Size = new System.Drawing.Size(73, 18);
            this.address_label.TabIndex = 21;
            this.address_label.Text = "Address";
            // 
            // phone_text_box
            // 
            this.phone_text_box.Location = new System.Drawing.Point(395, 314);
            this.phone_text_box.Name = "phone_text_box";
            this.phone_text_box.Size = new System.Drawing.Size(150, 22);
            this.phone_text_box.TabIndex = 24;
            // 
            // phone_label
            // 
            this.phone_label.AutoSize = true;
            this.phone_label.Font = new System.Drawing.Font("Mongolian Baiti", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.phone_label.Location = new System.Drawing.Point(278, 316);
            this.phone_label.Name = "phone_label";
            this.phone_label.Size = new System.Drawing.Size(57, 18);
            this.phone_label.TabIndex = 23;
            this.phone_label.Text = "Phone";
            // 
            // email_text_box
            // 
            this.email_text_box.Location = new System.Drawing.Point(395, 84);
            this.email_text_box.Name = "email_text_box";
            this.email_text_box.Size = new System.Drawing.Size(150, 22);
            this.email_text_box.TabIndex = 26;
            // 
            // email_label
            // 
            this.email_label.AutoSize = true;
            this.email_label.Font = new System.Drawing.Font("Mongolian Baiti", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.email_label.Location = new System.Drawing.Point(278, 86);
            this.email_label.Name = "email_label";
            this.email_label.Size = new System.Drawing.Size(54, 18);
            this.email_label.TabIndex = 25;
            this.email_label.Text = "Email";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(395, 365);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(150, 22);
            this.dateTimePicker1.TabIndex = 27;
            // 
            // dob_label
            // 
            this.dob_label.AutoSize = true;
            this.dob_label.Font = new System.Drawing.Font("Mongolian Baiti", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dob_label.Location = new System.Drawing.Point(278, 369);
            this.dob_label.Name = "dob_label";
            this.dob_label.Size = new System.Drawing.Size(46, 18);
            this.dob_label.TabIndex = 28;
            this.dob_label.Text = "DOB";
            // 
            // signup_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(743, 537);
            this.Controls.Add(this.dob_label);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.email_text_box);
            this.Controls.Add(this.email_label);
            this.Controls.Add(this.phone_text_box);
            this.Controls.Add(this.phone_label);
            this.Controls.Add(this.address_text_box);
            this.Controls.Add(this.address_label);
            this.Controls.Add(this.name_text_box);
            this.Controls.Add(this.customer_name_label);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.signup_button);
            this.Controls.Add(this.password_textbox_signup_form);
            this.Controls.Add(this.password_label_signup_form);
            this.Controls.Add(this.cnic_textbox_signup_form);
            this.Controls.Add(this.username_label_signup_form);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "signup_form";
            this.Text = "signup_form";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label signup_page_label;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private FontAwesome.Sharp.IconButton signup_button;
        private System.Windows.Forms.TextBox password_textbox_signup_form;
        private System.Windows.Forms.Label password_label_signup_form;
        private System.Windows.Forms.TextBox cnic_textbox_signup_form;
        private System.Windows.Forms.Label username_label_signup_form;
        private System.Windows.Forms.TextBox name_text_box;
        private System.Windows.Forms.Label customer_name_label;
        private System.Windows.Forms.TextBox address_text_box;
        private System.Windows.Forms.Label address_label;
        private System.Windows.Forms.TextBox phone_text_box;
        private System.Windows.Forms.Label phone_label;
        private System.Windows.Forms.TextBox email_text_box;
        private System.Windows.Forms.Label email_label;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label dob_label;
    }
}