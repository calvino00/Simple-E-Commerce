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
            this.btnSimpan = new System.Windows.Forms.Button();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lblHarga = new System.Windows.Forms.Label();
            this.lblJumlah = new System.Windows.Forms.Label();
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
            this.clmHargaBrg = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmJumlahBrg = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabDataMember = new System.Windows.Forms.TabPage();
            this.button1 = new System.Windows.Forms.Button();
            this.cmbFilterMember = new System.Windows.Forms.ComboBox();
            this.lblFilterMember = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.clmUsername = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmNama = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmTotalPembelian = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gbAdmin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tabData.SuspendLayout();
            this.tabDataBarang.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDataBarang)).BeginInit();
            this.tabDataOrder.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDataOrder)).BeginInit();
            this.tabDataMember.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // gbAdmin
            // 
            this.gbAdmin.Controls.Add(this.btnLogout);
            this.gbAdmin.Controls.Add(this.lblAdmin);
            this.gbAdmin.Controls.Add(this.txtNamaAdmin);
            this.gbAdmin.Controls.Add(this.pictureBox1);
            this.gbAdmin.Location = new System.Drawing.Point(60, 63);
            this.gbAdmin.Name = "gbAdmin";
            this.gbAdmin.Size = new System.Drawing.Size(331, 474);
            this.gbAdmin.TabIndex = 3;
            this.gbAdmin.TabStop = false;
            this.gbAdmin.Text = "Admin";
            // 
            // btnLogout
            // 
            this.btnLogout.Location = new System.Drawing.Point(109, 379);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(115, 55);
            this.btnLogout.TabIndex = 0;
            this.btnLogout.Text = "Log Out";
            this.btnLogout.UseVisualStyleBackColor = true;
            // 
            // lblAdmin
            // 
            this.lblAdmin.AutoSize = true;
            this.lblAdmin.Location = new System.Drawing.Point(138, 312);
            this.lblAdmin.Name = "lblAdmin";
            this.lblAdmin.Size = new System.Drawing.Size(155, 25);
            this.lblAdmin.TabIndex = 2;
            this.lblAdmin.Text = "{ nama admin }";
            // 
            // txtNamaAdmin
            // 
            this.txtNamaAdmin.AutoSize = true;
            this.txtNamaAdmin.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtNamaAdmin.Location = new System.Drawing.Point(37, 312);
            this.txtNamaAdmin.Name = "txtNamaAdmin";
            this.txtNamaAdmin.Size = new System.Drawing.Size(68, 25);
            this.txtNamaAdmin.TabIndex = 1;
            this.txtNamaAdmin.Text = "Nama";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(69, 60);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(203, 210);
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
            this.tabData.Location = new System.Drawing.Point(426, 52);
            this.tabData.Name = "tabData";
            this.tabData.SelectedIndex = 0;
            this.tabData.Size = new System.Drawing.Size(1440, 980);
            this.tabData.TabIndex = 2;
            // 
            // tabDataBarang
            // 
            this.tabDataBarang.Controls.Add(this.btnSimpan);
            this.tabDataBarang.Controls.Add(this.textBox4);
            this.tabDataBarang.Controls.Add(this.textBox3);
            this.tabDataBarang.Controls.Add(this.textBox2);
            this.tabDataBarang.Controls.Add(this.textBox1);
            this.tabDataBarang.Controls.Add(this.lblHarga);
            this.tabDataBarang.Controls.Add(this.lblJumlah);
            this.tabDataBarang.Controls.Add(this.lblNamaBarang);
            this.tabDataBarang.Controls.Add(this.dgvDataBarang);
            this.tabDataBarang.Controls.Add(this.lblKodeBarang);
            this.tabDataBarang.Location = new System.Drawing.Point(8, 39);
            this.tabDataBarang.Name = "tabDataBarang";
            this.tabDataBarang.Padding = new System.Windows.Forms.Padding(3);
            this.tabDataBarang.Size = new System.Drawing.Size(1424, 933);
            this.tabDataBarang.TabIndex = 0;
            this.tabDataBarang.Text = "Data Barang";
            this.tabDataBarang.UseVisualStyleBackColor = true;
            // 
            // btnSimpan
            // 
            this.btnSimpan.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSimpan.Location = new System.Drawing.Point(1191, 115);
            this.btnSimpan.Name = "btnSimpan";
            this.btnSimpan.Size = new System.Drawing.Size(167, 51);
            this.btnSimpan.TabIndex = 9;
            this.btnSimpan.Text = "Simpan";
            this.btnSimpan.UseVisualStyleBackColor = true;
            // 
            // textBox4
            // 
            this.textBox4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox4.Location = new System.Drawing.Point(297, 200);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(855, 31);
            this.textBox4.TabIndex = 8;
            // 
            // textBox3
            // 
            this.textBox3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox3.Location = new System.Drawing.Point(297, 152);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(855, 31);
            this.textBox3.TabIndex = 7;
            // 
            // textBox2
            // 
            this.textBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox2.Location = new System.Drawing.Point(297, 99);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(855, 31);
            this.textBox2.TabIndex = 6;
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.Location = new System.Drawing.Point(297, 49);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(855, 31);
            this.textBox1.TabIndex = 5;
            // 
            // lblHarga
            // 
            this.lblHarga.AutoSize = true;
            this.lblHarga.Location = new System.Drawing.Point(48, 203);
            this.lblHarga.Name = "lblHarga";
            this.lblHarga.Size = new System.Drawing.Size(70, 25);
            this.lblHarga.TabIndex = 4;
            this.lblHarga.Text = "Harga";
            // 
            // lblJumlah
            // 
            this.lblJumlah.AutoSize = true;
            this.lblJumlah.Location = new System.Drawing.Point(48, 152);
            this.lblJumlah.Name = "lblJumlah";
            this.lblJumlah.Size = new System.Drawing.Size(81, 25);
            this.lblJumlah.TabIndex = 3;
            this.lblJumlah.Text = "Jumlah";
            // 
            // lblNamaBarang
            // 
            this.lblNamaBarang.AutoSize = true;
            this.lblNamaBarang.Location = new System.Drawing.Point(48, 102);
            this.lblNamaBarang.Name = "lblNamaBarang";
            this.lblNamaBarang.Size = new System.Drawing.Size(143, 25);
            this.lblNamaBarang.TabIndex = 2;
            this.lblNamaBarang.Text = "Nama Barang";
            // 
            // dgvDataBarang
            // 
            this.dgvDataBarang.AllowUserToAddRows = false;
            this.dgvDataBarang.AllowUserToDeleteRows = false;
            this.dgvDataBarang.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvDataBarang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDataBarang.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmKodeBarang,
            this.clmNamaBarang,
            this.clmJumlah,
            this.clmHarga});
            this.dgvDataBarang.EnableHeadersVisualStyles = false;
            this.dgvDataBarang.Location = new System.Drawing.Point(53, 297);
            this.dgvDataBarang.Margin = new System.Windows.Forms.Padding(6);
            this.dgvDataBarang.Name = "dgvDataBarang";
            this.dgvDataBarang.ReadOnly = true;
            this.dgvDataBarang.RowTemplate.Height = 33;
            this.dgvDataBarang.Size = new System.Drawing.Size(1328, 585);
            this.dgvDataBarang.TabIndex = 1;
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
            this.lblKodeBarang.Location = new System.Drawing.Point(48, 52);
            this.lblKodeBarang.Name = "lblKodeBarang";
            this.lblKodeBarang.Size = new System.Drawing.Size(137, 25);
            this.lblKodeBarang.TabIndex = 0;
            this.lblKodeBarang.Text = "Kode Barang";
            // 
            // tabDataOrder
            // 
            this.tabDataOrder.Controls.Add(this.btnCari);
            this.tabDataOrder.Controls.Add(this.cmbFilter);
            this.tabDataOrder.Controls.Add(this.lblFilter);
            this.tabDataOrder.Controls.Add(this.dgvDataOrder);
            this.tabDataOrder.Location = new System.Drawing.Point(8, 39);
            this.tabDataOrder.Name = "tabDataOrder";
            this.tabDataOrder.Padding = new System.Windows.Forms.Padding(3);
            this.tabDataOrder.Size = new System.Drawing.Size(1424, 933);
            this.tabDataOrder.TabIndex = 1;
            this.tabDataOrder.Text = "Data Order";
            this.tabDataOrder.UseVisualStyleBackColor = true;
            // 
            // btnCari
            // 
            this.btnCari.Location = new System.Drawing.Point(608, 45);
            this.btnCari.Name = "btnCari";
            this.btnCari.Size = new System.Drawing.Size(146, 40);
            this.btnCari.TabIndex = 3;
            this.btnCari.Text = "Cari";
            this.btnCari.UseVisualStyleBackColor = true;
            // 
            // cmbFilter
            // 
            this.cmbFilter.FormattingEnabled = true;
            this.cmbFilter.Location = new System.Drawing.Point(257, 52);
            this.cmbFilter.Name = "cmbFilter";
            this.cmbFilter.Size = new System.Drawing.Size(294, 33);
            this.cmbFilter.TabIndex = 2;
            // 
            // lblFilter
            // 
            this.lblFilter.AutoSize = true;
            this.lblFilter.Location = new System.Drawing.Point(37, 55);
            this.lblFilter.Name = "lblFilter";
            this.lblFilter.Size = new System.Drawing.Size(179, 25);
            this.lblFilter.TabIndex = 1;
            this.lblFilter.Text = "Cari Berdasarkan";
            // 
            // dgvDataOrder
            // 
            this.dgvDataOrder.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvDataOrder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDataOrder.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmNoOrder,
            this.clmTglOrder,
            this.clmKodeBrg,
            this.clmNamaBrg,
            this.clmHargaBrg,
            this.clmJumlahBrg,
            this.clmTotal});
            this.dgvDataOrder.Location = new System.Drawing.Point(42, 138);
            this.dgvDataOrder.Name = "dgvDataOrder";
            this.dgvDataOrder.RowTemplate.Height = 33;
            this.dgvDataOrder.Size = new System.Drawing.Size(1355, 762);
            this.dgvDataOrder.TabIndex = 0;
            // 
            // clmNoOrder
            // 
            this.clmNoOrder.HeaderText = "No_Order";
            this.clmNoOrder.Name = "clmNoOrder";
            // 
            // clmTglOrder
            // 
            this.clmTglOrder.HeaderText = "Tgl_Order";
            this.clmTglOrder.Name = "clmTglOrder";
            // 
            // clmKodeBrg
            // 
            this.clmKodeBrg.HeaderText = "Kode_Barang";
            this.clmKodeBrg.Name = "clmKodeBrg";
            // 
            // clmNamaBrg
            // 
            this.clmNamaBrg.HeaderText = "Nama_Barang";
            this.clmNamaBrg.Name = "clmNamaBrg";
            // 
            // clmHargaBrg
            // 
            this.clmHargaBrg.HeaderText = "Harga";
            this.clmHargaBrg.Name = "clmHargaBrg";
            // 
            // clmJumlahBrg
            // 
            this.clmJumlahBrg.HeaderText = "Jumlah";
            this.clmJumlahBrg.Name = "clmJumlahBrg";
            // 
            // clmTotal
            // 
            this.clmTotal.HeaderText = "Total";
            this.clmTotal.Name = "clmTotal";
            // 
            // tabDataMember
            // 
            this.tabDataMember.Controls.Add(this.button1);
            this.tabDataMember.Controls.Add(this.cmbFilterMember);
            this.tabDataMember.Controls.Add(this.lblFilterMember);
            this.tabDataMember.Controls.Add(this.dataGridView1);
            this.tabDataMember.Location = new System.Drawing.Point(8, 39);
            this.tabDataMember.Name = "tabDataMember";
            this.tabDataMember.Padding = new System.Windows.Forms.Padding(3);
            this.tabDataMember.Size = new System.Drawing.Size(1424, 933);
            this.tabDataMember.TabIndex = 2;
            this.tabDataMember.Text = "Data Member";
            this.tabDataMember.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(687, 45);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(146, 40);
            this.button1.TabIndex = 4;
            this.button1.Text = "Cari";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // cmbFilterMember
            // 
            this.cmbFilterMember.FormattingEnabled = true;
            this.cmbFilterMember.Location = new System.Drawing.Point(299, 45);
            this.cmbFilterMember.Name = "cmbFilterMember";
            this.cmbFilterMember.Size = new System.Drawing.Size(320, 33);
            this.cmbFilterMember.TabIndex = 2;
            // 
            // lblFilterMember
            // 
            this.lblFilterMember.AutoSize = true;
            this.lblFilterMember.Location = new System.Drawing.Point(56, 48);
            this.lblFilterMember.Name = "lblFilterMember";
            this.lblFilterMember.Size = new System.Drawing.Size(179, 25);
            this.lblFilterMember.TabIndex = 1;
            this.lblFilterMember.Text = "Cari Berdasarkan";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmUsername,
            this.clmNama,
            this.clmTotalPembelian});
            this.dataGridView1.Location = new System.Drawing.Point(61, 130);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 33;
            this.dataGridView1.Size = new System.Drawing.Size(1307, 748);
            this.dataGridView1.TabIndex = 0;
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
            // FrmAdminInterface
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1927, 1085);
            this.Controls.Add(this.gbAdmin);
            this.Controls.Add(this.tabData);
            this.Name = "FrmAdminInterface";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmAdminInterface";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.gbAdmin.ResumeLayout(false);
            this.gbAdmin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tabData.ResumeLayout(false);
            this.tabDataBarang.ResumeLayout(false);
            this.tabDataBarang.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDataBarang)).EndInit();
            this.tabDataOrder.ResumeLayout(false);
            this.tabDataOrder.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDataOrder)).EndInit();
            this.tabDataMember.ResumeLayout(false);
            this.tabDataMember.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
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
        private System.Windows.Forms.Button btnSimpan;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lblHarga;
        private System.Windows.Forms.Label lblJumlah;
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
        private System.Windows.Forms.DataGridView dgvDataOrder;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmNoOrder;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmTglOrder;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmKodeBrg;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmNamaBrg;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmHargaBrg;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmJumlahBrg;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmTotal;
        private System.Windows.Forms.TabPage tabDataMember;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox cmbFilterMember;
        private System.Windows.Forms.Label lblFilterMember;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmUsername;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmNama;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmTotalPembelian;
    }
}