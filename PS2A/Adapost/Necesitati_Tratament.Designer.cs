namespace Adapost
{
    partial class Necesitati_Tratament
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
            this.btnAfisareHrana = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnInapoi = new System.Windows.Forms.Button();
            this.tbHrana = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbCautareAnimal = new System.Windows.Forms.TextBox();
            this.tbMedic = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btnAfisareAnimal = new System.Windows.Forms.Button();
            this.btnAfisareMedic = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 75);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(706, 184);
            this.dataGridView1.TabIndex = 0;
            // 
            // btnAfisareHrana
            // 
            this.btnAfisareHrana.Location = new System.Drawing.Point(235, 3);
            this.btnAfisareHrana.Name = "btnAfisareHrana";
            this.btnAfisareHrana.Size = new System.Drawing.Size(75, 23);
            this.btnAfisareHrana.TabIndex = 1;
            this.btnAfisareHrana.Text = "Afișare";
            this.btnAfisareHrana.UseVisualStyleBackColor = true;
            this.btnAfisareHrana.Click += new System.EventHandler(this.btnAfisareHrana_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 26);
            this.label1.TabIndex = 2;
            this.label1.Text = "Introduceți un tip de hrană:";
            // 
            // btnInapoi
            // 
            this.btnInapoi.Location = new System.Drawing.Point(534, 534);
            this.btnInapoi.Name = "btnInapoi";
            this.btnInapoi.Size = new System.Drawing.Size(75, 23);
            this.btnInapoi.TabIndex = 3;
            this.btnInapoi.Text = "Înapoi";
            this.btnInapoi.UseVisualStyleBackColor = true;
            this.btnInapoi.Click += new System.EventHandler(this.btnInapoi_Click);
            // 
            // tbHrana
            // 
            this.tbHrana.Location = new System.Drawing.Point(119, 3);
            this.tbHrana.Name = "tbHrana";
            this.tbHrana.Size = new System.Drawing.Size(100, 20);
            this.tbHrana.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 26);
            this.label2.TabIndex = 5;
            this.label2.Text = "Introduceți nume animal:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 26);
            this.label3.TabIndex = 6;
            this.label3.Text = "Introduceți nume medic:";
            // 
            // tbCautareAnimal
            // 
            this.tbCautareAnimal.Location = new System.Drawing.Point(119, 46);
            this.tbCautareAnimal.Name = "tbCautareAnimal";
            this.tbCautareAnimal.Size = new System.Drawing.Size(100, 20);
            this.tbCautareAnimal.TabIndex = 7;
            // 
            // tbMedic
            // 
            this.tbMedic.Location = new System.Drawing.Point(119, 90);
            this.tbMedic.Name = "tbMedic";
            this.tbMedic.Size = new System.Drawing.Size(100, 20);
            this.tbMedic.TabIndex = 8;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 92F));
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tbMedic, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.btnAfisareHrana, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.tbHrana, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.tbCautareAnimal, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.btnAfisareAnimal, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.btnAfisareMedic, 2, 2);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(54, 377);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 48.91304F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 51.08696F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 41F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(324, 129);
            this.tableLayoutPanel1.TabIndex = 9;
            // 
            // btnAfisareAnimal
            // 
            this.btnAfisareAnimal.Location = new System.Drawing.Point(235, 46);
            this.btnAfisareAnimal.Name = "btnAfisareAnimal";
            this.btnAfisareAnimal.Size = new System.Drawing.Size(75, 23);
            this.btnAfisareAnimal.TabIndex = 9;
            this.btnAfisareAnimal.Text = "Afișare";
            this.btnAfisareAnimal.UseVisualStyleBackColor = true;
            this.btnAfisareAnimal.Click += new System.EventHandler(this.btnAfisareAnimal_Click_1);
            // 
            // btnAfisareMedic
            // 
            this.btnAfisareMedic.Location = new System.Drawing.Point(235, 90);
            this.btnAfisareMedic.Name = "btnAfisareMedic";
            this.btnAfisareMedic.Size = new System.Drawing.Size(75, 23);
            this.btnAfisareMedic.TabIndex = 10;
            this.btnAfisareMedic.Text = "Afișare";
            this.btnAfisareMedic.UseVisualStyleBackColor = true;
            this.btnAfisareMedic.Click += new System.EventHandler(this.btnAfisareMedic_Click);
            // 
            // Necesitati_Tratament
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(725, 612);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.btnInapoi);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Necesitati_Tratament";
            this.Text = "Necesități și Tratament";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnAfisareHrana;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnInapoi;
        private System.Windows.Forms.TextBox tbHrana;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbCautareAnimal;
        private System.Windows.Forms.TextBox tbMedic;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button btnAfisareAnimal;
        private System.Windows.Forms.Button btnAfisareMedic;
    }
}