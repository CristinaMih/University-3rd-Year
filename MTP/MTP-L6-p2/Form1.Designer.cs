namespace MTP_Lab6_P2_v2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.universitateBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.universitateBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.universitateDataGridView = new System.Windows.Forms.DataGridView();
            this.studentiDataGridView = new System.Windows.Forms.DataGridView();
            this.specializariDataGridView = new System.Windows.Forms.DataGridView();
            this.btnAdaugare = new System.Windows.Forms.Button();
            this.specializariBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.studentiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.universitateBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.universitateDataSet = new MTP_Lab6_P2_v2.UniversitateDataSet();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.universitateTableAdapter = new MTP_Lab6_P2_v2.UniversitateDataSetTableAdapters.UniversitateTableAdapter();
            this.tableAdapterManager = new MTP_Lab6_P2_v2.UniversitateDataSetTableAdapters.TableAdapterManager();
            this.specializariTableAdapter = new MTP_Lab6_P2_v2.UniversitateDataSetTableAdapters.SpecializariTableAdapter();
            this.studentiTableAdapter = new MTP_Lab6_P2_v2.UniversitateDataSetTableAdapters.StudentiTableAdapter();
            this.btnCautare = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.universitateBindingNavigator)).BeginInit();
            this.universitateBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.universitateDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentiDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.specializariDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.specializariBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentiBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.universitateBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.universitateDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // universitateBindingNavigator
            // 
            this.universitateBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.universitateBindingNavigator.BindingSource = this.universitateBindingSource;
            this.universitateBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.universitateBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.universitateBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.universitateBindingNavigatorSaveItem});
            this.universitateBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.universitateBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.universitateBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.universitateBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.universitateBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.universitateBindingNavigator.Name = "universitateBindingNavigator";
            this.universitateBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.universitateBindingNavigator.Size = new System.Drawing.Size(808, 25);
            this.universitateBindingNavigator.TabIndex = 0;
            this.universitateBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // universitateBindingNavigatorSaveItem
            // 
            this.universitateBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.universitateBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("universitateBindingNavigatorSaveItem.Image")));
            this.universitateBindingNavigatorSaveItem.Name = "universitateBindingNavigatorSaveItem";
            this.universitateBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.universitateBindingNavigatorSaveItem.Text = "Save Data";
            this.universitateBindingNavigatorSaveItem.Click += new System.EventHandler(this.universitateBindingNavigatorSaveItem_Click);
            // 
            // universitateDataGridView
            // 
            this.universitateDataGridView.AutoGenerateColumns = false;
            this.universitateDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.universitateDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2});
            this.universitateDataGridView.DataSource = this.universitateBindingSource;
            this.universitateDataGridView.Location = new System.Drawing.Point(28, 28);
            this.universitateDataGridView.Name = "universitateDataGridView";
            this.universitateDataGridView.Size = new System.Drawing.Size(325, 118);
            this.universitateDataGridView.TabIndex = 1;
            // 
            // studentiDataGridView
            // 
            this.studentiDataGridView.AutoGenerateColumns = false;
            this.studentiDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.studentiDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9});
            this.studentiDataGridView.DataSource = this.studentiBindingSource;
            this.studentiDataGridView.Location = new System.Drawing.Point(28, 300);
            this.studentiDataGridView.Name = "studentiDataGridView";
            this.studentiDataGridView.Size = new System.Drawing.Size(621, 182);
            this.studentiDataGridView.TabIndex = 3;
            // 
            // specializariDataGridView
            // 
            this.specializariDataGridView.AutoGenerateColumns = false;
            this.specializariDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.specializariDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            this.specializariDataGridView.DataSource = this.specializariBindingSource;
            this.specializariDataGridView.Location = new System.Drawing.Point(28, 152);
            this.specializariDataGridView.Name = "specializariDataGridView";
            this.specializariDataGridView.Size = new System.Drawing.Size(621, 142);
            this.specializariDataGridView.TabIndex = 3;
            // 
            // btnAdaugare
            // 
            this.btnAdaugare.Location = new System.Drawing.Point(373, 69);
            this.btnAdaugare.Name = "btnAdaugare";
            this.btnAdaugare.Size = new System.Drawing.Size(147, 61);
            this.btnAdaugare.TabIndex = 4;
            this.btnAdaugare.Text = "Adauga Student";
            this.btnAdaugare.UseVisualStyleBackColor = true;
            this.btnAdaugare.Click += new System.EventHandler(this.btnAdaugare_Click);
            // 
            // specializariBindingSource
            // 
            this.specializariBindingSource.DataMember = "FK__Specializ__Facul__4222D4EF";
            this.specializariBindingSource.DataSource = this.universitateBindingSource;
            // 
            // studentiBindingSource
            // 
            this.studentiBindingSource.DataMember = "FK__Studenti__Specia__4316F928";
            this.studentiBindingSource.DataSource = this.specializariBindingSource;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Specializare";
            this.dataGridViewTextBoxColumn3.HeaderText = "Specializare";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Facultate";
            this.dataGridViewTextBoxColumn4.HeaderText = "Facultate";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Nr_Studenti";
            this.dataGridViewTextBoxColumn5.HeaderText = "Nr_Studenti";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // universitateBindingSource
            // 
            this.universitateBindingSource.DataMember = "Universitate";
            this.universitateBindingSource.DataSource = this.universitateDataSet;
            // 
            // universitateDataSet
            // 
            this.universitateDataSet.DataSetName = "UniversitateDataSet";
            this.universitateDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Marca";
            this.dataGridViewTextBoxColumn6.HeaderText = "Marca";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "Specializare";
            this.dataGridViewTextBoxColumn7.HeaderText = "Specializare";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "Nume";
            this.dataGridViewTextBoxColumn8.HeaderText = "Nume";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "An_Studiu";
            this.dataGridViewTextBoxColumn9.HeaderText = "An_Studiu";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Facultate";
            this.dataGridViewTextBoxColumn1.HeaderText = "Facultate";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Adresa";
            this.dataGridViewTextBoxColumn2.HeaderText = "Adresa";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // universitateTableAdapter
            // 
            this.universitateTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.SpecializariTableAdapter = this.specializariTableAdapter;
            this.tableAdapterManager.StudentiTableAdapter = this.studentiTableAdapter;
            this.tableAdapterManager.UniversitateTableAdapter = this.universitateTableAdapter;
            this.tableAdapterManager.UpdateOrder = MTP_Lab6_P2_v2.UniversitateDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // specializariTableAdapter
            // 
            this.specializariTableAdapter.ClearBeforeFill = true;
            // 
            // studentiTableAdapter
            // 
            this.studentiTableAdapter.ClearBeforeFill = true;
            // 
            // btnCautare
            // 
            this.btnCautare.Location = new System.Drawing.Point(526, 69);
            this.btnCautare.Name = "btnCautare";
            this.btnCautare.Size = new System.Drawing.Size(123, 61);
            this.btnCautare.TabIndex = 5;
            this.btnCautare.Text = "Cauta Student";
            this.btnCautare.UseVisualStyleBackColor = true;
            this.btnCautare.Click += new System.EventHandler(this.btnCautare_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(808, 557);
            this.Controls.Add(this.btnCautare);
            this.Controls.Add(this.btnAdaugare);
            this.Controls.Add(this.specializariDataGridView);
            this.Controls.Add(this.studentiDataGridView);
            this.Controls.Add(this.universitateDataGridView);
            this.Controls.Add(this.universitateBindingNavigator);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.universitateBindingNavigator)).EndInit();
            this.universitateBindingNavigator.ResumeLayout(false);
            this.universitateBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.universitateDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentiDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.specializariDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.specializariBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentiBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.universitateBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.universitateDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private UniversitateDataSet universitateDataSet;
        private System.Windows.Forms.BindingSource universitateBindingSource;
        private UniversitateDataSetTableAdapters.UniversitateTableAdapter universitateTableAdapter;
        private UniversitateDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator universitateBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton universitateBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView universitateDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private UniversitateDataSetTableAdapters.SpecializariTableAdapter specializariTableAdapter;
        private System.Windows.Forms.BindingSource specializariBindingSource;
        private UniversitateDataSetTableAdapters.StudentiTableAdapter studentiTableAdapter;
        private System.Windows.Forms.BindingSource studentiBindingSource;
        private System.Windows.Forms.DataGridView studentiDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridView specializariDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.Button btnAdaugare;
        private System.Windows.Forms.Button btnCautare;
    }
}

