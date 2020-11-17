namespace MTP_L7
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnCauta = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btnAdaugaConsultatie = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.pediatrieDataSet = new MTP_L7.pediatrieDataSet();
            this.pacientiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pacientiTableAdapter = new MTP_L7.pediatrieDataSetTableAdapters.pacientiTableAdapter();
            this.tableAdapterManager = new MTP_L7.pediatrieDataSetTableAdapters.TableAdapterManager();
            this.cNPDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prenumeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sexDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numemamaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numetataDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datanasteriiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.loculnasteriiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aPGARDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.medicfamilieDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.antecedenteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pediatrieDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pacientiBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Introduceti numele cautat: ";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(162, 69);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(207, 20);
            this.textBox1.TabIndex = 1;
            // 
            // btnCauta
            // 
            this.btnCauta.Location = new System.Drawing.Point(390, 65);
            this.btnCauta.Name = "btnCauta";
            this.btnCauta.Size = new System.Drawing.Size(75, 24);
            this.btnCauta.TabIndex = 2;
            this.btnCauta.Text = "Cauta";
            this.btnCauta.UseVisualStyleBackColor = true;
            this.btnCauta.Click += new System.EventHandler(this.btnCauta_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(199, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 29);
            this.label2.TabIndex = 3;
            this.label2.Text = "Pacienti";
            // 
            // btnAdaugaConsultatie
            // 
            this.btnAdaugaConsultatie.Location = new System.Drawing.Point(18, 311);
            this.btnAdaugaConsultatie.Name = "btnAdaugaConsultatie";
            this.btnAdaugaConsultatie.Size = new System.Drawing.Size(127, 51);
            this.btnAdaugaConsultatie.TabIndex = 4;
            this.btnAdaugaConsultatie.Text = "Adauga Consultatie";
            this.btnAdaugaConsultatie.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(179, 311);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(127, 51);
            this.button2.TabIndex = 5;
            this.button2.Text = "Vizualizare Fisa Pacient";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(338, 311);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(127, 51);
            this.button3.TabIndex = 6;
            this.button3.Text = "Adauga Radiografii";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(179, 395);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(127, 51);
            this.button4.TabIndex = 7;
            this.button4.Text = "Inchide Aplicatie";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cNPDataGridViewTextBoxColumn,
            this.numeDataGridViewTextBoxColumn,
            this.prenumeDataGridViewTextBoxColumn,
            this.sexDataGridViewTextBoxColumn,
            this.numemamaDataGridViewTextBoxColumn,
            this.numetataDataGridViewTextBoxColumn,
            this.datanasteriiDataGridViewTextBoxColumn,
            this.loculnasteriiDataGridViewTextBoxColumn,
            this.aPGARDataGridViewTextBoxColumn,
            this.medicfamilieDataGridViewTextBoxColumn,
            this.antecedenteDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.pacientiBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(18, 107);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(450, 166);
            this.dataGridView1.TabIndex = 8;
            // 
            // pediatrieDataSet
            // 
            this.pediatrieDataSet.DataSetName = "pediatrieDataSet";
            this.pediatrieDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pacientiBindingSource
            // 
            this.pacientiBindingSource.DataMember = "pacienti";
            this.pacientiBindingSource.DataSource = this.pediatrieDataSet;
            // 
            // pacientiTableAdapter
            // 
            this.pacientiTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.consultatiiTableAdapter = null;
            this.tableAdapterManager.pacientiTableAdapter = this.pacientiTableAdapter;
            this.tableAdapterManager.radiografiiTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = MTP_L7.pediatrieDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // cNPDataGridViewTextBoxColumn
            // 
            this.cNPDataGridViewTextBoxColumn.DataPropertyName = "CNP";
            this.cNPDataGridViewTextBoxColumn.HeaderText = "CNP";
            this.cNPDataGridViewTextBoxColumn.Name = "cNPDataGridViewTextBoxColumn";
            // 
            // numeDataGridViewTextBoxColumn
            // 
            this.numeDataGridViewTextBoxColumn.DataPropertyName = "Nume";
            this.numeDataGridViewTextBoxColumn.HeaderText = "Nume";
            this.numeDataGridViewTextBoxColumn.Name = "numeDataGridViewTextBoxColumn";
            // 
            // prenumeDataGridViewTextBoxColumn
            // 
            this.prenumeDataGridViewTextBoxColumn.DataPropertyName = "Prenume";
            this.prenumeDataGridViewTextBoxColumn.HeaderText = "Prenume";
            this.prenumeDataGridViewTextBoxColumn.Name = "prenumeDataGridViewTextBoxColumn";
            // 
            // sexDataGridViewTextBoxColumn
            // 
            this.sexDataGridViewTextBoxColumn.DataPropertyName = "Sex";
            this.sexDataGridViewTextBoxColumn.HeaderText = "Sex";
            this.sexDataGridViewTextBoxColumn.Name = "sexDataGridViewTextBoxColumn";
            // 
            // numemamaDataGridViewTextBoxColumn
            // 
            this.numemamaDataGridViewTextBoxColumn.DataPropertyName = "Nume_mama";
            this.numemamaDataGridViewTextBoxColumn.HeaderText = "Nume_mama";
            this.numemamaDataGridViewTextBoxColumn.Name = "numemamaDataGridViewTextBoxColumn";
            // 
            // numetataDataGridViewTextBoxColumn
            // 
            this.numetataDataGridViewTextBoxColumn.DataPropertyName = "Nume_tata";
            this.numetataDataGridViewTextBoxColumn.HeaderText = "Nume_tata";
            this.numetataDataGridViewTextBoxColumn.Name = "numetataDataGridViewTextBoxColumn";
            // 
            // datanasteriiDataGridViewTextBoxColumn
            // 
            this.datanasteriiDataGridViewTextBoxColumn.DataPropertyName = "Data_nasterii";
            this.datanasteriiDataGridViewTextBoxColumn.HeaderText = "Data_nasterii";
            this.datanasteriiDataGridViewTextBoxColumn.Name = "datanasteriiDataGridViewTextBoxColumn";
            // 
            // loculnasteriiDataGridViewTextBoxColumn
            // 
            this.loculnasteriiDataGridViewTextBoxColumn.DataPropertyName = "Locul_nasterii";
            this.loculnasteriiDataGridViewTextBoxColumn.HeaderText = "Locul_nasterii";
            this.loculnasteriiDataGridViewTextBoxColumn.Name = "loculnasteriiDataGridViewTextBoxColumn";
            // 
            // aPGARDataGridViewTextBoxColumn
            // 
            this.aPGARDataGridViewTextBoxColumn.DataPropertyName = "APGAR";
            this.aPGARDataGridViewTextBoxColumn.HeaderText = "APGAR";
            this.aPGARDataGridViewTextBoxColumn.Name = "aPGARDataGridViewTextBoxColumn";
            // 
            // medicfamilieDataGridViewTextBoxColumn
            // 
            this.medicfamilieDataGridViewTextBoxColumn.DataPropertyName = "Medic_familie";
            this.medicfamilieDataGridViewTextBoxColumn.HeaderText = "Medic_familie";
            this.medicfamilieDataGridViewTextBoxColumn.Name = "medicfamilieDataGridViewTextBoxColumn";
            // 
            // antecedenteDataGridViewTextBoxColumn
            // 
            this.antecedenteDataGridViewTextBoxColumn.DataPropertyName = "Antecedente";
            this.antecedenteDataGridViewTextBoxColumn.HeaderText = "Antecedente";
            this.antecedenteDataGridViewTextBoxColumn.Name = "antecedenteDataGridViewTextBoxColumn";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(503, 469);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnAdaugaConsultatie);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnCauta);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pediatrieDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pacientiBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnCauta;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnAdaugaConsultatie;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.DataGridView dataGridView1;
        private pediatrieDataSet pediatrieDataSet;
        private System.Windows.Forms.BindingSource pacientiBindingSource;
        private pediatrieDataSetTableAdapters.pacientiTableAdapter pacientiTableAdapter;
        private pediatrieDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridViewTextBoxColumn cNPDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn prenumeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sexDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numemamaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numetataDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn datanasteriiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn loculnasteriiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aPGARDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn medicfamilieDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn antecedenteDataGridViewTextBoxColumn;
    }
}

