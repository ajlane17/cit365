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
            this.label7 = new System.Windows.Forms.Label();
            this.radioByAmount = new System.Windows.Forms.RadioButton();
            this.radioByCustomer = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.btnSearchDeskMaterial = new System.Windows.Forms.Button();
            this.radioSearchMaterial = new System.Windows.Forms.RadioButton();
            this.txtSearchCustomer = new System.Windows.Forms.TextBox();
            this.btnSearchCustomer = new System.Windows.Forms.Button();
            this.radioShowByCustomer = new System.Windows.Forms.RadioButton();
            this.radioShowAll = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 138);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(760, 411);
            this.dataGridView1.TabIndex = 0;
            // 
            // cmbMaterialSearch
            // 
            this.cmbMaterialSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbMaterialSearch.FormattingEnabled = true;
            this.cmbMaterialSearch.Items.AddRange(new object[] {
            "Item 1",
            "Item 2"});
            this.cmbMaterialSearch.Location = new System.Drawing.Point(138, 76);
            this.cmbMaterialSearch.Name = "cmbMaterialSearch";
            this.cmbMaterialSearch.Size = new System.Drawing.Size(121, 28);
            this.cmbMaterialSearch.TabIndex = 1;
            this.cmbMaterialSearch.SelectedIndexChanged += new System.EventHandler(this.cmbMaterialSearch_SelectedIndexChanged);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.radioByAmount);
            this.panel3.Controls.Add(this.radioByCustomer);
            this.panel3.Location = new System.Drawing.Point(336, 15);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(215, 22);
            this.panel3.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(9, 4);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(40, 13);
            this.label7.TabIndex = 3;
            this.label7.Text = "Sorting";
            // 
            // radioByAmount
            // 
            this.radioByAmount.AutoSize = true;
            this.radioByAmount.Location = new System.Drawing.Point(136, 2);
            this.radioByAmount.Name = "radioByAmount";
            this.radioByAmount.Size = new System.Drawing.Size(61, 17);
            this.radioByAmount.TabIndex = 2;
            this.radioByAmount.Text = "Amount";
            this.radioByAmount.UseVisualStyleBackColor = true;
            // 
            // radioByCustomer
            // 
            this.radioByCustomer.AutoSize = true;
            this.radioByCustomer.Location = new System.Drawing.Point(61, 2);
            this.radioByCustomer.Name = "radioByCustomer";
            this.radioByCustomer.Size = new System.Drawing.Size(69, 17);
            this.radioByCustomer.TabIndex = 1;
            this.radioByCustomer.Text = "Customer";
            this.radioByCustomer.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.btnSearchDeskMaterial);
            this.panel1.Controls.Add(this.radioSearchMaterial);
            this.panel1.Controls.Add(this.txtSearchCustomer);
            this.panel1.Controls.Add(this.cmbMaterialSearch);
            this.panel1.Controls.Add(this.btnSearchCustomer);
            this.panel1.Controls.Add(this.radioShowByCustomer);
            this.panel1.Controls.Add(this.radioShowAll);
            this.panel1.Location = new System.Drawing.Point(12, 15);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(318, 107);
            this.panel1.TabIndex = 11;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(102, 9);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(80, 13);
            this.label8.TabIndex = 11;
            this.label8.Text = "Search Options";
            // 
            // btnSearchDeskMaterial
            // 
            this.btnSearchDeskMaterial.Location = new System.Drawing.Point(272, 79);
            this.btnSearchDeskMaterial.Name = "btnSearchDeskMaterial";
            this.btnSearchDeskMaterial.Size = new System.Drawing.Size(20, 22);
            this.btnSearchDeskMaterial.TabIndex = 9;
            this.btnSearchDeskMaterial.Text = ">>";
            this.btnSearchDeskMaterial.UseVisualStyleBackColor = true;
            this.btnSearchDeskMaterial.Visible = false;
            // 
            // radioSearchMaterial
            // 
            this.radioSearchMaterial.AutoSize = true;
            this.radioSearchMaterial.Location = new System.Drawing.Point(12, 79);
            this.radioSearchMaterial.Name = "radioSearchMaterial";
            this.radioSearchMaterial.Size = new System.Drawing.Size(113, 17);
            this.radioSearchMaterial.TabIndex = 7;
            this.radioSearchMaterial.Text = "Search by Material";
            this.radioSearchMaterial.UseVisualStyleBackColor = true;
            // 
            // txtSearchCustomer
            // 
            this.txtSearchCustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchCustomer.Location = new System.Drawing.Point(138, 38);
            this.txtSearchCustomer.Name = "txtSearchCustomer";
            this.txtSearchCustomer.Size = new System.Drawing.Size(121, 22);
            this.txtSearchCustomer.TabIndex = 4;
            this.txtSearchCustomer.Visible = false;
            // 
            // btnSearchCustomer
            // 
            this.btnSearchCustomer.Location = new System.Drawing.Point(272, 41);
            this.btnSearchCustomer.Name = "btnSearchCustomer";
            this.btnSearchCustomer.Size = new System.Drawing.Size(20, 22);
            this.btnSearchCustomer.TabIndex = 6;
            this.btnSearchCustomer.Text = ">>";
            this.btnSearchCustomer.UseVisualStyleBackColor = true;
            this.btnSearchCustomer.Visible = false;
            // 
            // radioShowByCustomer
            // 
            this.radioShowByCustomer.AutoSize = true;
            this.radioShowByCustomer.Location = new System.Drawing.Point(12, 41);
            this.radioShowByCustomer.Name = "radioShowByCustomer";
            this.radioShowByCustomer.Size = new System.Drawing.Size(120, 17);
            this.radioShowByCustomer.TabIndex = 2;
            this.radioShowByCustomer.Text = "Search by Customer";
            this.radioShowByCustomer.UseVisualStyleBackColor = true;
            // 
            // radioShowAll
            // 
            this.radioShowAll.AutoSize = true;
            this.radioShowAll.Checked = true;
            this.radioShowAll.Location = new System.Drawing.Point(12, 9);
            this.radioShowAll.Name = "radioShowAll";
            this.radioShowAll.Size = new System.Drawing.Size(66, 17);
            this.radioShowAll.TabIndex = 0;
            this.radioShowAll.TabStop = true;
            this.radioShowAll.Text = "Show All";
            this.radioShowAll.UseVisualStyleBackColor = true;
            // 
            // SearchQuotes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
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
        private System.Windows.Forms.RadioButton radioByAmount;
        private System.Windows.Forms.RadioButton radioByCustomer;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnSearchDeskMaterial;
        private System.Windows.Forms.RadioButton radioSearchMaterial;
        private System.Windows.Forms.TextBox txtSearchCustomer;
        private System.Windows.Forms.Button btnSearchCustomer;
        private System.Windows.Forms.RadioButton radioShowByCustomer;
        private System.Windows.Forms.RadioButton radioShowAll;
    }
}