namespace SteamMarketApp
{
    partial class SteamLoginForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
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
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            btnSubmit = new System.Windows.Forms.Button();
            lblPassword = new System.Windows.Forms.Label();
            lblAccountName = new System.Windows.Forms.Label();
            txtAccountName = new System.Windows.Forms.TextBox();
            txtPassword = new System.Windows.Forms.TextBox();
            chkRememberMe = new System.Windows.Forms.CheckBox();
            SuspendLayout();
            // 
            // btnSubmit
            // 
            btnSubmit.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            btnSubmit.BackColor = System.Drawing.Color.FromArgb(45, 115, 255);
            btnSubmit.DialogResult = System.Windows.Forms.DialogResult.OK;
            btnSubmit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnSubmit.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            btnSubmit.ForeColor = System.Drawing.Color.White;
            btnSubmit.Location = new System.Drawing.Point(14, 301);
            btnSubmit.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new System.Drawing.Size(204, 46);
            btnSubmit.TabIndex = 5;
            btnSubmit.Text = "Sign In";
            btnSubmit.UseVisualStyleBackColor = false;
            btnSubmit.Click += Submit;
            // 
            // lblPassword
            // 
            lblPassword.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            lblPassword.AutoSize = true;
            lblPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lblPassword.ForeColor = System.Drawing.Color.FromArgb(220, 230, 240);
            lblPassword.Location = new System.Drawing.Point(166, 152);
            lblPassword.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new System.Drawing.Size(106, 25);
            lblPassword.TabIndex = 6;
            lblPassword.Text = "Password";
            // 
            // lblAccountName
            // 
            lblAccountName.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            lblAccountName.AutoSize = true;
            lblAccountName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lblAccountName.ForeColor = System.Drawing.Color.FromArgb(220, 230, 240);
            lblAccountName.Location = new System.Drawing.Point(166, 77);
            lblAccountName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblAccountName.Name = "lblAccountName";
            lblAccountName.Size = new System.Drawing.Size(152, 25);
            lblAccountName.TabIndex = 7;
            lblAccountName.Text = "Account Name";
            // 
            // txtAccountName
            // 
            txtAccountName.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            txtAccountName.BackColor = System.Drawing.Color.FromArgb(60, 60, 65);
            txtAccountName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            txtAccountName.ForeColor = System.Drawing.Color.FromArgb(220, 230, 240);
            txtAccountName.Location = new System.Drawing.Point(166, 105);
            txtAccountName.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            txtAccountName.Name = "txtAccountName";
            txtAccountName.Size = new System.Drawing.Size(250, 31);
            txtAccountName.TabIndex = 8;
            // 
            // txtPassword
            // 
            txtPassword.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            txtPassword.BackColor = System.Drawing.Color.FromArgb(60, 60, 65);
            txtPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            txtPassword.ForeColor = System.Drawing.Color.FromArgb(220, 230, 240);
            txtPassword.Location = new System.Drawing.Point(166, 180);
            txtPassword.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.Size = new System.Drawing.Size(250, 31);
            txtPassword.TabIndex = 9;
            // 
            // chkRememberMe
            // 
            chkRememberMe.AutoSize = true;
            chkRememberMe.ForeColor = System.Drawing.Color.FromArgb(220, 230, 240);
            chkRememberMe.Location = new System.Drawing.Point(166, 234);
            chkRememberMe.Name = "chkRememberMe";
            chkRememberMe.Size = new System.Drawing.Size(104, 19);
            chkRememberMe.TabIndex = 10;
            chkRememberMe.Text = "Remember me";
            chkRememberMe.UseVisualStyleBackColor = true;
            // 
            // SteamLoginForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.FromArgb(40, 45, 55);
            ClientSize = new System.Drawing.Size(584, 361);
            Controls.Add(chkRememberMe);
            Controls.Add(txtPassword);
            Controls.Add(txtAccountName);
            Controls.Add(lblAccountName);
            Controls.Add(lblPassword);
            Controls.Add(btnSubmit);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            Name = "SteamLoginForm";
            Text = "Steam Login";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblAccountName;
        private System.Windows.Forms.TextBox txtAccountName;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.CheckBox chkRememberMe;
    }
}