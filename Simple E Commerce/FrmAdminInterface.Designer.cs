﻿namespace Simple_E_Commerce
{
    partial class FrmAdminInterface
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
            this.gbAdmin = new System.Windows.Forms.GroupBox();
            this.btnLogout = new System.Windows.Forms.Button();
            this.lblAdmin = new System.Windows.Forms.Label();
            this.txtNamaAdmin = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tabData = new System.Windows.Forms.TabControl();
            this.tabDataBarang = new System.Windows.Forms.TabPage();
            this.gBoxFilter = new System.Windows.Forms.GroupBox();
            this.txtHarga_max = new System.Windows.Forms.TextBox();
            this.lblHarga_max = new System.Windows.Forms.Label();
            this.txtJumlah_max = new System.Windows.Forms.TextBox();
            this.txtHarga_min = new System.Windows.Forms.TextBox();
            this.txtJumlah_min = new System.Windows.Forms.TextBox();
            this.lblHarga_min = new System.Windows.Forms.Label();
            this.lblJumlah_max = new System.Windows.Forms.Label();
            this.lblHarga = new System.Windows.Forms.Label();
            this.lblJumlah = new System.Windows.Forms.Label();
            this.lblJumlah__min = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.txtNamaBarang = new System.Windows.Forms.TextBox();
            this.txtKodeBarang = new System.Windows.Forms.TextBox();
            this.lblNamaBarang = new System.Windows.Forms.Label();
            this.dgvDataBarang = new System.Windows.Forms.DataGridView();
            this.clmKodeBarang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmNamaBarang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmJumlah = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmHarga = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblKodeBarang = new System.Windows.Forms.Label();
            this.tabDataOrder = new System.Windows.Forms.TabPage();
            this.btnCari = new System.Windows.Forms.Button();
            this.cmbFilter = new System.Windows.Forms.ComboBox();
            this.lblFilter = new System.Windows.Forms.Label();
            this.dgvDataOrder = new System.Windows.Forms.DataGridView();
            this.clmNoOrder = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmTglOrder = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmKodeBrg = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmNamaBrg = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmNamaPembeli = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmHargaBrg = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmJumlahBrg = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabDataMember = new System.Windows.Forms.TabPage();
            this.button1 = new System.Windows.Forms.Button();
            this.cmbFilterMember = new System.Windows.Forms.ComboBox();
            this.lblFilterMember = new System.Windows.Forms.Label();
            this.dgvDataMember = new System.Windows.Forms.DataGridView();
            this.clmUsername = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmNama = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmTotalPembelian = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnTambah = new System.Windows.Forms.Button();
            this.gbAdmin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tabData.SuspendLayout();
            this.tabDataBarang.SuspendLayout();
            this.gBoxFilter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDataBarang)).BeginInit();
            this.tabDataOrder.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDataOrder)).BeginInit();
            this.tabDataMember.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDataMember)).BeginInit();
            this.SuspendLayout();
            // 
            // gbAdmin
            // 
            this.gbAdmin.Controls.Add(this.btnLogout);
            this.gbAdmin.Controls.Add(this.lblAdmin);
            this.gbAdmin.Controls.Add(this.txtNamaAdmin);
            this.gbAdmin.Controls.Add(this.pictureBox1);
            this.gbAdmin.Location = new System.Drawing.Point(40, 40);
            this.gbAdmin.Margin = new System.Windows.Forms.Padding(2);
            this.gbAdmin.Name = "gbAdmin";
            this.gbAdmin.Padding = new System.Windows.Forms.Padding(2);
            this.gbAdmin.Size = new System.Drawing.Size(221, 303);
            this.gbAdmin.TabIndex = 3;
            this.gbAdmin.TabStop = false;
            this.gbAdmin.Text = "Admin";
            // 
            // btnLogout
            // 
            this.btnLogout.Location = new System.Drawing.Point(73, 243);
            this.btnLogout.Margin = new System.Windows.Forms.Padding(2);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(77, 35);
            this.btnLogout.TabIndex = 0;
            this.btnLogout.Text = "Log Out";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // lblAdmin
            // 
            this.lblAdmin.AutoSize = true;
            this.lblAdmin.Location = new System.Drawing.Point(94, 200);
            this.lblAdmin.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAdmin.Name = "lblAdmin";
            this.lblAdmin.Size = new System.Drawing.Size(103, 17);
            this.lblAdmin.TabIndex = 2;
            this.lblAdmin.Text = "{ nama admin }";
            // 
            // txtNamaAdmin
            // 
            this.txtNamaAdmin.AutoSize = true;
            this.txtNamaAdmin.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtNamaAdmin.Location = new System.Drawing.Point(25, 200);
            this.txtNamaAdmin.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.txtNamaAdmin.Name = "txtNamaAdmin";
            this.txtNamaAdmin.Size = new System.Drawing.Size(65, 17);
            this.txtNamaAdmin.TabIndex = 1;
            this.txtNamaAdmin.Text = "Nama    :";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(46, 38);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(135, 134);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // tabData
            // 
            this.tabData.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabData.Controls.Add(this.tabDataBarang);
            this.tabData.Controls.Add(this.tabDataOrder);
            this.tabData.Controls.Add(this.tabDataMember);
            this.tabData.Location = new System.Drawing.Point(284, 11);
            this.tabData.Margin = new System.Windows.Forms.Padding(2);
            this.tabData.Name = "tabData";
            this.tabData.SelectedIndex = 0;
            this.tabData.Size = new System.Drawing.Size(1001, 405);
            this.tabData.TabIndex = 2;
            // 
            // tabDataBarang
            // 
            this.tabDataBarang.Controls.Add(this.gBoxFilter);
            this.tabDataBarang.Controls.Add(this.btnDelete);
            this.tabDataBarang.Controls.Add(this.txtNamaBarang);
            this.tabDataBarang.Controls.Add(this.txtKodeBarang);
            this.tabDataBarang.Controls.Add(this.lblNamaBarang);
            this.tabDataBarang.Controls.Add(this.dgvDataBarang);
            this.tabDataBarang.Controls.Add(this.lblKodeBarang);
            this.tabDataBarang.Location = new System.Drawing.Point(4, 25);
            this.tabDataBarang.Margin = new System.Windows.Forms.Padding(2);
            this.tabDataBarang.Name = "tabDataBarang";
            this.tabDataBarang.Padding = new System.Windows.Forms.Padding(2);
            this.tabDataBarang.Size = new System.Drawing.Size(993, 376);
            this.tabDataBarang.TabIndex = 0;
            this.tabDataBarang.Text = "Data Barang";
            this.tabDataBarang.UseVisualStyleBackColor = true;
            // 
            // gBoxFilter
            // 
            this.gBoxFilter.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gBoxFilter.Controls.Add(this.txtHarga_max);
            this.gBoxFilter.Controls.Add(this.lblHarga_max);
            this.gBoxFilter.Controls.Add(this.txtJumlah_max);
            this.gBoxFilter.Controls.Add(this.txtHarga_min);
            this.gBoxFilter.Controls.Add(this.txtJumlah_min);
            this.gBoxFilter.Controls.Add(this.lblHarga_min);
            this.gBoxFilter.Controls.Add(this.lblJumlah_max);
            this.gBoxFilter.Controls.Add(this.lblHarga);
            this.gBoxFilter.Controls.Add(this.lblJumlah);
            this.gBoxFilter.Controls.Add(this.lblJumlah__min);
            this.gBoxFilter.Location = new System.Drawing.Point(12, 81);
            this.gBoxFilter.Name = "gBoxFilter";
            this.gBoxFilter.Size = new System.Drawing.Size(978, 95);
            this.gBoxFilter.TabIndex = 11;
            this.gBoxFilter.TabStop = false;
            // 
            // txtHarga_max
            // 
            this.txtHarga_max.Location = new System.Drawing.Point(762, 64);
            this.txtHarga_max.Name = "txtHarga_max";
            this.txtHarga_max.Size = new System.Drawing.Size(200, 22);
            this.txtHarga_max.TabIndex = 1;
            // 
            // lblHarga_max
            // 
            this.lblHarga_max.AutoSize = true;
            this.lblHarga_max.Location = new System.Drawing.Point(759, 44);
            this.lblHarga_max.Name = "lblHarga_max";
            this.lblHarga_max.Size = new System.Drawing.Size(37, 17);
            this.lblHarga_max.TabIndex = 0;
            this.lblHarga_max.Text = "MAX";
            // 
            // txtJumlah_max
            // 
            this.txtJumlah_max.Location = new System.Drawing.Point(248, 64);
            this.txtJumlah_max.Name = "txtJumlah_max";
            this.txtJumlah_max.Size = new System.Drawing.Size(200, 22);
            this.txtJumlah_max.TabIndex = 1;
            // 
            // txtHarga_min
            // 
            this.txtHarga_min.Location = new System.Drawing.Point(541, 64);
            this.txtHarga_min.Name = "txtHarga_min";
            this.txtHarga_min.Size = new System.Drawing.Size(200, 22);
            this.txtHarga_min.TabIndex = 1;
            // 
            // txtJumlah_min
            // 
            this.txtJumlah_min.Location = new System.Drawing.Point(9, 64);
            this.txtJumlah_min.Name = "txtJumlah_min";
            this.txtJumlah_min.Size = new System.Drawing.Size(200, 22);
            this.txtJumlah_min.TabIndex = 1;
            // 
            // lblHarga_min
            // 
            this.lblHarga_min.AutoSize = true;
            this.lblHarga_min.Location = new System.Drawing.Point(538, 44);
            this.lblHarga_min.Name = "lblHarga_min";
            this.lblHarga_min.Size = new System.Drawing.Size(32, 17);
            this.lblHarga_min.TabIndex = 0;
            this.lblHarga_min.Text = "MIN";
            // 
            // lblJumlah_max
            // 
            this.lblJumlah_max.AutoSize = true;
            this.lblJumlah_max.Location = new System.Drawing.Point(245, 44);
            this.lblJumlah_max.Name = "lblJumlah_max";
            this.lblJumlah_max.Size = new System.Drawing.Size(37, 17);
            this.lblJumlah_max.TabIndex = 0;
            this.lblJumlah_max.Text = "MAX";
            // 
            // lblHarga
            // 
            this.lblHarga.AutoSize = true;
            this.lblHarga.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHarga.Location = new System.Drawing.Point(537, 14);
            this.lblHarga.Name = "lblHarga";
            this.lblHarga.Size = new System.Drawing.Size(55, 20);
            this.lblHarga.TabIndex = 0;
            this.lblHarga.Text = "Harga";
            // 
            // lblJumlah
            // 
            this.lblJumlah.AutoSize = true;
            this.lblJumlah.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblJumlah.Location = new System.Drawing.Point(6, 14);
            this.lblJumlah.Name = "lblJumlah";
            this.lblJumlah.Size = new System.Drawing.Size(63, 20);
            this.lblJumlah.TabIndex = 0;
            this.lblJumlah.Text = "Jumlah";
            // 
            // lblJumlah__min
            // 
            this.lblJumlah__min.AutoSize = true;
            this.lblJumlah__min.Location = new System.Drawing.Point(6, 43);
            this.lblJumlah__min.Name = "lblJumlah__min";
            this.lblJumlah__min.Size = new System.Drawing.Size(32, 17);
            this.lblJumlah__min.TabIndex = 0;
            this.lblJumlah__min.Text = "MIN";
            // 
            // btnDelete
            // 
            this.btnDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDelete.Location = new System.Drawing.Point(849, 33);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(2);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(111, 33);
            this.btnDelete.TabIndex = 10;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // txtNamaBarang
            // 
            this.txtNamaBarang.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNamaBarang.Location = new System.Drawing.Point(138, 53);
            this.txtNamaBarang.Name = "txtNamaBarang";
            this.txtNamaBarang.Size = new System.Drawing.Size(665, 22);
            this.txtNamaBarang.TabIndex = 6;
            // 
            // txtKodeBarang
            // 
            this.txtKodeBarang.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtKodeBarang.Location = new System.Drawing.Point(138, 20);
            this.txtKodeBarang.Name = "txtKodeBarang";
            this.txtKodeBarang.Size = new System.Drawing.Size(665, 22);
            this.txtKodeBarang.TabIndex = 5;
            this.txtKodeBarang.Leave += new System.EventHandler(this.txtDataBarang_Leave);
            // 
            // lblNamaBarang
            // 
            this.lblNamaBarang.AutoSize = true;
            this.lblNamaBarang.Location = new System.Drawing.Point(31, 58);
            this.lblNamaBarang.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNamaBarang.Name = "lblNamaBarang";
            this.lblNamaBarang.Size = new System.Drawing.Size(95, 17);
            this.lblNamaBarang.TabIndex = 2;
            this.lblNamaBarang.Text = "Nama Barang";
            // 
            // dgvDataBarang
            // 
            this.dgvDataBarang.AllowUserToAddRows = false;
            this.dgvDataBarang.AllowUserToDeleteRows = false;
            this.dgvDataBarang.AllowUserToResizeColumns = false;
            this.dgvDataBarang.AllowUserToResizeRows = false;
            this.dgvDataBarang.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvDataBarang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDataBarang.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmKodeBarang,
            this.clmNamaBarang,
            this.clmJumlah,
            this.clmHarga});
            this.dgvDataBarang.Location = new System.Drawing.Point(9, 176);
            this.dgvDataBarang.Margin = new System.Windows.Forms.Padding(6);
            this.dgvDataBarang.Name = "dgvDataBarang";
            this.dgvDataBarang.ReadOnly = true;
            this.dgvDataBarang.RowHeadersVisible = false;
            this.dgvDataBarang.RowTemplate.Height = 33;
            this.dgvDataBarang.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDataBarang.Size = new System.Drawing.Size(978, 484);
            this.dgvDataBarang.TabIndex = 1;
            this.dgvDataBarang.Resize += new System.EventHandler(this.dgvDataBarang_Resize);
            // 
            // clmKodeBarang
            // 
            this.clmKodeBarang.HeaderText = "Kode Barang";
            this.clmKodeBarang.Name = "clmKodeBarang";
            this.clmKodeBarang.ReadOnly = true;
            // 
            // clmNamaBarang
            // 
            this.clmNamaBarang.HeaderText = "Nama Barang";
            this.clmNamaBarang.Name = "clmNamaBarang";
            this.clmNamaBarang.ReadOnly = true;
            // 
            // clmJumlah
            // 
            this.clmJumlah.HeaderText = "Jumlah";
            this.clmJumlah.Name = "clmJumlah";
            this.clmJumlah.ReadOnly = true;
            // 
            // clmHarga
            // 
            this.clmHarga.HeaderText = "Harga";
            this.clmHarga.Name = "clmHarga";
            this.clmHarga.ReadOnly = true;
            // 
            // lblKodeBarang
            // 
            this.lblKodeBarang.AutoSize = true;
            this.lblKodeBarang.Location = new System.Drawing.Point(31, 25);
            this.lblKodeBarang.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblKodeBarang.Name = "lblKodeBarang";
            this.lblKodeBarang.Size = new System.Drawing.Size(91, 17);
            this.lblKodeBarang.TabIndex = 0;
            this.lblKodeBarang.Text = "Kode Barang";
            // 
            // tabDataOrder
            // 
            this.tabDataOrder.Controls.Add(this.btnCari);
            this.tabDataOrder.Controls.Add(this.cmbFilter);
            this.tabDataOrder.Controls.Add(this.lblFilter);
            this.tabDataOrder.Controls.Add(this.dgvDataOrder);
            this.tabDataOrder.Location = new System.Drawing.Point(4, 25);
            this.tabDataOrder.Margin = new System.Windows.Forms.Padding(2);
            this.tabDataOrder.Name = "tabDataOrder";
            this.tabDataOrder.Padding = new System.Windows.Forms.Padding(3);
            this.tabDataOrder.Size = new System.Drawing.Size(983, 376);
            this.tabDataOrder.TabIndex = 1;
            this.tabDataOrder.Text = "Data Order";
            this.tabDataOrder.UseVisualStyleBackColor = true;
            // 
            // btnCari
            // 
            this.btnCari.Location = new System.Drawing.Point(417, 29);
            this.btnCari.Margin = new System.Windows.Forms.Padding(2);
            this.btnCari.Name = "btnCari";
            this.btnCari.Size = new System.Drawing.Size(97, 26);
            this.btnCari.TabIndex = 3;
            this.btnCari.Text = "Cari";
            this.btnCari.UseVisualStyleBackColor = true;
            // 
            // cmbFilter
            // 
            this.cmbFilter.FormattingEnabled = true;
            this.cmbFilter.Items.AddRange(new object[] {
            "NoOrder",
            "TglOrder",
            "KodeBarang\t",
            "NamaBarang\t",
            "NamaPembeli",
            "Harga",
            "Jumlah"});
            this.cmbFilter.Location = new System.Drawing.Point(183, 33);
            this.cmbFilter.Margin = new System.Windows.Forms.Padding(2);
            this.cmbFilter.Name = "cmbFilter";
            this.cmbFilter.Size = new System.Drawing.Size(197, 24);
            this.cmbFilter.TabIndex = 2;
            // 
            // lblFilter
            // 
            this.lblFilter.AutoSize = true;
            this.lblFilter.Location = new System.Drawing.Point(37, 35);
            this.lblFilter.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblFilter.Name = "lblFilter";
            this.lblFilter.Size = new System.Drawing.Size(118, 17);
            this.lblFilter.TabIndex = 1;
            this.lblFilter.Text = "Cari Berdasarkan";
            // 
            // dgvDataOrder
            // 
            this.dgvDataOrder.AllowUserToAddRows = false;
            this.dgvDataOrder.AllowUserToDeleteRows = false;
            this.dgvDataOrder.AllowUserToResizeColumns = false;
            this.dgvDataOrder.AllowUserToResizeRows = false;
            this.dgvDataOrder.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvDataOrder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDataOrder.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmNoOrder,
            this.clmTglOrder,
            this.clmKodeBrg,
            this.clmNamaBrg,
            this.clmNamaPembeli,
            this.clmHargaBrg,
            this.clmJumlahBrg,
            this.clmTotal});
            this.dgvDataOrder.Location = new System.Drawing.Point(4, 99);
            this.dgvDataOrder.Margin = new System.Windows.Forms.Padding(2);
            this.dgvDataOrder.Name = "dgvDataOrder";
            this.dgvDataOrder.ReadOnly = true;
            this.dgvDataOrder.RowHeadersVisible = false;
            this.dgvDataOrder.RowTemplate.Height = 33;
            this.dgvDataOrder.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDataOrder.Size = new System.Drawing.Size(1138, 685);
            this.dgvDataOrder.TabIndex = 0;
            // 
            // clmNoOrder
            // 
            this.clmNoOrder.HeaderText = "No Order";
            this.clmNoOrder.Name = "clmNoOrder";
            this.clmNoOrder.ReadOnly = true;
            // 
            // clmTglOrder
            // 
            this.clmTglOrder.HeaderText = "Tgl Order";
            this.clmTglOrder.Name = "clmTglOrder";
            this.clmTglOrder.ReadOnly = true;
            // 
            // clmKodeBrg
            // 
            this.clmKodeBrg.HeaderText = "Kode Barang";
            this.clmKodeBrg.Name = "clmKodeBrg";
            this.clmKodeBrg.ReadOnly = true;
            // 
            // clmNamaBrg
            // 
            this.clmNamaBrg.HeaderText = "Nama Barang";
            this.clmNamaBrg.Name = "clmNamaBrg";
            this.clmNamaBrg.ReadOnly = true;
            // 
            // clmNamaPembeli
            // 
            this.clmNamaPembeli.HeaderText = "Nama Pembeli";
            this.clmNamaPembeli.Name = "clmNamaPembeli";
            this.clmNamaPembeli.ReadOnly = true;
            // 
            // clmHargaBrg
            // 
            this.clmHargaBrg.HeaderText = "Harga";
            this.clmHargaBrg.Name = "clmHargaBrg";
            this.clmHargaBrg.ReadOnly = true;
            // 
            // clmJumlahBrg
            // 
            this.clmJumlahBrg.HeaderText = "Jumlah";
            this.clmJumlahBrg.Name = "clmJumlahBrg";
            this.clmJumlahBrg.ReadOnly = true;
            // 
            // clmTotal
            // 
            this.clmTotal.HeaderText = "Total";
            this.clmTotal.Name = "clmTotal";
            this.clmTotal.ReadOnly = true;
            // 
            // tabDataMember
            // 
            this.tabDataMember.Controls.Add(this.button1);
            this.tabDataMember.Controls.Add(this.cmbFilterMember);
            this.tabDataMember.Controls.Add(this.lblFilterMember);
            this.tabDataMember.Controls.Add(this.dgvDataMember);
            this.tabDataMember.Location = new System.Drawing.Point(4, 25);
            this.tabDataMember.Margin = new System.Windows.Forms.Padding(2);
            this.tabDataMember.Name = "tabDataMember";
            this.tabDataMember.Padding = new System.Windows.Forms.Padding(2);
            this.tabDataMember.Size = new System.Drawing.Size(983, 376);
            this.tabDataMember.TabIndex = 2;
            this.tabDataMember.Text = "Data Member";
            this.tabDataMember.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(458, 29);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(97, 26);
            this.button1.TabIndex = 4;
            this.button1.Text = "Cari";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // cmbFilterMember
            // 
            this.cmbFilterMember.FormattingEnabled = true;
            this.cmbFilterMember.Location = new System.Drawing.Point(199, 29);
            this.cmbFilterMember.Margin = new System.Windows.Forms.Padding(2);
            this.cmbFilterMember.Name = "cmbFilterMember";
            this.cmbFilterMember.Size = new System.Drawing.Size(215, 24);
            this.cmbFilterMember.TabIndex = 2;
            // 
            // lblFilterMember
            // 
            this.lblFilterMember.AutoSize = true;
            this.lblFilterMember.Location = new System.Drawing.Point(37, 31);
            this.lblFilterMember.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblFilterMember.Name = "lblFilterMember";
            this.lblFilterMember.Size = new System.Drawing.Size(118, 17);
            this.lblFilterMember.TabIndex = 1;
            this.lblFilterMember.Text = "Cari Berdasarkan";
            // 
            // dgvDataMember
            // 
            this.dgvDataMember.AllowUserToAddRows = false;
            this.dgvDataMember.AllowUserToDeleteRows = false;
            this.dgvDataMember.AllowUserToResizeColumns = false;
            this.dgvDataMember.AllowUserToResizeRows = false;
            this.dgvDataMember.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvDataMember.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDataMember.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmUsername,
            this.clmNama,
            this.clmTotalPembelian});
            this.dgvDataMember.Location = new System.Drawing.Point(4, 101);
            this.dgvDataMember.Margin = new System.Windows.Forms.Padding(2);
            this.dgvDataMember.Name = "dgvDataMember";
            this.dgvDataMember.ReadOnly = true;
            this.dgvDataMember.RowHeadersVisible = false;
            this.dgvDataMember.RowTemplate.Height = 33;
            this.dgvDataMember.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDataMember.Size = new System.Drawing.Size(1138, 391);
            this.dgvDataMember.TabIndex = 0;
            this.dgvDataMember.Resize += new System.EventHandler(this.dgvDataMember_Resize);
            // 
            // clmUsername
            // 
            this.clmUsername.HeaderText = "Username";
            this.clmUsername.Name = "clmUsername";
            this.clmUsername.ReadOnly = true;
            // 
            // clmNama
            // 
            this.clmNama.HeaderText = "Nama";
            this.clmNama.Name = "clmNama";
            this.clmNama.ReadOnly = true;
            // 
            // clmTotalPembelian
            // 
            this.clmTotalPembelian.HeaderText = "Total Pembelian";
            this.clmTotalPembelian.Name = "clmTotalPembelian";
            this.clmTotalPembelian.ReadOnly = true;
            // 
            // btnTambah
            // 
            this.btnTambah.Location = new System.Drawing.Point(98, 348);
            this.btnTambah.Name = "btnTambah";
            this.btnTambah.Size = new System.Drawing.Size(112, 45);
            this.btnTambah.TabIndex = 4;
            this.btnTambah.Text = "Tambah Data Barang";
            this.btnTambah.UseVisualStyleBackColor = true;
            this.btnTambah.Click += new System.EventHandler(this.btnTambah_Click);
            // 
            // FrmAdminInterface
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1296, 427);
            this.Controls.Add(this.btnTambah);
            this.Controls.Add(this.gbAdmin);
            this.Controls.Add(this.tabData);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FrmAdminInterface";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmAdminInterface";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmAdminInterface_Load);
            this.gbAdmin.ResumeLayout(false);
            this.gbAdmin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tabData.ResumeLayout(false);
            this.tabDataBarang.ResumeLayout(false);
            this.tabDataBarang.PerformLayout();
            this.gBoxFilter.ResumeLayout(false);
            this.gBoxFilter.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDataBarang)).EndInit();
            this.tabDataOrder.ResumeLayout(false);
            this.tabDataOrder.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDataOrder)).EndInit();
            this.tabDataMember.ResumeLayout(false);
            this.tabDataMember.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDataMember)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbAdmin;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Label lblAdmin;
        private System.Windows.Forms.Label txtNamaAdmin;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TabControl tabData;
        private System.Windows.Forms.TabPage tabDataBarang;
        private System.Windows.Forms.TextBox txtNamaBarang;
        private System.Windows.Forms.TextBox txtKodeBarang;
        private System.Windows.Forms.Label lblNamaBarang;
        private System.Windows.Forms.DataGridView dgvDataBarang;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmKodeBarang;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmNamaBarang;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmJumlah;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmHarga;
        private System.Windows.Forms.Label lblKodeBarang;
        private System.Windows.Forms.TabPage tabDataOrder;
        private System.Windows.Forms.Button btnCari;
        private System.Windows.Forms.ComboBox cmbFilter;
        private System.Windows.Forms.Label lblFilter;
        private System.Windows.Forms.TabPage tabDataMember;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox cmbFilterMember;
        private System.Windows.Forms.Label lblFilterMember;
        private System.Windows.Forms.DataGridView dgvDataMember;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmUsername;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmNama;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmTotalPembelian;
        private System.Windows.Forms.DataGridView dgvDataOrder;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmNoOrder;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmTglOrder;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmKodeBrg;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmNamaBrg;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmNamaPembeli;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmHargaBrg;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmJumlahBrg;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmTotal;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Label lblJumlah_max;
        private System.Windows.Forms.Label lblJumlah__min;
        private System.Windows.Forms.TextBox txtJumlah_max;
        private System.Windows.Forms.TextBox txtJumlah_min;
        private System.Windows.Forms.TextBox txtHarga_max;
        private System.Windows.Forms.TextBox txtHarga_min;
        private System.Windows.Forms.Label lblHarga_max;
        private System.Windows.Forms.Label lblHarga_min;
        private System.Windows.Forms.GroupBox gBoxFilter;
        private System.Windows.Forms.Label lblHarga;
        private System.Windows.Forms.Label lblJumlah;
        private System.Windows.Forms.Button btnTambah;
    }
}