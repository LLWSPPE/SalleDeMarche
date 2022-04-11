
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Products));
            this.dtgCotations = new System.Windows.Forms.DataGridView();
            this.lblProduct = new System.Windows.Forms.Label();
            this.lblBonjour = new System.Windows.Forms.Label();
            this.lblSubBonjour = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtgCotations)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgCotations
            // 
            this.dtgCotations.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgCotations.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgCotations.Location = new System.Drawing.Point(9, 162);
            this.dtgCotations.Margin = new System.Windows.Forms.Padding(2);
            this.dtgCotations.Name = "dtgCotations";
            this.dtgCotations.RowHeadersWidth = 51;
            this.dtgCotations.RowTemplate.Height = 24;
            this.dtgCotations.Size = new System.Drawing.Size(1034, 363);
            this.dtgCotations.TabIndex = 0;
            // 
            // lblProduct
            // 
            this.lblProduct.AutoSize = true;
            this.lblProduct.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProduct.Location = new System.Drawing.Point(14, 123);
            this.lblProduct.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblProduct.Name = "lblProduct";
            this.lblProduct.Size = new System.Drawing.Size(176, 28);
            this.lblProduct.TabIndex = 1;
            this.lblProduct.Text = "Cotations du jour";
            // 
            // lblBonjour
            // 
            this.lblBonjour.AutoSize = true;
            this.lblBonjour.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBonjour.Location = new System.Drawing.Point(12, 24);
            this.lblBonjour.Name = "lblBonjour";
            this.lblBonjour.Size = new System.Drawing.Size(359, 37);
            this.lblBonjour.TabIndex = 2;
            this.lblBonjour.Text = "Bienvenue sur LLWS Network";
            // 
            // lblSubBonjour
            // 
            this.lblSubBonjour.AutoSize = true;
            this.lblSubBonjour.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubBonjour.Location = new System.Drawing.Point(16, 74);
            this.lblSubBonjour.Name = "lblSubBonjour";
            this.lblSubBonjour.Size = new System.Drawing.Size(824, 34);
            this.lblSubBonjour.TabIndex = 3;
            this.lblSubBonjour.Text = resources.GetString("lblSubBonjour.Text");
            // 
            // Products
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1054, 592);
            this.Controls.Add(this.lblSubBonjour);
            this.Controls.Add(this.lblBonjour);
            this.Controls.Add(this.lblProduct);
            this.Controls.Add(this.dtgCotations);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Products";
            this.Text = "Products";
            ((System.ComponentModel.ISupportInitialize)(this.dtgCotations)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgCotations;
        private System.Windows.Forms.Label lblProduct;
        private System.Windows.Forms.Label lblBonjour;
        private System.Windows.Forms.Label lblSubBonjour;
    }
}