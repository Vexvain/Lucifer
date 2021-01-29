namespace SafeGuardTemplate
{
    partial class ForgotPassword
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
            this.usernameTB = new System.Windows.Forms.TextBox();
            this.forgotBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // usernameTB
            // 
            this.usernameTB.Location = new System.Drawing.Point(65, 56);
            this.usernameTB.Name = "usernameTB";
            this.usernameTB.Size = new System.Drawing.Size(100, 20);
            this.usernameTB.TabIndex = 0;
            this.usernameTB.Text = "Username";
            // 
            // forgotBtn
            // 
            this.forgotBtn.Location = new System.Drawing.Point(65, 95);
            this.forgotBtn.Name = "forgotBtn";
            this.forgotBtn.Size = new System.Drawing.Size(100, 23);
            this.forgotBtn.TabIndex = 1;
            this.forgotBtn.Text = "Forgot Password";
            this.forgotBtn.UseVisualStyleBackColor = true;
            this.forgotBtn.Click += new System.EventHandler(this.forgotBtn_Click);
            // 
            // ForgotPassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(243, 181);
            this.Controls.Add(this.forgotBtn);
            this.Controls.Add(this.usernameTB);
            this.Name = "ForgotPassword";
            this.Text = "ForgotPassword";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox usernameTB;
        private System.Windows.Forms.Button forgotBtn;
    }
}