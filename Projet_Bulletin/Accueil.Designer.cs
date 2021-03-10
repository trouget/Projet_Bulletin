
namespace Projet_Bulletin
{
    partial class Accueil
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
            this.eleves_dtgv = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.eleves_dtgv)).BeginInit();
            this.SuspendLayout();
            // 
            // eleves_dtgv
            // 
            this.eleves_dtgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.eleves_dtgv.Location = new System.Drawing.Point(0, 1);
            this.eleves_dtgv.Margin = new System.Windows.Forms.Padding(4);
            this.eleves_dtgv.Name = "eleves_dtgv";
            this.eleves_dtgv.RowHeadersWidth = 51;
            this.eleves_dtgv.Size = new System.Drawing.Size(1065, 556);
            this.eleves_dtgv.TabIndex = 0;
            this.eleves_dtgv.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Accueil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.eleves_dtgv);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Accueil";
            this.Text = "Accueil";
            ((System.ComponentModel.ISupportInitialize)(this.eleves_dtgv)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView eleves_dtgv;
    }
}