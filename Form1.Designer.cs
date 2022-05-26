
namespace XMLToExcel
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.btnReadXML = new System.Windows.Forms.Button();
            this.btnSaveToExcel = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nazwaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dlugiopisDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.wagaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kodDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eanDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.typDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cenazewnetrznahurtDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cenazewnetrznaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vatDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iloscwariantowDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ilosczdjecDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.marzaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.produktBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.produktBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btnReadXML
            // 
            this.btnReadXML.Location = new System.Drawing.Point(12, 12);
            this.btnReadXML.Name = "btnReadXML";
            this.btnReadXML.Size = new System.Drawing.Size(135, 43);
            this.btnReadXML.TabIndex = 0;
            this.btnReadXML.Text = "Wczytaj plik XML";
            this.btnReadXML.UseVisualStyleBackColor = true;
            this.btnReadXML.Click += new System.EventHandler(this.btnReadXML_Click);
            // 
            // btnSaveToExcel
            // 
            this.btnSaveToExcel.Location = new System.Drawing.Point(172, 12);
            this.btnSaveToExcel.Name = "btnSaveToExcel";
            this.btnSaveToExcel.Size = new System.Drawing.Size(165, 43);
            this.btnSaveToExcel.TabIndex = 1;
            this.btnSaveToExcel.Text = "Zapisz do pliku Excel";
            this.btnSaveToExcel.UseVisualStyleBackColor = true;
            this.btnSaveToExcel.Click += new System.EventHandler(this.btnSaveToExcel_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.btnReadXML);
            this.panel1.Controls.Add(this.btnSaveToExcel);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 80);
            this.panel1.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(378, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(154, 42);
            this.button1.TabIndex = 2;
            this.button1.Text = "Otworz plik Excel";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.nazwaDataGridViewTextBoxColumn,
            this.dlugiopisDataGridViewTextBoxColumn,
            this.wagaDataGridViewTextBoxColumn,
            this.kodDataGridViewTextBoxColumn,
            this.eanDataGridViewTextBoxColumn,
            this.statusDataGridViewTextBoxColumn,
            this.typDataGridViewTextBoxColumn,
            this.cenazewnetrznahurtDataGridViewTextBoxColumn,
            this.cenazewnetrznaDataGridViewTextBoxColumn,
            this.vatDataGridViewTextBoxColumn,
            this.iloscwariantowDataGridViewTextBoxColumn,
            this.ilosczdjecDataGridViewTextBoxColumn,
            this.marzaDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.produktBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(0, 80);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(800, 367);
            this.dataGridView1.TabIndex = 0;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.Width = 125;
            // 
            // nazwaDataGridViewTextBoxColumn
            // 
            this.nazwaDataGridViewTextBoxColumn.DataPropertyName = "Nazwa";
            this.nazwaDataGridViewTextBoxColumn.HeaderText = "Nazwa";
            this.nazwaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nazwaDataGridViewTextBoxColumn.Name = "nazwaDataGridViewTextBoxColumn";
            this.nazwaDataGridViewTextBoxColumn.Width = 125;
            // 
            // dlugiopisDataGridViewTextBoxColumn
            // 
            this.dlugiopisDataGridViewTextBoxColumn.DataPropertyName = "Dlugi_opis";
            this.dlugiopisDataGridViewTextBoxColumn.HeaderText = "Dlugi_opis";
            this.dlugiopisDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.dlugiopisDataGridViewTextBoxColumn.Name = "dlugiopisDataGridViewTextBoxColumn";
            this.dlugiopisDataGridViewTextBoxColumn.Width = 125;
            // 
            // wagaDataGridViewTextBoxColumn
            // 
            this.wagaDataGridViewTextBoxColumn.DataPropertyName = "Waga";
            this.wagaDataGridViewTextBoxColumn.HeaderText = "Waga";
            this.wagaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.wagaDataGridViewTextBoxColumn.Name = "wagaDataGridViewTextBoxColumn";
            this.wagaDataGridViewTextBoxColumn.Width = 125;
            // 
            // kodDataGridViewTextBoxColumn
            // 
            this.kodDataGridViewTextBoxColumn.DataPropertyName = "Kod";
            this.kodDataGridViewTextBoxColumn.HeaderText = "Kod";
            this.kodDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.kodDataGridViewTextBoxColumn.Name = "kodDataGridViewTextBoxColumn";
            this.kodDataGridViewTextBoxColumn.Width = 125;
            // 
            // eanDataGridViewTextBoxColumn
            // 
            this.eanDataGridViewTextBoxColumn.DataPropertyName = "Ean";
            this.eanDataGridViewTextBoxColumn.HeaderText = "Ean";
            this.eanDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.eanDataGridViewTextBoxColumn.Name = "eanDataGridViewTextBoxColumn";
            this.eanDataGridViewTextBoxColumn.Width = 125;
            // 
            // statusDataGridViewTextBoxColumn
            // 
            this.statusDataGridViewTextBoxColumn.DataPropertyName = "Status";
            this.statusDataGridViewTextBoxColumn.HeaderText = "Status";
            this.statusDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.statusDataGridViewTextBoxColumn.Name = "statusDataGridViewTextBoxColumn";
            this.statusDataGridViewTextBoxColumn.Width = 125;
            // 
            // typDataGridViewTextBoxColumn
            // 
            this.typDataGridViewTextBoxColumn.DataPropertyName = "Typ";
            this.typDataGridViewTextBoxColumn.HeaderText = "Typ";
            this.typDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.typDataGridViewTextBoxColumn.Name = "typDataGridViewTextBoxColumn";
            this.typDataGridViewTextBoxColumn.Width = 125;
            // 
            // cenazewnetrznahurtDataGridViewTextBoxColumn
            // 
            this.cenazewnetrznahurtDataGridViewTextBoxColumn.DataPropertyName = "Cena_zewnetrzna_hurt";
            this.cenazewnetrznahurtDataGridViewTextBoxColumn.HeaderText = "Cena_zewnetrzna_hurt";
            this.cenazewnetrznahurtDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.cenazewnetrznahurtDataGridViewTextBoxColumn.Name = "cenazewnetrznahurtDataGridViewTextBoxColumn";
            this.cenazewnetrznahurtDataGridViewTextBoxColumn.Width = 125;
            // 
            // cenazewnetrznaDataGridViewTextBoxColumn
            // 
            this.cenazewnetrznaDataGridViewTextBoxColumn.DataPropertyName = "Cena_zewnetrzna";
            this.cenazewnetrznaDataGridViewTextBoxColumn.HeaderText = "Cena_zewnetrzna";
            this.cenazewnetrznaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.cenazewnetrznaDataGridViewTextBoxColumn.Name = "cenazewnetrznaDataGridViewTextBoxColumn";
            this.cenazewnetrznaDataGridViewTextBoxColumn.Width = 125;
            // 
            // vatDataGridViewTextBoxColumn
            // 
            this.vatDataGridViewTextBoxColumn.DataPropertyName = "Vat";
            this.vatDataGridViewTextBoxColumn.HeaderText = "Vat";
            this.vatDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.vatDataGridViewTextBoxColumn.Name = "vatDataGridViewTextBoxColumn";
            this.vatDataGridViewTextBoxColumn.Width = 125;
            // 
            // iloscwariantowDataGridViewTextBoxColumn
            // 
            this.iloscwariantowDataGridViewTextBoxColumn.DataPropertyName = "Ilosc_wariantow";
            this.iloscwariantowDataGridViewTextBoxColumn.HeaderText = "Ilosc_wariantow";
            this.iloscwariantowDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.iloscwariantowDataGridViewTextBoxColumn.Name = "iloscwariantowDataGridViewTextBoxColumn";
            this.iloscwariantowDataGridViewTextBoxColumn.Width = 125;
            // 
            // ilosczdjecDataGridViewTextBoxColumn
            // 
            this.ilosczdjecDataGridViewTextBoxColumn.DataPropertyName = "ilosc_zdjec";
            this.ilosczdjecDataGridViewTextBoxColumn.HeaderText = "ilosc_zdjec";
            this.ilosczdjecDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.ilosczdjecDataGridViewTextBoxColumn.Name = "ilosczdjecDataGridViewTextBoxColumn";
            this.ilosczdjecDataGridViewTextBoxColumn.Width = 125;
            // 
            // marzaDataGridViewTextBoxColumn
            // 
            this.marzaDataGridViewTextBoxColumn.DataPropertyName = "Marza";
            this.marzaDataGridViewTextBoxColumn.HeaderText = "Marza";
            this.marzaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.marzaDataGridViewTextBoxColumn.Name = "marzaDataGridViewTextBoxColumn";
            this.marzaDataGridViewTextBoxColumn.Width = 125;
            // 
            // produktBindingSource
            // 
            this.produktBindingSource.DataSource = typeof(Xml2CSharp.Produkt);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.produktBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnReadXML;
        private System.Windows.Forms.Button btnSaveToExcel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridViewTextBoxColumn zdjeciaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nazwaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dlugiopisDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn wagaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kodDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn eanDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn typDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cenazewnetrznahurtDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cenazewnetrznaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vatDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iloscwariantowDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ilosczdjecDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn marzaDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource produktBindingSource;
        private System.Windows.Forms.Button button1;
    }
}

