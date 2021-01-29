namespace SafeGuardTemplate
{
    partial class ResetPassword
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
            this.passTB = new System.Windows.Forms.TextBox();
            this.tokenTB = new System.Windows.Forms.TextBox();
            this.usernameTB = new System.Windows.Forms.TextBox();
            this.ResetBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // passTB
            // 
            this.passTB.Location = new System.Drawing.Point(66, 75);
            this.passTB.Name = "passTB";
            this.passTB.Size = new System.Drawing.Size(152, 20);
            this.passTB.TabIndex = 9;
            this.passTB.Text = "Password";
            // 
            // tokenTB
            // 
            this.tokenTB.Location = new System.Drawing.Point(66, 101);
            this.tokenTB.Name = "tokenTB";
            this.tokenTB.Size = new System.Drawing.Size(152, 20);
            this.tokenTB.TabIndex = 7;
            this.tokenTB.Text = "Token";
            // 
            // usernameTB
            // 
            this.usernameTB.Location = new System.Drawing.Point(66, 49);
            this.usernameTB.Name = "usernameTB";
            this.usernameTB.Size = new System.Drawing.Size(152, 20);
            this.usernameTB.TabIndex = 6;
            this.usernameTB.Text = "Username";
            // 
            // ResetBtn
            // 
            this.ResetBtn.Location = new System.Drawing.Point(66, 127);
            this.ResetBtn.Name = "ResetBtn";
            this.ResetBtn.Size = new System.Drawing.Size(152, 39);
            this.ResetBtn.TabIndex = 5;
            this.ResetBtn.Text = "Reset Password";
            this.ResetBtn.UseVisualStyleBackColor = true;
            this.ResetBtn.Click += new System.EventHandler(this.ResetBtn_Click);
            // 
            // ResetPassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(283, 220);
            this.Controls.Add(this.passTB);
            this.Controls.Add(this.tokenTB);
            this.Controls.Add(this.usernameTB);
            this.Controls.Add(this.ResetBtn);
            this.Name = "ResetPassword";
            this.Text = "ResetPassword";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox passTB;
        private System.Windows.Forms.TextBox tokenTB;
        private System.Windows.Forms.TextBox usernameTB;
        private System.Windows.Forms.Button ResetBtn;
    }
}