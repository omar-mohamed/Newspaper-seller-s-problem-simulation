namespace Simulation_task
{
    partial class Demandprobabilitydistribution
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.demand = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Good = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fair = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Poor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.demand,
            this.Good,
            this.Fair,
            this.Poor});
            this.dataGridView1.Location = new System.Drawing.Point(44, 60);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(524, 400);
            this.dataGridView1.TabIndex = 6;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(44, 32);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(525, 52);
            this.textBox1.TabIndex = 5;
            this.textBox1.Text = "Demand probability distribution";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(652, 413);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "Finish";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // demand
            // 
            this.demand.HeaderText = "Demand";
            this.demand.Name = "demand";
            this.demand.Width = 120;
            // 
            // Good
            // 
            this.Good.HeaderText = "Good";
            this.Good.Name = "Good";
            this.Good.Width = 120;
            // 
            // Fair
            // 
            this.Fair.HeaderText = "Fair";
            this.Fair.Name = "Fair";
            this.Fair.Width = 120;
            // 
            // Poor
            // 
            this.Poor.HeaderText = "Poor";
            this.Poor.Name = "Poor";
            this.Poor.Width = 120;
            // 
            // Demandprobabilitydistribution
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(759, 512);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.textBox1);
            this.Name = "Demandprobabilitydistribution";
            this.Text = "Distribution_for_type_of_newsday";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewTextBoxColumn demand;
        private System.Windows.Forms.DataGridViewTextBoxColumn Good;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fair;
        private System.Windows.Forms.DataGridViewTextBoxColumn Poor;
    }
}