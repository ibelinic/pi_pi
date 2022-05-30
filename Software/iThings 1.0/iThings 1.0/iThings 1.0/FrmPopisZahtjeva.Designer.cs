namespace iThings_1._0
{
    partial class FrmPopisZahtjeva
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
            this.dgvZahtjevi = new System.Windows.Forms.DataGridView();
            this.btnUnos = new System.Windows.Forms.Button();
            this.btnZatvori = new System.Windows.Forms.Button();
            this.labelaNaslovForma1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvZahtjevi)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvZahtjevi
            // 
            this.dgvZahtjevi.BackgroundColor = System.Drawing.Color.PapayaWhip;
            this.dgvZahtjevi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvZahtjevi.Location = new System.Drawing.Point(12, 87);
            this.dgvZahtjevi.Name = "dgvZahtjevi";
            this.dgvZahtjevi.RowHeadersWidth = 51;
            this.dgvZahtjevi.RowTemplate.Height = 24;
            this.dgvZahtjevi.Size = new System.Drawing.Size(878, 378);
            this.dgvZahtjevi.TabIndex = 0;
            this.dgvZahtjevi.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvZahtjevi_CellContentClick);
            // 
            // btnUnos
            // 
            this.btnUnos.BackColor = System.Drawing.Color.LightCoral;
            this.btnUnos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btnUnos.Location = new System.Drawing.Point(458, 491);
            this.btnUnos.Name = "btnUnos";
            this.btnUnos.Size = new System.Drawing.Size(249, 44);
            this.btnUnos.TabIndex = 1;
            this.btnUnos.Text = "Detaljni postupci sa zahtjevima";
            this.btnUnos.UseVisualStyleBackColor = false;
            this.btnUnos.Click += new System.EventHandler(this.btnUnos_Click);
            // 
            // btnZatvori
            // 
            this.btnZatvori.BackColor = System.Drawing.Color.Khaki;
            this.btnZatvori.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btnZatvori.Location = new System.Drawing.Point(220, 491);
            this.btnZatvori.Name = "btnZatvori";
            this.btnZatvori.Size = new System.Drawing.Size(211, 44);
            this.btnZatvori.TabIndex = 2;
            this.btnZatvori.Text = "Zatvori aplikaciju";
            this.btnZatvori.UseVisualStyleBackColor = false;
            this.btnZatvori.Click += new System.EventHandler(this.btnZatvori_Click);
            // 
            // labelaNaslovForma1
            // 
            this.labelaNaslovForma1.AutoSize = true;
            this.labelaNaslovForma1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.labelaNaslovForma1.Location = new System.Drawing.Point(312, 26);
            this.labelaNaslovForma1.Name = "labelaNaslovForma1";
            this.labelaNaslovForma1.Size = new System.Drawing.Size(239, 39);
            this.labelaNaslovForma1.TabIndex = 3;
            this.labelaNaslovForma1.Text = "Popis zahtjeva";
            // 
            // FrmPopisZahtjeva
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(902, 563);
            this.Controls.Add(this.labelaNaslovForma1);
            this.Controls.Add(this.btnZatvori);
            this.Controls.Add(this.btnUnos);
            this.Controls.Add(this.dgvZahtjevi);
            this.Name = "FrmPopisZahtjeva";
            this.Text = "Popis zahtjeva za nabavu tehničke opreme na fakultetu";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvZahtjevi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvZahtjevi;
        private System.Windows.Forms.Button btnUnos;
        private System.Windows.Forms.Button btnZatvori;
        private System.Windows.Forms.Label labelaNaslovForma1;
    }
}