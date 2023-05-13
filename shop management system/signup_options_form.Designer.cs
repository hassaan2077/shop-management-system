namespace shop_management_system
{
    partial class signup_options_form
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
            this.employee_button = new FontAwesome.Sharp.IconButton();
            this.customer_button = new FontAwesome.Sharp.IconButton();
            this.email_label = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // employee_button
            // 
            this.employee_button.BackColor = System.Drawing.Color.Gainsboro;
            this.employee_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.employee_button.IconChar = FontAwesome.Sharp.IconChar.None;
            this.employee_button.IconColor = System.Drawing.Color.Black;
            this.employee_button.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.employee_button.Location = new System.Drawing.Point(49, 66);
            this.employee_button.Name = "employee_button";
            this.employee_button.Size = new System.Drawing.Size(105, 41);
            this.employee_button.TabIndex = 18;
            this.employee_button.Text = "Employee";
            this.employee_button.UseVisualStyleBackColor = false;
            this.employee_button.Click += new System.EventHandler(this.employee_button_Click);
            // 
            // customer_button
            // 
            this.customer_button.BackColor = System.Drawing.Color.Gainsboro;
            this.customer_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.customer_button.IconChar = FontAwesome.Sharp.IconChar.None;
            this.customer_button.IconColor = System.Drawing.Color.Black;
            this.customer_button.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.customer_button.Location = new System.Drawing.Point(339, 66);
            this.customer_button.Name = "customer_button";
            this.customer_button.Size = new System.Drawing.Size(105, 41);
            this.customer_button.TabIndex = 19;
            this.customer_button.Text = "Customer";
            this.customer_button.UseVisualStyleBackColor = false;
            this.customer_button.Click += new System.EventHandler(this.customer_button_Click);
            // 
            // email_label
            // 
            this.email_label.AutoSize = true;
            this.email_label.Font = new System.Drawing.Font("Mongolian Baiti", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.email_label.Location = new System.Drawing.Point(46, 18);
            this.email_label.Name = "email_label";
            this.email_label.Size = new System.Drawing.Size(171, 18);
            this.email_label.TabIndex = 26;
            this.email_label.Text = "Select account type:";
            // 
            // signup_options_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(499, 142);
            this.Controls.Add(this.email_label);
            this.Controls.Add(this.customer_button);
            this.Controls.Add(this.employee_button);
            this.Name = "signup_options_form";
            this.Text = "signup_options_form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private FontAwesome.Sharp.IconButton employee_button;
        private FontAwesome.Sharp.IconButton customer_button;
        private System.Windows.Forms.Label email_label;
    }
}