namespace CHDT
{
    partial class Form_Main
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
            this.btnaddproduct = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.tbname = new System.Windows.Forms.TextBox();
            this.tbid = new System.Windows.Forms.TextBox();
            this.tbdes = new System.Windows.Forms.TextBox();
            this.tbcategory = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.nmprice = new System.Windows.Forms.NumericUpDown();
            this.dtgvcus = new System.Windows.Forms.DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmprice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvcus)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnaddproduct
            // 
            this.btnaddproduct.Location = new System.Drawing.Point(94, 317);
            this.btnaddproduct.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnaddproduct.Name = "btnaddproduct";
            this.btnaddproduct.Size = new System.Drawing.Size(288, 50);
            this.btnaddproduct.TabIndex = 0;
            this.btnaddproduct.Text = "Update Product";
            this.btnaddproduct.UseVisualStyleBackColor = true;
            this.btnaddproduct.Click += new System.EventHandler(this.btnaddproduct_Click);
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(423, 41);
            this.dataGridView2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 62;
            this.dataGridView2.RowTemplate.Height = 28;
            this.dataGridView2.Size = new System.Drawing.Size(782, 253);
            this.dataGridView2.TabIndex = 5;
            this.dataGridView2.Click += new System.EventHandler(this.dataGridView2_Click);
            // 
            // tbname
            // 
            this.tbname.Location = new System.Drawing.Point(94, 80);
            this.tbname.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbname.Name = "tbname";
            this.tbname.Size = new System.Drawing.Size(288, 22);
            this.tbname.TabIndex = 7;
            // 
            // tbid
            // 
            this.tbid.Location = new System.Drawing.Point(94, 33);
            this.tbid.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbid.Name = "tbid";
            this.tbid.ReadOnly = true;
            this.tbid.Size = new System.Drawing.Size(76, 22);
            this.tbid.TabIndex = 8;
            // 
            // tbdes
            // 
            this.tbdes.Location = new System.Drawing.Point(94, 187);
            this.tbdes.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbdes.Multiline = true;
            this.tbdes.Name = "tbdes";
            this.tbdes.Size = new System.Drawing.Size(288, 102);
            this.tbdes.TabIndex = 9;
            // 
            // tbcategory
            // 
            this.tbcategory.Location = new System.Drawing.Point(306, 33);
            this.tbcategory.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbcategory.Name = "tbcategory";
            this.tbcategory.ReadOnly = true;
            this.tbcategory.Size = new System.Drawing.Size(76, 22);
            this.tbcategory.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(61, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 17);
            this.label1.TabIndex = 11;
            this.label1.Text = "ID:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(192, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 17);
            this.label2.TabIndex = 12;
            this.label2.Text = "IDCATEGORY:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(33, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 17);
            this.label3.TabIndex = 13;
            this.label3.Text = "Name :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(38, 138);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 17);
            this.label4.TabIndex = 14;
            this.label4.Text = "Price :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 190);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 17);
            this.label5.TabIndex = 15;
            this.label5.Text = "Description :";
            // 
            // nmprice
            // 
            this.nmprice.Location = new System.Drawing.Point(94, 136);
            this.nmprice.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.nmprice.Maximum = new decimal(new int[] {
            -727379968,
            232,
            0,
            0});
            this.nmprice.Name = "nmprice";
            this.nmprice.Size = new System.Drawing.Size(288, 22);
            this.nmprice.TabIndex = 16;
            // 
            // dtgvcus
            // 
            this.dtgvcus.AllowUserToAddRows = false;
            this.dtgvcus.AllowUserToDeleteRows = false;
            this.dtgvcus.BackgroundColor = System.Drawing.Color.White;
            this.dtgvcus.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvcus.Location = new System.Drawing.Point(423, 324);
            this.dtgvcus.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtgvcus.Name = "dtgvcus";
            this.dtgvcus.RowHeadersWidth = 62;
            this.dtgvcus.RowTemplate.Height = 28;
            this.dtgvcus.Size = new System.Drawing.Size(782, 105);
            this.dtgvcus.TabIndex = 18;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(420, 304);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(132, 17);
            this.label6.TabIndex = 19;
            this.label6.Text = "Customer Subcribe:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(127, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(191, 29);
            this.label7.TabIndex = 20;
            this.label7.Text = "Observer Demo";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.nmprice);
            this.panel1.Controls.Add(this.tbname);
            this.panel1.Controls.Add(this.tbid);
            this.panel1.Controls.Add(this.tbdes);
            this.panel1.Controls.Add(this.tbcategory);
            this.panel1.Controls.Add(this.btnaddproduct);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Location = new System.Drawing.Point(14, 41);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(403, 388);
            this.panel1.TabIndex = 21;
            // 
            // Form_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1208, 448);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dtgvcus);
            this.Controls.Add(this.dataGridView2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form_Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Demo";
            this.Load += new System.EventHandler(this.Form_Main_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmprice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvcus)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnaddproduct;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.TextBox tbname;
        private System.Windows.Forms.TextBox tbid;
        private System.Windows.Forms.TextBox tbdes;
        private System.Windows.Forms.TextBox tbcategory;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown nmprice;
        private System.Windows.Forms.DataGridView dtgvcus;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel1;
    }
}

