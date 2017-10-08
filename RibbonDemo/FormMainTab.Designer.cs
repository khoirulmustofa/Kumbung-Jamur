namespace RibbonDemo
{
    partial class FormMainTab
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource5 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource6 = new Microsoft.Reporting.WinForms.ReportDataSource();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPageHome = new System.Windows.Forms.TabPage();
            this.label32 = new System.Windows.Forms.Label();
            this.lblSettingKumbung1 = new System.Windows.Forms.Label();
            this.lblMesseg = new System.Windows.Forms.Label();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.btnJalan = new System.Windows.Forms.Button();
            this.label22 = new System.Windows.Forms.Label();
            this.btnBerhenti = new System.Windows.Forms.Button();
            this.tabPageGrafikRealTime = new System.Windows.Forms.TabPage();
            this.label21 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.zedGraphKelembapan = new ZedGraph.ZedGraphControl();
            this.zedGraphTemperature = new ZedGraph.ZedGraphControl();
            this.tabPageTemperature = new System.Windows.Forms.TabPage();
            this.label17 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnCariTemperature = new System.Windows.Forms.Button();
            this.dpSampaiTemperature = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.dpMulaiTemperature = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.rvTemperature = new Microsoft.Reporting.WinForms.ReportViewer();
            this.tabPageKelembapan = new System.Windows.Forms.TabPage();
            this.label18 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnCariKelembapan = new System.Windows.Forms.Button();
            this.dpSampaiKelembapan = new System.Windows.Forms.DateTimePicker();
            this.label19 = new System.Windows.Forms.Label();
            this.dpMulaiKelembapan = new System.Windows.Forms.DateTimePicker();
            this.label20 = new System.Windows.Forms.Label();
            this.rvKelembapan = new Microsoft.Reporting.WinForms.ReportViewer();
            this.tabPageKumbung = new System.Windows.Forms.TabPage();
            this.gvKumbung = new System.Windows.Forms.DataGridView();
            this.btnEditKumbung = new System.Windows.Forms.Button();
            this.btnHapusKumbung = new System.Windows.Forms.Button();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.btnBatalKumbung = new System.Windows.Forms.Button();
            this.txtKapasitas = new System.Windows.Forms.TextBox();
            this.txtNamaKumbung = new System.Windows.Forms.TextBox();
            this.label26 = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            this.btnSimpanKumbung = new System.Windows.Forms.Button();
            this.txtKodeKumbung = new System.Windows.Forms.TextBox();
            this.label28 = new System.Windows.Forms.Label();
            this.btnUpdateKumbung = new System.Windows.Forms.Button();
            this.label24 = new System.Windows.Forms.Label();
            this.tabPageSetting = new System.Windows.Forms.TabPage();
            this.gvSetting = new System.Windows.Forms.DataGridView();
            this.btnDeleteSetting = new System.Windows.Forms.Button();
            this.btnEditSetting = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.cmbKodeKumbung = new System.Windows.Forms.ComboBox();
            this.rbTidakAktif = new System.Windows.Forms.RadioButton();
            this.rbAktif = new System.Windows.Forms.RadioButton();
            this.btnSimpanSetting = new System.Windows.Forms.Button();
            this.label30 = new System.Windows.Forms.Label();
            this.label31 = new System.Windows.Forms.Label();
            this.txtSettingKelembapanMax = new System.Windows.Forms.TextBox();
            this.txtSettingKelembapanMin = new System.Windows.Forms.TextBox();
            this.label29 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.txtSettingTemperatureMax = new System.Windows.Forms.TextBox();
            this.txtKeterangan = new System.Windows.Forms.TextBox();
            this.label23 = new System.Windows.Forms.Label();
            this.btnBatalSetting = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.txtSettingTemperatureMin = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.txtKodeSetting = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.btnUpdateSetting = new System.Windows.Forms.Button();
            this.tabPageUsers = new System.Windows.Forms.TabPage();
            this.label15 = new System.Windows.Forms.Label();
            this.btnEditUser = new System.Windows.Forms.Button();
            this.btnHapusUser = new System.Windows.Forms.Button();
            this.gvUser = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbUser = new System.Windows.Forms.RadioButton();
            this.rbAdministrator = new System.Windows.Forms.RadioButton();
            this.btnBatalUser = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.txtNamaLengkap = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btnSimpanUser = new System.Windows.Forms.Button();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnUpdateUser = new System.Windows.Forms.Button();
            this.lblNamaPT = new System.Windows.Forms.Label();
            this.lblNamaLengkap = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblLevels = new System.Windows.Forms.Label();
            this.btnKeluar = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.ReportKelembapanDataSet = new RibbonDemo.ReportKelembapanDataSet();
            this.ProcKelembapanBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ProcKelembapanTableAdapter = new RibbonDemo.ReportKelembapanDataSetTableAdapters.ProcKelembapanTableAdapter();
            this.ReportTemperatureDataSet = new RibbonDemo.ReportTemperatureDataSet();
            this.ProcTemperatureBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ProcTemperatureTableAdapter = new RibbonDemo.ReportTemperatureDataSetTableAdapters.ProcTemperatureTableAdapter();
            this.tabControl1.SuspendLayout();
            this.tabPageHome.SuspendLayout();
            this.tabPageGrafikRealTime.SuspendLayout();
            this.tabPageTemperature.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tabPageKelembapan.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.tabPageKumbung.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvKumbung)).BeginInit();
            this.groupBox5.SuspendLayout();
            this.tabPageSetting.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvSetting)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.tabPageUsers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvUser)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ReportKelembapanDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProcKelembapanBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ReportTemperatureDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProcTemperatureBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPageHome);
            this.tabControl1.Controls.Add(this.tabPageGrafikRealTime);
            this.tabControl1.Controls.Add(this.tabPageTemperature);
            this.tabControl1.Controls.Add(this.tabPageKelembapan);
            this.tabControl1.Controls.Add(this.tabPageKumbung);
            this.tabControl1.Controls.Add(this.tabPageSetting);
            this.tabControl1.Controls.Add(this.tabPageUsers);
            this.tabControl1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.ItemSize = new System.Drawing.Size(200, 50);
            this.tabControl1.Location = new System.Drawing.Point(12, 82);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1338, 618);
            this.tabControl1.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabControl1.TabIndex = 0;
            // 
            // tabPageHome
            // 
            this.tabPageHome.BackColor = System.Drawing.Color.Purple;
            this.tabPageHome.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabPageHome.Controls.Add(this.label32);
            this.tabPageHome.Controls.Add(this.lblSettingKumbung1);
            this.tabPageHome.Controls.Add(this.lblMesseg);
            this.tabPageHome.Controls.Add(this.groupBox6);
            this.tabPageHome.Controls.Add(this.btnJalan);
            this.tabPageHome.Controls.Add(this.label22);
            this.tabPageHome.Controls.Add(this.btnBerhenti);
            this.tabPageHome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPageHome.ImageKey = "(none)";
            this.tabPageHome.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.tabPageHome.Location = new System.Drawing.Point(4, 54);
            this.tabPageHome.Name = "tabPageHome";
            this.tabPageHome.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageHome.Size = new System.Drawing.Size(1330, 560);
            this.tabPageHome.TabIndex = 0;
            this.tabPageHome.Text = "Home";
            // 
            // label32
            // 
            this.label32.AutoSize = true;
            this.label32.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label32.ForeColor = System.Drawing.Color.White;
            this.label32.Location = new System.Drawing.Point(497, 274);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(230, 24);
            this.label32.TabIndex = 33;
            this.label32.Text = "Kode Setting Kumbung 1 :";
            // 
            // lblSettingKumbung1
            // 
            this.lblSettingKumbung1.AutoSize = true;
            this.lblSettingKumbung1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSettingKumbung1.ForeColor = System.Drawing.Color.White;
            this.lblSettingKumbung1.Location = new System.Drawing.Point(733, 274);
            this.lblSettingKumbung1.Name = "lblSettingKumbung1";
            this.lblSettingKumbung1.Size = new System.Drawing.Size(70, 24);
            this.lblSettingKumbung1.TabIndex = 32;
            this.lblSettingKumbung1.Text = "label32";
            // 
            // lblMesseg
            // 
            this.lblMesseg.AutoSize = true;
            this.lblMesseg.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMesseg.ForeColor = System.Drawing.Color.White;
            this.lblMesseg.Location = new System.Drawing.Point(493, 113);
            this.lblMesseg.Name = "lblMesseg";
            this.lblMesseg.Size = new System.Drawing.Size(558, 45);
            this.lblMesseg.TabIndex = 31;
            this.lblMesseg.Text = "Aplikasi Sedang TIDAK Merekam Data";
            // 
            // groupBox6
            // 
            this.groupBox6.ForeColor = System.Drawing.Color.White;
            this.groupBox6.Location = new System.Drawing.Point(20, 113);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(424, 430);
            this.groupBox6.TabIndex = 30;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "groupBox6";
            // 
            // btnJalan
            // 
            this.btnJalan.BackColor = System.Drawing.Color.Lime;
            this.btnJalan.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnJalan.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnJalan.FlatAppearance.BorderSize = 0;
            this.btnJalan.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnJalan.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Yellow;
            this.btnJalan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnJalan.Font = new System.Drawing.Font("Segoe UI", 16F);
            this.btnJalan.ForeColor = System.Drawing.Color.Black;
            this.btnJalan.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnJalan.Location = new System.Drawing.Point(656, 171);
            this.btnJalan.Name = "btnJalan";
            this.btnJalan.Size = new System.Drawing.Size(119, 61);
            this.btnJalan.TabIndex = 28;
            this.btnJalan.Text = "Jalan";
            this.btnJalan.UseVisualStyleBackColor = false;
            this.btnJalan.Click += new System.EventHandler(this.btnJalan_Click);
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Segoe UI", 22F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.ForeColor = System.Drawing.Color.White;
            this.label22.Location = new System.Drawing.Point(13, 3);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(99, 41);
            this.label22.TabIndex = 27;
            this.label22.Text = "Home";
            // 
            // btnBerhenti
            // 
            this.btnBerhenti.BackColor = System.Drawing.Color.Red;
            this.btnBerhenti.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBerhenti.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnBerhenti.FlatAppearance.BorderSize = 0;
            this.btnBerhenti.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnBerhenti.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Yellow;
            this.btnBerhenti.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBerhenti.Font = new System.Drawing.Font("Segoe UI", 16F);
            this.btnBerhenti.ForeColor = System.Drawing.Color.White;
            this.btnBerhenti.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnBerhenti.Location = new System.Drawing.Point(501, 171);
            this.btnBerhenti.Name = "btnBerhenti";
            this.btnBerhenti.Size = new System.Drawing.Size(119, 61);
            this.btnBerhenti.TabIndex = 29;
            this.btnBerhenti.Text = "Berhenti";
            this.btnBerhenti.UseVisualStyleBackColor = false;
            this.btnBerhenti.Click += new System.EventHandler(this.btnBerhenti_Click);
            // 
            // tabPageGrafikRealTime
            // 
            this.tabPageGrafikRealTime.BackColor = System.Drawing.Color.Purple;
            this.tabPageGrafikRealTime.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabPageGrafikRealTime.Controls.Add(this.label21);
            this.tabPageGrafikRealTime.Controls.Add(this.label4);
            this.tabPageGrafikRealTime.Controls.Add(this.label1);
            this.tabPageGrafikRealTime.Controls.Add(this.zedGraphKelembapan);
            this.tabPageGrafikRealTime.Controls.Add(this.zedGraphTemperature);
            this.tabPageGrafikRealTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPageGrafikRealTime.Location = new System.Drawing.Point(4, 54);
            this.tabPageGrafikRealTime.Name = "tabPageGrafikRealTime";
            this.tabPageGrafikRealTime.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageGrafikRealTime.Size = new System.Drawing.Size(1330, 560);
            this.tabPageGrafikRealTime.TabIndex = 2;
            this.tabPageGrafikRealTime.Text = "Grafik Real Time";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Segoe UI", 22F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.ForeColor = System.Drawing.Color.White;
            this.label21.Location = new System.Drawing.Point(13, 3);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(231, 41);
            this.label21.TabIndex = 26;
            this.label21.Text = "Grafik Real Time";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(914, 62);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(162, 20);
            this.label4.TabIndex = 15;
            this.label4.Text = "Grafik Kelembapan";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(250, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(165, 20);
            this.label1.TabIndex = 14;
            this.label1.Text = "Grafik Temperature";
            // 
            // zedGraphKelembapan
            // 
            this.zedGraphKelembapan.Location = new System.Drawing.Point(669, 87);
            this.zedGraphKelembapan.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.zedGraphKelembapan.Name = "zedGraphKelembapan";
            this.zedGraphKelembapan.ScrollGrace = 0D;
            this.zedGraphKelembapan.ScrollMaxX = 0D;
            this.zedGraphKelembapan.ScrollMaxY = 0D;
            this.zedGraphKelembapan.ScrollMaxY2 = 0D;
            this.zedGraphKelembapan.ScrollMinX = 0D;
            this.zedGraphKelembapan.ScrollMinY = 0D;
            this.zedGraphKelembapan.ScrollMinY2 = 0D;
            this.zedGraphKelembapan.Size = new System.Drawing.Size(653, 463);
            this.zedGraphKelembapan.TabIndex = 1;
            // 
            // zedGraphTemperature
            // 
            this.zedGraphTemperature.Location = new System.Drawing.Point(6, 87);
            this.zedGraphTemperature.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.zedGraphTemperature.Name = "zedGraphTemperature";
            this.zedGraphTemperature.ScrollGrace = 0D;
            this.zedGraphTemperature.ScrollMaxX = 0D;
            this.zedGraphTemperature.ScrollMaxY = 0D;
            this.zedGraphTemperature.ScrollMaxY2 = 0D;
            this.zedGraphTemperature.ScrollMinX = 0D;
            this.zedGraphTemperature.ScrollMinY = 0D;
            this.zedGraphTemperature.ScrollMinY2 = 0D;
            this.zedGraphTemperature.Size = new System.Drawing.Size(653, 463);
            this.zedGraphTemperature.TabIndex = 0;
            // 
            // tabPageTemperature
            // 
            this.tabPageTemperature.BackColor = System.Drawing.Color.Purple;
            this.tabPageTemperature.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabPageTemperature.Controls.Add(this.label17);
            this.tabPageTemperature.Controls.Add(this.groupBox2);
            this.tabPageTemperature.Controls.Add(this.rvTemperature);
            this.tabPageTemperature.Location = new System.Drawing.Point(4, 54);
            this.tabPageTemperature.Name = "tabPageTemperature";
            this.tabPageTemperature.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageTemperature.Size = new System.Drawing.Size(1330, 560);
            this.tabPageTemperature.TabIndex = 5;
            this.tabPageTemperature.Text = "Temperature";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Segoe UI", 22F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.Color.White;
            this.label17.Location = new System.Drawing.Point(13, 3);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(300, 41);
            this.label17.TabIndex = 26;
            this.label17.Text = "Laporan Temperature";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.White;
            this.groupBox2.Controls.Add(this.btnCariTemperature);
            this.groupBox2.Controls.Add(this.dpSampaiTemperature);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.dpMulaiTemperature);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.Black;
            this.groupBox2.Location = new System.Drawing.Point(1034, 47);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(289, 385);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Form Cari :";
            // 
            // btnCariTemperature
            // 
            this.btnCariTemperature.BackColor = System.Drawing.Color.Lime;
            this.btnCariTemperature.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCariTemperature.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnCariTemperature.FlatAppearance.BorderSize = 0;
            this.btnCariTemperature.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnCariTemperature.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Yellow;
            this.btnCariTemperature.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCariTemperature.Font = new System.Drawing.Font("Segoe UI", 16F);
            this.btnCariTemperature.ForeColor = System.Drawing.Color.Black;
            this.btnCariTemperature.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnCariTemperature.Location = new System.Drawing.Point(190, 342);
            this.btnCariTemperature.Name = "btnCariTemperature";
            this.btnCariTemperature.Size = new System.Drawing.Size(93, 37);
            this.btnCariTemperature.TabIndex = 27;
            this.btnCariTemperature.Text = "Cari";
            this.btnCariTemperature.UseVisualStyleBackColor = false;
            this.btnCariTemperature.Click += new System.EventHandler(this.btnCariTemperature_Click);
            // 
            // dpSampaiTemperature
            // 
            this.dpSampaiTemperature.CustomFormat = "yyyy-MM-dd HH:mm:ss ";
            this.dpSampaiTemperature.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dpSampaiTemperature.Location = new System.Drawing.Point(9, 146);
            this.dpSampaiTemperature.Name = "dpSampaiTemperature";
            this.dpSampaiTemperature.Size = new System.Drawing.Size(274, 26);
            this.dpSampaiTemperature.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 122);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 20);
            this.label5.TabIndex = 2;
            this.label5.Text = "Sampai :";
            // 
            // dpMulaiTemperature
            // 
            this.dpMulaiTemperature.CustomFormat = "yyyy-MM-dd HH:mm:ss ";
            this.dpMulaiTemperature.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dpMulaiTemperature.Location = new System.Drawing.Point(9, 67);
            this.dpMulaiTemperature.Name = "dpMulaiTemperature";
            this.dpMulaiTemperature.Size = new System.Drawing.Size(274, 26);
            this.dpMulaiTemperature.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(9, 43);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 20);
            this.label6.TabIndex = 0;
            this.label6.Text = "Mulai :";
            // 
            // rvTemperature
            // 
            this.rvTemperature.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            reportDataSource5.Name = "DataSet1";
            reportDataSource5.Value = this.ProcTemperatureBindingSource;
            this.rvTemperature.LocalReport.DataSources.Add(reportDataSource5);
            this.rvTemperature.LocalReport.ReportEmbeddedResource = "RibbonDemo.ReportTemperature.rdlc";
            this.rvTemperature.Location = new System.Drawing.Point(20, 47);
            this.rvTemperature.Name = "rvTemperature";
            this.rvTemperature.Size = new System.Drawing.Size(1008, 496);
            this.rvTemperature.TabIndex = 6;
            // 
            // tabPageKelembapan
            // 
            this.tabPageKelembapan.BackColor = System.Drawing.Color.Purple;
            this.tabPageKelembapan.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabPageKelembapan.Controls.Add(this.label18);
            this.tabPageKelembapan.Controls.Add(this.groupBox4);
            this.tabPageKelembapan.Controls.Add(this.rvKelembapan);
            this.tabPageKelembapan.Location = new System.Drawing.Point(4, 54);
            this.tabPageKelembapan.Name = "tabPageKelembapan";
            this.tabPageKelembapan.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageKelembapan.Size = new System.Drawing.Size(1330, 560);
            this.tabPageKelembapan.TabIndex = 6;
            this.tabPageKelembapan.Text = "Kelembapan";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Segoe UI", 22F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.ForeColor = System.Drawing.Color.White;
            this.label18.Location = new System.Drawing.Point(13, 3);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(298, 41);
            this.label18.TabIndex = 29;
            this.label18.Text = "Laporan Kelembapan";
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.Color.White;
            this.groupBox4.Controls.Add(this.btnCariKelembapan);
            this.groupBox4.Controls.Add(this.dpSampaiKelembapan);
            this.groupBox4.Controls.Add(this.label19);
            this.groupBox4.Controls.Add(this.dpMulaiKelembapan);
            this.groupBox4.Controls.Add(this.label20);
            this.groupBox4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.ForeColor = System.Drawing.Color.Black;
            this.groupBox4.Location = new System.Drawing.Point(1034, 47);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(289, 385);
            this.groupBox4.TabIndex = 28;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Form Cari :";
            // 
            // btnCariKelembapan
            // 
            this.btnCariKelembapan.BackColor = System.Drawing.Color.Lime;
            this.btnCariKelembapan.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCariKelembapan.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnCariKelembapan.FlatAppearance.BorderSize = 0;
            this.btnCariKelembapan.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnCariKelembapan.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Yellow;
            this.btnCariKelembapan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCariKelembapan.Font = new System.Drawing.Font("Segoe UI", 16F);
            this.btnCariKelembapan.ForeColor = System.Drawing.Color.Black;
            this.btnCariKelembapan.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnCariKelembapan.Location = new System.Drawing.Point(190, 342);
            this.btnCariKelembapan.Name = "btnCariKelembapan";
            this.btnCariKelembapan.Size = new System.Drawing.Size(93, 37);
            this.btnCariKelembapan.TabIndex = 27;
            this.btnCariKelembapan.Text = "Cari";
            this.btnCariKelembapan.UseVisualStyleBackColor = false;
            this.btnCariKelembapan.Click += new System.EventHandler(this.btnCariKelembapan_Click);
            // 
            // dpSampaiKelembapan
            // 
            this.dpSampaiKelembapan.CustomFormat = "yyyy-MM-dd HH:mm:ss ";
            this.dpSampaiKelembapan.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dpSampaiKelembapan.Location = new System.Drawing.Point(9, 146);
            this.dpSampaiKelembapan.Name = "dpSampaiKelembapan";
            this.dpSampaiKelembapan.Size = new System.Drawing.Size(274, 26);
            this.dpSampaiKelembapan.TabIndex = 3;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(9, 122);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(71, 20);
            this.label19.TabIndex = 2;
            this.label19.Text = "Sampai :";
            // 
            // dpMulaiKelembapan
            // 
            this.dpMulaiKelembapan.CustomFormat = "yyyy-MM-dd HH:mm:ss ";
            this.dpMulaiKelembapan.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dpMulaiKelembapan.Location = new System.Drawing.Point(9, 67);
            this.dpMulaiKelembapan.Name = "dpMulaiKelembapan";
            this.dpMulaiKelembapan.Size = new System.Drawing.Size(274, 26);
            this.dpMulaiKelembapan.TabIndex = 1;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(9, 43);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(54, 20);
            this.label20.TabIndex = 0;
            this.label20.Text = "Mulai :";
            // 
            // rvKelembapan
            // 
            this.rvKelembapan.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            reportDataSource6.Name = "DataSet1";
            reportDataSource6.Value = this.ProcKelembapanBindingSource;
            this.rvKelembapan.LocalReport.DataSources.Add(reportDataSource6);
            this.rvKelembapan.LocalReport.ReportEmbeddedResource = "RibbonDemo.ReportKelembapan.rdlc";
            this.rvKelembapan.Location = new System.Drawing.Point(20, 47);
            this.rvKelembapan.Name = "rvKelembapan";
            this.rvKelembapan.Size = new System.Drawing.Size(1008, 496);
            this.rvKelembapan.TabIndex = 27;
            // 
            // tabPageKumbung
            // 
            this.tabPageKumbung.BackColor = System.Drawing.Color.Purple;
            this.tabPageKumbung.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabPageKumbung.Controls.Add(this.gvKumbung);
            this.tabPageKumbung.Controls.Add(this.btnEditKumbung);
            this.tabPageKumbung.Controls.Add(this.btnHapusKumbung);
            this.tabPageKumbung.Controls.Add(this.groupBox5);
            this.tabPageKumbung.Controls.Add(this.label24);
            this.tabPageKumbung.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPageKumbung.Location = new System.Drawing.Point(4, 54);
            this.tabPageKumbung.Name = "tabPageKumbung";
            this.tabPageKumbung.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageKumbung.Size = new System.Drawing.Size(1330, 560);
            this.tabPageKumbung.TabIndex = 7;
            this.tabPageKumbung.Text = "Kumbung";
            // 
            // gvKumbung
            // 
            this.gvKumbung.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle13.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle13.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle13.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle13.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gvKumbung.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle13;
            this.gvKumbung.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvKumbung.GridColor = System.Drawing.Color.Purple;
            this.gvKumbung.Location = new System.Drawing.Point(423, 83);
            this.gvKumbung.Name = "gvKumbung";
            this.gvKumbung.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle14.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle14.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gvKumbung.RowHeadersDefaultCellStyle = dataGridViewCellStyle14;
            this.gvKumbung.RowHeadersWidth = 50;
            this.gvKumbung.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gvKumbung.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.Black;
            this.gvKumbung.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.White;
            this.gvKumbung.RowTemplate.Height = 30;
            this.gvKumbung.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.gvKumbung.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gvKumbung.Size = new System.Drawing.Size(888, 458);
            this.gvKumbung.TabIndex = 32;
            // 
            // btnEditKumbung
            // 
            this.btnEditKumbung.BackColor = System.Drawing.Color.Lime;
            this.btnEditKumbung.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEditKumbung.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnEditKumbung.FlatAppearance.BorderSize = 0;
            this.btnEditKumbung.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnEditKumbung.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Yellow;
            this.btnEditKumbung.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditKumbung.Font = new System.Drawing.Font("Segoe UI", 16F);
            this.btnEditKumbung.ForeColor = System.Drawing.Color.Black;
            this.btnEditKumbung.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnEditKumbung.Location = new System.Drawing.Point(1111, 40);
            this.btnEditKumbung.Name = "btnEditKumbung";
            this.btnEditKumbung.Size = new System.Drawing.Size(93, 37);
            this.btnEditKumbung.TabIndex = 31;
            this.btnEditKumbung.Text = "Edit";
            this.btnEditKumbung.UseVisualStyleBackColor = false;
            this.btnEditKumbung.Click += new System.EventHandler(this.btnEditKumbung_Click);
            // 
            // btnHapusKumbung
            // 
            this.btnHapusKumbung.BackColor = System.Drawing.Color.Lime;
            this.btnHapusKumbung.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHapusKumbung.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnHapusKumbung.FlatAppearance.BorderSize = 0;
            this.btnHapusKumbung.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnHapusKumbung.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Yellow;
            this.btnHapusKumbung.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHapusKumbung.Font = new System.Drawing.Font("Segoe UI", 16F);
            this.btnHapusKumbung.ForeColor = System.Drawing.Color.Black;
            this.btnHapusKumbung.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnHapusKumbung.Location = new System.Drawing.Point(1218, 40);
            this.btnHapusKumbung.Name = "btnHapusKumbung";
            this.btnHapusKumbung.Size = new System.Drawing.Size(93, 37);
            this.btnHapusKumbung.TabIndex = 30;
            this.btnHapusKumbung.Text = "Hapus";
            this.btnHapusKumbung.UseVisualStyleBackColor = false;
            this.btnHapusKumbung.Click += new System.EventHandler(this.btnDeleteKumbung_Click);
            // 
            // groupBox5
            // 
            this.groupBox5.BackColor = System.Drawing.Color.White;
            this.groupBox5.Controls.Add(this.btnBatalKumbung);
            this.groupBox5.Controls.Add(this.txtKapasitas);
            this.groupBox5.Controls.Add(this.txtNamaKumbung);
            this.groupBox5.Controls.Add(this.label26);
            this.groupBox5.Controls.Add(this.label27);
            this.groupBox5.Controls.Add(this.btnSimpanKumbung);
            this.groupBox5.Controls.Add(this.txtKodeKumbung);
            this.groupBox5.Controls.Add(this.label28);
            this.groupBox5.Controls.Add(this.btnUpdateKumbung);
            this.groupBox5.ForeColor = System.Drawing.Color.Black;
            this.groupBox5.Location = new System.Drawing.Point(16, 83);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(401, 458);
            this.groupBox5.TabIndex = 28;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Form Kumbung :";
            // 
            // btnBatalKumbung
            // 
            this.btnBatalKumbung.BackColor = System.Drawing.Color.Lime;
            this.btnBatalKumbung.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBatalKumbung.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnBatalKumbung.FlatAppearance.BorderSize = 0;
            this.btnBatalKumbung.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnBatalKumbung.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Yellow;
            this.btnBatalKumbung.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBatalKumbung.Font = new System.Drawing.Font("Segoe UI", 16F);
            this.btnBatalKumbung.ForeColor = System.Drawing.Color.Black;
            this.btnBatalKumbung.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnBatalKumbung.Location = new System.Drawing.Point(270, 395);
            this.btnBatalKumbung.Name = "btnBatalKumbung";
            this.btnBatalKumbung.Size = new System.Drawing.Size(93, 37);
            this.btnBatalKumbung.TabIndex = 19;
            this.btnBatalKumbung.Text = "Batal";
            this.btnBatalKumbung.UseVisualStyleBackColor = false;
            this.btnBatalKumbung.Click += new System.EventHandler(this.btnBatalKumbung_Click);
            // 
            // txtKapasitas
            // 
            this.txtKapasitas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtKapasitas.ForeColor = System.Drawing.Color.Black;
            this.txtKapasitas.Location = new System.Drawing.Point(37, 220);
            this.txtKapasitas.Name = "txtKapasitas";
            this.txtKapasitas.Size = new System.Drawing.Size(326, 26);
            this.txtKapasitas.TabIndex = 16;
            // 
            // txtNamaKumbung
            // 
            this.txtNamaKumbung.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNamaKumbung.ForeColor = System.Drawing.Color.Black;
            this.txtNamaKumbung.Location = new System.Drawing.Point(37, 148);
            this.txtNamaKumbung.Name = "txtNamaKumbung";
            this.txtNamaKumbung.Size = new System.Drawing.Size(326, 26);
            this.txtNamaKumbung.TabIndex = 14;
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label26.ForeColor = System.Drawing.Color.Black;
            this.label26.Location = new System.Drawing.Point(33, 197);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(87, 20);
            this.label26.TabIndex = 15;
            this.label26.Text = "Kapasitas :";
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label27.ForeColor = System.Drawing.Color.Black;
            this.label27.Location = new System.Drawing.Point(33, 125);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(131, 20);
            this.label27.TabIndex = 13;
            this.label27.Text = "Nama Kumbung :";
            // 
            // btnSimpanKumbung
            // 
            this.btnSimpanKumbung.BackColor = System.Drawing.Color.Lime;
            this.btnSimpanKumbung.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSimpanKumbung.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnSimpanKumbung.FlatAppearance.BorderSize = 0;
            this.btnSimpanKumbung.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnSimpanKumbung.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Yellow;
            this.btnSimpanKumbung.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSimpanKumbung.Font = new System.Drawing.Font("Segoe UI", 16F);
            this.btnSimpanKumbung.ForeColor = System.Drawing.Color.Black;
            this.btnSimpanKumbung.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnSimpanKumbung.Location = new System.Drawing.Point(37, 395);
            this.btnSimpanKumbung.Name = "btnSimpanKumbung";
            this.btnSimpanKumbung.Size = new System.Drawing.Size(93, 37);
            this.btnSimpanKumbung.TabIndex = 12;
            this.btnSimpanKumbung.Text = "Simpan";
            this.btnSimpanKumbung.UseVisualStyleBackColor = false;
            this.btnSimpanKumbung.Click += new System.EventHandler(this.btnSimpanKumbung_Click);
            // 
            // txtKodeKumbung
            // 
            this.txtKodeKumbung.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtKodeKumbung.ForeColor = System.Drawing.Color.Black;
            this.txtKodeKumbung.Location = new System.Drawing.Point(37, 76);
            this.txtKodeKumbung.Name = "txtKodeKumbung";
            this.txtKodeKumbung.Size = new System.Drawing.Size(326, 26);
            this.txtKodeKumbung.TabIndex = 1;
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label28.ForeColor = System.Drawing.Color.Black;
            this.label28.Location = new System.Drawing.Point(33, 53);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(126, 20);
            this.label28.TabIndex = 0;
            this.label28.Text = "Kode Kumbung :";
            // 
            // btnUpdateKumbung
            // 
            this.btnUpdateKumbung.BackColor = System.Drawing.Color.Lime;
            this.btnUpdateKumbung.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUpdateKumbung.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnUpdateKumbung.FlatAppearance.BorderSize = 0;
            this.btnUpdateKumbung.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnUpdateKumbung.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Yellow;
            this.btnUpdateKumbung.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdateKumbung.Font = new System.Drawing.Font("Segoe UI", 16F);
            this.btnUpdateKumbung.ForeColor = System.Drawing.Color.Black;
            this.btnUpdateKumbung.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnUpdateKumbung.Location = new System.Drawing.Point(37, 395);
            this.btnUpdateKumbung.Name = "btnUpdateKumbung";
            this.btnUpdateKumbung.Size = new System.Drawing.Size(93, 37);
            this.btnUpdateKumbung.TabIndex = 20;
            this.btnUpdateKumbung.Text = "Update";
            this.btnUpdateKumbung.UseVisualStyleBackColor = false;
            this.btnUpdateKumbung.Click += new System.EventHandler(this.btnUpdateKumbung_Click);
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Font = new System.Drawing.Font("Segoe UI", 22F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label24.ForeColor = System.Drawing.Color.White;
            this.label24.Location = new System.Drawing.Point(13, 3);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(148, 41);
            this.label24.TabIndex = 27;
            this.label24.Text = "Kumbung";
            // 
            // tabPageSetting
            // 
            this.tabPageSetting.BackColor = System.Drawing.Color.Purple;
            this.tabPageSetting.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabPageSetting.Controls.Add(this.gvSetting);
            this.tabPageSetting.Controls.Add(this.btnDeleteSetting);
            this.tabPageSetting.Controls.Add(this.btnEditSetting);
            this.tabPageSetting.Controls.Add(this.label11);
            this.tabPageSetting.Controls.Add(this.groupBox3);
            this.tabPageSetting.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPageSetting.ForeColor = System.Drawing.Color.Black;
            this.tabPageSetting.Location = new System.Drawing.Point(4, 54);
            this.tabPageSetting.Name = "tabPageSetting";
            this.tabPageSetting.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageSetting.Size = new System.Drawing.Size(1330, 560);
            this.tabPageSetting.TabIndex = 1;
            this.tabPageSetting.Text = "Setting";
            // 
            // gvSetting
            // 
            this.gvSetting.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle15.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle15.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle15.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle15.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle15.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gvSetting.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle15;
            this.gvSetting.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvSetting.GridColor = System.Drawing.Color.Purple;
            this.gvSetting.Location = new System.Drawing.Point(423, 83);
            this.gvSetting.Name = "gvSetting";
            this.gvSetting.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle16.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle16.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle16.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle16.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle16.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle16.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gvSetting.RowHeadersDefaultCellStyle = dataGridViewCellStyle16;
            this.gvSetting.RowHeadersWidth = 50;
            this.gvSetting.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.gvSetting.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gvSetting.RowTemplate.DefaultCellStyle.Format = "G";
            this.gvSetting.RowTemplate.DefaultCellStyle.NullValue = null;
            this.gvSetting.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.Black;
            this.gvSetting.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.White;
            this.gvSetting.RowTemplate.Height = 30;
            this.gvSetting.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.gvSetting.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gvSetting.Size = new System.Drawing.Size(888, 458);
            this.gvSetting.TabIndex = 34;
            // 
            // btnDeleteSetting
            // 
            this.btnDeleteSetting.BackColor = System.Drawing.Color.Lime;
            this.btnDeleteSetting.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDeleteSetting.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnDeleteSetting.FlatAppearance.BorderSize = 0;
            this.btnDeleteSetting.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnDeleteSetting.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Yellow;
            this.btnDeleteSetting.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteSetting.Font = new System.Drawing.Font("Segoe UI", 16F);
            this.btnDeleteSetting.ForeColor = System.Drawing.Color.Black;
            this.btnDeleteSetting.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnDeleteSetting.Location = new System.Drawing.Point(1218, 40);
            this.btnDeleteSetting.Name = "btnDeleteSetting";
            this.btnDeleteSetting.Size = new System.Drawing.Size(93, 37);
            this.btnDeleteSetting.TabIndex = 33;
            this.btnDeleteSetting.Text = "Hapus";
            this.btnDeleteSetting.UseVisualStyleBackColor = false;
            this.btnDeleteSetting.Click += new System.EventHandler(this.btnDeleteSetting_Click);
            // 
            // btnEditSetting
            // 
            this.btnEditSetting.BackColor = System.Drawing.Color.Lime;
            this.btnEditSetting.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEditSetting.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnEditSetting.FlatAppearance.BorderSize = 0;
            this.btnEditSetting.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnEditSetting.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Yellow;
            this.btnEditSetting.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditSetting.Font = new System.Drawing.Font("Segoe UI", 16F);
            this.btnEditSetting.ForeColor = System.Drawing.Color.Black;
            this.btnEditSetting.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnEditSetting.Location = new System.Drawing.Point(1111, 40);
            this.btnEditSetting.Name = "btnEditSetting";
            this.btnEditSetting.Size = new System.Drawing.Size(93, 37);
            this.btnEditSetting.TabIndex = 32;
            this.btnEditSetting.Text = "Edit";
            this.btnEditSetting.UseVisualStyleBackColor = false;
            this.btnEditSetting.Click += new System.EventHandler(this.btnEditSetting_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 22F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(13, 3);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(112, 41);
            this.label11.TabIndex = 25;
            this.label11.Text = "Setting";
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.White;
            this.groupBox3.Controls.Add(this.cmbKodeKumbung);
            this.groupBox3.Controls.Add(this.rbTidakAktif);
            this.groupBox3.Controls.Add(this.rbAktif);
            this.groupBox3.Controls.Add(this.btnSimpanSetting);
            this.groupBox3.Controls.Add(this.label30);
            this.groupBox3.Controls.Add(this.label31);
            this.groupBox3.Controls.Add(this.txtSettingKelembapanMax);
            this.groupBox3.Controls.Add(this.txtSettingKelembapanMin);
            this.groupBox3.Controls.Add(this.label29);
            this.groupBox3.Controls.Add(this.label25);
            this.groupBox3.Controls.Add(this.txtSettingTemperatureMax);
            this.groupBox3.Controls.Add(this.txtKeterangan);
            this.groupBox3.Controls.Add(this.label23);
            this.groupBox3.Controls.Add(this.btnBatalSetting);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Controls.Add(this.txtSettingTemperatureMin);
            this.groupBox3.Controls.Add(this.label13);
            this.groupBox3.Controls.Add(this.label14);
            this.groupBox3.Controls.Add(this.txtKodeSetting);
            this.groupBox3.Controls.Add(this.label16);
            this.groupBox3.Controls.Add(this.btnUpdateSetting);
            this.groupBox3.ForeColor = System.Drawing.Color.Black;
            this.groupBox3.Location = new System.Drawing.Point(16, 83);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(401, 458);
            this.groupBox3.TabIndex = 23;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Form Setting :";
            // 
            // cmbKodeKumbung
            // 
            this.cmbKodeKumbung.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbKodeKumbung.FormattingEnabled = true;
            this.cmbKodeKumbung.Items.AddRange(new object[] {
            "Kumbung1",
            "Kumbung2"});
            this.cmbKodeKumbung.Location = new System.Drawing.Point(39, 114);
            this.cmbKodeKumbung.Name = "cmbKodeKumbung";
            this.cmbKodeKumbung.Size = new System.Drawing.Size(324, 28);
            this.cmbKodeKumbung.TabIndex = 36;
            // 
            // rbTidakAktif
            // 
            this.rbTidakAktif.AutoSize = true;
            this.rbTidakAktif.Location = new System.Drawing.Point(255, 367);
            this.rbTidakAktif.Name = "rbTidakAktif";
            this.rbTidakAktif.Size = new System.Drawing.Size(101, 24);
            this.rbTidakAktif.TabIndex = 35;
            this.rbTidakAktif.TabStop = true;
            this.rbTidakAktif.Text = "Tidak Aktif";
            this.rbTidakAktif.UseVisualStyleBackColor = true;
            // 
            // rbAktif
            // 
            this.rbAktif.AutoSize = true;
            this.rbAktif.Location = new System.Drawing.Point(39, 367);
            this.rbAktif.Name = "rbAktif";
            this.rbAktif.Size = new System.Drawing.Size(59, 24);
            this.rbAktif.TabIndex = 34;
            this.rbAktif.TabStop = true;
            this.rbAktif.Text = "Aktif";
            this.rbAktif.UseVisualStyleBackColor = true;
            // 
            // btnSimpanSetting
            // 
            this.btnSimpanSetting.BackColor = System.Drawing.Color.Lime;
            this.btnSimpanSetting.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSimpanSetting.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnSimpanSetting.FlatAppearance.BorderSize = 0;
            this.btnSimpanSetting.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnSimpanSetting.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Yellow;
            this.btnSimpanSetting.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSimpanSetting.Font = new System.Drawing.Font("Segoe UI", 16F);
            this.btnSimpanSetting.ForeColor = System.Drawing.Color.Black;
            this.btnSimpanSetting.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnSimpanSetting.Location = new System.Drawing.Point(92, 415);
            this.btnSimpanSetting.Name = "btnSimpanSetting";
            this.btnSimpanSetting.Size = new System.Drawing.Size(93, 37);
            this.btnSimpanSetting.TabIndex = 12;
            this.btnSimpanSetting.Text = "Simpan";
            this.btnSimpanSetting.UseVisualStyleBackColor = false;
            this.btnSimpanSetting.Click += new System.EventHandler(this.btnSimpanSetting_Click);
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.ForeColor = System.Drawing.Color.Black;
            this.label30.Location = new System.Drawing.Point(35, 255);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(46, 20);
            this.label30.TabIndex = 30;
            this.label30.Text = "MIN :";
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.ForeColor = System.Drawing.Color.Black;
            this.label31.Location = new System.Drawing.Point(207, 268);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(52, 20);
            this.label31.TabIndex = 29;
            this.label31.Text = "MAX :";
            // 
            // txtSettingKelembapanMax
            // 
            this.txtSettingKelembapanMax.ForeColor = System.Drawing.Color.Black;
            this.txtSettingKelembapanMax.Location = new System.Drawing.Point(265, 265);
            this.txtSettingKelembapanMax.Name = "txtSettingKelembapanMax";
            this.txtSettingKelembapanMax.Size = new System.Drawing.Size(98, 26);
            this.txtSettingKelembapanMax.TabIndex = 28;
            // 
            // txtSettingKelembapanMin
            // 
            this.txtSettingKelembapanMin.ForeColor = System.Drawing.Color.Black;
            this.txtSettingKelembapanMin.Location = new System.Drawing.Point(87, 252);
            this.txtSettingKelembapanMin.Name = "txtSettingKelembapanMin";
            this.txtSettingKelembapanMin.Size = new System.Drawing.Size(98, 26);
            this.txtSettingKelembapanMin.TabIndex = 27;
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.ForeColor = System.Drawing.Color.Black;
            this.label29.Location = new System.Drawing.Point(35, 186);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(46, 20);
            this.label29.TabIndex = 26;
            this.label29.Text = "MIN :";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.ForeColor = System.Drawing.Color.Black;
            this.label25.Location = new System.Drawing.Point(207, 199);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(52, 20);
            this.label25.TabIndex = 25;
            this.label25.Text = "MAX :";
            // 
            // txtSettingTemperatureMax
            // 
            this.txtSettingTemperatureMax.ForeColor = System.Drawing.Color.Black;
            this.txtSettingTemperatureMax.Location = new System.Drawing.Point(265, 196);
            this.txtSettingTemperatureMax.Name = "txtSettingTemperatureMax";
            this.txtSettingTemperatureMax.Size = new System.Drawing.Size(98, 26);
            this.txtSettingTemperatureMax.TabIndex = 24;
            // 
            // txtKeterangan
            // 
            this.txtKeterangan.ForeColor = System.Drawing.Color.Black;
            this.txtKeterangan.Location = new System.Drawing.Point(37, 321);
            this.txtKeterangan.Multiline = true;
            this.txtKeterangan.Name = "txtKeterangan";
            this.txtKeterangan.Size = new System.Drawing.Size(326, 40);
            this.txtKeterangan.TabIndex = 22;
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.ForeColor = System.Drawing.Color.Black;
            this.label23.Location = new System.Drawing.Point(35, 298);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(100, 20);
            this.label23.TabIndex = 21;
            this.label23.Text = "Keterangan :";
            // 
            // btnBatalSetting
            // 
            this.btnBatalSetting.BackColor = System.Drawing.Color.Lime;
            this.btnBatalSetting.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBatalSetting.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnBatalSetting.FlatAppearance.BorderSize = 0;
            this.btnBatalSetting.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnBatalSetting.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Yellow;
            this.btnBatalSetting.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBatalSetting.Font = new System.Drawing.Font("Segoe UI", 16F);
            this.btnBatalSetting.ForeColor = System.Drawing.Color.Black;
            this.btnBatalSetting.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnBatalSetting.Location = new System.Drawing.Point(270, 415);
            this.btnBatalSetting.Name = "btnBatalSetting";
            this.btnBatalSetting.Size = new System.Drawing.Size(93, 37);
            this.btnBatalSetting.TabIndex = 19;
            this.btnBatalSetting.Text = "Batal";
            this.btnBatalSetting.UseVisualStyleBackColor = false;
            this.btnBatalSetting.Click += new System.EventHandler(this.btnBatalSetting_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.ForeColor = System.Drawing.Color.Black;
            this.label12.Location = new System.Drawing.Point(33, 229);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(161, 20);
            this.label12.TabIndex = 17;
            this.label12.Text = "Setting Kelembapan :";
            // 
            // txtSettingTemperatureMin
            // 
            this.txtSettingTemperatureMin.ForeColor = System.Drawing.Color.Black;
            this.txtSettingTemperatureMin.Location = new System.Drawing.Point(87, 183);
            this.txtSettingTemperatureMin.Name = "txtSettingTemperatureMin";
            this.txtSettingTemperatureMin.Size = new System.Drawing.Size(98, 26);
            this.txtSettingTemperatureMin.TabIndex = 16;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.ForeColor = System.Drawing.Color.Black;
            this.label13.Location = new System.Drawing.Point(35, 160);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(163, 20);
            this.label13.TabIndex = 15;
            this.label13.Text = "Setting Temperature :";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.ForeColor = System.Drawing.Color.Black;
            this.label14.Location = new System.Drawing.Point(35, 91);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(126, 20);
            this.label14.TabIndex = 13;
            this.label14.Text = "Kode Kumbung :";
            // 
            // txtKodeSetting
            // 
            this.txtKodeSetting.Enabled = false;
            this.txtKodeSetting.ForeColor = System.Drawing.Color.Black;
            this.txtKodeSetting.Location = new System.Drawing.Point(37, 45);
            this.txtKodeSetting.Name = "txtKodeSetting";
            this.txtKodeSetting.Size = new System.Drawing.Size(326, 26);
            this.txtKodeSetting.TabIndex = 1;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.ForeColor = System.Drawing.Color.Black;
            this.label16.Location = new System.Drawing.Point(33, 22);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(109, 20);
            this.label16.TabIndex = 0;
            this.label16.Text = "Kode Setting :";
            // 
            // btnUpdateSetting
            // 
            this.btnUpdateSetting.BackColor = System.Drawing.Color.Lime;
            this.btnUpdateSetting.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUpdateSetting.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnUpdateSetting.FlatAppearance.BorderSize = 0;
            this.btnUpdateSetting.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnUpdateSetting.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Yellow;
            this.btnUpdateSetting.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdateSetting.Font = new System.Drawing.Font("Segoe UI", 16F);
            this.btnUpdateSetting.ForeColor = System.Drawing.Color.Black;
            this.btnUpdateSetting.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnUpdateSetting.Location = new System.Drawing.Point(37, 415);
            this.btnUpdateSetting.Name = "btnUpdateSetting";
            this.btnUpdateSetting.Size = new System.Drawing.Size(93, 37);
            this.btnUpdateSetting.TabIndex = 31;
            this.btnUpdateSetting.Text = "Update";
            this.btnUpdateSetting.UseVisualStyleBackColor = false;
            this.btnUpdateSetting.Click += new System.EventHandler(this.btnUpdateSetting_Click);
            // 
            // tabPageUsers
            // 
            this.tabPageUsers.BackColor = System.Drawing.Color.Purple;
            this.tabPageUsers.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabPageUsers.Controls.Add(this.label15);
            this.tabPageUsers.Controls.Add(this.btnEditUser);
            this.tabPageUsers.Controls.Add(this.btnHapusUser);
            this.tabPageUsers.Controls.Add(this.gvUser);
            this.tabPageUsers.Controls.Add(this.groupBox1);
            this.tabPageUsers.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPageUsers.Location = new System.Drawing.Point(4, 54);
            this.tabPageUsers.Name = "tabPageUsers";
            this.tabPageUsers.Size = new System.Drawing.Size(1330, 560);
            this.tabPageUsers.TabIndex = 4;
            this.tabPageUsers.Text = "User";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Segoe UI", 22F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.White;
            this.label15.Location = new System.Drawing.Point(13, 3);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(78, 41);
            this.label15.TabIndex = 22;
            this.label15.Text = "User";
            // 
            // btnEditUser
            // 
            this.btnEditUser.BackColor = System.Drawing.Color.Lime;
            this.btnEditUser.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEditUser.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnEditUser.FlatAppearance.BorderSize = 0;
            this.btnEditUser.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnEditUser.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Yellow;
            this.btnEditUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditUser.Font = new System.Drawing.Font("Segoe UI", 16F);
            this.btnEditUser.ForeColor = System.Drawing.Color.Black;
            this.btnEditUser.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnEditUser.Location = new System.Drawing.Point(1110, 40);
            this.btnEditUser.Name = "btnEditUser";
            this.btnEditUser.Size = new System.Drawing.Size(93, 37);
            this.btnEditUser.TabIndex = 21;
            this.btnEditUser.Text = "Edit";
            this.btnEditUser.UseVisualStyleBackColor = false;
            this.btnEditUser.Click += new System.EventHandler(this.btnEditUser_Click);
            // 
            // btnHapusUser
            // 
            this.btnHapusUser.BackColor = System.Drawing.Color.Lime;
            this.btnHapusUser.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHapusUser.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnHapusUser.FlatAppearance.BorderSize = 0;
            this.btnHapusUser.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnHapusUser.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Yellow;
            this.btnHapusUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHapusUser.Font = new System.Drawing.Font("Segoe UI", 16F);
            this.btnHapusUser.ForeColor = System.Drawing.Color.Black;
            this.btnHapusUser.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnHapusUser.Location = new System.Drawing.Point(1218, 40);
            this.btnHapusUser.Name = "btnHapusUser";
            this.btnHapusUser.Size = new System.Drawing.Size(93, 37);
            this.btnHapusUser.TabIndex = 20;
            this.btnHapusUser.Text = "Hapus";
            this.btnHapusUser.UseVisualStyleBackColor = false;
            this.btnHapusUser.Click += new System.EventHandler(this.btnHapusUser_Click);
            // 
            // gvUser
            // 
            this.gvUser.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle17.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle17.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle17.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle17.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle17.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle17.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gvUser.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle17;
            this.gvUser.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvUser.GridColor = System.Drawing.Color.Purple;
            this.gvUser.Location = new System.Drawing.Point(423, 83);
            this.gvUser.Name = "gvUser";
            this.gvUser.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle18.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle18.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle18.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle18.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle18.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle18.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gvUser.RowHeadersDefaultCellStyle = dataGridViewCellStyle18;
            this.gvUser.RowHeadersWidth = 50;
            this.gvUser.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.gvUser.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gvUser.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.Black;
            this.gvUser.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.White;
            this.gvUser.RowTemplate.Height = 30;
            this.gvUser.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.gvUser.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gvUser.Size = new System.Drawing.Size(888, 458);
            this.gvUser.TabIndex = 3;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.rbUser);
            this.groupBox1.Controls.Add(this.rbAdministrator);
            this.groupBox1.Controls.Add(this.btnBatalUser);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.txtNamaLengkap);
            this.groupBox1.Controls.Add(this.txtPassword);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.btnSimpanUser);
            this.groupBox1.Controls.Add(this.txtUserName);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.btnUpdateUser);
            this.groupBox1.ForeColor = System.Drawing.Color.Black;
            this.groupBox1.Location = new System.Drawing.Point(16, 83);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(401, 458);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Form User :";
            // 
            // rbUser
            // 
            this.rbUser.AutoSize = true;
            this.rbUser.Location = new System.Drawing.Point(211, 292);
            this.rbUser.Name = "rbUser";
            this.rbUser.Size = new System.Drawing.Size(61, 24);
            this.rbUser.TabIndex = 22;
            this.rbUser.TabStop = true;
            this.rbUser.Text = "User";
            this.rbUser.UseVisualStyleBackColor = true;
            // 
            // rbAdministrator
            // 
            this.rbAdministrator.AutoSize = true;
            this.rbAdministrator.Location = new System.Drawing.Point(37, 292);
            this.rbAdministrator.Name = "rbAdministrator";
            this.rbAdministrator.Size = new System.Drawing.Size(121, 24);
            this.rbAdministrator.TabIndex = 21;
            this.rbAdministrator.TabStop = true;
            this.rbAdministrator.Text = "Administrator";
            this.rbAdministrator.UseVisualStyleBackColor = true;
            // 
            // btnBatalUser
            // 
            this.btnBatalUser.BackColor = System.Drawing.Color.Lime;
            this.btnBatalUser.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBatalUser.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnBatalUser.FlatAppearance.BorderSize = 0;
            this.btnBatalUser.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnBatalUser.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Yellow;
            this.btnBatalUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBatalUser.Font = new System.Drawing.Font("Segoe UI", 16F);
            this.btnBatalUser.ForeColor = System.Drawing.Color.Black;
            this.btnBatalUser.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnBatalUser.Location = new System.Drawing.Point(270, 395);
            this.btnBatalUser.Name = "btnBatalUser";
            this.btnBatalUser.Size = new System.Drawing.Size(93, 37);
            this.btnBatalUser.TabIndex = 19;
            this.btnBatalUser.Text = "Batal";
            this.btnBatalUser.UseVisualStyleBackColor = false;
            this.btnBatalUser.Click += new System.EventHandler(this.btnBatalUser_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(33, 269);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(54, 20);
            this.label10.TabIndex = 17;
            this.label10.Text = "Level :";
            // 
            // txtNamaLengkap
            // 
            this.txtNamaLengkap.ForeColor = System.Drawing.Color.Black;
            this.txtNamaLengkap.Location = new System.Drawing.Point(37, 220);
            this.txtNamaLengkap.Name = "txtNamaLengkap";
            this.txtNamaLengkap.Size = new System.Drawing.Size(326, 26);
            this.txtNamaLengkap.TabIndex = 16;
            // 
            // txtPassword
            // 
            this.txtPassword.ForeColor = System.Drawing.Color.Black;
            this.txtPassword.Location = new System.Drawing.Point(37, 148);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(326, 26);
            this.txtPassword.TabIndex = 14;
            this.txtPassword.UseSystemPasswordChar = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(33, 197);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(125, 20);
            this.label9.TabIndex = 15;
            this.label9.Text = "Nama Lengkap :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(33, 125);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(86, 20);
            this.label8.TabIndex = 13;
            this.label8.Text = "Password :";
            // 
            // btnSimpanUser
            // 
            this.btnSimpanUser.BackColor = System.Drawing.Color.Lime;
            this.btnSimpanUser.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSimpanUser.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnSimpanUser.FlatAppearance.BorderSize = 0;
            this.btnSimpanUser.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnSimpanUser.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Yellow;
            this.btnSimpanUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSimpanUser.Font = new System.Drawing.Font("Segoe UI", 16F);
            this.btnSimpanUser.ForeColor = System.Drawing.Color.Black;
            this.btnSimpanUser.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnSimpanUser.Location = new System.Drawing.Point(37, 395);
            this.btnSimpanUser.Name = "btnSimpanUser";
            this.btnSimpanUser.Size = new System.Drawing.Size(93, 37);
            this.btnSimpanUser.TabIndex = 12;
            this.btnSimpanUser.Text = "Simpan";
            this.btnSimpanUser.UseVisualStyleBackColor = false;
            this.btnSimpanUser.Click += new System.EventHandler(this.btnSimpanUser_Click);
            // 
            // txtUserName
            // 
            this.txtUserName.ForeColor = System.Drawing.Color.Black;
            this.txtUserName.Location = new System.Drawing.Point(37, 76);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(326, 26);
            this.txtUserName.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(33, 53);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(97, 20);
            this.label7.TabIndex = 0;
            this.label7.Text = "User Name :";
            // 
            // btnUpdateUser
            // 
            this.btnUpdateUser.BackColor = System.Drawing.Color.Lime;
            this.btnUpdateUser.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUpdateUser.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnUpdateUser.FlatAppearance.BorderSize = 0;
            this.btnUpdateUser.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnUpdateUser.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Yellow;
            this.btnUpdateUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdateUser.Font = new System.Drawing.Font("Segoe UI", 16F);
            this.btnUpdateUser.ForeColor = System.Drawing.Color.Black;
            this.btnUpdateUser.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnUpdateUser.Location = new System.Drawing.Point(37, 395);
            this.btnUpdateUser.Name = "btnUpdateUser";
            this.btnUpdateUser.Size = new System.Drawing.Size(93, 37);
            this.btnUpdateUser.TabIndex = 20;
            this.btnUpdateUser.Text = "Update";
            this.btnUpdateUser.UseVisualStyleBackColor = false;
            this.btnUpdateUser.Click += new System.EventHandler(this.btnUpdateUser_Click);
            // 
            // lblNamaPT
            // 
            this.lblNamaPT.AutoSize = true;
            this.lblNamaPT.BackColor = System.Drawing.Color.Transparent;
            this.lblNamaPT.Font = new System.Drawing.Font("Century Schoolbook", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNamaPT.ForeColor = System.Drawing.Color.White;
            this.lblNamaPT.Location = new System.Drawing.Point(16, 13);
            this.lblNamaPT.Name = "lblNamaPT";
            this.lblNamaPT.Size = new System.Drawing.Size(555, 40);
            this.lblNamaPT.TabIndex = 1;
            this.lblNamaPT.Text = "Kumbung Jamur Khoirul Mustofa";
            // 
            // lblNamaLengkap
            // 
            this.lblNamaLengkap.AutoSize = true;
            this.lblNamaLengkap.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNamaLengkap.ForeColor = System.Drawing.Color.White;
            this.lblNamaLengkap.Location = new System.Drawing.Point(1188, 13);
            this.lblNamaLengkap.Name = "lblNamaLengkap";
            this.lblNamaLengkap.Size = new System.Drawing.Size(128, 20);
            this.lblNamaLengkap.TabIndex = 2;
            this.lblNamaLengkap.Text = "lblNamaLengkap";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(1123, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Nama :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(1123, 44);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Level :";
            // 
            // lblLevels
            // 
            this.lblLevels.AutoSize = true;
            this.lblLevels.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLevels.ForeColor = System.Drawing.Color.White;
            this.lblLevels.Location = new System.Drawing.Point(1188, 44);
            this.lblLevels.Name = "lblLevels";
            this.lblLevels.Size = new System.Drawing.Size(69, 20);
            this.lblLevels.TabIndex = 5;
            this.lblLevels.Text = "lblLevels";
            // 
            // btnKeluar
            // 
            this.btnKeluar.BackColor = System.Drawing.Color.Lime;
            this.btnKeluar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnKeluar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnKeluar.FlatAppearance.BorderSize = 0;
            this.btnKeluar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnKeluar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Yellow;
            this.btnKeluar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKeluar.Font = new System.Drawing.Font("Segoe UI", 16F);
            this.btnKeluar.ForeColor = System.Drawing.Color.Black;
            this.btnKeluar.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnKeluar.Location = new System.Drawing.Point(1024, 27);
            this.btnKeluar.Name = "btnKeluar";
            this.btnKeluar.Size = new System.Drawing.Size(93, 37);
            this.btnKeluar.TabIndex = 11;
            this.btnKeluar.Text = "Keluar";
            this.btnKeluar.UseVisualStyleBackColor = false;
            this.btnKeluar.Click += new System.EventHandler(this.btnKeluar_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 5000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // ReportKelembapanDataSet
            // 
            this.ReportKelembapanDataSet.DataSetName = "ReportKelembapanDataSet";
            this.ReportKelembapanDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ProcKelembapanBindingSource
            // 
            this.ProcKelembapanBindingSource.DataMember = "ProcKelembapan";
            this.ProcKelembapanBindingSource.DataSource = this.ReportKelembapanDataSet;
            // 
            // ProcKelembapanTableAdapter
            // 
            this.ProcKelembapanTableAdapter.ClearBeforeFill = true;
            // 
            // ReportTemperatureDataSet
            // 
            this.ReportTemperatureDataSet.DataSetName = "ReportTemperatureDataSet";
            this.ReportTemperatureDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ProcTemperatureBindingSource
            // 
            this.ProcTemperatureBindingSource.DataMember = "ProcTemperature";
            this.ProcTemperatureBindingSource.DataSource = this.ReportTemperatureDataSet;
            // 
            // ProcTemperatureTableAdapter
            // 
            this.ProcTemperatureTableAdapter.ClearBeforeFill = true;
            // 
            // FormMainTab
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1362, 706);
            this.ControlBox = false;
            this.Controls.Add(this.btnKeluar);
            this.Controls.Add(this.lblLevels);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblNamaLengkap);
            this.Controls.Add(this.lblNamaPT);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FormMainTab";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormMainTab";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormMainTab_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPageHome.ResumeLayout(false);
            this.tabPageHome.PerformLayout();
            this.tabPageGrafikRealTime.ResumeLayout(false);
            this.tabPageGrafikRealTime.PerformLayout();
            this.tabPageTemperature.ResumeLayout(false);
            this.tabPageTemperature.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.tabPageKelembapan.ResumeLayout(false);
            this.tabPageKelembapan.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.tabPageKumbung.ResumeLayout(false);
            this.tabPageKumbung.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvKumbung)).EndInit();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.tabPageSetting.ResumeLayout(false);
            this.tabPageSetting.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvSetting)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.tabPageUsers.ResumeLayout(false);
            this.tabPageUsers.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvUser)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ReportKelembapanDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProcKelembapanBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ReportTemperatureDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProcTemperatureBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        
        
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPageHome;
        private System.Windows.Forms.TabPage tabPageSetting;
        private System.Windows.Forms.TabPage tabPageGrafikRealTime;
        private System.Windows.Forms.Label lblNamaPT;
        private System.Windows.Forms.Label lblNamaLengkap;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblLevels;
        private System.Windows.Forms.Button btnKeluar;
        private System.Windows.Forms.TabPage tabPageUsers;
        private System.Windows.Forms.TabPage tabPageTemperature;
        private System.Windows.Forms.TabPage tabPageKelembapan;
        private System.Windows.Forms.TabPage tabPageKumbung;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DateTimePicker dpSampaiTemperature;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dpMulaiTemperature;
        private System.Windows.Forms.Label label6;
        private Microsoft.Reporting.WinForms.ReportViewer rvTemperature;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private ZedGraph.ZedGraphControl zedGraphKelembapan;
        private ZedGraph.ZedGraphControl zedGraphTemperature;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnBatalSetting;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button btnSimpanSetting;
        private System.Windows.Forms.TextBox txtKodeSetting;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Button btnEditUser;
        private System.Windows.Forms.Button btnHapusUser;
        private System.Windows.Forms.DataGridView gvUser;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnBatalUser;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtNamaLengkap;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnSimpanUser;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Button btnCariTemperature;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btnCariKelembapan;
        private System.Windows.Forms.DateTimePicker dpSampaiKelembapan;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.DateTimePicker dpMulaiKelembapan;
        private System.Windows.Forms.Label label20;
        private Microsoft.Reporting.WinForms.ReportViewer rvKelembapan;
        private System.Windows.Forms.Button btnUpdateUser;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.TextBox txtKeterangan;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Button btnEditKumbung;
        private System.Windows.Forms.Button btnHapusKumbung;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button btnUpdateKumbung;
        private System.Windows.Forms.Button btnBatalKumbung;
        private System.Windows.Forms.TextBox txtKapasitas;
        private System.Windows.Forms.TextBox txtNamaKumbung;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Button btnSimpanKumbung;
        private System.Windows.Forms.TextBox txtKodeKumbung;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.DataGridView gvKumbung;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.Label label31;
        private System.Windows.Forms.TextBox txtSettingKelembapanMax;
        private System.Windows.Forms.TextBox txtSettingKelembapanMin;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.TextBox txtSettingTemperatureMax;
        private System.Windows.Forms.TextBox txtSettingTemperatureMin;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btnBerhenti;
        private System.Windows.Forms.Button btnJalan;
        private System.Windows.Forms.Label lblMesseg;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Button btnUpdateSetting;
        private System.Windows.Forms.Button btnDeleteSetting;
        private System.Windows.Forms.Button btnEditSetting;
        private System.Windows.Forms.DataGridView gvSetting;
        private System.Windows.Forms.RadioButton rbUser;
        private System.Windows.Forms.RadioButton rbAdministrator;
        private System.Windows.Forms.Label lblSettingKumbung1;
        private System.Windows.Forms.RadioButton rbTidakAktif;
        private System.Windows.Forms.RadioButton rbAktif;
        private System.Windows.Forms.ComboBox cmbKodeKumbung;
        private System.Windows.Forms.Label label32;
        private System.Windows.Forms.BindingSource ProcKelembapanBindingSource;
        private ReportKelembapanDataSet ReportKelembapanDataSet;
        private ReportKelembapanDataSetTableAdapters.ProcKelembapanTableAdapter ProcKelembapanTableAdapter;
        private System.Windows.Forms.BindingSource ProcTemperatureBindingSource;
        private ReportTemperatureDataSet ReportTemperatureDataSet;
        private ReportTemperatureDataSetTableAdapters.ProcTemperatureTableAdapter ProcTemperatureTableAdapter;
    }
}