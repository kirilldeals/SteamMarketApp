using System;

namespace SteamMarketApp
{
    partial class AuthCodeForm
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
            lblCode = new System.Windows.Forms.Label();
            txtCode = new System.Windows.Forms.TextBox();
            btnSubmit = new System.Windows.Forms.Button();
            SuspendLayout();
            // 
            // lblCode
            // 
            lblCode.AutoSize = true;
            lblCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lblCode.ForeColor = System.Drawing.Color.FromArgb(220, 230, 240);
            lblCode.Location = new System.Drawing.Point(14, 9);
            lblCode.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblCode.Name = "lblCode";
            lblCode.Size = new System.Drawing.Size(282, 20);
            lblCode.TabIndex = 8;
            lblCode.Text = "Enter the code from your authenticator";
            // 
            // txtCode
            // 
            txtCode.BackColor = System.Drawing.Color.FromArgb(60, 60, 65);
            txtCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            txtCode.ForeColor = System.Drawing.Color.FromArgb(220, 230, 240);
            txtCode.Location = new System.Drawing.Point(14, 43);
            txtCode.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            txtCode.MaxLength = 5;
            txtCode.Name = "txtCode";
            txtCode.Size = new System.Drawing.Size(317, 32);
            txtCode.TabIndex = 9;
            // 
            // btnSubmit
            // 
            btnSubmit.BackColor = System.Drawing.Color.FromArgb(45, 115, 255);
            btnSubmit.DialogResult = System.Windows.Forms.DialogResult.OK;
            btnSubmit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnSubmit.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            btnSubmit.ForeColor = System.Drawing.Color.White;
            btnSubmit.Location = new System.Drawing.Point(14, 103);
            btnSubmit.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new System.Drawing.Size(84, 46);
            btnSubmit.TabIndex = 10;
            btnSubmit.Text = "OK";
            btnSubmit.UseVisualStyleBackColor = false;
            btnSubmit.Click += Submit;
            // 
            // AuthCodeForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.FromArgb(40, 45, 55);
            ClientSize = new System.Drawing.Size(344, 161);
            Controls.Add(btnSubmit);
            Controls.Add(txtCode);
            Controls.Add(lblCode);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            Name = "AuthCodeForm";
            Text = "Two Factor Authentication";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lblCode;
        private System.Windows.Forms.TextBox txtCode;
        private System.Windows.Forms.Button btnSubmit;
    }
}