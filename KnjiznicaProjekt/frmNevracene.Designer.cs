namespace KnjiznicaProjekt
{
    partial class frmNevracene
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmNevracene));
            this.knjiznicaProjektDataSet = new KnjiznicaProjekt.KnjiznicaProjektDataSet();
            this.nevraceneKnjigeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.nevraceneKnjigeTableAdapter = new KnjiznicaProjekt.KnjiznicaProjektDataSetTableAdapters.NevraceneKnjigeTableAdapter();
            this.tableAdapterManager = new KnjiznicaProjekt.KnjiznicaProjektDataSetTableAdapters.TableAdapterManager();
            this.posuditeljiTableAdapter = new KnjiznicaProjekt.KnjiznicaProjektDataSetTableAdapters.PosuditeljiTableAdapter();
            this.nevraceneKnjigeBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.nevraceneKnjigeBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.nevraceneKnjigeDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.knjiznicaProjektDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.posuditeljiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.knjiznicaProjektDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nevraceneKnjigeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nevraceneKnjigeBindingNavigator)).BeginInit();
            this.nevraceneKnjigeBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nevraceneKnjigeDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.knjiznicaProjektDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.posuditeljiBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // knjiznicaProjektDataSet
            // 
            this.knjiznicaProjektDataSet.DataSetName = "KnjiznicaProjektDataSet";
            this.knjiznicaProjektDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // nevraceneKnjigeBindingSource
            // 
            this.nevraceneKnjigeBindingSource.DataMember = "NevraceneKnjige";
            this.nevraceneKnjigeBindingSource.DataSource = this.knjiznicaProjektDataSet;
            // 
            // nevraceneKnjigeTableAdapter
            // 
            this.nevraceneKnjigeTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.KnjigeTableAdapter = null;
            this.tableAdapterManager.LoginTableAdapter = null;
            this.tableAdapterManager.PosuditeljiTableAdapter = this.posuditeljiTableAdapter;
            this.tableAdapterManager.TransakcijeTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = KnjiznicaProjekt.KnjiznicaProjektDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // posuditeljiTableAdapter
            // 
            this.posuditeljiTableAdapter.ClearBeforeFill = true;
            // 
            // nevraceneKnjigeBindingNavigator
            // 
            this.nevraceneKnjigeBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.nevraceneKnjigeBindingNavigator.BindingSource = this.nevraceneKnjigeBindingSource;
            this.nevraceneKnjigeBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.nevraceneKnjigeBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.nevraceneKnjigeBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.nevraceneKnjigeBindingNavigatorSaveItem});
            this.nevraceneKnjigeBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.nevraceneKnjigeBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.nevraceneKnjigeBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.nevraceneKnjigeBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.nevraceneKnjigeBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.nevraceneKnjigeBindingNavigator.Name = "nevraceneKnjigeBindingNavigator";
            this.nevraceneKnjigeBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.nevraceneKnjigeBindingNavigator.Size = new System.Drawing.Size(797, 25);
            this.nevraceneKnjigeBindingNavigator.TabIndex = 0;
            this.nevraceneKnjigeBindingNavigator.Text = "bindingNavigator1";
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
            // nevraceneKnjigeBindingNavigatorSaveItem
            // 
            this.nevraceneKnjigeBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.nevraceneKnjigeBindingNavigatorSaveItem.Enabled = false;
            this.nevraceneKnjigeBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("nevraceneKnjigeBindingNavigatorSaveItem.Image")));
            this.nevraceneKnjigeBindingNavigatorSaveItem.Name = "nevraceneKnjigeBindingNavigatorSaveItem";
            this.nevraceneKnjigeBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.nevraceneKnjigeBindingNavigatorSaveItem.Text = "Save Data";
            // 
            // nevraceneKnjigeDataGridView
            // 
            this.nevraceneKnjigeDataGridView.AutoGenerateColumns = false;
            this.nevraceneKnjigeDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.nevraceneKnjigeDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6});
            this.nevraceneKnjigeDataGridView.DataSource = this.nevraceneKnjigeBindingSource;
            this.nevraceneKnjigeDataGridView.Location = new System.Drawing.Point(12, 28);
            this.nevraceneKnjigeDataGridView.Name = "nevraceneKnjigeDataGridView";
            this.nevraceneKnjigeDataGridView.Size = new System.Drawing.Size(776, 220);
            this.nevraceneKnjigeDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "TransakcijaID";
            this.dataGridViewTextBoxColumn1.HeaderText = "TransakcijaID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Knjiga";
            this.dataGridViewTextBoxColumn2.HeaderText = "Knjiga";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Posuditelj";
            this.dataGridViewTextBoxColumn3.HeaderText = "Posuditelj";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Resizable = System.Windows.Forms.DataGridViewTriState.True;
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
            // knjiznicaProjektDataSetBindingSource
            // 
            this.knjiznicaProjektDataSetBindingSource.DataSource = this.knjiznicaProjektDataSet;
            this.knjiznicaProjektDataSetBindingSource.Position = 0;
            // 
            // posuditeljiBindingSource
            // 
            this.posuditeljiBindingSource.DataMember = "Posuditelji";
            this.posuditeljiBindingSource.DataSource = this.knjiznicaProjektDataSetBindingSource;
            // 
            // frmNevracene
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::KnjiznicaProjekt.Properties.Resources.sutterlin_g7ce574d83_1280;
            this.ClientSize = new System.Drawing.Size(797, 257);
            this.Controls.Add(this.nevraceneKnjigeDataGridView);
            this.Controls.Add(this.nevraceneKnjigeBindingNavigator);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(813, 296);
            this.MinimumSize = new System.Drawing.Size(813, 296);
            this.Name = "frmNevracene";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nevracene";
            this.Load += new System.EventHandler(this.frmNevracene_Load);
            ((System.ComponentModel.ISupportInitialize)(this.knjiznicaProjektDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nevraceneKnjigeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nevraceneKnjigeBindingNavigator)).EndInit();
            this.nevraceneKnjigeBindingNavigator.ResumeLayout(false);
            this.nevraceneKnjigeBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nevraceneKnjigeDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.knjiznicaProjektDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.posuditeljiBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private KnjiznicaProjektDataSet knjiznicaProjektDataSet;
        private System.Windows.Forms.BindingSource nevraceneKnjigeBindingSource;
        private KnjiznicaProjektDataSetTableAdapters.NevraceneKnjigeTableAdapter nevraceneKnjigeTableAdapter;
        private KnjiznicaProjektDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator nevraceneKnjigeBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton nevraceneKnjigeBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView nevraceneKnjigeDataGridView;
        private KnjiznicaProjektDataSetTableAdapters.PosuditeljiTableAdapter posuditeljiTableAdapter;
        private System.Windows.Forms.BindingSource knjiznicaProjektDataSetBindingSource;
        private System.Windows.Forms.BindingSource posuditeljiBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
    }
}