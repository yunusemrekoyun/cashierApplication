namespace cashierApplication
{
    partial class kasiyer_ekran
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(kasiyer_ekran));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.urunlerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.yKM_DATABASEDataSet3 = new cashierApplication.YKM_DATABASEDataSet3();
            this.urunlerTableAdapter = new cashierApplication.YKM_DATABASEDataSet3TableAdapters.urunlerTableAdapter();
            this.personel_tablosuTableAdapter1 = new cashierApplication.YKM_DATABASEDataSet1TableAdapters.personel_tablosuTableAdapter();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.btnarama = new System.Windows.Forms.Button();
            this.barkodtext = new System.Windows.Forms.TextBox();
            this.barkod = new System.Windows.Forms.Label();
            this.tl = new System.Windows.Forms.Label();
            this.ORDERDGV = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fiyat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.miktartotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toplam = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnbitir = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.miktar = new System.Windows.Forms.TextBox();
            this.urunfiyat = new System.Windows.Forms.TextBox();
            this.urunad = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button4 = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label11 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label12 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.urunlerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yKM_DATABASEDataSet3)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ORDERDGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // urunlerBindingSource
            // 
            this.urunlerBindingSource.DataMember = "urunler";
            this.urunlerBindingSource.DataSource = this.yKM_DATABASEDataSet3;
            // 
            // yKM_DATABASEDataSet3
            // 
            this.yKM_DATABASEDataSet3.DataSetName = "YKM_DATABASEDataSet3";
            this.yKM_DATABASEDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // urunlerTableAdapter
            // 
            this.urunlerTableAdapter.ClearBeforeFill = true;
            // 
            // personel_tablosuTableAdapter1
            // 
            this.personel_tablosuTableAdapter1.ClearBeforeFill = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.pictureBox3);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button6);
            this.panel1.Controls.Add(this.btnarama);
            this.panel1.Controls.Add(this.barkodtext);
            this.panel1.Controls.Add(this.barkod);
            this.panel1.Controls.Add(this.tl);
            this.panel1.Controls.Add(this.ORDERDGV);
            this.panel1.Controls.Add(this.btnbitir);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.miktar);
            this.panel1.Controls.Add(this.urunfiyat);
            this.panel1.Controls.Add(this.urunad);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Location = new System.Drawing.Point(43, 64);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1222, 672);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(1178, 12);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(26, 26);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 36;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label10.Location = new System.Drawing.Point(945, 624);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(125, 21);
            this.label10.TabIndex = 32;
            this.label10.Text = "Genel Toplam :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(22, 252);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(251, 13);
            this.label9.TabIndex = 31;
            this.label9.Text = "*Seçeceğiniz ürünün solundaki ok tuşuna çift basın.";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(125, 12);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(299, 13);
            this.label8.TabIndex = 30;
            this.label8.Text = "*Ekle butonundan önce Ürün AD kısmının dolu olması gerekir. ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(554, 150);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(320, 13);
            this.label1.TabIndex = 29;
            this.label1.Text = "* İptal etmek istediğiniz ürünün yanına tıklayıp delete duşuna basın.";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(977, 53);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 18);
            this.label7.TabIndex = 28;
            this.label7.Text = "Saat :";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(911, 17);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 18);
            this.label6.TabIndex = 27;
            this.label6.Text = "Tarih :";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(849, 624);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 13);
            this.label5.TabIndex = 26;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.LightCyan;
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.Font = new System.Drawing.Font("Palatino Linotype", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button2.Location = new System.Drawing.Point(740, 91);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(157, 37);
            this.button2.TabIndex = 23;
            this.button2.Text = "SATIŞ İPTAL";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.LightCyan;
            this.button6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button6.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button6.Location = new System.Drawing.Point(25, 211);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(168, 37);
            this.button6.TabIndex = 22;
            this.button6.Text = "TÜM ÜRÜNLERİ GÖR";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // btnarama
            // 
            this.btnarama.BackColor = System.Drawing.Color.LightCyan;
            this.btnarama.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnarama.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnarama.Location = new System.Drawing.Point(280, 66);
            this.btnarama.Name = "btnarama";
            this.btnarama.Size = new System.Drawing.Size(150, 37);
            this.btnarama.TabIndex = 20;
            this.btnarama.Text = "BARKOD İLE ARAMA";
            this.btnarama.UseVisualStyleBackColor = false;
            this.btnarama.Click += new System.EventHandler(this.btnarama_Click);
            // 
            // barkodtext
            // 
            this.barkodtext.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.barkodtext.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.barkodtext.Location = new System.Drawing.Point(128, 69);
            this.barkodtext.MaxLength = 6;
            this.barkodtext.Name = "barkodtext";
            this.barkodtext.Size = new System.Drawing.Size(133, 29);
            this.barkodtext.TabIndex = 19;
            // 
            // barkod
            // 
            this.barkod.AutoSize = true;
            this.barkod.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.barkod.Location = new System.Drawing.Point(21, 73);
            this.barkod.Name = "barkod";
            this.barkod.Size = new System.Drawing.Size(103, 20);
            this.barkod.TabIndex = 18;
            this.barkod.Text = "Barkod No :";
            // 
            // tl
            // 
            this.tl.AutoSize = true;
            this.tl.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tl.Location = new System.Drawing.Point(1085, 624);
            this.tl.Name = "tl";
            this.tl.Size = new System.Drawing.Size(19, 21);
            this.tl.TabIndex = 17;
            this.tl.Text = "₺";
            this.tl.Click += new System.EventHandler(this.label5_Click);
            // 
            // ORDERDGV
            // 
            this.ORDERDGV.BackgroundColor = System.Drawing.Color.White;
            this.ORDERDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ORDERDGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.ad,
            this.fiyat,
            this.miktartotal,
            this.toplam});
            this.ORDERDGV.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ORDERDGV.Location = new System.Drawing.Point(557, 166);
            this.ORDERDGV.Name = "ORDERDGV";
            this.ORDERDGV.Size = new System.Drawing.Size(537, 409);
            this.ORDERDGV.TabIndex = 14;
            this.ORDERDGV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ORDERDGV_CellContentClick);
            this.ORDERDGV.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ORDERDGV_CellDoubleClick);
            // 
            // id
            // 
            this.id.HeaderText = "Ürün Sayısı :";
            this.id.Name = "id";
            // 
            // ad
            // 
            this.ad.HeaderText = "Ürün Ad :";
            this.ad.Name = "ad";
            // 
            // fiyat
            // 
            this.fiyat.HeaderText = "Fiyat :";
            this.fiyat.Name = "fiyat";
            // 
            // miktartotal
            // 
            this.miktartotal.HeaderText = "Miktar :";
            this.miktartotal.Name = "miktartotal";
            // 
            // toplam
            // 
            this.toplam.HeaderText = "Toplam :";
            this.toplam.Name = "toplam";
            // 
            // btnbitir
            // 
            this.btnbitir.BackColor = System.Drawing.Color.LightCyan;
            this.btnbitir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnbitir.Font = new System.Drawing.Font("Palatino Linotype", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnbitir.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnbitir.Location = new System.Drawing.Point(937, 91);
            this.btnbitir.Name = "btnbitir";
            this.btnbitir.Size = new System.Drawing.Size(157, 37);
            this.btnbitir.TabIndex = 11;
            this.btnbitir.Text = "BİTİR / YAZDIR";
            this.btnbitir.UseVisualStyleBackColor = false;
            this.btnbitir.Click += new System.EventHandler(this.btnbitir_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.LightCyan;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button1.Location = new System.Drawing.Point(330, 211);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 37);
            this.button1.TabIndex = 10;
            this.button1.Text = "EKLE";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // miktar
            // 
            this.miktar.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.miktar.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.miktar.Location = new System.Drawing.Point(128, 176);
            this.miktar.Name = "miktar";
            this.miktar.Size = new System.Drawing.Size(195, 29);
            this.miktar.TabIndex = 8;
            // 
            // urunfiyat
            // 
            this.urunfiyat.BackColor = System.Drawing.Color.AntiqueWhite;
            this.urunfiyat.Enabled = false;
            this.urunfiyat.Font = new System.Drawing.Font("MS Reference Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.urunfiyat.ForeColor = System.Drawing.SystemColors.WindowText;
            this.urunfiyat.Location = new System.Drawing.Point(128, 115);
            this.urunfiyat.Name = "urunfiyat";
            this.urunfiyat.Size = new System.Drawing.Size(195, 33);
            this.urunfiyat.TabIndex = 7;
            // 
            // urunad
            // 
            this.urunad.Enabled = false;
            this.urunad.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.urunad.Location = new System.Drawing.Point(125, 28);
            this.urunad.Name = "urunad";
            this.urunad.Size = new System.Drawing.Size(485, 27);
            this.urunad.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(60, 176);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "Miktar :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(64, 123);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Fiyat :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(34, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Ürün AD :";
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dataGridView1.Location = new System.Drawing.Point(25, 268);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(485, 358);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.LightCyan;
            this.button4.Font = new System.Drawing.Font("Palatino Linotype", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button4.Location = new System.Drawing.Point(1157, 760);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(178, 44);
            this.button4.TabIndex = 25;
            this.button4.Text = "KART BAŞVURU";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label11.Location = new System.Drawing.Point(37, 730);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(0, 25);
            this.label11.TabIndex = 26;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(62, 38);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 29;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click_1);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(0, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(1347, 816);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 30;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label12.Location = new System.Drawing.Point(133, 22);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(0, 19);
            this.label12.TabIndex = 37;
            // 
            // kasiyer_ekran
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1348, 815);
            this.ControlBox = false;
            this.Controls.Add(this.label12);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.pictureBox2);
            this.Name = "kasiyer_ekran";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.kasiyer_ekran_Load);
            ((System.ComponentModel.ISupportInitialize)(this.urunlerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yKM_DATABASEDataSet3)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ORDERDGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private YKM_DATABASEDataSet3 yKM_DATABASEDataSet3;
        private System.Windows.Forms.BindingSource urunlerBindingSource;
        private YKM_DATABASEDataSet3TableAdapters.urunlerTableAdapter urunlerTableAdapter;
        private YKM_DATABASEDataSet1TableAdapters.personel_tablosuTableAdapter personel_tablosuTableAdapter1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox miktar;
        private System.Windows.Forms.TextBox urunfiyat;
        private System.Windows.Forms.TextBox urunad;
        private System.Windows.Forms.Button btnbitir;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView ORDERDGV;
        private System.Windows.Forms.TextBox barkodtext;
        private System.Windows.Forms.Label barkod;
        private System.Windows.Forms.Button btnarama;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn ad;
        private System.Windows.Forms.DataGridViewTextBoxColumn fiyat;
        private System.Windows.Forms.DataGridViewTextBoxColumn miktartotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn toplam;
        private System.Windows.Forms.Button button2;
        public System.Windows.Forms.Label tl;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        public System.Windows.Forms.Label label11;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label12;
    }
}