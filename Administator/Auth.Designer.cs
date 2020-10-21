namespace Administator
{
    partial class Auth
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.LoginReg = new System.Windows.Forms.TextBox();
            this.PasswordReg = new System.Windows.Forms.TextBox();
            this.FirstNameReg = new System.Windows.Forms.TextBox();
            this.LastNameReg = new System.Windows.Forms.TextBox();
            this.RegisterButton = new System.Windows.Forms.Button();
            this.RepeatPassword = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(98, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Registration";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(52, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Login";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(52, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Password";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(47, 146);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "First Name";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(47, 172);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Last Name";
            // 
            // LoginReg
            // 
            this.LoginReg.Location = new System.Drawing.Point(114, 67);
            this.LoginReg.Name = "LoginReg";
            this.LoginReg.Size = new System.Drawing.Size(169, 20);
            this.LoginReg.TabIndex = 5;
            // 
            // PasswordReg
            // 
            this.PasswordReg.Location = new System.Drawing.Point(114, 94);
            this.PasswordReg.Name = "PasswordReg";
            this.PasswordReg.Size = new System.Drawing.Size(169, 20);
            this.PasswordReg.TabIndex = 6;
            // 
            // FirstNameReg
            // 
            this.FirstNameReg.Location = new System.Drawing.Point(114, 146);
            this.FirstNameReg.Name = "FirstNameReg";
            this.FirstNameReg.Size = new System.Drawing.Size(168, 20);
            this.FirstNameReg.TabIndex = 7;
            // 
            // LastNameReg
            // 
            this.LastNameReg.Location = new System.Drawing.Point(115, 172);
            this.LastNameReg.Name = "LastNameReg";
            this.LastNameReg.Size = new System.Drawing.Size(169, 20);
            this.LastNameReg.TabIndex = 8;
            // 
            // RegisterButton
            // 
            this.RegisterButton.Location = new System.Drawing.Point(115, 198);
            this.RegisterButton.Name = "RegisterButton";
            this.RegisterButton.Size = new System.Drawing.Size(75, 23);
            this.RegisterButton.TabIndex = 9;
            this.RegisterButton.Text = "Register";
            this.RegisterButton.UseVisualStyleBackColor = true;
            this.RegisterButton.Click += new System.EventHandler(this.RegisterButton_Click);
            // 
            // RepeatPassword
            // 
            this.RepeatPassword.Location = new System.Drawing.Point(115, 120);
            this.RepeatPassword.Name = "RepeatPassword";
            this.RepeatPassword.Size = new System.Drawing.Size(169, 20);
            this.RepeatPassword.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(53, 123);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Password";
            // 
            // Auth
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(334, 283);
            this.Controls.Add(this.RepeatPassword);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.RegisterButton);
            this.Controls.Add(this.LastNameReg);
            this.Controls.Add(this.FirstNameReg);
            this.Controls.Add(this.PasswordReg);
            this.Controls.Add(this.LoginReg);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Auth";
            this.Text = "Auth";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Auth_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox LoginReg;
        private System.Windows.Forms.TextBox PasswordReg;
        private System.Windows.Forms.TextBox FirstNameReg;
        private System.Windows.Forms.TextBox LastNameReg;
        private System.Windows.Forms.Button RegisterButton;
        private System.Windows.Forms.TextBox RepeatPassword;
        private System.Windows.Forms.Label label6;
    }
}