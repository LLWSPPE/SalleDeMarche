
namespace LLWS.UserInterface.Mouvements
{
    partial class Mouvements
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblMouvements = new System.Windows.Forms.Label();
            this.dtgAchats = new System.Windows.Forms.DataGridView();
            this.dtgVentes = new System.Windows.Forms.DataGridView();
            this.lblAchats = new System.Windows.Forms.Label();
            this.lblVentes = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtgAchats)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgVentes)).BeginInit();
            this.SuspendLayout();
            // 
            // lblMouvements
            // 
            this.lblMouvements.AutoSize = true;
            this.lblMouvements.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMouvements.Location = new System.Drawing.Point(766, 69);
            this.lblMouvements.Name = "lblMouvements";
            this.lblMouvements.Size = new System.Drawing.Size(350, 37);
            this.lblMouvements.TabIndex = 0;
            this.lblMouvements.Text = "Historique des opérations";
            // 
            // dtgAchats
            // 
            this.dtgAchats.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Moccasin;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Gold;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgAchats.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dtgAchats.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Moccasin;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Gold;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgAchats.DefaultCellStyle = dataGridViewCellStyle2;
            this.dtgAchats.Location = new System.Drawing.Point(24, 258);
            this.dtgAchats.Name = "dtgAchats";
            this.dtgAchats.RowHeadersWidth = 51;
            this.dtgAchats.RowTemplate.Height = 24;
            this.dtgAchats.Size = new System.Drawing.Size(955, 645);
            this.dtgAchats.TabIndex = 1;
            // 
            // dtgVentes
            // 
            this.dtgVentes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgVentes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.PaleGreen;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.LimeGreen;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgVentes.DefaultCellStyle = dataGridViewCellStyle3;
            this.dtgVentes.Location = new System.Drawing.Point(1021, 258);
            this.dtgVentes.Name = "dtgVentes";
            this.dtgVentes.RowHeadersWidth = 51;
            this.dtgVentes.RowTemplate.Height = 24;
            this.dtgVentes.Size = new System.Drawing.Size(958, 645);
            this.dtgVentes.TabIndex = 2;
            // 
            // lblAchats
            // 
            this.lblAchats.AutoSize = true;
            this.lblAchats.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAchats.Location = new System.Drawing.Point(18, 202);
            this.lblAchats.Name = "lblAchats";
            this.lblAchats.Size = new System.Drawing.Size(76, 28);
            this.lblAchats.TabIndex = 3;
            this.lblAchats.Text = "Achats";
            // 
            // lblVentes
            // 
            this.lblVentes.AutoSize = true;
            this.lblVentes.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVentes.Location = new System.Drawing.Point(1015, 202);
            this.lblVentes.Name = "lblVentes";
            this.lblVentes.Size = new System.Drawing.Size(75, 28);
            this.lblVentes.TabIndex = 4;
            this.lblVentes.Text = "Ventes";
            // 
            // Mouvements
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1924, 1061);
            this.Controls.Add(this.lblVentes);
            this.Controls.Add(this.lblAchats);
            this.Controls.Add(this.dtgVentes);
            this.Controls.Add(this.dtgAchats);
            this.Controls.Add(this.lblMouvements);
            this.Name = "Mouvements";
            this.Text = "Mouvements";
            ((System.ComponentModel.ISupportInitialize)(this.dtgAchats)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgVentes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMouvements;
        private System.Windows.Forms.DataGridView dtgAchats;
        private System.Windows.Forms.DataGridView dtgVentes;
        private System.Windows.Forms.Label lblAchats;
        private System.Windows.Forms.Label lblVentes;
    }
}