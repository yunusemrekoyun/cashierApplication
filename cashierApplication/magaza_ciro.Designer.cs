namespace cashierApplication
{
    partial class magaza_ciro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(magaza_ciro));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.faturaidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.faturatarihDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.satistoplamDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.odemetipiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.magazaadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.faturaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.yKM_DATABASEDataSet8 = new cashierApplication.YKM_DATABASEDataSet8();
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.faturaTableAdapter = new cashierApplication.YKM_DATABASEDataSet8TableAdapters.faturaTableAdapter();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.faturaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yKM_DATABASEDataSet8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.faturaidDataGridViewTextBoxColumn,
            this.faturatarihDataGridViewTextBoxColumn,
            this.satistoplamDataGridViewTextBoxColumn,
            this.odemetipiDataGridViewTextBoxColumn,
            this.magazaadDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.faturaBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(22, 50);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(445, 359);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
            // 
            // faturaidDataGridViewTextBoxColumn
            // 
            this.faturaidDataGridViewTextBoxColumn.DataPropertyName = "fatura_id";
            this.faturaidDataGridViewTextBoxColumn.HeaderText = "fatura_id";
            this.faturaidDataGridViewTextBoxColumn.Name = "faturaidDataGridViewTextBoxColumn";
            this.faturaidDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // faturatarihDataGridViewTextBoxColumn
            // 
            this.faturatarihDataGridViewTextBoxColumn.DataPropertyName = "fatura_tarih";
            this.faturatarihDataGridViewTextBoxColumn.HeaderText = "fatura_tarih";
            this.faturatarihDataGridViewTextBoxColumn.Name = "faturatarihDataGridViewTextBoxColumn";
            // 
            // satistoplamDataGridViewTextBoxColumn
            // 
            this.satistoplamDataGridViewTextBoxColumn.DataPropertyName = "satis_toplam";
            this.satistoplamDataGridViewTextBoxColumn.HeaderText = "satis_toplam";
            this.satistoplamDataGridViewTextBoxColumn.Name = "satistoplamDataGridViewTextBoxColumn";
            // 
            // odemetipiDataGridViewTextBoxColumn
            // 
            this.odemetipiDataGridViewTextBoxColumn.DataPropertyName = "odeme_tipi";
            this.odemetipiDataGridViewTextBoxColumn.HeaderText = "odeme_tipi";
            this.odemetipiDataGridViewTextBoxColumn.Name = "odemetipiDataGridViewTextBoxColumn";
            // 
            // magazaadDataGridViewTextBoxColumn
            // 
            this.magazaadDataGridViewTextBoxColumn.DataPropertyName = "magaza_ad";
            this.magazaadDataGridViewTextBoxColumn.HeaderText = "magaza_ad";
            this.magazaadDataGridViewTextBoxColumn.Name = "magazaadDataGridViewTextBoxColumn";
            // 
            // faturaBindingSource
            // 
            this.faturaBindingSource.DataMember = "fatura";
            this.faturaBindingSource.DataSource = this.yKM_DATABASEDataSet8;
            // 
            // yKM_DATABASEDataSet8
            // 
            this.yKM_DATABASEDataSet8.DataSetName = "YKM_DATABASEDataSet8";
            this.yKM_DATABASEDataSet8.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // button1
            // 
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.Location = new System.Drawing.Point(679, 192);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 27);
            this.button1.TabIndex = 4;
            this.button1.Text = "Gir";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(241, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "label3";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(529, 67);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(225, 31);
            this.dateTimePicker1.TabIndex = 8;
            this.dateTimePicker1.Value = new System.DateTime(2022, 12, 10, 2, 44, 0, 0);
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker2.Location = new System.Drawing.Point(529, 143);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(225, 31);
            this.dateTimePicker2.TabIndex = 9;
            this.dateTimePicker2.Value = new System.DateTime(2022, 12, 30, 0, 0, 0, 0);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(482, 376);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(159, 20);
            this.label4.TabIndex = 10;
            this.label4.Text = "Hesaplanan Toplam :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(655, 376);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 20);
            this.label5.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(694, 303);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 13);
            this.label2.TabIndex = 12;
            // 
            // faturaTableAdapter
            // 
            this.faturaTableAdapter.ClearBeforeFill = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 7);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(37, 28);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 32;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(526, 51);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(106, 13);
            this.label6.TabIndex = 33;
            this.label6.Text = "*başlangıc tarihi girin:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(526, 127);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(79, 13);
            this.label7.TabIndex = 34;
            this.label7.Text = "*bitiş tarihi girin:";
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button2.Location = new System.Drawing.Point(486, 326);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(155, 37);
            this.button2.TabIndex = 35;
            this.button2.Text = "CİRO HESAPLA";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // magaza_ciro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(799, 447);
            this.ControlBox = false;
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "magaza_ciro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Load += new System.EventHandler(this.magaza_ciro_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.faturaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yKM_DATABASEDataSet8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        public System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private YKM_DATABASEDataSet8 yKM_DATABASEDataSet8;
        private System.Windows.Forms.BindingSource faturaBindingSource;
        private YKM_DATABASEDataSet8TableAdapters.faturaTableAdapter faturaTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn faturaidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn faturatarihDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn satistoplamDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn odemetipiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn magazaadDataGridViewTextBoxColumn;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button2;
    }
}