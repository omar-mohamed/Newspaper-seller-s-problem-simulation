namespace Simulation_task
{
    partial class results_table
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Day = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.randomNewsDayType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NewsDayType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RandomDigitDemand = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Demand = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RevenueFromSales = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LostProfitFromExcess = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Scrap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DailyProfit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Day,
            this.randomNewsDayType,
            this.NewsDayType,
            this.RandomDigitDemand,
            this.Demand,
            this.RevenueFromSales,
            this.LostProfitFromExcess,
            this.Scrap,
            this.DailyProfit});
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(948, 567);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Day
            // 
            this.Day.HeaderText = "Day";
            this.Day.Name = "Day";
            this.Day.ReadOnly = true;
            // 
            // randomNewsDayType
            // 
            this.randomNewsDayType.HeaderText = "Random digit for newsday type";
            this.randomNewsDayType.Name = "randomNewsDayType";
            this.randomNewsDayType.ReadOnly = true;
            // 
            // NewsDayType
            // 
            this.NewsDayType.HeaderText = "NewsDayType";
            this.NewsDayType.Name = "NewsDayType";
            this.NewsDayType.ReadOnly = true;
            // 
            // RandomDigitDemand
            // 
            this.RandomDigitDemand.HeaderText = "Random digit for demand ";
            this.RandomDigitDemand.Name = "RandomDigitDemand";
            this.RandomDigitDemand.ReadOnly = true;
            // 
            // Demand
            // 
            this.Demand.HeaderText = "Demand";
            this.Demand.Name = "Demand";
            this.Demand.ReadOnly = true;
            // 
            // RevenueFromSales
            // 
            this.RevenueFromSales.HeaderText = "Revenue from sales";
            this.RevenueFromSales.Name = "RevenueFromSales";
            this.RevenueFromSales.ReadOnly = true;
            // 
            // LostProfitFromExcess
            // 
            this.LostProfitFromExcess.HeaderText = "Lost Profit From Excess Demand";
            this.LostProfitFromExcess.Name = "LostProfitFromExcess";
            this.LostProfitFromExcess.ReadOnly = true;
            // 
            // Scrap
            // 
            this.Scrap.HeaderText = "Scrap";
            this.Scrap.Name = "Scrap";
            this.Scrap.ReadOnly = true;
            // 
            // DailyProfit
            // 
            this.DailyProfit.HeaderText = "Daily profit";
            this.DailyProfit.Name = "DailyProfit";
            this.DailyProfit.ReadOnly = true;
            // 
            // results_table
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(994, 570);
            this.Controls.Add(this.dataGridView1);
            this.Name = "results_table";
            this.Text = "results_table";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Day;
        private System.Windows.Forms.DataGridViewTextBoxColumn randomNewsDayType;
        private System.Windows.Forms.DataGridViewTextBoxColumn NewsDayType;
        private System.Windows.Forms.DataGridViewTextBoxColumn RandomDigitDemand;
        private System.Windows.Forms.DataGridViewTextBoxColumn Demand;
        private System.Windows.Forms.DataGridViewTextBoxColumn RevenueFromSales;
        private System.Windows.Forms.DataGridViewTextBoxColumn LostProfitFromExcess;
        private System.Windows.Forms.DataGridViewTextBoxColumn Scrap;
        private System.Windows.Forms.DataGridViewTextBoxColumn DailyProfit;
    }
}