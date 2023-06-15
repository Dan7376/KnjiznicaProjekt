namespace KnjiznicaProjekt
{
    partial class frmTransakcije
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTransakcije));
            this.knjiznicaProjektDataSet = new KnjiznicaProjekt.KnjiznicaProjektDataSet();
            this.transakcijeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.transakcijeTableAdapter = new KnjiznicaProjekt.KnjiznicaProjektDataSetTableAdapters.TransakcijeTableAdapter();
            this.tableAdapterManager = new KnjiznicaProjekt.KnjiznicaProjektDataSetTableAdapters.TableAdapterManager();
            this.knjigeTableAdapter = new KnjiznicaProjekt.KnjiznicaProjektDataSetTableAdapters.KnjigeTableAdapter();
            this.posuditeljiTableAdapter = new KnjiznicaProjekt.KnjiznicaProjektDataSetTableAdapters.PosuditeljiTableAdapter();
            this.transakcijeBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.transakcijeBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.transakcijeDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.knjigeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.posuditeljiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.knjiznicaProjektDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.transakcijeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.transakcijeBindingNavigator)).BeginInit();
            this.transakcijeBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.transakcijeDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.knjigeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.posuditeljiBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // knjiznicaProjektDataSet
            // 
            this.knjiznicaProjektDataSet.DataSetName = "KnjiznicaProjektDataSet";
            this.knjiznicaProjektDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // transakcijeBindingSource
            // 
            this.transakcijeBindingSource.DataMember = "Transakcije";
            this.transakcijeBindingSource.DataSource = this.knjiznicaProjektDataSet;
            // 
            // transakcijeTableAdapter
            // 
            this.transakcijeTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.KnjigeTableAdapter = this.knjigeTableAdapter;
            this.tableAdapterManager.LoginTableAdapter = null;
            this.tableAdapterManager.PosuditeljiTableAdapter = this.posuditeljiTableAdapter;
            this.tableAdapterManager.TransakcijeTableAdapter = this.transakcijeTableAdapter;
            this.tableAdapterManager.UpdateOrder = KnjiznicaProjekt.KnjiznicaProjektDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // knjigeTableAdapter
            // 
            this.knjigeTableAdapter.ClearBeforeFill = true;
            // 
            // posuditeljiTableAdapter
            // 
            this.posuditeljiTableAdapter.ClearBeforeFill = true;
            // 
            // transakcijeBindingNavigator
            // 
            this.transakcijeBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.transakcijeBindingNavigator.BindingSource = this.transakcijeBindingSource;
            this.transakcijeBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.transakcijeBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.transakcijeBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.transakcijeBindingNavigatorSaveItem});
            this.transakcijeBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.transakcijeBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.transakcijeBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.transakcijeBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.transakcijeBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.transakcijeBindingNavigator.Name = "transakcijeBindingNavigator";
            this.transakcijeBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.transakcijeBindingNavigator.Size = new System.Drawing.Size(678, 25);
            this.transakcijeBindingNavigator.TabIndex = 0;
            this.transakcijeBindingNavigator.Text = "bindingNavigator1";
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
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
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
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
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
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // transakcijeBindingNavigatorSaveItem
            // 
            this.transakcijeBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.transakcijeBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("transakcijeBindingNavigatorSaveItem.Image")));
            this.transakcijeBindingNavigatorSaveItem.Name = "transakcijeBindingNavigatorSaveItem";
            this.transakcijeBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.transakcijeBindingNavigatorSaveItem.Text = "Save Data";
            this.transakcijeBindingNavigatorSaveItem.Click += new System.EventHandler(this.transakcijeBindingNavigatorSaveItem_Click_1);
            // 
            // transakcijeDataGridView
            // 
            this.transakcijeDataGridView.AutoGenerateColumns = false;
            this.transakcijeDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.transakcijeDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6});
            this.transakcijeDataGridView.DataSource = this.transakcijeBindingSource;
            this.transakcijeDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.transakcijeDataGridView.Location = new System.Drawing.Point(0, 25);
            this.transakcijeDataGridView.Name = "transakcijeDataGridView";
            this.transakcijeDataGridView.Size = new System.Drawing.Size(678, 477);
            this.transakcijeDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "TransakcijaID";
            this.dataGridViewTextBoxColumn1.HeaderText = "TransakcijaID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "KnjigaID";
            this.dataGridViewTextBoxColumn2.DataSource = this.knjigeBindingSource;
            this.dataGridViewTextBoxColumn2.DisplayMember = "Naslov";
            this.dataGridViewTextBoxColumn2.HeaderText = "KnjigaID";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewTextBoxColumn2.ValueMember = "KnjigaID";
            // 
            // knjigeBindingSource
            // 
            this.knjigeBindingSource.DataMember = "Knjige";
            this.knjigeBindingSource.DataSource = this.knjiznicaProjektDataSet;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "PosuditeljID";
            this.dataGridViewTextBoxColumn3.DataSource = this.posuditeljiBindingSource;
            this.dataGridViewTextBoxColumn3.DisplayMember = "ImePrezime";
            this.dataGridViewTextBoxColumn3.HeaderText = "PosuditeljID";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewTextBoxColumn3.ValueMember = "PosuditeljID";
            // 
            // posuditeljiBindingSource
            // 
            this.posuditeljiBindingSource.DataMember = "Posuditelji";
            this.posuditeljiBindingSource.DataSource = this.knjiznicaProjektDataSet;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "DatumPosudbe";
            this.dataGridViewTextBoxColumn4.HeaderText = "DatumPosudbe";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "DatumVracanja";
            this.dataGridViewTextBoxColumn5.HeaderText = "DatumVracanja";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Status";
            this.dataGridViewTextBoxColumn6.HeaderText = "Status";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // frmTransakcije
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(678, 502);
            this.Controls.Add(this.transakcijeDataGridView);
            this.Controls.Add(this.transakcijeBindingNavigator);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(694, 541);
            this.MinimumSize = new System.Drawing.Size(694, 541);
            this.Name = "frmTransakcije";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Transakcije";
            this.Load += new System.EventHandler(this.frmTransakcije_Load);
            ((System.ComponentModel.ISupportInitialize)(this.knjiznicaProjektDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.transakcijeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.transakcijeBindingNavigator)).EndInit();
            this.transakcijeBindingNavigator.ResumeLayout(false);
            this.transakcijeBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.transakcijeDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.knjigeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.posuditeljiBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private KnjiznicaProjektDataSet knjiznicaProjektDataSet;
        private System.Windows.Forms.BindingSource transakcijeBindingSource;
        private KnjiznicaProjektDataSetTableAdapters.TransakcijeTableAdapter transakcijeTableAdapter;
        private KnjiznicaProjektDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator transakcijeBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton transakcijeBindingNavigatorSaveItem;
        private KnjiznicaProjektDataSetTableAdapters.KnjigeTableAdapter knjigeTableAdapter;
        private System.Windows.Forms.DataGridView transakcijeDataGridView;
        private System.Windows.Forms.BindingSource knjigeBindingSource;
        private KnjiznicaProjektDataSetTableAdapters.PosuditeljiTableAdapter posuditeljiTableAdapter;
        private System.Windows.Forms.BindingSource posuditeljiBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewComboBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewComboBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
    }
}