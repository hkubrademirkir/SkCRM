namespace CRMSporKulubu.WinUI.PanelUI
{
	partial class CalisanlarForm
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CalisanlarForm));
			this.btnUyeEkle = new System.Windows.Forms.Button();
			this.btnDelete = new System.Windows.Forms.Button();
			this.btnUpdate = new System.Windows.Forms.Button();
			this.panel2 = new System.Windows.Forms.Panel();
			this.panel1 = new System.Windows.Forms.Panel();
			this.nmrMaasBilgisi = new System.Windows.Forms.NumericUpDown();
			this.label3 = new System.Windows.Forms.Label();
			this.dtpKayitTarihi = new System.Windows.Forms.DateTimePicker();
			this.label1 = new System.Windows.Forms.Label();
			this.txtAdres = new System.Windows.Forms.TextBox();
			this.txtTel = new System.Windows.Forms.TextBox();
			this.txtEmail = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.rdbErkek = new System.Windows.Forms.RadioButton();
			this.rdbKadin = new System.Windows.Forms.RadioButton();
			this.dtpDogumTarihi = new System.Windows.Forms.DateTimePicker();
			this.label2 = new System.Windows.Forms.Label();
			this.txtAd = new System.Windows.Forms.TextBox();
			this.txtSoyad = new System.Windows.Forms.TextBox();
			this.panel11 = new System.Windows.Forms.Panel();
			this.dgvCalisanlar = new System.Windows.Forms.DataGridView();
			this.txtTCNo = new System.Windows.Forms.TextBox();
			this.chkRegisterYetkisi = new System.Windows.Forms.CheckBox();
			this.pictureBox2 = new System.Windows.Forms.PictureBox();
			this.txtCalisanAra = new System.Windows.Forms.TextBox();
			this.label10 = new System.Windows.Forms.Label();
			this.label9 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.nmrMaasBilgisi)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dgvCalisanlar)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
			this.SuspendLayout();
			// 
			// btnUyeEkle
			// 
			this.btnUyeEkle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(205)))), ((int)(((byte)(242)))));
			this.btnUyeEkle.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(205)))), ((int)(((byte)(242)))));
			this.btnUyeEkle.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(231)))), ((int)(((byte)(255)))));
			this.btnUyeEkle.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(231)))), ((int)(((byte)(255)))));
			this.btnUyeEkle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnUyeEkle.Font = new System.Drawing.Font("Berlin Sans FB", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnUyeEkle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(24)))), ((int)(((byte)(60)))));
			this.btnUyeEkle.Image = ((System.Drawing.Image)(resources.GetObject("btnUyeEkle.Image")));
			this.btnUyeEkle.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnUyeEkle.Location = new System.Drawing.Point(727, 2);
			this.btnUyeEkle.Margin = new System.Windows.Forms.Padding(2);
			this.btnUyeEkle.Name = "btnUyeEkle";
			this.btnUyeEkle.Size = new System.Drawing.Size(173, 37);
			this.btnUyeEkle.TabIndex = 73;
			this.btnUyeEkle.Text = "YENI ÇALISAN EKLE";
			this.btnUyeEkle.UseVisualStyleBackColor = false;
			this.btnUyeEkle.Click += new System.EventHandler(this.btnUyeEkle_Click);
			// 
			// btnDelete
			// 
			this.btnDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(205)))), ((int)(((byte)(242)))));
			this.btnDelete.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(205)))), ((int)(((byte)(242)))));
			this.btnDelete.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(231)))), ((int)(((byte)(255)))));
			this.btnDelete.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(231)))), ((int)(((byte)(255)))));
			this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnDelete.Font = new System.Drawing.Font("Berlin Sans FB", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnDelete.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(24)))), ((int)(((byte)(60)))));
			this.btnDelete.Location = new System.Drawing.Point(768, 495);
			this.btnDelete.Margin = new System.Windows.Forms.Padding(2);
			this.btnDelete.Name = "btnDelete";
			this.btnDelete.Size = new System.Drawing.Size(75, 28);
			this.btnDelete.TabIndex = 72;
			this.btnDelete.Text = "SIL";
			this.btnDelete.UseVisualStyleBackColor = false;
			this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
			// 
			// btnUpdate
			// 
			this.btnUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(205)))), ((int)(((byte)(242)))));
			this.btnUpdate.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(205)))), ((int)(((byte)(242)))));
			this.btnUpdate.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(231)))), ((int)(((byte)(255)))));
			this.btnUpdate.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(231)))), ((int)(((byte)(255)))));
			this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnUpdate.Font = new System.Drawing.Font("Berlin Sans FB", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnUpdate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(24)))), ((int)(((byte)(60)))));
			this.btnUpdate.Location = new System.Drawing.Point(678, 495);
			this.btnUpdate.Margin = new System.Windows.Forms.Padding(2);
			this.btnUpdate.Name = "btnUpdate";
			this.btnUpdate.Size = new System.Drawing.Size(75, 28);
			this.btnUpdate.TabIndex = 71;
			this.btnUpdate.Text = "GÜNCELLE";
			this.btnUpdate.UseVisualStyleBackColor = false;
			this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
			// 
			// panel2
			// 
			this.panel2.BackColor = System.Drawing.Color.Gray;
			this.panel2.Location = new System.Drawing.Point(604, 359);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(1, 180);
			this.panel2.TabIndex = 70;
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.Gray;
			this.panel1.Location = new System.Drawing.Point(318, 359);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(1, 180);
			this.panel1.TabIndex = 69;
			// 
			// nmrMaasBilgisi
			// 
			this.nmrMaasBilgisi.Location = new System.Drawing.Point(632, 439);
			this.nmrMaasBilgisi.Margin = new System.Windows.Forms.Padding(2);
			this.nmrMaasBilgisi.Maximum = new decimal(new int[] {
            500000,
            0,
            0,
            0});
			this.nmrMaasBilgisi.Name = "nmrMaasBilgisi";
			this.nmrMaasBilgisi.Size = new System.Drawing.Size(263, 20);
			this.nmrMaasBilgisi.TabIndex = 68;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Berlin Sans FB", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.ForeColor = System.Drawing.Color.Black;
			this.label3.Location = new System.Drawing.Point(629, 424);
			this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(63, 13);
			this.label3.TabIndex = 67;
			this.label3.Text = "Maaş Bilgisi";
			// 
			// dtpKayitTarihi
			// 
			this.dtpKayitTarihi.CalendarMonthBackground = System.Drawing.SystemColors.MenuText;
			this.dtpKayitTarihi.CalendarTitleBackColor = System.Drawing.SystemColors.ControlText;
			this.dtpKayitTarihi.CalendarTitleForeColor = System.Drawing.Color.Gray;
			this.dtpKayitTarihi.Location = new System.Drawing.Point(632, 394);
			this.dtpKayitTarihi.Margin = new System.Windows.Forms.Padding(2);
			this.dtpKayitTarihi.Name = "dtpKayitTarihi";
			this.dtpKayitTarihi.Size = new System.Drawing.Size(263, 20);
			this.dtpKayitTarihi.TabIndex = 66;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Berlin Sans FB", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.Color.Black;
			this.label1.Location = new System.Drawing.Point(629, 373);
			this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(64, 13);
			this.label1.TabIndex = 65;
			this.label1.Text = "Kayıt Tarihi";
			// 
			// txtAdres
			// 
			this.txtAdres.BackColor = System.Drawing.Color.White;
			this.txtAdres.Font = new System.Drawing.Font("Berlin Sans FB", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtAdres.ForeColor = System.Drawing.Color.Black;
			this.txtAdres.Location = new System.Drawing.Point(345, 456);
			this.txtAdres.Margin = new System.Windows.Forms.Padding(2);
			this.txtAdres.Multiline = true;
			this.txtAdres.Name = "txtAdres";
			this.txtAdres.Size = new System.Drawing.Size(229, 87);
			this.txtAdres.TabIndex = 64;
			// 
			// txtTel
			// 
			this.txtTel.BackColor = System.Drawing.Color.White;
			this.txtTel.Font = new System.Drawing.Font("Berlin Sans FB", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtTel.ForeColor = System.Drawing.Color.Black;
			this.txtTel.Location = new System.Drawing.Point(346, 405);
			this.txtTel.Margin = new System.Windows.Forms.Padding(2);
			this.txtTel.Multiline = true;
			this.txtTel.Name = "txtTel";
			this.txtTel.Size = new System.Drawing.Size(228, 27);
			this.txtTel.TabIndex = 63;
			// 
			// txtEmail
			// 
			this.txtEmail.BackColor = System.Drawing.Color.White;
			this.txtEmail.Font = new System.Drawing.Font("Berlin Sans FB", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtEmail.ForeColor = System.Drawing.Color.Black;
			this.txtEmail.Location = new System.Drawing.Point(346, 359);
			this.txtEmail.Margin = new System.Windows.Forms.Padding(2);
			this.txtEmail.Multiline = true;
			this.txtEmail.Name = "txtEmail";
			this.txtEmail.Size = new System.Drawing.Size(228, 27);
			this.txtEmail.TabIndex = 62;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Berlin Sans FB", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.ForeColor = System.Drawing.Color.Black;
			this.label5.Location = new System.Drawing.Point(27, 530);
			this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(44, 13);
			this.label5.TabIndex = 61;
			this.label5.Text = "Cinsiyet";
			// 
			// rdbErkek
			// 
			this.rdbErkek.ForeColor = System.Drawing.Color.Black;
			this.rdbErkek.Location = new System.Drawing.Point(139, 526);
			this.rdbErkek.Name = "rdbErkek";
			this.rdbErkek.Size = new System.Drawing.Size(63, 24);
			this.rdbErkek.TabIndex = 59;
			this.rdbErkek.Text = "Erkek";
			// 
			// rdbKadin
			// 
			this.rdbKadin.ForeColor = System.Drawing.Color.Black;
			this.rdbKadin.Location = new System.Drawing.Point(82, 526);
			this.rdbKadin.Name = "rdbKadin";
			this.rdbKadin.Size = new System.Drawing.Size(61, 24);
			this.rdbKadin.TabIndex = 60;
			this.rdbKadin.Text = "Kadın";
			// 
			// dtpDogumTarihi
			// 
			this.dtpDogumTarihi.CalendarMonthBackground = System.Drawing.SystemColors.MenuText;
			this.dtpDogumTarihi.CalendarTitleBackColor = System.Drawing.SystemColors.ControlText;
			this.dtpDogumTarihi.CalendarTitleForeColor = System.Drawing.Color.Gray;
			this.dtpDogumTarihi.Location = new System.Drawing.Point(30, 503);
			this.dtpDogumTarihi.Margin = new System.Windows.Forms.Padding(2);
			this.dtpDogumTarihi.Name = "dtpDogumTarihi";
			this.dtpDogumTarihi.Size = new System.Drawing.Size(263, 20);
			this.dtpDogumTarihi.TabIndex = 58;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Berlin Sans FB", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.ForeColor = System.Drawing.Color.Black;
			this.label2.Location = new System.Drawing.Point(27, 482);
			this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(73, 13);
			this.label2.TabIndex = 57;
			this.label2.Text = "Doğum Tarihi";
			// 
			// txtAd
			// 
			this.txtAd.BackColor = System.Drawing.Color.White;
			this.txtAd.Font = new System.Drawing.Font("Berlin Sans FB", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtAd.ForeColor = System.Drawing.Color.Black;
			this.txtAd.Location = new System.Drawing.Point(28, 405);
			this.txtAd.Margin = new System.Windows.Forms.Padding(2);
			this.txtAd.Multiline = true;
			this.txtAd.Name = "txtAd";
			this.txtAd.Size = new System.Drawing.Size(265, 27);
			this.txtAd.TabIndex = 56;
			// 
			// txtSoyad
			// 
			this.txtSoyad.BackColor = System.Drawing.Color.White;
			this.txtSoyad.Font = new System.Drawing.Font("Berlin Sans FB", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtSoyad.ForeColor = System.Drawing.Color.Black;
			this.txtSoyad.Location = new System.Drawing.Point(28, 450);
			this.txtSoyad.Margin = new System.Windows.Forms.Padding(2);
			this.txtSoyad.Multiline = true;
			this.txtSoyad.Name = "txtSoyad";
			this.txtSoyad.Size = new System.Drawing.Size(265, 27);
			this.txtSoyad.TabIndex = 55;
			// 
			// panel11
			// 
			this.panel11.BackColor = System.Drawing.Color.DarkGray;
			this.panel11.Location = new System.Drawing.Point(28, 385);
			this.panel11.Margin = new System.Windows.Forms.Padding(2);
			this.panel11.Name = "panel11";
			this.panel11.Size = new System.Drawing.Size(265, 1);
			this.panel11.TabIndex = 52;
			// 
			// dgvCalisanlar
			// 
			this.dgvCalisanlar.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dgvCalisanlar.BackgroundColor = System.Drawing.Color.White;
			this.dgvCalisanlar.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.dgvCalisanlar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvCalisanlar.Location = new System.Drawing.Point(11, 44);
			this.dgvCalisanlar.Name = "dgvCalisanlar";
			this.dgvCalisanlar.RowHeadersWidth = 20;
			this.dgvCalisanlar.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.White;
			this.dgvCalisanlar.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Berlin Sans FB", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.dgvCalisanlar.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
			this.dgvCalisanlar.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(205)))), ((int)(((byte)(242)))));
			this.dgvCalisanlar.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
			this.dgvCalisanlar.RowTemplate.Height = 32;
			this.dgvCalisanlar.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgvCalisanlar.Size = new System.Drawing.Size(889, 285);
			this.dgvCalisanlar.TabIndex = 50;
			this.dgvCalisanlar.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dgvCalisanlar_DataBindingComplete);
			this.dgvCalisanlar.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.dgvCalisanlar_MouseDoubleClick);
			// 
			// txtTCNo
			// 
			this.txtTCNo.BackColor = System.Drawing.Color.White;
			this.txtTCNo.Font = new System.Drawing.Font("Berlin Sans FB", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtTCNo.ForeColor = System.Drawing.Color.Black;
			this.txtTCNo.Location = new System.Drawing.Point(28, 359);
			this.txtTCNo.Margin = new System.Windows.Forms.Padding(2);
			this.txtTCNo.Multiline = true;
			this.txtTCNo.Name = "txtTCNo";
			this.txtTCNo.Size = new System.Drawing.Size(265, 27);
			this.txtTCNo.TabIndex = 54;
			// 
			// chkRegisterYetkisi
			// 
			this.chkRegisterYetkisi.AutoSize = true;
			this.chkRegisterYetkisi.Font = new System.Drawing.Font("Berlin Sans FB", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.chkRegisterYetkisi.ForeColor = System.Drawing.Color.Black;
			this.chkRegisterYetkisi.Location = new System.Drawing.Point(632, 466);
			this.chkRegisterYetkisi.Margin = new System.Windows.Forms.Padding(2);
			this.chkRegisterYetkisi.Name = "chkRegisterYetkisi";
			this.chkRegisterYetkisi.Size = new System.Drawing.Size(100, 17);
			this.chkRegisterYetkisi.TabIndex = 84;
			this.chkRegisterYetkisi.Text = "Register Yetkisi";
			this.chkRegisterYetkisi.UseVisualStyleBackColor = true;
			// 
			// pictureBox2
			// 
			this.pictureBox2.BackColor = System.Drawing.Color.Silver;
			this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
			this.pictureBox2.Location = new System.Drawing.Point(257, 19);
			this.pictureBox2.Name = "pictureBox2";
			this.pictureBox2.Size = new System.Drawing.Size(17, 17);
			this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox2.TabIndex = 91;
			this.pictureBox2.TabStop = false;
			// 
			// txtCalisanAra
			// 
			this.txtCalisanAra.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this.txtCalisanAra.Font = new System.Drawing.Font("Berlin Sans FB", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtCalisanAra.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(24)))), ((int)(((byte)(60)))));
			this.txtCalisanAra.Location = new System.Drawing.Point(11, 17);
			this.txtCalisanAra.Margin = new System.Windows.Forms.Padding(2);
			this.txtCalisanAra.Name = "txtCalisanAra";
			this.txtCalisanAra.Size = new System.Drawing.Size(266, 22);
			this.txtCalisanAra.TabIndex = 90;
			this.txtCalisanAra.Text = "Çalışan Ara";
			this.txtCalisanAra.Click += new System.EventHandler(this.txtCalisanAra_Click);
			this.txtCalisanAra.TextChanged += new System.EventHandler(this.txtCalisanAra_TextChanged);
			// 
			// label10
			// 
			this.label10.AutoSize = true;
			this.label10.Font = new System.Drawing.Font("Berlin Sans FB", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label10.ForeColor = System.Drawing.Color.Black;
			this.label10.Location = new System.Drawing.Point(343, 439);
			this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(37, 15);
			this.label10.TabIndex = 97;
			this.label10.Text = "Adres";
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Font = new System.Drawing.Font("Berlin Sans FB", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label9.ForeColor = System.Drawing.Color.Black;
			this.label9.Location = new System.Drawing.Point(343, 388);
			this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(29, 15);
			this.label9.TabIndex = 96;
			this.label9.Text = "Gsm";
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Font = new System.Drawing.Font("Berlin Sans FB", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label8.ForeColor = System.Drawing.Color.Black;
			this.label8.Location = new System.Drawing.Point(343, 342);
			this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(35, 15);
			this.label8.TabIndex = 95;
			this.label8.Text = "Email";
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Font = new System.Drawing.Font("Berlin Sans FB", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label7.ForeColor = System.Drawing.Color.Black;
			this.label7.Location = new System.Drawing.Point(27, 433);
			this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(40, 15);
			this.label7.TabIndex = 94;
			this.label7.Text = "Soyad";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Berlin Sans FB", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.ForeColor = System.Drawing.Color.Black;
			this.label6.Location = new System.Drawing.Point(27, 388);
			this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(23, 15);
			this.label6.TabIndex = 93;
			this.label6.Text = "Ad";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Berlin Sans FB", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.ForeColor = System.Drawing.Color.Black;
			this.label4.Location = new System.Drawing.Point(27, 342);
			this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(150, 15);
			this.label4.TabIndex = 92;
			this.label4.Text = "Tc Kimlik No - Pasaport No";
			// 
			// CalisanlarForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.ClientSize = new System.Drawing.Size(912, 552);
			this.Controls.Add(this.label10);
			this.Controls.Add(this.label9);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.pictureBox2);
			this.Controls.Add(this.txtCalisanAra);
			this.Controls.Add(this.chkRegisterYetkisi);
			this.Controls.Add(this.btnUyeEkle);
			this.Controls.Add(this.btnDelete);
			this.Controls.Add(this.btnUpdate);
			this.Controls.Add(this.panel2);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.nmrMaasBilgisi);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.dtpKayitTarihi);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.txtAdres);
			this.Controls.Add(this.txtTel);
			this.Controls.Add(this.txtEmail);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.rdbErkek);
			this.Controls.Add(this.rdbKadin);
			this.Controls.Add(this.dtpDogumTarihi);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.txtAd);
			this.Controls.Add(this.txtSoyad);
			this.Controls.Add(this.panel11);
			this.Controls.Add(this.dgvCalisanlar);
			this.Controls.Add(this.txtTCNo);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "CalisanlarForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "CalisanlarForm";
			this.Load += new System.EventHandler(this.CalisanlarForm_Load);
			((System.ComponentModel.ISupportInitialize)(this.nmrMaasBilgisi)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dgvCalisanlar)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button btnUyeEkle;
		private System.Windows.Forms.Button btnDelete;
		private System.Windows.Forms.Button btnUpdate;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.NumericUpDown nmrMaasBilgisi;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.DateTimePicker dtpKayitTarihi;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox txtAdres;
		private System.Windows.Forms.TextBox txtTel;
		private System.Windows.Forms.TextBox txtEmail;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.RadioButton rdbErkek;
		private System.Windows.Forms.RadioButton rdbKadin;
		private System.Windows.Forms.DateTimePicker dtpDogumTarihi;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox txtAd;
		private System.Windows.Forms.TextBox txtSoyad;
		private System.Windows.Forms.Panel panel11;
		private System.Windows.Forms.DataGridView dgvCalisanlar;
		private System.Windows.Forms.TextBox txtTCNo;
		private System.Windows.Forms.CheckBox chkRegisterYetkisi;
		private System.Windows.Forms.PictureBox pictureBox2;
		private System.Windows.Forms.TextBox txtCalisanAra;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label4;
	}
}