namespace WarsztatSamochodowy
{
    partial class DaneParagonu
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DaneParagonu));
            this.btbDrukuj = new System.Windows.Forms.Button();
            this.btnImageList = new System.Windows.Forms.ImageList(this.components);
            this.btnUsun = new System.Windows.Forms.Button();
            this.btnDodaj = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCena = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtIlosc = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNazwa = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nazwaProduktuDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cenaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iloscDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.razemDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.paragonBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.paragonBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btbDrukuj
            // 
            this.btbDrukuj.Font = new System.Drawing.Font("Arial Black", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btbDrukuj.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btbDrukuj.ImageIndex = 2;
            this.btbDrukuj.ImageList = this.btnImageList;
            this.btbDrukuj.Location = new System.Drawing.Point(451, 333);
            this.btbDrukuj.Name = "btbDrukuj";
            this.btbDrukuj.Size = new System.Drawing.Size(105, 54);
            this.btbDrukuj.TabIndex = 24;
            this.btbDrukuj.Text = "Drukuj";
            this.btbDrukuj.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btbDrukuj.UseVisualStyleBackColor = true;
            this.btbDrukuj.Click += new System.EventHandler(this.btbDrukuj_Click);
            // 
            // btnImageList
            // 
            this.btnImageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("btnImageList.ImageStream")));
            this.btnImageList.TransparentColor = System.Drawing.Color.Transparent;
            this.btnImageList.Images.SetKeyName(0, "śmietnik.png");
            this.btnImageList.Images.SetKeyName(1, "plusik.png");
            this.btnImageList.Images.SetKeyName(2, "drukrka.png");
            // 
            // btnUsun
            // 
            this.btnUsun.BackColor = System.Drawing.Color.Transparent;
            this.btnUsun.Font = new System.Drawing.Font("Arial Black", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnUsun.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnUsun.ImageIndex = 0;
            this.btnUsun.ImageList = this.btnImageList;
            this.btnUsun.Location = new System.Drawing.Point(341, 333);
            this.btnUsun.Name = "btnUsun";
            this.btnUsun.Size = new System.Drawing.Size(105, 54);
            this.btnUsun.TabIndex = 23;
            this.btnUsun.Text = "Usuń";
            this.btnUsun.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUsun.UseVisualStyleBackColor = false;
            // 
            // btnDodaj
            // 
            this.btnDodaj.BackColor = System.Drawing.Color.Transparent;
            this.btnDodaj.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnDodaj.Font = new System.Drawing.Font("Arial Black", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnDodaj.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDodaj.ImageIndex = 1;
            this.btnDodaj.ImageList = this.btnImageList;
            this.btnDodaj.Location = new System.Drawing.Point(230, 333);
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.Size = new System.Drawing.Size(105, 54);
            this.btnDodaj.TabIndex = 21;
            this.btnDodaj.Text = "Dodaj";
            this.btnDodaj.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDodaj.UseVisualStyleBackColor = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(47, 304);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(131, 17);
            this.label3.TabIndex = 25;
            this.label3.Text = "Cena (za sztukę)";
            // 
            // txtCena
            // 
            this.txtCena.Location = new System.Drawing.Point(184, 303);
            this.txtCena.Name = "txtCena";
            this.txtCena.Size = new System.Drawing.Size(63, 20);
            this.txtCena.TabIndex = 18;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(47, 330);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 17);
            this.label2.TabIndex = 22;
            this.label2.Text = "Ilość";
            // 
            // txtIlosc
            // 
            this.txtIlosc.Location = new System.Drawing.Point(94, 329);
            this.txtIlosc.Name = "txtIlosc";
            this.txtIlosc.Size = new System.Drawing.Size(63, 20);
            this.txtIlosc.TabIndex = 20;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(46, 277);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(172, 17);
            this.label1.TabIndex = 19;
            this.label1.Text = "Nazwa produktu/usługi";
            // 
            // txtNazwa
            // 
            this.txtNazwa.BackColor = System.Drawing.SystemColors.Window;
            this.txtNazwa.Location = new System.Drawing.Point(224, 277);
            this.txtNazwa.Name = "txtNazwa";
            this.txtNazwa.Size = new System.Drawing.Size(214, 20);
            this.txtNazwa.TabIndex = 17;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.nazwaProduktuDataGridViewTextBoxColumn,
            this.cenaDataGridViewTextBoxColumn,
            this.iloscDataGridViewTextBoxColumn,
            this.razemDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.paragonBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(545, 252);
            this.dataGridView1.TabIndex = 16;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Numer";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.Width = 50;
            // 
            // nazwaProduktuDataGridViewTextBoxColumn
            // 
            this.nazwaProduktuDataGridViewTextBoxColumn.DataPropertyName = "nazwaProduktu";
            this.nazwaProduktuDataGridViewTextBoxColumn.HeaderText = "Nazwa produktu/usługi";
            this.nazwaProduktuDataGridViewTextBoxColumn.Name = "nazwaProduktuDataGridViewTextBoxColumn";
            this.nazwaProduktuDataGridViewTextBoxColumn.Width = 230;
            // 
            // cenaDataGridViewTextBoxColumn
            // 
            this.cenaDataGridViewTextBoxColumn.DataPropertyName = "cena";
            this.cenaDataGridViewTextBoxColumn.HeaderText = "Cena";
            this.cenaDataGridViewTextBoxColumn.Name = "cenaDataGridViewTextBoxColumn";
            this.cenaDataGridViewTextBoxColumn.Width = 70;
            // 
            // iloscDataGridViewTextBoxColumn
            // 
            this.iloscDataGridViewTextBoxColumn.DataPropertyName = "ilosc";
            this.iloscDataGridViewTextBoxColumn.HeaderText = "Ilość";
            this.iloscDataGridViewTextBoxColumn.Name = "iloscDataGridViewTextBoxColumn";
            this.iloscDataGridViewTextBoxColumn.Width = 50;
            // 
            // razemDataGridViewTextBoxColumn
            // 
            this.razemDataGridViewTextBoxColumn.DataPropertyName = "razem";
            this.razemDataGridViewTextBoxColumn.HeaderText = "Razem";
            this.razemDataGridViewTextBoxColumn.Name = "razemDataGridViewTextBoxColumn";
            this.razemDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // paragonBindingSource
            // 
            this.paragonBindingSource.DataSource = typeof(WarsztatSamochodowy.Models.Paragon);
            // 
            // DaneParagonu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(569, 397);
            this.Controls.Add(this.btbDrukuj);
            this.Controls.Add(this.btnUsun);
            this.Controls.Add(this.btnDodaj);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtCena);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtIlosc);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtNazwa);
            this.Controls.Add(this.dataGridView1);
            this.Name = "DaneParagonu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Paragon";
            this.Load += new System.EventHandler(this.DaneParagonu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.paragonBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btbDrukuj;
        private System.Windows.Forms.ImageList btnImageList;
        private System.Windows.Forms.Button btnUsun;
        private System.Windows.Forms.Button btnDodaj;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtCena;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtIlosc;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNazwa;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nazwaProduktuDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cenaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iloscDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn razemDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource paragonBindingSource;
    }
}