namespace lab4
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.compmanufDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.comptypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.compyearDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantitystockDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantitysoldDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.comptableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.compDataSet = new lab4.compDataSet();
            this.comp_tableTableAdapter = new lab4.compDataSetTableAdapters.comp_tableTableAdapter();
            this.save = new System.Windows.Forms.Button();
            this.cancel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.comptableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.compDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.compmanufDataGridViewTextBoxColumn,
            this.comptypeDataGridViewTextBoxColumn,
            this.compyearDataGridViewTextBoxColumn,
            this.quantitystockDataGridViewTextBoxColumn,
            this.quantitysoldDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.comptableBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(72, 30);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(530, 148);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            // 
            // compmanufDataGridViewTextBoxColumn
            // 
            this.compmanufDataGridViewTextBoxColumn.DataPropertyName = "comp_manuf";
            this.compmanufDataGridViewTextBoxColumn.HeaderText = "comp_manuf";
            this.compmanufDataGridViewTextBoxColumn.Name = "compmanufDataGridViewTextBoxColumn";
            // 
            // comptypeDataGridViewTextBoxColumn
            // 
            this.comptypeDataGridViewTextBoxColumn.DataPropertyName = "comp_type";
            this.comptypeDataGridViewTextBoxColumn.HeaderText = "comp_type";
            this.comptypeDataGridViewTextBoxColumn.Name = "comptypeDataGridViewTextBoxColumn";
            // 
            // compyearDataGridViewTextBoxColumn
            // 
            this.compyearDataGridViewTextBoxColumn.DataPropertyName = "comp_year";
            this.compyearDataGridViewTextBoxColumn.HeaderText = "comp_year";
            this.compyearDataGridViewTextBoxColumn.Name = "comp_yearDataGridViewTextBoxColumn";
            // 
            // quantitystockDataGridViewTextBoxColumn
            // 
            this.quantitystockDataGridViewTextBoxColumn.DataPropertyName = "quantity_stock";
            this.quantitystockDataGridViewTextBoxColumn.HeaderText = "quantity_stock";
            this.quantitystockDataGridViewTextBoxColumn.Name = "quantity_stockDataGridViewTextBoxColumn";
            // 
            // quantity_soldDataGridViewTextBoxColumn
            // 
            this.quantitysoldDataGridViewTextBoxColumn.DataPropertyName = "quantity_sold";
            this.quantitysoldDataGridViewTextBoxColumn.HeaderText = "quantity_sold";
            this.quantitysoldDataGridViewTextBoxColumn.Name = "quantity_soldDataGridViewTextBoxColumn";
            // 
            // comptableBindingSource
            // 
            this.comptableBindingSource.DataMember = "comp_table";
            this.comptableBindingSource.DataSource = this.compDataSet;
            // 
            // compDataSet
            // 
            this.compDataSet.DataSetName = "compDataSet";
            this.compDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // comp_tableTableAdapter
            // 
            this.comp_tableTableAdapter.ClearBeforeFill = true;
            // 
            // save
            // 
            this.save.Location = new System.Drawing.Point(168, 194);
            this.save.Margin = new System.Windows.Forms.Padding(2);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(106, 27);
            this.save.TabIndex = 1;
            this.save.Text = "Сохранить";
            this.save.UseVisualStyleBackColor = true;
            this.save.Click += new System.EventHandler(this.save_Click);
            // 
            // cancel
            // 
            this.cancel.Location = new System.Drawing.Point(305, 194);
            this.cancel.Margin = new System.Windows.Forms.Padding(2);
            this.cancel.Name = "cancel";
            this.cancel.Size = new System.Drawing.Size(107, 27);
            this.cancel.TabIndex = 2;
            this.cancel.Text = "Отменить";
            this.cancel.UseVisualStyleBackColor = true;
            this.cancel.Click += new System.EventHandler(this.cancel_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(638, 296);
            this.Controls.Add(this.cancel);
            this.Controls.Add(this.save);
            this.Controls.Add(this.dataGridView1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.comptableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.compDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private compDataSet compDataSet;
        private System.Windows.Forms.BindingSource comptableBindingSource;
        private compDataSetTableAdapters.comp_tableTableAdapter comp_tableTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn compmanufDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn comptypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn compyearDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantitystockDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantitysoldDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button save;
        private System.Windows.Forms.Button cancel;
    }
}

