
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
            this.nom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prenom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.année1 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.année2 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.certification = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.eleves_dtgv)).BeginInit();
            this.SuspendLayout();
            // 
            // eleves_dtgv
            // 
            this.eleves_dtgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.eleves_dtgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nom,
            this.prenom,
            this.année1,
            this.année2,
            this.certification});
            this.eleves_dtgv.Location = new System.Drawing.Point(129, 27);
            this.eleves_dtgv.Name = "eleves_dtgv";
            this.eleves_dtgv.Size = new System.Drawing.Size(544, 377);
            this.eleves_dtgv.TabIndex = 0;
            this.eleves_dtgv.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // nom
            // 
            this.nom.HeaderText = "nom";
            this.nom.Name = "nom";
            // 
            // prenom
            // 
            this.prenom.HeaderText = "prenom";
            this.prenom.Name = "prenom";
            // 
            // année1
            // 
            this.année1.HeaderText = "année1";
            this.année1.Name = "année1";
            this.année1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.année1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // année2
            // 
            this.année2.HeaderText = "année2";
            this.année2.Name = "année2";
            // 
            // certification
            // 
            this.certification.HeaderText = "certification";
            this.certification.Name = "certification";
            // 
            // Accueil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.eleves_dtgv);
            this.Name = "Accueil";
            this.Text = "Accueil";
            ((System.ComponentModel.ISupportInitialize)(this.eleves_dtgv)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView eleves_dtgv;
        private System.Windows.Forms.DataGridViewTextBoxColumn nom;
        private System.Windows.Forms.DataGridViewTextBoxColumn prenom;
        private System.Windows.Forms.DataGridViewButtonColumn année1;
        private System.Windows.Forms.DataGridViewButtonColumn année2;
        private System.Windows.Forms.DataGridViewButtonColumn certification;
    }
}