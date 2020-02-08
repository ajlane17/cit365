namespace MegaDesk
{
    partial class MainMenu
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
            this.addNewQuote = new System.Windows.Forms.Button();
            this.searchQuotes = new System.Windows.Forms.Button();
            this.exit = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // addNewQuote
            // 
            this.addNewQuote.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addNewQuote.FlatAppearance.BorderColor = System.Drawing.Color.DarkOliveGreen;
            this.addNewQuote.FlatAppearance.BorderSize = 2;
            this.addNewQuote.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkSeaGreen;
            this.addNewQuote.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Honeydew;
            this.addNewQuote.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addNewQuote.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addNewQuote.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.addNewQuote.Location = new System.Drawing.Point(478, 155);
            this.addNewQuote.Name = "addNewQuote";
            this.addNewQuote.Size = new System.Drawing.Size(294, 109);
            this.addNewQuote.TabIndex = 0;
            this.addNewQuote.Text = "&Add New Quote";
            this.addNewQuote.UseVisualStyleBackColor = true;
            this.addNewQuote.Click += new System.EventHandler(this.addNewQuote_Click);
            // 
            // searchQuotes
            // 
            this.searchQuotes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.searchQuotes.FlatAppearance.BorderColor = System.Drawing.Color.DarkOliveGreen;
            this.searchQuotes.FlatAppearance.BorderSize = 2;
            this.searchQuotes.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkSeaGreen;
            this.searchQuotes.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Honeydew;
            this.searchQuotes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.searchQuotes.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchQuotes.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.searchQuotes.Location = new System.Drawing.Point(478, 297);
            this.searchQuotes.Name = "searchQuotes";
            this.searchQuotes.Size = new System.Drawing.Size(294, 109);
            this.searchQuotes.TabIndex = 2;
            this.searchQuotes.Text = "&View and &Search Quotes";
            this.searchQuotes.UseVisualStyleBackColor = true;
            this.searchQuotes.Click += new System.EventHandler(this.searchQuotes_Click);
            // 
            // exit
            // 
            this.exit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.exit.FlatAppearance.BorderColor = System.Drawing.Color.DarkOliveGreen;
            this.exit.FlatAppearance.BorderSize = 2;
            this.exit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkSeaGreen;
            this.exit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Honeydew;
            this.exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exit.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.exit.Location = new System.Drawing.Point(478, 439);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(294, 109);
            this.exit.TabIndex = 3;
            this.exit.Text = "E&xit";
            this.exit.UseVisualStyleBackColor = true;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox2.Image = global::MegaDesk.Properties.Resources.carpentry;
            this.pictureBox2.Location = new System.Drawing.Point(12, 155);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(446, 394);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 5;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::MegaDesk.Properties.Resources.logo;
            this.pictureBox1.Location = new System.Drawing.Point(0, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(785, 123);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.searchQuotes);
            this.Controls.Add(this.addNewQuote);
            this.Controls.Add(this.pictureBox1);
            this.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "MainMenu";
            this.Text = " Mega Desk 2.0";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button addNewQuote;
        private System.Windows.Forms.Button searchQuotes;
        private System.Windows.Forms.Button exit;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}

