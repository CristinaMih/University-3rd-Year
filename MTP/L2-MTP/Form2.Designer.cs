namespace L2_MTP
{
    partial class Form2
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.NumeTF = new System.Windows.Forms.TextBox();
            this.VarstaTF = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.checkBC = new System.Windows.Forms.CheckBox();
            this.checkBCp = new System.Windows.Forms.CheckBox();
            this.checkBJ = new System.Windows.Forms.CheckBox();
            this.btnTrimite = new System.Windows.Forms.Button();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.VarstaTF);
            this.groupBox1.Controls.Add(this.NumeTF);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(45, 60);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(249, 180);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Date Personale";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nume";
            // 
            // NumeTF
            // 
            this.NumeTF.Location = new System.Drawing.Point(92, 56);
            this.NumeTF.Name = "NumeTF";
            this.NumeTF.Size = new System.Drawing.Size(100, 20);
            this.NumeTF.TabIndex = 1;
            // 
            // VarstaTF
            // 
            this.VarstaTF.Location = new System.Drawing.Point(92, 103);
            this.VarstaTF.Name = "VarstaTF";
            this.VarstaTF.Size = new System.Drawing.Size(100, 20);
            this.VarstaTF.TabIndex = 2;
            this.VarstaTF.TextChanged += new System.EventHandler(this.VarstaTF_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Varsta";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(42, 256);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Judet";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Items.AddRange(new object[] {
            "Alba",
            "Hunedoara",
            "Timis",
            "Olt"});
            this.listBox1.Location = new System.Drawing.Point(45, 283);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(120, 95);
            this.listBox1.TabIndex = 2;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(311, 283);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(67, 17);
            this.radioButton1.TabIndex = 3;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Masculin";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(311, 324);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(61, 17);
            this.radioButton2.TabIndex = 4;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Feminin";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // checkBC
            // 
            this.checkBC.AutoSize = true;
            this.checkBC.Location = new System.Drawing.Point(234, 280);
            this.checkBC.Name = "checkBC";
            this.checkBC.Size = new System.Drawing.Size(33, 17);
            this.checkBC.TabIndex = 5;
            this.checkBC.Text = "C";
            this.checkBC.UseVisualStyleBackColor = true;
            // 
            // checkBCp
            // 
            this.checkBCp.AutoSize = true;
            this.checkBCp.Location = new System.Drawing.Point(234, 303);
            this.checkBCp.Name = "checkBCp";
            this.checkBCp.Size = new System.Drawing.Size(45, 17);
            this.checkBCp.TabIndex = 6;
            this.checkBCp.Text = "C++";
            this.checkBCp.UseVisualStyleBackColor = true;
            // 
            // checkBJ
            // 
            this.checkBJ.AutoSize = true;
            this.checkBJ.Location = new System.Drawing.Point(234, 326);
            this.checkBJ.Name = "checkBJ";
            this.checkBJ.Size = new System.Drawing.Size(49, 17);
            this.checkBJ.TabIndex = 7;
            this.checkBJ.Text = "Java";
            this.checkBJ.UseVisualStyleBackColor = true;
            // 
            // btnTrimite
            // 
            this.btnTrimite.Location = new System.Drawing.Point(248, 373);
            this.btnTrimite.Name = "btnTrimite";
            this.btnTrimite.Size = new System.Drawing.Size(75, 23);
            this.btnTrimite.TabIndex = 8;
            this.btnTrimite.Text = "Trimite";
            this.btnTrimite.UseVisualStyleBackColor = true;
            this.btnTrimite.Click += new System.EventHandler(this.btnTrimite_Click);
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.Location = new System.Drawing.Point(332, 67);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(390, 173);
            this.listBox2.TabIndex = 9;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.btnTrimite);
            this.Controls.Add(this.checkBJ);
            this.Controls.Add(this.checkBCp);
            this.Controls.Add(this.checkBC);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox VarstaTF;
        private System.Windows.Forms.TextBox NumeTF;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.CheckBox checkBC;
        private System.Windows.Forms.CheckBox checkBCp;
        private System.Windows.Forms.CheckBox checkBJ;
        private System.Windows.Forms.Button btnTrimite;
        private System.Windows.Forms.ListBox listBox2;
    }
}