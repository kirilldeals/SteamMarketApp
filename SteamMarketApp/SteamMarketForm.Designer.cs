namespace SteamMarketApp
{
    partial class SteamMarketForm
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
            lblGrowth = new System.Windows.Forms.Label();
            lblDecline = new System.Windows.Forms.Label();
            btnMarket = new System.Windows.Forms.Button();
            btnInventory = new System.Windows.Forms.Button();
            btnMarketRefresh = new System.Windows.Forms.Button();
            lblPriceHistoryCount = new System.Windows.Forms.Label();
            label6 = new System.Windows.Forms.Label();
            numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            label1 = new System.Windows.Forms.Label();
            btnInventoryRefresh = new System.Windows.Forms.Button();
            btnLogout = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            SuspendLayout();
            // 
            // lblGrowth
            // 
            lblGrowth.AutoSize = true;
            lblGrowth.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lblGrowth.ForeColor = System.Drawing.Color.FromArgb(255, 230, 240);
            lblGrowth.Location = new System.Drawing.Point(13, 149);
            lblGrowth.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblGrowth.Name = "lblGrowth";
            lblGrowth.Size = new System.Drawing.Size(182, 25);
            lblGrowth.TabIndex = 4;
            lblGrowth.Text = "The most growing";
            // 
            // lblDecline
            // 
            lblDecline.AutoSize = true;
            lblDecline.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lblDecline.ForeColor = System.Drawing.Color.FromArgb(220, 255, 240);
            lblDecline.Location = new System.Drawing.Point(786, 149);
            lblDecline.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblDecline.Name = "lblDecline";
            lblDecline.Size = new System.Drawing.Size(193, 25);
            lblDecline.TabIndex = 5;
            lblDecline.Text = "The most declining";
            // 
            // btnMarket
            // 
            btnMarket.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnMarket.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            btnMarket.ForeColor = System.Drawing.Color.FromArgb(220, 230, 240);
            btnMarket.Location = new System.Drawing.Point(14, 83);
            btnMarket.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btnMarket.Name = "btnMarket";
            btnMarket.Size = new System.Drawing.Size(250, 46);
            btnMarket.TabIndex = 6;
            btnMarket.Text = "From market";
            btnMarket.UseVisualStyleBackColor = true;
            btnMarket.Click += button1_Click;
            // 
            // btnInventory
            // 
            btnInventory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnInventory.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            btnInventory.ForeColor = System.Drawing.Color.FromArgb(220, 230, 240);
            btnInventory.Location = new System.Drawing.Point(273, 83);
            btnInventory.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btnInventory.Name = "btnInventory";
            btnInventory.Size = new System.Drawing.Size(250, 46);
            btnInventory.TabIndex = 7;
            btnInventory.Text = "From my inventory";
            btnInventory.UseVisualStyleBackColor = true;
            // 
            // btnMarketRefresh
            // 
            btnMarketRefresh.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            btnMarketRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnMarketRefresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            btnMarketRefresh.ForeColor = System.Drawing.Color.Red;
            btnMarketRefresh.Location = new System.Drawing.Point(733, 83);
            btnMarketRefresh.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btnMarketRefresh.Name = "btnMarketRefresh";
            btnMarketRefresh.Size = new System.Drawing.Size(315, 46);
            btnMarketRefresh.TabIndex = 8;
            btnMarketRefresh.Text = "Refresh all (market)";
            btnMarketRefresh.UseVisualStyleBackColor = true;
            // 
            // lblPriceHistoryCount
            // 
            lblPriceHistoryCount.AutoSize = true;
            lblPriceHistoryCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lblPriceHistoryCount.ForeColor = System.Drawing.Color.FromArgb(220, 230, 240);
            lblPriceHistoryCount.Location = new System.Drawing.Point(14, 32);
            lblPriceHistoryCount.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblPriceHistoryCount.Name = "lblPriceHistoryCount";
            lblPriceHistoryCount.Size = new System.Drawing.Size(251, 25);
            lblPriceHistoryCount.TabIndex = 9;
            lblPriceHistoryCount.Text = "Items price history count:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label6.ForeColor = System.Drawing.Color.FromArgb(220, 230, 240);
            label6.Location = new System.Drawing.Point(273, 32);
            label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(24, 25);
            label6.TabIndex = 10;
            label6.Text = "0";
            // 
            // numericUpDown1
            // 
            numericUpDown1.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            numericUpDown1.BackColor = System.Drawing.Color.FromArgb(40, 45, 55);
            numericUpDown1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            numericUpDown1.ForeColor = System.Drawing.Color.FromArgb(220, 230, 240);
            numericUpDown1.Increment = new decimal(new int[] { 100, 0, 0, 0 });
            numericUpDown1.Location = new System.Drawing.Point(1091, 34);
            numericUpDown1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            numericUpDown1.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            numericUpDown1.Minimum = new decimal(new int[] { 100, 0, 0, 0 });
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new System.Drawing.Size(146, 26);
            numericUpDown1.TabIndex = 12;
            numericUpDown1.Value = new decimal(new int[] { 100, 0, 0, 0 });
            // 
            // label1
            // 
            label1.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label1.ForeColor = System.Drawing.Color.FromArgb(220, 230, 240);
            label1.Location = new System.Drawing.Point(724, 36);
            label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(348, 20);
            label1.TabIndex = 13;
            label1.Text = "Количество товаров из Торговой площадки:";
            // 
            // btnInventoryRefresh
            // 
            btnInventoryRefresh.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            btnInventoryRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnInventoryRefresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            btnInventoryRefresh.ForeColor = System.Drawing.Color.Red;
            btnInventoryRefresh.Location = new System.Drawing.Point(1055, 83);
            btnInventoryRefresh.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btnInventoryRefresh.Name = "btnInventoryRefresh";
            btnInventoryRefresh.Size = new System.Drawing.Size(315, 46);
            btnInventoryRefresh.TabIndex = 14;
            btnInventoryRefresh.Text = "Refresh all (inventory)";
            btnInventoryRefresh.UseVisualStyleBackColor = true;
            // 
            // btnLogout
            // 
            btnLogout.BackColor = System.Drawing.Color.Cyan;
            btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnLogout.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            btnLogout.ForeColor = System.Drawing.Color.FromArgb(40, 45, 55);
            btnLogout.Location = new System.Drawing.Point(1270, 22);
            btnLogout.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new System.Drawing.Size(100, 46);
            btnLogout.TabIndex = 15;
            btnLogout.Text = "Log Out";
            btnLogout.UseVisualStyleBackColor = false;
            // 
            // SteamMarketForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.FromArgb(40, 45, 55);
            ClientSize = new System.Drawing.Size(1384, 761);
            Controls.Add(btnLogout);
            Controls.Add(btnInventoryRefresh);
            Controls.Add(label1);
            Controls.Add(numericUpDown1);
            Controls.Add(label6);
            Controls.Add(lblPriceHistoryCount);
            Controls.Add(btnMarketRefresh);
            Controls.Add(btnInventory);
            Controls.Add(btnMarket);
            Controls.Add(lblDecline);
            Controls.Add(lblGrowth);
            Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            MinimumSize = new System.Drawing.Size(1400, 800);
            Name = "SteamMarketForm";
            Text = "Steam Market Analyzer";
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private System.Windows.Forms.Label lblGrowth;
        private System.Windows.Forms.Label lblDecline;
        private System.Windows.Forms.Button btnMarket;
        private System.Windows.Forms.Button btnInventory;
        private System.Windows.Forms.Button btnMarketRefresh;
        private System.Windows.Forms.Label lblPriceHistoryCount;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnInventoryRefresh;
        private System.Windows.Forms.Button btnLogout;
    }
}