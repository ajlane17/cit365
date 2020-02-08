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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
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
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(1);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Honeydew;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.DarkGreen;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.GridColor = System.Drawing.Color.DarkOliveGreen;
            this.dataGridView1.Location = new System.Drawing.Point(12, 183);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 22;
            this.dataGridView1.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.White;
            this.dataGridView1.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridView1.RowTemplate.DefaultCellStyle.Padding = new System.Windows.Forms.Padding(1);
            this.dataGridView1.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.Honeydew;
            this.dataGridView1.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.dataGridView1.Size = new System.Drawing.Size(751, 341);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // cmbMaterialSearch
            // 
            this.cmbMaterialSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbMaterialSearch.FormattingEnabled = true;
            this.cmbMaterialSearch.Location = new System.Drawing.Point(200, 102);
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
            this.panel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel3.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.panel3.Location = new System.Drawing.Point(430, 12);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(333, 138);
            this.panel3.TabIndex = 12;
            // 
            // radioSortNone
            // 
            this.radioSortNone.AutoSize = true;
            this.radioSortNone.Checked = true;
            this.radioSortNone.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioSortNone.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.radioSortNone.Location = new System.Drawing.Point(19, 69);
            this.radioSortNone.Name = "radioSortNone";
            this.radioSortNone.Size = new System.Drawing.Size(65, 24);
            this.radioSortNone.TabIndex = 13;
            this.radioSortNone.TabStop = true;
            this.radioSortNone.Text = "None";
            this.radioSortNone.UseVisualStyleBackColor = true;
            this.radioSortNone.CheckedChanged += new System.EventHandler(this.radioSearchUpdated_CheckedChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(109, 11);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(113, 24);
            this.label7.TabIndex = 3;
            this.label7.Text = "Sort Options";
            // 
            // radioSortAmount
            // 
            this.radioSortAmount.AutoSize = true;
            this.radioSortAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioSortAmount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.radioSortAmount.Location = new System.Drawing.Point(232, 69);
            this.radioSortAmount.Name = "radioSortAmount";
            this.radioSortAmount.Size = new System.Drawing.Size(83, 24);
            this.radioSortAmount.TabIndex = 2;
            this.radioSortAmount.Text = "Amount";
            this.radioSortAmount.UseVisualStyleBackColor = true;
            this.radioSortAmount.CheckedChanged += new System.EventHandler(this.radioSearchUpdated_CheckedChanged);
            // 
            // radioSortCustomer
            // 
            this.radioSortCustomer.AutoSize = true;
            this.radioSortCustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioSortCustomer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.radioSortCustomer.Location = new System.Drawing.Point(113, 69);
            this.radioSortCustomer.Name = "radioSortCustomer";
            this.radioSortCustomer.Size = new System.Drawing.Size(96, 24);
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
            this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(397, 138);
            this.panel1.TabIndex = 11;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(126, 11);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(140, 24);
            this.label8.TabIndex = 11;
            this.label8.Text = "Search Options";
            // 
            // btnSearchDeskMaterial
            // 
            this.btnSearchDeskMaterial.FlatAppearance.BorderColor = System.Drawing.Color.DarkOliveGreen;
            this.btnSearchDeskMaterial.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkSeaGreen;
            this.btnSearchDeskMaterial.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Honeydew;
            this.btnSearchDeskMaterial.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearchDeskMaterial.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchDeskMaterial.Location = new System.Drawing.Point(330, 104);
            this.btnSearchDeskMaterial.Name = "btnSearchDeskMaterial";
            this.btnSearchDeskMaterial.Size = new System.Drawing.Size(42, 25);
            this.btnSearchDeskMaterial.TabIndex = 9;
            this.btnSearchDeskMaterial.Text = "GO";
            this.btnSearchDeskMaterial.UseVisualStyleBackColor = true;
            this.btnSearchDeskMaterial.Visible = false;
            this.btnSearchDeskMaterial.Click += new System.EventHandler(this.radioSearchUpdated_CheckedChanged);
            // 
            // radioSearchMaterial
            // 
            this.radioSearchMaterial.AutoSize = true;
            this.radioSearchMaterial.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioSearchMaterial.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.radioSearchMaterial.Location = new System.Drawing.Point(24, 103);
            this.radioSearchMaterial.Name = "radioSearchMaterial";
            this.radioSearchMaterial.Size = new System.Drawing.Size(158, 24);
            this.radioSearchMaterial.TabIndex = 7;
            this.radioSearchMaterial.Text = "Search by Material";
            this.radioSearchMaterial.UseVisualStyleBackColor = true;
            this.radioSearchMaterial.CheckedChanged += new System.EventHandler(this.radioSearchUpdated_CheckedChanged);
            // 
            // txtSearchCustomer
            // 
            this.txtSearchCustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchCustomer.Location = new System.Drawing.Point(200, 70);
            this.txtSearchCustomer.MinimumSize = new System.Drawing.Size(4, 20);
            this.txtSearchCustomer.Name = "txtSearchCustomer";
            this.txtSearchCustomer.Size = new System.Drawing.Size(121, 22);
            this.txtSearchCustomer.TabIndex = 4;
            this.txtSearchCustomer.Visible = false;
            this.txtSearchCustomer.TextChanged += new System.EventHandler(this.txtSearchCustomer_TextChanged);
            // 
            // btnSearchCustomer
            // 
            this.btnSearchCustomer.FlatAppearance.BorderColor = System.Drawing.Color.DarkOliveGreen;
            this.btnSearchCustomer.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkSeaGreen;
            this.btnSearchCustomer.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Honeydew;
            this.btnSearchCustomer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearchCustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchCustomer.Location = new System.Drawing.Point(330, 69);
            this.btnSearchCustomer.Name = "btnSearchCustomer";
            this.btnSearchCustomer.Size = new System.Drawing.Size(42, 25);
            this.btnSearchCustomer.TabIndex = 6;
            this.btnSearchCustomer.Text = "GO";
            this.btnSearchCustomer.UseVisualStyleBackColor = true;
            this.btnSearchCustomer.Visible = false;
            this.btnSearchCustomer.Click += new System.EventHandler(this.radioSearchUpdated_CheckedChanged);
            // 
            // radioSearchCustomer
            // 
            this.radioSearchCustomer.AutoSize = true;
            this.radioSearchCustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioSearchCustomer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.radioSearchCustomer.Location = new System.Drawing.Point(24, 70);
            this.radioSearchCustomer.Name = "radioSearchCustomer";
            this.radioSearchCustomer.Size = new System.Drawing.Size(171, 24);
            this.radioSearchCustomer.TabIndex = 2;
            this.radioSearchCustomer.Text = "Search by Customer";
            this.radioSearchCustomer.UseVisualStyleBackColor = true;
            this.radioSearchCustomer.CheckedChanged += new System.EventHandler(this.radioSearchUpdated_CheckedChanged);
            // 
            // radioSearchAll
            // 
            this.radioSearchAll.AutoSize = true;
            this.radioSearchAll.Checked = true;
            this.radioSearchAll.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioSearchAll.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.radioSearchAll.Location = new System.Drawing.Point(24, 40);
            this.radioSearchAll.Name = "radioSearchAll";
            this.radioSearchAll.Size = new System.Drawing.Size(88, 24);
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
            this.BackColor = System.Drawing.Color.White;
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