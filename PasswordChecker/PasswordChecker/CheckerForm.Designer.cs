namespace PasswordChecker
{
    partial class CheckerForm
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
            this.login = new System.Windows.Forms.TextBox();
            this.password = new System.Windows.Forms.TextBox();
            this.check = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // login
            // 
            this.login.Location = new System.Drawing.Point(12, 12);
            this.login.Name = "login";
            this.login.Size = new System.Drawing.Size(535, 29);
            this.login.TabIndex = 0;
            // 
            // password
            // 
            this.password.Location = new System.Drawing.Point(12, 58);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(535, 29);
            this.password.TabIndex = 1;
            // 
            // check
            // 
            this.check.Location = new System.Drawing.Point(12, 103);
            this.check.Name = "check";
            this.check.Size = new System.Drawing.Size(535, 77);
            this.check.TabIndex = 2;
            this.check.Text = "Check!";
            this.check.UseVisualStyleBackColor = true;
            this.check.Click += new System.EventHandler(this.check_Click);
            // 
            // CheckerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(560, 192);
            this.Controls.Add(this.check);
            this.Controls.Add(this.password);
            this.Controls.Add(this.login);
            this.Name = "CheckerForm";
            this.Text = "PasswordChecker for Tibia";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox login;
        private System.Windows.Forms.TextBox password;
        private System.Windows.Forms.Button check;
    }
}

