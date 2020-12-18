namespace Adapost
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
            this.btnAfisareAnimale = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnPersoane = new System.Windows.Forms.Button();
            this.btnAdoptie = new System.Windows.Forms.Button();
            this.buttonNecesități = new System.Windows.Forms.Button();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAfisareAnimale
            // 
            this.btnAfisareAnimale.Location = new System.Drawing.Point(3, 3);
            this.btnAfisareAnimale.Name = "btnAfisareAnimale";
            this.btnAfisareAnimale.Size = new System.Drawing.Size(191, 52);
            this.btnAfisareAnimale.TabIndex = 0;
            this.btnAfisareAnimale.Text = "Afișare Animale";
            this.btnAfisareAnimale.UseVisualStyleBackColor = true;
            this.btnAfisareAnimale.Click += new System.EventHandler(this.btnAfisareAnimale_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.btnAfisareAnimale);
            this.flowLayoutPanel1.Controls.Add(this.btnPersoane);
            this.flowLayoutPanel1.Controls.Add(this.btnAdoptie);
            this.flowLayoutPanel1.Controls.Add(this.buttonNecesități);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(51, 68);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(194, 346);
            this.flowLayoutPanel1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(26, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(276, 37);
            this.label1.TabIndex = 2;
            this.label1.Text = "Adăpost Animale";
            // 
            // btnPersoane
            // 
            this.btnPersoane.Location = new System.Drawing.Point(3, 61);
            this.btnPersoane.Name = "btnPersoane";
            this.btnPersoane.Size = new System.Drawing.Size(191, 55);
            this.btnPersoane.TabIndex = 1;
            this.btnPersoane.Text = "Donatori/Adoptori";
            this.btnPersoane.UseVisualStyleBackColor = true;
            this.btnPersoane.Click += new System.EventHandler(this.btnPersoane_Click);
            // 
            // btnAdoptie
            // 
            this.btnAdoptie.Location = new System.Drawing.Point(3, 122);
            this.btnAdoptie.Name = "btnAdoptie";
            this.btnAdoptie.Size = new System.Drawing.Size(191, 51);
            this.btnAdoptie.TabIndex = 2;
            this.btnAdoptie.Text = "Animale adoptate/donate";
            this.btnAdoptie.UseVisualStyleBackColor = true;
            this.btnAdoptie.Click += new System.EventHandler(this.btnAdoptie_Click);
            // 
            // buttonNecesități
            // 
            this.buttonNecesități.Location = new System.Drawing.Point(3, 179);
            this.buttonNecesități.Name = "buttonNecesități";
            this.buttonNecesități.Size = new System.Drawing.Size(191, 50);
            this.buttonNecesități.TabIndex = 3;
            this.buttonNecesități.Text = "Necesități/tratament";
            this.buttonNecesități.UseVisualStyleBackColor = true;
            this.buttonNecesități.Click += new System.EventHandler(this.buttonNecesități_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(318, 477);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Name = "Form1";
            this.Text = "Pagina Principala";
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAfisareAnimale;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button btnPersoane;
        private System.Windows.Forms.Button btnAdoptie;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonNecesități;
    }
}

