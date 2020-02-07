namespace MegaDesk
{
    partial class SearchQuotes
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
            this.cmbMaterialSearch = new System.Windows.Forms.ComboBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.radioSortNone = new System.Windows.Forms.RadioButton();
            this.label7 = new System.Windows.Forms.Label();
            this.radioSortAmount = new System.Windows.Forms.RadioButton();
            this.radioSortCustomer = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.btnSearchDeskMaterial = new System.Windows.Forms.Button();
            this.radioSearchMaterial = new System.Windows.Forms.RadioButton();
            this.txtSearchCustomer = new System.Windows.Forms.TextBox();
            this.btnSearchCustomer = new System.Windows.Forms.Button();
            this.radioSearchCustomer = new System.Windows.Forms.RadioButton();
            this.radioSearchAll = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 138);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 22;
            this.dataGridView1.Size = new System.Drawing.Size(635, 411);
            this.dataGridView1.TabIndex = 0;
            // 
            // cmbMaterialSearch
            // 
            this.cmbMaterialSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbMaterialSearch.FormattingEnabled = true;
            this.cmbMaterialSearch.Location = new System.Drawing.Point(229, 76);
            this.cmbMaterialSearch.Name = "cmbMaterialSearch";
            this.cmbMaterialSearch.Size = new System.Drawing.Size(121, 28);
            this.cmbMaterialSearch.TabIndex = 1;
            this.cmbMaterialSearch.SelectedIndexChanged += new System.EventHandler(this.radioSearchUpdated_CheckedChanged);
            this.cmbMaterialSearch.SelectionChangeCommitted += new System.EventHandler(this.radioSearchUpdated_CheckedChanged);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.radioSortNone);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.radioSortAmount);
            this.panel3.Controls.Add(this.radioSortCustomer);
            this.panel3.Location = new System.Drawing.Point(439, 12);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(208, 107);
            this.panel3.TabIndex = 12;
            // 
            // radioSortNone
            // 
            this.radioSortNone.AutoSize = true;
            this.radioSortNone.Checked = true;
            this.radioSortNone.Location = new System.Drawing.Point(108, 6);
            this.radioSortNone.Name = "radioSortNone";
            this.radioSortNone.Size = new System.Drawing.Size(51, 17);
            this.radioSortNone.TabIndex = 13;
            this.radioSortNone.TabStop = true;
            this.radioSortNone.Text = "None";
            this.radioSortNone.UseVisualStyleBackColor = true;
            this.radioSortNone.CheckedChanged += new System.EventHandler(this.radioSearchUpdated_CheckedChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(10, 38);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 13);
            this.label7.TabIndex = 3;
            this.label7.Text = "Sort Options";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // radioSortAmount
            // 
            this.radioSortAmount.AutoSize = true;
            this.radioSortAmount.Location = new System.Drawing.Point(108, 79);
            this.radioSortAmount.Name = "radioSortAmount";
            this.radioSortAmount.Size = new System.Drawing.Size(61, 17);
            this.radioSortAmount.TabIndex = 2;
            this.radioSortAmount.Text = "Amount";
            this.radioSortAmount.UseVisualStyleBackColor = true;
            this.radioSortAmount.CheckedChanged += new System.EventHandler(this.radioSearchUpdated_CheckedChanged);
            // 
            // radioSortCustomer
            // 
            this.radioSortCustomer.AutoSize = true;
            this.radioSortCustomer.Location = new System.Drawing.Point(108, 41);
            this.radioSortCustomer.Name = "radioSortCustomer";
            this.radioSortCustomer.Size = new System.Drawing.Size(69, 17);
            this.radioSortCustomer.TabIndex = 1;
            this.radioSortCustomer.Text = "Customer";
            this.radioSortCustomer.UseVisualStyleBackColor = true;
            this.radioSortCustomer.CheckedChanged += new System.EventHandler(this.radioSearchUpdated_CheckedChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.btnSearchDeskMaterial);
            this.panel1.Controls.Add(this.radioSearchMaterial);
            this.panel1.Controls.Add(this.txtSearchCustomer);
            this.panel1.Controls.Add(this.cmbMaterialSearch);
            this.panel1.Controls.Add(this.btnSearchCustomer);
            this.panel1.Controls.Add(this.radioSearchCustomer);
            this.panel1.Controls.Add(this.radioSearchAll);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(406, 107);
            this.panel1.TabIndex = 11;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(3, 43);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(80, 13);
            this.label8.TabIndex = 11;
            this.label8.Text = "Search Options";
            // 
            // btnSearchDeskMaterial
            // 
            this.btnSearchDeskMaterial.Location = new System.Drawing.Point(356, 79);
            this.btnSearchDeskMaterial.Name = "btnSearchDeskMaterial";
            this.btnSearchDeskMaterial.Size = new System.Drawing.Size(20, 22);
            this.btnSearchDeskMaterial.TabIndex = 9;
            this.btnSearchDeskMaterial.Text = ">>";
            this.btnSearchDeskMaterial.UseVisualStyleBackColor = true;
            this.btnSearchDeskMaterial.Visible = false;
            this.btnSearchDeskMaterial.Click += new System.EventHandler(this.radioSearchUpdated_CheckedChanged);
            // 
            // radioSearchMaterial
            // 
            this.radioSearchMaterial.AutoSize = true;
            this.radioSearchMaterial.Location = new System.Drawing.Point(103, 79);
            this.radioSearchMaterial.Name = "radioSearchMaterial";
            this.radioSearchMaterial.Size = new System.Drawing.Size(113, 17);
            this.radioSearchMaterial.TabIndex = 7;
            this.radioSearchMaterial.Text = "Search by Material";
            this.radioSearchMaterial.UseVisualStyleBackColor = true;
            this.radioSearchMaterial.CheckedChanged += new System.EventHandler(this.radioSearchUpdated_CheckedChanged);
            // 
            // txtSearchCustomer
            // 
            this.txtSearchCustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchCustomer.Location = new System.Drawing.Point(229, 38);
            this.txtSearchCustomer.Name = "txtSearchCustomer";
            this.txtSearchCustomer.Size = new System.Drawing.Size(121, 22);
            this.txtSearchCustomer.TabIndex = 4;
            this.txtSearchCustomer.Visible = false;
            // 
            // btnSearchCustomer
            // 
            this.btnSearchCustomer.Location = new System.Drawing.Point(356, 38);
            this.btnSearchCustomer.Name = "btnSearchCustomer";
            this.btnSearchCustomer.Size = new System.Drawing.Size(20, 22);
            this.btnSearchCustomer.TabIndex = 6;
            this.btnSearchCustomer.Text = ">>";
            this.btnSearchCustomer.UseVisualStyleBackColor = true;
            this.btnSearchCustomer.Visible = false;
            this.btnSearchCustomer.Click += new System.EventHandler(this.radioSearchUpdated_CheckedChanged);
            // 
            // radioSearchCustomer
            // 
            this.radioSearchCustomer.AutoSize = true;
            this.radioSearchCustomer.Location = new System.Drawing.Point(103, 41);
            this.radioSearchCustomer.Name = "radioSearchCustomer";
            this.radioSearchCustomer.Size = new System.Drawing.Size(120, 17);
            this.radioSearchCustomer.TabIndex = 2;
            this.radioSearchCustomer.Text = "Search by Customer";
            this.radioSearchCustomer.UseVisualStyleBackColor = true;
            this.radioSearchCustomer.CheckedChanged += new System.EventHandler(this.radioSearchUpdated_CheckedChanged);
            // 
            // radioSearchAll
            // 
            this.radioSearchAll.AutoSize = true;
            this.radioSearchAll.Checked = true;
            this.radioSearchAll.Location = new System.Drawing.Point(103, 9);
            this.radioSearchAll.Name = "radioSearchAll";
            this.radioSearchAll.Size = new System.Drawing.Size(66, 17);
            this.radioSearchAll.TabIndex = 0;
            this.radioSearchAll.TabStop = true;
            this.radioSearchAll.Text = "Show All";
            this.radioSearchAll.UseVisualStyleBackColor = true;
            this.radioSearchAll.CheckedChanged += new System.EventHandler(this.radioSearchUpdated_CheckedChanged);
            // 
            // SearchQuotes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(661, 561);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "SearchQuotes";
            this.Text = "Search Quotes";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox cmbMaterialSearch;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.RadioButton radioSortAmount;
        private System.Windows.Forms.RadioButton radioSortCustomer;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnSearchDeskMaterial;
        private System.Windows.Forms.RadioButton radioSearchMaterial;
        private System.Windows.Forms.TextBox txtSearchCustomer;
        private System.Windows.Forms.Button btnSearchCustomer;
        private System.Windows.Forms.RadioButton radioSearchCustomer;
        private System.Windows.Forms.RadioButton radioSearchAll;
        private System.Windows.Forms.RadioButton radioSortNone;
    }
}