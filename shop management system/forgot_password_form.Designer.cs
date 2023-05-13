namespace shop_management_system
{
    partial class forgot_password_form
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
            this.cnic_textbox = new System.Windows.Forms.TextBox();
            this.cnic_label = new System.Windows.Forms.Label();
            this.admin_button = new System.Windows.Forms.Button();
            this.employee_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cnic_textbox
            // 
            this.cnic_textbox.Location = new System.Drawing.Point(206, 54);
            this.cnic_textbox.Name = "cnic_textbox";
            this.cnic_textbox.Size = new System.Drawing.Size(150, 22);
            this.cnic_textbox.TabIndex = 9;
            // 
            // cnic_label
            // 
            this.cnic_label.AutoSize = true;
            this.cnic_label.Font = new System.Drawing.Font("Mongolian Baiti", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cnic_label.Location = new System.Drawing.Point(89, 58);
            this.cnic_label.Name = "cnic_label";
            this.cnic_label.Size = new System.Drawing.Size(52, 18);
            this.cnic_label.TabIndex = 8;
            this.cnic_label.Text = "CNIC";
            // 
            // admin_button
            // 
            this.admin_button.Location = new System.Drawing.Point(121, 104);
            this.admin_button.Name = "admin_button";
            this.admin_button.Size = new System.Drawing.Size(83, 28);
            this.admin_button.TabIndex = 10;
            this.admin_button.Text = "admin";
            this.admin_button.UseVisualStyleBackColor = true;
            this.admin_button.Click += new System.EventHandler(this.button1_Click);
            // 
            // employee_button
            // 
            this.employee_button.Location = new System.Drawing.Point(237, 104);
            this.employee_button.Name = "employee_button";
            this.employee_button.Size = new System.Drawing.Size(83, 28);
            this.employee_button.TabIndex = 11;
            this.employee_button.Text = "employee";
            this.employee_button.UseVisualStyleBackColor = true;
            this.employee_button.Click += new System.EventHandler(this.employee_button_Click);
            // 
            // forgot_password_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(455, 162);
            this.Controls.Add(this.employee_button);
            this.Controls.Add(this.admin_button);
            this.Controls.Add(this.cnic_textbox);
            this.Controls.Add(this.cnic_label);
            this.Name = "forgot_password_form";
            this.Text = "forgot_password_form";
            this.Load += new System.EventHandler(this.forgot_password_form_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox cnic_textbox;
        private System.Windows.Forms.Label cnic_label;
        private System.Windows.Forms.Button admin_button;
        private System.Windows.Forms.Button employee_button;
    }
}