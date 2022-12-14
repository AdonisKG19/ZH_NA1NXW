namespace ZH_NA1NXW
{
    partial class UserControl3
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.textbookIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stockNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.titleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.notAvailableDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.ordersDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.textbookBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textbookBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.textbookIdDataGridViewTextBoxColumn,
            this.stockNumberDataGridViewTextBoxColumn,
            this.titleDataGridViewTextBoxColumn,
            this.priceDataGridViewTextBoxColumn,
            this.notAvailableDataGridViewCheckBoxColumn,
            this.ordersDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.textbookBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(253, 62);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(569, 368);
            this.dataGridView1.TabIndex = 0;
            // 
            // textbookIdDataGridViewTextBoxColumn
            // 
            this.textbookIdDataGridViewTextBoxColumn.DataPropertyName = "TextbookId";
            this.textbookIdDataGridViewTextBoxColumn.HeaderText = "TextbookId";
            this.textbookIdDataGridViewTextBoxColumn.Name = "textbookIdDataGridViewTextBoxColumn";
            // 
            // stockNumberDataGridViewTextBoxColumn
            // 
            this.stockNumberDataGridViewTextBoxColumn.DataPropertyName = "StockNumber";
            this.stockNumberDataGridViewTextBoxColumn.HeaderText = "StockNumber";
            this.stockNumberDataGridViewTextBoxColumn.Name = "stockNumberDataGridViewTextBoxColumn";
            // 
            // titleDataGridViewTextBoxColumn
            // 
            this.titleDataGridViewTextBoxColumn.DataPropertyName = "Title";
            this.titleDataGridViewTextBoxColumn.HeaderText = "Title";
            this.titleDataGridViewTextBoxColumn.Name = "titleDataGridViewTextBoxColumn";
            // 
            // priceDataGridViewTextBoxColumn
            // 
            this.priceDataGridViewTextBoxColumn.DataPropertyName = "Price";
            this.priceDataGridViewTextBoxColumn.HeaderText = "Price";
            this.priceDataGridViewTextBoxColumn.Name = "priceDataGridViewTextBoxColumn";
            // 
            // notAvailableDataGridViewCheckBoxColumn
            // 
            this.notAvailableDataGridViewCheckBoxColumn.DataPropertyName = "NotAvailable";
            this.notAvailableDataGridViewCheckBoxColumn.HeaderText = "NotAvailable";
            this.notAvailableDataGridViewCheckBoxColumn.Name = "notAvailableDataGridViewCheckBoxColumn";
            // 
            // ordersDataGridViewTextBoxColumn
            // 
            this.ordersDataGridViewTextBoxColumn.DataPropertyName = "Orders";
            this.ordersDataGridViewTextBoxColumn.HeaderText = "Orders";
            this.ordersDataGridViewTextBoxColumn.Name = "ordersDataGridViewTextBoxColumn";
            this.ordersDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // textbookBindingSource
            // 
            this.textbookBindingSource.DataSource = typeof(ZH_NA1NXW.Models.Textbook);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(80, 175);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(140, 117);
            this.button1.TabIndex = 1;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // UserControl3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "UserControl3";
            this.Size = new System.Drawing.Size(1127, 530);
            this.Load += new System.EventHandler(this.UserControl3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textbookBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DataGridView dataGridView1;
        private Button button1;
        private DataGridViewTextBoxColumn textbookIdDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn stockNumberDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn titleDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private DataGridViewCheckBoxColumn notAvailableDataGridViewCheckBoxColumn;
        private DataGridViewTextBoxColumn ordersDataGridViewTextBoxColumn;
        private BindingSource textbookBindingSource;
    }
}
