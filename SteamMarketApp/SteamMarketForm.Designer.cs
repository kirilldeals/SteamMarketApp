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
            btnMarketRefreshAll = new System.Windows.Forms.Button();
            lblForMarketCount = new System.Windows.Forms.Label();
            lblMarketCount = new System.Windows.Forms.Label();
            btnInventoryRefreshAll = new System.Windows.Forms.Button();
            btnLogout = new System.Windows.Forms.Button();
            lblInventoryCount = new System.Windows.Forms.Label();
            lblForInventoryCount = new System.Windows.Forms.Label();
            tlpPriceChartsInfo = new System.Windows.Forms.TableLayoutPanel();
            tlpPriceChartsLabels = new System.Windows.Forms.TableLayoutPanel();
            tlpPriceCharts = new System.Windows.Forms.TableLayoutPanel();
            chartCountNumericUpDown = new System.Windows.Forms.NumericUpDown();
            lblCharts = new System.Windows.Forms.Label();
            btnStopMarket = new System.Windows.Forms.Button();
            lblMarketTooManyRequests = new System.Windows.Forms.Label();
            btnMarketGet = new System.Windows.Forms.Button();
            lblInventoryTooManyRequests = new System.Windows.Forms.Label();
            cboFilterBy = new System.Windows.Forms.ComboBox();
            lblFilterBy = new System.Windows.Forms.Label();
            tlpPriceChartsInfo.SuspendLayout();
            tlpPriceChartsLabels.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)chartCountNumericUpDown).BeginInit();
            SuspendLayout();
            // 
            // lblGrowth
            // 
            lblGrowth.AutoSize = true;
            lblGrowth.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lblGrowth.ForeColor = System.Drawing.Color.FromArgb(230, 255, 230);
            lblGrowth.Location = new System.Drawing.Point(680, 0);
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
            lblDecline.ForeColor = System.Drawing.Color.FromArgb(255, 230, 230);
            lblDecline.Location = new System.Drawing.Point(4, 0);
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
            btnMarket.Location = new System.Drawing.Point(342, 126);
            btnMarket.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btnMarket.Name = "btnMarket";
            btnMarket.Size = new System.Drawing.Size(280, 68);
            btnMarket.TabIndex = 6;
            btnMarket.Text = "From market";
            btnMarket.UseVisualStyleBackColor = true;
            btnMarket.Click += CreatePriceChartsFromMarket;
            // 
            // btnInventory
            // 
            btnInventory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnInventory.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            btnInventory.ForeColor = System.Drawing.Color.FromArgb(220, 230, 240);
            btnInventory.Location = new System.Drawing.Point(630, 126);
            btnInventory.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btnInventory.Name = "btnInventory";
            btnInventory.Size = new System.Drawing.Size(280, 68);
            btnInventory.TabIndex = 7;
            btnInventory.Text = "From my inventory";
            btnInventory.UseVisualStyleBackColor = true;
            btnInventory.Click += CreatePriceChartsFromInventory;
            // 
            // btnMarketRefreshAll
            // 
            btnMarketRefreshAll.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            btnMarketRefreshAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnMarketRefreshAll.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            btnMarketRefreshAll.ForeColor = System.Drawing.Color.FromArgb(255, 60, 60);
            btnMarketRefreshAll.Location = new System.Drawing.Point(803, 64);
            btnMarketRefreshAll.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btnMarketRefreshAll.Name = "btnMarketRefreshAll";
            btnMarketRefreshAll.Size = new System.Drawing.Size(280, 46);
            btnMarketRefreshAll.TabIndex = 8;
            btnMarketRefreshAll.Text = "Refresh all (market)";
            btnMarketRefreshAll.UseVisualStyleBackColor = true;
            btnMarketRefreshAll.Click += RefreshAllItemsFromMarket;
            // 
            // lblForMarketCount
            // 
            lblForMarketCount.AutoSize = true;
            lblForMarketCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lblForMarketCount.ForeColor = System.Drawing.Color.FromArgb(220, 230, 240);
            lblForMarketCount.Location = new System.Drawing.Point(13, 22);
            lblForMarketCount.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblForMarketCount.Name = "lblForMarketCount";
            lblForMarketCount.Size = new System.Drawing.Size(266, 25);
            lblForMarketCount.TabIndex = 9;
            lblForMarketCount.Text = "Market price history count:";
            // 
            // lblMarketCount
            // 
            lblMarketCount.AutoSize = true;
            lblMarketCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lblMarketCount.ForeColor = System.Drawing.Color.FromArgb(220, 230, 240);
            lblMarketCount.Location = new System.Drawing.Point(310, 22);
            lblMarketCount.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblMarketCount.Name = "lblMarketCount";
            lblMarketCount.Size = new System.Drawing.Size(24, 25);
            lblMarketCount.TabIndex = 10;
            lblMarketCount.Text = "0";
            // 
            // btnInventoryRefreshAll
            // 
            btnInventoryRefreshAll.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            btnInventoryRefreshAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnInventoryRefreshAll.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            btnInventoryRefreshAll.ForeColor = System.Drawing.Color.FromArgb(255, 60, 60);
            btnInventoryRefreshAll.Location = new System.Drawing.Point(1091, 64);
            btnInventoryRefreshAll.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btnInventoryRefreshAll.Name = "btnInventoryRefreshAll";
            btnInventoryRefreshAll.Size = new System.Drawing.Size(280, 46);
            btnInventoryRefreshAll.TabIndex = 14;
            btnInventoryRefreshAll.Text = "Refresh all (inventory)";
            btnInventoryRefreshAll.UseVisualStyleBackColor = true;
            btnInventoryRefreshAll.Click += RefreshAllItemsFromInventory;
            // 
            // btnLogout
            // 
            btnLogout.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            btnLogout.BackColor = System.Drawing.SystemColors.MenuHighlight;
            btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnLogout.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            btnLogout.ForeColor = System.Drawing.Color.FromArgb(40, 45, 55);
            btnLogout.Location = new System.Drawing.Point(1271, 12);
            btnLogout.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new System.Drawing.Size(100, 46);
            btnLogout.TabIndex = 15;
            btnLogout.Text = "Log Out";
            btnLogout.UseVisualStyleBackColor = false;
            btnLogout.Click += Logout;
            // 
            // lblInventoryCount
            // 
            lblInventoryCount.AutoSize = true;
            lblInventoryCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lblInventoryCount.ForeColor = System.Drawing.Color.FromArgb(220, 230, 240);
            lblInventoryCount.Location = new System.Drawing.Point(310, 74);
            lblInventoryCount.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblInventoryCount.Name = "lblInventoryCount";
            lblInventoryCount.Size = new System.Drawing.Size(24, 25);
            lblInventoryCount.TabIndex = 17;
            lblInventoryCount.Text = "0";
            // 
            // lblForInventoryCount
            // 
            lblForInventoryCount.AutoSize = true;
            lblForInventoryCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lblForInventoryCount.ForeColor = System.Drawing.Color.FromArgb(220, 230, 240);
            lblForInventoryCount.Location = new System.Drawing.Point(13, 74);
            lblForInventoryCount.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblForInventoryCount.Name = "lblForInventoryCount";
            lblForInventoryCount.Size = new System.Drawing.Size(288, 25);
            lblForInventoryCount.TabIndex = 16;
            lblForInventoryCount.Text = "Inventory price history count:";
            // 
            // tlpPriceChartsInfo
            // 
            tlpPriceChartsInfo.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            tlpPriceChartsInfo.AutoScroll = true;
            tlpPriceChartsInfo.ColumnCount = 1;
            tlpPriceChartsInfo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            tlpPriceChartsInfo.Controls.Add(tlpPriceChartsLabels, 0, 0);
            tlpPriceChartsInfo.Controls.Add(tlpPriceCharts, 0, 1);
            tlpPriceChartsInfo.Location = new System.Drawing.Point(13, 200);
            tlpPriceChartsInfo.Name = "tlpPriceChartsInfo";
            tlpPriceChartsInfo.RowCount = 2;
            tlpPriceChartsInfo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 38F));
            tlpPriceChartsInfo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            tlpPriceChartsInfo.Size = new System.Drawing.Size(1358, 549);
            tlpPriceChartsInfo.TabIndex = 18;
            // 
            // tlpPriceChartsLabels
            // 
            tlpPriceChartsLabels.ColumnCount = 2;
            tlpPriceChartsLabels.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            tlpPriceChartsLabels.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            tlpPriceChartsLabels.Controls.Add(lblGrowth, 1, 0);
            tlpPriceChartsLabels.Controls.Add(lblDecline, 0, 0);
            tlpPriceChartsLabels.Dock = System.Windows.Forms.DockStyle.Fill;
            tlpPriceChartsLabels.Location = new System.Drawing.Point(3, 3);
            tlpPriceChartsLabels.Name = "tlpPriceChartsLabels";
            tlpPriceChartsLabels.RowCount = 1;
            tlpPriceChartsLabels.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            tlpPriceChartsLabels.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            tlpPriceChartsLabels.Size = new System.Drawing.Size(1352, 32);
            tlpPriceChartsLabels.TabIndex = 0;
            // 
            // tlpPriceCharts
            // 
            tlpPriceCharts.AutoScroll = true;
            tlpPriceCharts.ColumnCount = 2;
            tlpPriceCharts.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            tlpPriceCharts.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            tlpPriceCharts.Dock = System.Windows.Forms.DockStyle.Fill;
            tlpPriceCharts.Location = new System.Drawing.Point(3, 41);
            tlpPriceCharts.Name = "tlpPriceCharts";
            tlpPriceCharts.RowCount = 1;
            tlpPriceCharts.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            tlpPriceCharts.Size = new System.Drawing.Size(1352, 505);
            tlpPriceCharts.TabIndex = 1;
            // 
            // chartCountNumericUpDown
            // 
            chartCountNumericUpDown.BackColor = System.Drawing.Color.FromArgb(40, 45, 55);
            chartCountNumericUpDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            chartCountNumericUpDown.ForeColor = System.Drawing.Color.FromArgb(220, 230, 240);
            chartCountNumericUpDown.Location = new System.Drawing.Point(175, 124);
            chartCountNumericUpDown.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            chartCountNumericUpDown.Name = "chartCountNumericUpDown";
            chartCountNumericUpDown.Size = new System.Drawing.Size(160, 31);
            chartCountNumericUpDown.TabIndex = 20;
            chartCountNumericUpDown.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // lblCharts
            // 
            lblCharts.AutoSize = true;
            lblCharts.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lblCharts.ForeColor = System.Drawing.Color.FromArgb(220, 230, 240);
            lblCharts.Location = new System.Drawing.Point(13, 126);
            lblCharts.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblCharts.Name = "lblCharts";
            lblCharts.Size = new System.Drawing.Size(155, 25);
            lblCharts.TabIndex = 21;
            lblCharts.Text = "Charts to show";
            // 
            // btnStopMarket
            // 
            btnStopMarket.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            btnStopMarket.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnStopMarket.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            btnStopMarket.ForeColor = System.Drawing.Color.FromArgb(255, 60, 60);
            btnStopMarket.Location = new System.Drawing.Point(803, 12);
            btnStopMarket.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btnStopMarket.Name = "btnStopMarket";
            btnStopMarket.Size = new System.Drawing.Size(80, 46);
            btnStopMarket.TabIndex = 22;
            btnStopMarket.Text = "Stop";
            btnStopMarket.UseVisualStyleBackColor = true;
            btnStopMarket.Visible = false;
            btnStopMarket.Click += StopMarketAPICalls;
            // 
            // lblMarketTooManyRequests
            // 
            lblMarketTooManyRequests.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            lblMarketTooManyRequests.AutoSize = true;
            lblMarketTooManyRequests.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lblMarketTooManyRequests.ForeColor = System.Drawing.Color.FromArgb(220, 230, 240);
            lblMarketTooManyRequests.Location = new System.Drawing.Point(891, 12);
            lblMarketTooManyRequests.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblMarketTooManyRequests.Name = "lblMarketTooManyRequests";
            lblMarketTooManyRequests.Size = new System.Drawing.Size(297, 20);
            lblMarketTooManyRequests.TabIndex = 23;
            lblMarketTooManyRequests.Text = "Market: too many requests. Please wait...";
            lblMarketTooManyRequests.Visible = false;
            // 
            // btnMarketGet
            // 
            btnMarketGet.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            btnMarketGet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnMarketGet.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            btnMarketGet.ForeColor = System.Drawing.Color.FromArgb(200, 200, 128);
            btnMarketGet.Location = new System.Drawing.Point(515, 64);
            btnMarketGet.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btnMarketGet.Name = "btnMarketGet";
            btnMarketGet.Size = new System.Drawing.Size(280, 46);
            btnMarketGet.TabIndex = 24;
            btnMarketGet.Text = "Get price histories from market";
            btnMarketGet.UseVisualStyleBackColor = true;
            btnMarketGet.Click += ContinueGetItemsFromMarket;
            // 
            // lblInventoryTooManyRequests
            // 
            lblInventoryTooManyRequests.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            lblInventoryTooManyRequests.AutoSize = true;
            lblInventoryTooManyRequests.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lblInventoryTooManyRequests.ForeColor = System.Drawing.Color.FromArgb(220, 230, 240);
            lblInventoryTooManyRequests.Location = new System.Drawing.Point(891, 38);
            lblInventoryTooManyRequests.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblInventoryTooManyRequests.Name = "lblInventoryTooManyRequests";
            lblInventoryTooManyRequests.Size = new System.Drawing.Size(313, 20);
            lblInventoryTooManyRequests.TabIndex = 25;
            lblInventoryTooManyRequests.Text = "Inventory: too many requests. Please wait...";
            lblInventoryTooManyRequests.Visible = false;
            // 
            // cboFilterBy
            // 
            cboFilterBy.BackColor = System.Drawing.Color.FromArgb(40, 45, 55);
            cboFilterBy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            cboFilterBy.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            cboFilterBy.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            cboFilterBy.ForeColor = System.Drawing.Color.FromArgb(220, 230, 240);
            cboFilterBy.FormattingEnabled = true;
            cboFilterBy.Items.AddRange(new object[] { "Growth Rate", "Price" });
            cboFilterBy.Location = new System.Drawing.Point(175, 161);
            cboFilterBy.Name = "cboFilterBy";
            cboFilterBy.Size = new System.Drawing.Size(160, 33);
            cboFilterBy.TabIndex = 26;
            // 
            // lblFilterBy
            // 
            lblFilterBy.AutoSize = true;
            lblFilterBy.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lblFilterBy.ForeColor = System.Drawing.Color.FromArgb(220, 230, 240);
            lblFilterBy.Location = new System.Drawing.Point(13, 164);
            lblFilterBy.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblFilterBy.Name = "lblFilterBy";
            lblFilterBy.Size = new System.Drawing.Size(89, 25);
            lblFilterBy.TabIndex = 27;
            lblFilterBy.Text = "Filter by";
            // 
            // SteamMarketForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.FromArgb(40, 45, 55);
            ClientSize = new System.Drawing.Size(1384, 761);
            Controls.Add(lblFilterBy);
            Controls.Add(cboFilterBy);
            Controls.Add(lblInventoryTooManyRequests);
            Controls.Add(btnMarketGet);
            Controls.Add(lblMarketTooManyRequests);
            Controls.Add(btnStopMarket);
            Controls.Add(tlpPriceChartsInfo);
            Controls.Add(lblCharts);
            Controls.Add(chartCountNumericUpDown);
            Controls.Add(lblInventoryCount);
            Controls.Add(lblForInventoryCount);
            Controls.Add(btnLogout);
            Controls.Add(btnInventoryRefreshAll);
            Controls.Add(lblMarketCount);
            Controls.Add(lblForMarketCount);
            Controls.Add(btnMarketRefreshAll);
            Controls.Add(btnInventory);
            Controls.Add(btnMarket);
            Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            MinimumSize = new System.Drawing.Size(1400, 800);
            Name = "SteamMarketForm";
            Text = "Steam Market Analyzer";
            tlpPriceChartsInfo.ResumeLayout(false);
            tlpPriceChartsLabels.ResumeLayout(false);
            tlpPriceChartsLabels.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)chartCountNumericUpDown).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private System.Windows.Forms.Label lblGrowth;
        private System.Windows.Forms.Label lblDecline;
        private System.Windows.Forms.Button btnMarket;
        private System.Windows.Forms.Button btnInventory;
        private System.Windows.Forms.Button btnMarketRefreshAll;
        private System.Windows.Forms.Label lblForMarketCount;
        private System.Windows.Forms.Label lblMarketCount;
        private System.Windows.Forms.Button btnInventoryRefreshAll;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Label lblInventoryCount;
        private System.Windows.Forms.Label lblForInventoryCount;
        private System.Windows.Forms.TableLayoutPanel tlpPriceChartsInfo;
        private System.Windows.Forms.NumericUpDown chartCountNumericUpDown;
        private System.Windows.Forms.Label lblCharts;
        private System.Windows.Forms.TableLayoutPanel tlpPriceChartsLabels;
        private System.Windows.Forms.TableLayoutPanel tlpPriceCharts;
        private System.Windows.Forms.Button btnStopMarket;
        private System.Windows.Forms.Label lblMarketTooManyRequests;
        private System.Windows.Forms.Button btnMarketGet;
        private System.Windows.Forms.Label lblInventoryTooManyRequests;
        private System.Windows.Forms.ComboBox cboFilterBy;
        private System.Windows.Forms.Label lblFilterBy;
    }
}