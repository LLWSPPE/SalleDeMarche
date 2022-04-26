
namespace LLWS.UserInterface.Products
{
    partial class Products
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Products));
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.dtgCotations = new System.Windows.Forms.DataGridView();
            this.lblProduct = new System.Windows.Forms.Label();
            this.lblBonjour = new System.Windows.Forms.Label();
            this.lblSubBonjour = new System.Windows.Forms.Label();
            this.pnlHistorique = new System.Windows.Forms.Panel();
            this.dtgHistorique = new System.Windows.Forms.DataGridView();
            this.chrtHistorique = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.dtgCotations)).BeginInit();
            this.pnlHistorique.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgHistorique)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chrtHistorique)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgCotations
            // 
            this.dtgCotations.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgCotations.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgCotations.DefaultCellStyle = dataGridViewCellStyle2;
            this.dtgCotations.Location = new System.Drawing.Point(12, 201);
            this.dtgCotations.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtgCotations.Name = "dtgCotations";
            this.dtgCotations.RowHeadersVisible = false;
            this.dtgCotations.RowHeadersWidth = 51;
            this.dtgCotations.RowTemplate.Height = 24;
            this.dtgCotations.Size = new System.Drawing.Size(1260, 447);
            this.dtgCotations.TabIndex = 0;
            this.dtgCotations.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgCotations_CellContentClick);
            // 
            // lblProduct
            // 
            this.lblProduct.AutoSize = true;
            this.lblProduct.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProduct.Location = new System.Drawing.Point(19, 151);
            this.lblProduct.Name = "lblProduct";
            this.lblProduct.Size = new System.Drawing.Size(176, 28);
            this.lblProduct.TabIndex = 1;
            this.lblProduct.Text = "Cotations du jour";
            // 
            // lblBonjour
            // 
            this.lblBonjour.AutoSize = true;
            this.lblBonjour.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBonjour.Location = new System.Drawing.Point(16, 30);
            this.lblBonjour.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBonjour.Name = "lblBonjour";
            this.lblBonjour.Size = new System.Drawing.Size(359, 37);
            this.lblBonjour.TabIndex = 2;
            this.lblBonjour.Text = "Bienvenue sur LLWS Network";
            // 
            // lblSubBonjour
            // 
            this.lblSubBonjour.AutoSize = true;
            this.lblSubBonjour.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubBonjour.Location = new System.Drawing.Point(21, 91);
            this.lblSubBonjour.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSubBonjour.Name = "lblSubBonjour";
            this.lblSubBonjour.Size = new System.Drawing.Size(824, 34);
            this.lblSubBonjour.TabIndex = 3;
            this.lblSubBonjour.Text = resources.GetString("lblSubBonjour.Text");
            // 
            // pnlHistorique
            // 
            this.pnlHistorique.Controls.Add(this.chrtHistorique);
            this.pnlHistorique.Location = new System.Drawing.Point(12, 653);
            this.pnlHistorique.Name = "pnlHistorique";
            this.pnlHistorique.Size = new System.Drawing.Size(985, 209);
            this.pnlHistorique.TabIndex = 4;
            // 
            // dtgHistorique
            // 
            this.dtgHistorique.AllowUserToAddRows = false;
            this.dtgHistorique.AllowUserToDeleteRows = false;
            this.dtgHistorique.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgHistorique.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgHistorique.Location = new System.Drawing.Point(656, 653);
            this.dtgHistorique.Name = "dtgHistorique";
            this.dtgHistorique.RowHeadersVisible = false;
            this.dtgHistorique.RowTemplate.Height = 24;
            this.dtgHistorique.Size = new System.Drawing.Size(616, 209);
            this.dtgHistorique.TabIndex = 0;
            // 
            // chrtHistorique
            // 
            this.chrtHistorique.BorderlineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dot;
            chartArea2.Name = "ChartArea1";
            this.chrtHistorique.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chrtHistorique.Legends.Add(legend2);
            this.chrtHistorique.Location = new System.Drawing.Point(0, 0);
            this.chrtHistorique.Name = "chrtHistorique";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.chrtHistorique.Series.Add(series2);
            this.chrtHistorique.Size = new System.Drawing.Size(651, 206);
            this.chrtHistorique.TabIndex = 0;
            this.chrtHistorique.Text = "chart1";
            // 
            // Products
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1506, 874);
            this.Controls.Add(this.dtgHistorique);
            this.Controls.Add(this.pnlHistorique);
            this.Controls.Add(this.lblSubBonjour);
            this.Controls.Add(this.lblBonjour);
            this.Controls.Add(this.lblProduct);
            this.Controls.Add(this.dtgCotations);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Products";
            this.Text = "Products";
            ((System.ComponentModel.ISupportInitialize)(this.dtgCotations)).EndInit();
            this.pnlHistorique.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgHistorique)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chrtHistorique)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgCotations;
        private System.Windows.Forms.Label lblProduct;
        private System.Windows.Forms.Label lblBonjour;
        private System.Windows.Forms.Label lblSubBonjour;
        private System.Windows.Forms.Panel pnlHistorique;
        private System.Windows.Forms.DataGridView dtgHistorique;
        private System.Windows.Forms.DataVisualization.Charting.Chart chrtHistorique;
    }
}