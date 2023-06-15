namespace KnjiznicaProjekt
{
    partial class frmPosudjene
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPosudjene));
            this.knjiznicaProjektDataSet = new KnjiznicaProjekt.KnjiznicaProjektDataSet();
            this.posudeneKnjigeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.posudeneKnjigeTableAdapter = new KnjiznicaProjekt.KnjiznicaProjektDataSetTableAdapters.PosudeneKnjigeTableAdapter();
            this.tableAdapterManager = new KnjiznicaProjekt.KnjiznicaProjektDataSetTableAdapters.TableAdapterManager();
            this.posudeneKnjigeDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.knjiznicaProjektDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.posudeneKnjigeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.posudeneKnjigeDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // knjiznicaProjektDataSet
            // 
            this.knjiznicaProjektDataSet.DataSetName = "KnjiznicaProjektDataSet";
            this.knjiznicaProjektDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // posudeneKnjigeBindingSource
            // 
            this.posudeneKnjigeBindingSource.DataMember = "PosudeneKnjige";
            this.posudeneKnjigeBindingSource.DataSource = this.knjiznicaProjektDataSet;
            // 
            // posudeneKnjigeTableAdapter
            // 
            this.posudeneKnjigeTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Connection = null;
            this.tableAdapterManager.KnjigeTableAdapter = null;
            this.tableAdapterManager.LoginTableAdapter = null;
            this.tableAdapterManager.PosuditeljiTableAdapter = null;
            this.tableAdapterManager.TransakcijeTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = KnjiznicaProjekt.KnjiznicaProjektDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // posudeneKnjigeDataGridView
            // 
            this.posudeneKnjigeDataGridView.AutoGenerateColumns = false;
            this.posudeneKnjigeDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.posudeneKnjigeDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6});
            this.posudeneKnjigeDataGridView.DataSource = this.posudeneKnjigeBindingSource;
            this.posudeneKnjigeDataGridView.Location = new System.Drawing.Point(3, 12);
            this.posudeneKnjigeDataGridView.Name = "posudeneKnjigeDataGridView";
            this.posudeneKnjigeDataGridView.Size = new System.Drawing.Size(776, 220);
            this.posudeneKnjigeDataGridView.TabIndex = 1;
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
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(78, 261);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(122, 20);
            this.textBox1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 264);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Knjiga";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(206, 257);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(79, 27);
            this.button1.TabIndex = 4;
            this.button1.Text = "Filtriraj";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // frmPosudjene
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::KnjiznicaProjekt.Properties.Resources.sutterlin_g7ce574d83_1280;
            this.ClientSize = new System.Drawing.Size(795, 314);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.posudeneKnjigeDataGridView);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(811, 353);
            this.MinimumSize = new System.Drawing.Size(811, 353);
            this.Name = "frmPosudjene";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Posuđene";
            this.Load += new System.EventHandler(this.frmPosudjene_Load);
            ((System.ComponentModel.ISupportInitialize)(this.knjiznicaProjektDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.posudeneKnjigeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.posudeneKnjigeDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private KnjiznicaProjektDataSet knjiznicaProjektDataSet;
        private System.Windows.Forms.BindingSource posudeneKnjigeBindingSource;
        private KnjiznicaProjektDataSetTableAdapters.PosudeneKnjigeTableAdapter posudeneKnjigeTableAdapter;
        private KnjiznicaProjektDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView posudeneKnjigeDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
    }
}