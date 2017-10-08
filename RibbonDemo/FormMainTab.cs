using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using RibbonDemo.Facade;
using Microsoft.Reporting.WinForms;
using RibbonDemo.Entity;
using System.Globalization;
using System.IO.Ports;
using ZedGraph;

namespace RibbonDemo
{
    public partial class FormMainTab : Form
    {
        //public String Username = "111", Namelengkap = "Khoirul Mustofa", Level = "jjj";
        public String Username, Namelengkap, Level;
        public DataTable tbl;

        /**Inisialisaisi arduino
         * Setup port serial dengan nama port COM65,
         * dan baud rate sebesar 9600.
         * Baud rate disini dengan di arduino harus sama
         * **/
        SerialPort arduino = new SerialPort("COM5", 9600);


        //Array list untuk menyimpan data suhu dan waktu
        double[] bufferSuhu = new double[10];
        double[] bufferWaktu = new double[10];

        List<double> listSuhu = new List<double>();
        List<double> listWaktu = new List<double>();

        //waktu mulai dalam milidetik
        double waktuStart = 100;
        //interval simpan ke database (menit)
        int intervalSimpan = 1;
        //pencacah interval
        int counter = 0;

        public FormMainTab()
        {
            InitializeComponent();
        }

        private void FormMainTab_Load(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(Username))
            {
                MessageBox.Show("Anda Harus Login Dahulu", "Khoirul Mustofa", MessageBoxButtons.OK, MessageBoxIcon.Error);
                FormLogin oFormLogin = new FormLogin();
                this.Username = string.Empty;
                oFormLogin.Show();
                this.Hide();
            }
            else
            {
                lblLevels.Text = Level;
                lblNamaLengkap.Text = Namelengkap;
                if (Level == "User")
                {
                    this.tabControl1.Controls.Remove(this.tabPageKumbung);
                    this.tabControl1.Controls.Remove(this.tabPageSetting);
                    this.tabControl1.Controls.Remove(this.tabPageUsers);
                }
                // load grid Kumbung
                getAllDataKumbung();
                // load grid Setting
                getAllDataSetting();
                //
                getAllDataUsers();
                // cottrol button
                ControlComponent();
                //Load Kode Setting Kumbung
                LoadKodeSettingKumbung();
                // use setting
                LoadsettingKumbung();

                // Load untuk grafik
                LoadGrafik();
            }

        }

        private void LoadGrafik()
        {
            try
            {
                //catat waktu pertama sebagai referensi
                waktuStart = Environment.TickCount;

                //Inisialisasi ZedGraph
                GraphPane grafikKelembapan = zedGraphKelembapan.GraphPane;
                grafikKelembapan.Title.Text = "Grafik Kelembapan";
                grafikKelembapan.XAxis.Title.Text = "Waktu (Detik)";
                grafikKelembapan.YAxis.Title.Text = "Kelembapan (%)";

                //Simpan 120 point. Pada 500 ms sampel rate.
                //RollingPointPairList adalah class penyimpanan yang efisien 
                //dengan tetap merolling kumpulan point data tanpa perlu
                //men-shift nilai data apapun
                RollingPointPairList listKelembapan = new RollingPointPairList(120);

                //Inisialisasi kurva
                LineItem kurvaKelembapan = grafikKelembapan.AddCurve("Kelembapan", listKelembapan, Color.Red, SymbolType.Circle);

                //Inisialisasi ZedGraph
                GraphPane grafikSuhu = zedGraphTemperature.GraphPane;
                grafikSuhu.Title.Text = "Grafik Temperature";
                grafikSuhu.XAxis.Title.Text = "Waktu (Detik)";
                grafikSuhu.YAxis.Title.Text = "Temperature (Celcius)";

                //Simpan 120 point. Pada 500 ms sampel rate.
                //RollingPointPairList adalah class penyimpanan yang efisien 
                //dengan tetap merolling kumpulan point data tanpa perlu
                //men-shift nilai data apapun
                RollingPointPairList listTemperature = new RollingPointPairList(120);

                //Inisialisasi kurva
                LineItem kurvaTemperature = grafikSuhu.AddCurve("Temperature", listTemperature, Color.Blue, SymbolType.Circle);
            }
            catch (Exception gagal)
            {
                //error handling
                //MessageBox.Show(gagal.ToString());
            }
        }

        private void LoadsettingKumbung()
        {
            string kodeSettingkumbung1 = new SettingFacade().getkodeSettingKumbung1();
            lblSettingKumbung1.Text = kodeSettingkumbung1;
        }

        private void getAllDataUsers()
        {
            try
            {
                UsersFacede oUsersFacede = new UsersFacede();
                tbl = oUsersFacede.getAllDataUsersAsTable();

                gvUser.DataSource = null;
                gvUser.Columns.Clear();
                gvUser.DataSource = tbl;
                gvUser.AllowUserToAddRows = false;
                gvUser.ReadOnly = true;
                gvUser.Columns[0].Width = 200;
                gvUser.Columns[0].HeaderText = "USER NAME";
                gvUser.Columns[1].Width = 400;
                gvUser.Columns[1].HeaderText = "FULL NAME";
                gvUser.Columns[2].Width = 150;
                gvUser.Columns[2].HeaderText = "LEVEL";

            }
            catch (Exception ex)
            {
            }
        }
        #region FORM LOAD
        private void LoadKodeSettingKumbung()
        {

            txtKodeSetting.Text = "KMSET_" + cmbKodeKumbung.Text + DateTime.Now.ToString("_ddMMyyHHmmss");
        }



        private void ControlComponent()
        {
            // Kumbung
            btnUpdateKumbung.Visible = false;
            btnSimpanKumbung.Visible = true;

            // Settung Kumbung
            txtKodeSetting.Enabled = false;
            btnUpdateSetting.Visible = false;
            btnSimpanSetting.Visible = true;
            txtKodeSetting.Visible = true;

            // User
            btnUpdateUser.Visible = false;
            btnSimpanUser.Visible = true;
        }

        #endregion FORM LOAD
        #region KUMBUNG
        private void btnSimpanKumbung_Click(object sender, EventArgs e)
        {
            try
            {
                if (ValidationSaveKumbung())
                {
                    Kumbung oKumbung = new Kumbung();
                    oKumbung.kode_kumbung = txtKodeKumbung.Text;
                    oKumbung.nama_kumbung = txtNamaKumbung.Text;
                    oKumbung.kapasitas = Int32.Parse(txtKapasitas.Text);

                    KumbungFacede oKumbungFacede = new KumbungFacede();
                    if (oKumbungFacede.Insert(oKumbung))
                    {
                        ClearTextKumbung();
                        MessageBox.Show("Data Kumbung Berhasil di Simpan !!", "Khoirul Mustofa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Data Kumbung GAGAL di Simpan !!", "Khoirul Mustofa", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }
                    getAllDataKumbung();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ada Error : " + ex.ToString(), "Khoirul Mustofa", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void ClearTextKumbung()
        {
            txtKodeKumbung.Text = "";
            txtNamaKumbung.Text = "";
            txtKapasitas.Text = "";
            txtKodeKumbung.Focus();
        }

        private void getAllDataKumbung()
        {
            try
            {
                KumbungFacede oKumbungFacede = new KumbungFacede();
                tbl = oKumbungFacede.getAllDataKumbungAsTable();

                gvKumbung.DataSource = null;
                gvKumbung.Columns.Clear();
                gvKumbung.DataSource = tbl;
                gvKumbung.AllowUserToAddRows = false;
                gvKumbung.ReadOnly = true;
                gvKumbung.Columns[0].Width = 200;
                gvKumbung.Columns[0].HeaderText = "KODE KUMBUNG";
                gvKumbung.Columns[1].Width = 400;
                gvKumbung.Columns[1].HeaderText = "NAMA KUMBUNG";
                gvKumbung.Columns[2].Width = 150;
                gvKumbung.Columns[2].HeaderText = "KAPASISTAS";

            }
            catch (Exception ex)
            {
            }
        }

        private bool ValidationSaveKumbung()
        {
            if (string.IsNullOrEmpty(txtKodeKumbung.Text))
            {
                MessageBox.Show("Kode Kumbung di isi Lohhhh !!!");
                txtKodeKumbung.Focus();
            }
            else if (string.IsNullOrEmpty(txtNamaKumbung.Text))
            {
                MessageBox.Show("Nama Kumbung belom di isi Lohhhh !!!");
                txtNamaKumbung.Focus();
            }
            else if (string.IsNullOrEmpty(txtKapasitas.Text))
            {
                MessageBox.Show("Kapasitas belom di isi Lohhhh !!!");
                txtKapasitas.Focus();
            }
            else
            {
                return true;
            }

            return false;
        }
        private void btnEditKumbung_Click(object sender, EventArgs e)
        {
            txtKodeKumbung.Enabled = false;
            btnUpdateKumbung.Visible = true;
            btnSimpanKumbung.Visible = false;
            txtKodeKumbung.Text = gvKumbung.SelectedRows[0].Cells["kode_kumbung"].Value.ToString();
            txtNamaKumbung.Text = gvKumbung.SelectedRows[0].Cells["nama_kumbung"].Value.ToString();
            txtKapasitas.Text = gvKumbung.SelectedRows[0].Cells["kapasitas"].Value.ToString();
        }

        private void btnBatalKumbung_Click(object sender, EventArgs e)
        {
            txtKodeKumbung.Enabled = true;
            ClearTextKumbung();
            getAllDataKumbung();
        }

        private void btnUpdateKumbung_Click(object sender, EventArgs e)
        {
            try
            {
                if (ValidationSaveKumbung())
                {
                    Kumbung oKumbung = new Kumbung();
                    oKumbung.kode_kumbung = txtKodeKumbung.Text;
                    oKumbung.nama_kumbung = txtNamaKumbung.Text;
                    oKumbung.kapasitas = Int32.Parse(txtKapasitas.Text);

                    KumbungFacede oKumbungFacede = new KumbungFacede();
                    if (oKumbungFacede.Update(oKumbung))
                    {
                        ClearTextKumbung();
                        MessageBox.Show("Data Kumbung Berhasil di Update !!", "Khoirul Mustofa", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        btnUpdateKumbung.Visible = false;
                        btnSimpanKumbung.Visible = true;
                        txtKodeKumbung.Enabled = true;
                    }
                    else
                    {
                        MessageBox.Show("Data Kumbung GAGAL di Update !!", "Khoirul Mustofa", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }
                    getAllDataKumbung();
                }
            }
            catch (Exception ex)
            {

            }
        }

        private void btnDeleteKumbung_Click(object sender, EventArgs e)
        {
            string KodeKumbung = gvKumbung.SelectedRows[0].Cells["kode_kumbung"].Value.ToString();
            try
            {
                KumbungFacede oKumbungFacede = new KumbungFacede();
                if (MessageBox.Show("Apakah Anda Yakin Akan Menghapus Data Ini ?", "Khoirul Mustofa", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    if (oKumbungFacede.Delete(KodeKumbung))
                    {
                        ClearTextKumbung();
                        MessageBox.Show("Data Kumbung Berhasil di Delete !!", "Khoirul Mustofa", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        btnUpdateKumbung.Visible = false;
                        btnSimpanKumbung.Visible = true;
                    }
                    else
                    {
                        MessageBox.Show("Data Kumbung GAGAL di Delete !!", "Khoirul Mustofa", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }
                } getAllDataKumbung();

            }
            catch (Exception ex)
            {
            }

        }
        #endregion KUMBUNG

        private void btnSimpanSetting_Click(object sender, EventArgs e)
        {
            try
            {
                if (ValidationSaveSetting())
                {
                    SettingKumbung oSettingKumbung = new SettingKumbung();
                    oSettingKumbung.kode_setting_kumbung = txtKodeSetting.Text;

                    oSettingKumbung.kode_kumbung = cmbKodeKumbung.Text;
                    oSettingKumbung.setting_temperature_min = Int32.Parse(txtSettingTemperatureMin.Text);
                    oSettingKumbung.setting_temperature_max = Int32.Parse(txtSettingTemperatureMax.Text);
                    oSettingKumbung.setting_kelembapan_min = Int32.Parse(txtSettingKelembapanMin.Text);
                    oSettingKumbung.setting_kelembapan_max = Int32.Parse(txtSettingKelembapanMax.Text);
                    oSettingKumbung.tanggal_setting = DateTime.Now.ToString();
                    oSettingKumbung.Keterangan = txtKeterangan.Text;
                    oSettingKumbung.user_name = Username;
                    string staus = "";
                    if (rbAktif.Checked)
                    {
                        staus = "Aktif";
                    }
                    else if (rbTidakAktif.Checked)
                    {
                        staus = "Tidak Aktif";
                    }
                    oSettingKumbung.status = staus;
                    SettingFacade oSettingKumbungFacade = new SettingFacade();
                    if (oSettingKumbungFacade.Insert(oSettingKumbung))
                    {
                        ClearTextSetting();
                        MessageBox.Show("Data Setting Berhasil di Simpan !!", "Khoirul Mustofa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Data Setting GAGAL di Simpan !!", "Khoirul Mustofa", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }
                    LoadKodeSettingKumbung();
                    getAllDataSetting();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ada Error : " + ex.ToString(), "Khoirul Mustofa", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void getAllDataSetting()
        {
            try
            {

                SettingFacade oSettingKumbungFacade = new SettingFacade();
                tbl = oSettingKumbungFacade.getAllDataSettingsAsTable();

                gvSetting.DataSource = null;
                gvSetting.Columns.Clear();
                gvSetting.DataSource = tbl;
                gvSetting.AllowUserToAddRows = false;
                gvSetting.ReadOnly = true;
                gvSetting.Columns[0].Width = 100;
                gvSetting.Columns[0].HeaderText = "STATUS";
                gvSetting.Columns[1].Width = 270;
                gvSetting.Columns[1].HeaderText = "KODE SETTING KUMBUNG";
                gvSetting.Columns[2].Width = 150;
                gvSetting.Columns[2].HeaderText = "KODE KUMBUNG";
                gvSetting.Columns[3].Width = 180;
                gvSetting.Columns[3].HeaderText = "TEMPERATURE MIN";
                gvSetting.Columns[4].Width = 180;
                gvSetting.Columns[4].HeaderText = "TEMPERATURE MAX";
                gvSetting.Columns[5].Width = 180;
                gvSetting.Columns[5].HeaderText = "KELEMBAPAN MIN";
                gvSetting.Columns[6].Width = 180;
                gvSetting.Columns[6].HeaderText = "KELEMBAPAN MAX";
                gvSetting.Columns[7].Width = 200;
                gvSetting.Columns[7].HeaderText = "KETERANGAN";
                gvSetting.Columns[8].Width = 150;
                gvSetting.Columns[8].HeaderText = "USER NAME";

            }
            catch (Exception ex)
            {
            }
        }

        private void ClearTextSetting()
        {
            txtSettingTemperatureMin.Text = "";
            txtSettingTemperatureMax.Text = "";
            txtSettingKelembapanMin.Text = "";
            txtSettingKelembapanMax.Text = "";
            txtKeterangan.Text = "";
            txtSettingTemperatureMin.Focus();
        }

        private bool ValidationSaveSetting()
        {
            if (string.IsNullOrEmpty(txtSettingTemperatureMin.Text))
            {
                MessageBox.Show("Setting Temperature Min di isi Lohhhh !!!");
                txtSettingTemperatureMin.Focus();
            }
            else if (string.IsNullOrEmpty(cmbKodeKumbung.Text))
            {
                MessageBox.Show("Combo Kode Kumbung belom di isi Lohhhh !!!");
                cmbKodeKumbung.Focus();
            }
            else if (string.IsNullOrEmpty(txtSettingTemperatureMax.Text))
            {
                MessageBox.Show("Setting Temperature Max belom di isi Lohhhh !!!");
                txtSettingTemperatureMax.Focus();
            }
            else if (string.IsNullOrEmpty(txtSettingKelembapanMin.Text))
            {
                MessageBox.Show("Setting Kelembapan Min belom di isi Lohhhh !!!");
                txtSettingKelembapanMin.Focus();
            }
            else if (string.IsNullOrEmpty(txtSettingKelembapanMax.Text))
            {
                MessageBox.Show("Setting Kelembapan Max belom di isi Lohhhh !!!");
                txtSettingKelembapanMax.Focus();
            }
            else if (string.IsNullOrEmpty(txtKeterangan.Text))
            {
                MessageBox.Show("Keterangan belom di isi Lohhhh !!!");
                txtKeterangan.Focus();
            }
            else
            {
                return true;
            }

            return false;
        }

        private void btnUpdateUser_Click(object sender, EventArgs e)
        {
            try
            {
                if (ValidationSaveUser())
                {
                    Users oUsers = new Users();
                    oUsers.Username = txtUserName.Text;
                    oUsers.Passwords = txtPassword.Text;
                    oUsers.FullName = txtNamaLengkap.Text;
                    string Level = "";
                    if (rbAdministrator.Checked)
                    {
                        Level = "Administrator";
                    }
                    else if (rbUser.Checked)
                    {
                        Level = "User";
                    }
                    oUsers.Levels = Level;

                    UsersFacede oUsersFacede = new UsersFacede();
                    if (oUsersFacede.Update(oUsers))
                    {
                        ClearTextUser();
                        MessageBox.Show("Data User Berhasil di Update !!", "Khoirul Mustofa", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        btnUpdateUser.Visible = false;
                        btnSimpanUser.Visible = true;
                        txtUserName.Enabled = true;
                    }
                    else
                    {
                        MessageBox.Show("Data User GAGAL di Update !!", "Khoirul Mustofa", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }
                    getAllDataUsers();
                }
            }
            catch (Exception ex)
            {

            }
        }

        private bool ValidationSaveUser()
        {

            if (string.IsNullOrEmpty(txtUserName.Text))
            {
                MessageBox.Show("User Name di isi Lohhhh !!!");
                txtUserName.Focus();
            }
            else if (string.IsNullOrEmpty(txtPassword.Text))
            {
                MessageBox.Show("Password belom di isi Lohhhh !!!");
                txtPassword.Focus();
            }
            else if (string.IsNullOrEmpty(txtNamaLengkap.Text))
            {
                MessageBox.Show("Nama Lengkap belom di isi Lohhhh !!!");
                txtNamaLengkap.Focus();
            }
            else
            {
                return true;
            }

            return false;
        }

        private void btnSimpanUser_Click(object sender, EventArgs e)
        {
            try
            {
                if (ValidationSaveUser())
                {
                    Users oUsers = new Users();
                    oUsers.Username = txtUserName.Text;
                    oUsers.Passwords = txtPassword.Text;
                    oUsers.FullName = txtNamaLengkap.Text;
                    string Level = "";
                    if (rbAdministrator.Checked)
                    {
                        Level = "Administrator";
                    }
                    else if (rbUser.Checked)
                    {
                        Level = "User";
                    }
                    oUsers.Levels = Level;

                    UsersFacede oUsersFacede = new UsersFacede();
                    if (oUsersFacede.Insert(oUsers))
                    {
                        ClearTextUser();
                        MessageBox.Show("Data User Berhasil di Simpan !!", "Khoirul Mustofa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Data User GAGAL di Simpan !!", "Khoirul Mustofa", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }
                    getAllDataUsers();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ada Error : " + ex.ToString(), "Khoirul Mustofa", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void btnEditUser_Click(object sender, EventArgs e)
        {
            txtUserName.Enabled = false;
            btnUpdateUser.Visible = true;
            btnSimpanUser.Visible = false;
            string userName = txtUserName.Text = gvUser.SelectedRows[0].Cells["user_name"].Value.ToString();
            Users oUsers = new UsersFacede().GetUserById(userName);
            txtUserName.Text = oUsers.Username;
            txtPassword.Text = oUsers.Passwords;
            txtNamaLengkap.Text = oUsers.FullName;
            if (oUsers.Levels == "Administrator")
            {
                rbAdministrator.Checked = true;
            }
            else if (oUsers.Levels == "User")
            {
                rbAdministrator.Checked = true;
            }
        }

        private void btnHapusUser_Click(object sender, EventArgs e)
        {
            string userName = gvUser.SelectedRows[0].Cells["user_name"].Value.ToString();
            try
            {
                UsersFacede oUsersFacede = new UsersFacede();
                if (MessageBox.Show("Apakah Anda Yakin Akan Menghapus Data Ini ?", "Khoirul Mustofa", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    if (oUsersFacede.Delete(userName))
                    {
                        ClearTextUser();
                        MessageBox.Show("Data Kumbung Berhasil di Delete !!", "Khoirul Mustofa", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        btnUpdateUser.Visible = false;
                        btnSimpanUser.Visible = true;
                    }
                    else
                    {
                        MessageBox.Show("Data Kumbung GAGAL di Delete !!", "Khoirul Mustofa", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }
                }
                getAllDataUsers();
                ClearTextUser();

            }
            catch (Exception ex)
            {
            }
        }

        private void btnBatalUser_Click(object sender, EventArgs e)
        {
            txtUserName.Enabled = true;
            ClearTextUser();
            getAllDataUsers();
        }

        private void ClearTextUser()
        {
            txtUserName.Text = "";
            txtPassword.Text = "";
            txtNamaLengkap.Text = "";
            txtUserName.Focus();
            rbUser.Checked = true;
        }

        private void btnUpdateSetting_Click(object sender, EventArgs e)
        {
            try
            {
                if (ValidationSaveSetting())
                {
                    SettingKumbung oSettingKumbung = new SettingKumbung();
                    oSettingKumbung.kode_setting_kumbung = txtKodeSetting.Text;

                    oSettingKumbung.kode_kumbung = cmbKodeKumbung.Text;
                    oSettingKumbung.setting_temperature_min = Int32.Parse(txtSettingTemperatureMin.Text);
                    oSettingKumbung.setting_temperature_max = Int32.Parse(txtSettingTemperatureMax.Text);
                    oSettingKumbung.setting_kelembapan_min = Int32.Parse(txtSettingKelembapanMin.Text);
                    oSettingKumbung.setting_kelembapan_max = Int32.Parse(txtSettingKelembapanMax.Text);
                    oSettingKumbung.tanggal_setting = DateTime.Now.ToString();
                    oSettingKumbung.Keterangan = txtKeterangan.Text;
                    oSettingKumbung.user_name = Username;
                    string staus = "";
                    if (rbAktif.Checked)
                    {
                        staus = "Aktif";
                    }
                    else if (rbTidakAktif.Checked)
                    {
                        staus = "Tidak Aktif";
                    }
                    oSettingKumbung.status = staus;
                    SettingFacade oSettingKumbungFacade = new SettingFacade();
                    if (oSettingKumbungFacade.Update(oSettingKumbung))
                    {
                        ClearTextSetting();
                        MessageBox.Show("Data Setting Berhasil di Update !!", "Khoirul Mustofa", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        btnUpdateSetting.Visible = false;
                        btnSimpanSetting.Visible = true;
                    }
                    else
                    {
                        MessageBox.Show("Data Setting GAGAL di Update !!", "Khoirul Mustofa", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }
                    getAllDataSetting();
                }
            }
            catch (Exception ex)
            {

            }
        }

        private void btnEditSetting_Click(object sender, EventArgs e)
        {
            btnUpdateSetting.Visible = true;
            btnSimpanSetting.Visible = false;

            txtKodeSetting.Text = gvSetting.SelectedRows[0].Cells["kode_setting_kumbung"].Value.ToString();
            cmbKodeKumbung.Text = gvSetting.SelectedRows[0].Cells["kode_kumbung"].Value.ToString();

            txtSettingTemperatureMin.Text = gvSetting.SelectedRows[0].Cells["setting_temperature_min"].Value.ToString();
            txtSettingTemperatureMax.Text = gvSetting.SelectedRows[0].Cells["setting_temperature_max"].Value.ToString();
            txtSettingKelembapanMin.Text = gvSetting.SelectedRows[0].Cells["setting_kelembapan_min"].Value.ToString();
            txtSettingKelembapanMax.Text = gvSetting.SelectedRows[0].Cells["setting_kelembapan_max"].Value.ToString();
            txtKeterangan.Text = gvSetting.SelectedRows[0].Cells["Keterangan"].Value.ToString();
            string status = gvSetting.SelectedRows[0].Cells["status"].Value.ToString();
            if (status == "Aktif")
            {
                rbAktif.Checked = true;
            }
            else if (status == "Tidak Aktif")
            {
                rbTidakAktif.Checked = true;
            }

            getAllDataSetting();

        }

        private void rbKumbung1_CheckedChanged(object sender, EventArgs e)
        {
            txtKodeSetting.Text = "KMSET_" + "Kumbung1" + DateTime.Now.ToString("_ddMMyyHHmmss");
        }

        private void rbKumbung2_CheckedChanged(object sender, EventArgs e)
        {
            txtKodeSetting.Text = "KMSET_" + "Kumbung2" + DateTime.Now.ToString("_ddMMyyHHmmss");
        }

        private void btnBatalSetting_Click(object sender, EventArgs e)
        {
            ClearTextSetting();
            btnUpdateSetting.Visible = false;
            btnSimpanSetting.Visible = true;
            LoadKodeSettingKumbung();
        }

        private void btnDeleteSetting_Click(object sender, EventArgs e)
        {
            string KodeSetting = gvSetting.SelectedRows[0].Cells["kode_setting_kumbung"].Value.ToString();
            try
            {
                SettingFacade oSettingKumbung = new SettingFacade();
                if (MessageBox.Show("Apakah Anda Yakin Akan Menghapus Data Ini ?", "Khoirul Mustofa", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    if (oSettingKumbung.Delete(KodeSetting))
                    {
                        ClearTextSetting();
                        MessageBox.Show("Data Setting Berhasil di Delete !!", "Khoirul Mustofa", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        btnUpdateSetting.Visible = false;
                        btnSimpanSetting.Visible = true;
                    }
                    else
                    {
                        MessageBox.Show("Data Setting GAGAL di Delete !!", "Khoirul Mustofa", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }
                } getAllDataSetting();

            }
            catch (Exception ex)
            {
            }
        }

        private void btnJalan_Click(object sender, EventArgs e)
        {
            lblMesseg.Text = "Aplikasi Sedang Merekam Data !!";
            lblMesseg.BackColor = Color.Green;

            try
            {
                //matikan tombol start
                btnJalan.Visible = false;
                //nyalakan tombol stop
                btnBerhenti.Visible = true;
                //set batas waktu pembacaan serial sebelum dinyatakan gagal
                arduino.ReadTimeout = 1000;
                //set batas waktu penulisan serial
                arduino.WriteTimeout = 1000;

                //nyalakan detak
                timer1.Enabled = true;
                //mulai detak
                timer1.Start();
            }
            catch (Exception gagal)
            {
                //Error handling
                //MessageBox.Show(gagal.ToString());
            }
        }

        private void btnBerhenti_Click(object sender, EventArgs e)
        {
            lblMesseg.Text = "Aplikasi Sedang TIDAK Merekam Data !!";
            lblMesseg.BackColor = Color.Red;
            try
            {
                //nyalakan kembali tombol start
                btnJalan.Visible = true;
                //matikan tombol stop
                btnBerhenti.Visible = false;
                //stop detak
                timer1.Stop();
                //matikan detak
                timer1.Enabled = false;
                //jika komunikasi masih terbuka, tutup komunikasi
                if (arduino.IsOpen)
                {
                    arduino.Close();
                }
            }
            catch (Exception gagal)
            {
                //error handling
                //MessageBox.Show(gagal.ToString());
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            try
            {
                //increment-kan pencacah
                counter++;

                //Mulai komunikasi dengan arduino
                arduino.Open();

                //get item kurva pertama pada grafik
                LineItem curvaKelembapan = zedGraphKelembapan.GraphPane.CurveList[0] as LineItem;
                LineItem curvaTemperature = zedGraphTemperature.GraphPane.CurveList[0] as LineItem;

                //get PointPairList
                IPointListEdit listKelebapan = curvaKelembapan.Points as IPointListEdit;
                IPointListEdit listTemperature = curvaTemperature.Points as IPointListEdit;

                //waktu yang terlewati
                double waktu = (Environment.TickCount - waktuStart) / 1000.0;

                //baca data suhu yang dikirim arduino,
                //konversi data tersebut (string) ke double,
                //dan tambahkan ke listSuhu
                float dataKelembapan = float.Parse(arduino.ReadLine(), CultureInfo.InvariantCulture.NumberFormat);
                float dataTemperature = float.Parse(arduino.ReadLine(), CultureInfo.InvariantCulture.NumberFormat);

                listKelebapan.Add(waktu, Convert.ToDouble(dataKelembapan));
                listTemperature.Add(waktu, Convert.ToDouble(dataTemperature));

                //Tutup komunikasi dengan arduino
                arduino.Close();

                //Buat scale X tetap rolling dalam interval 30 detik, dengan satu
                //langkah besar antara nilai X maksimal dan akhir dari axis
                Scale xScaleKelembapan = zedGraphKelembapan.GraphPane.XAxis.Scale;
                if (waktu > xScaleKelembapan.Max - xScaleKelembapan.MajorStep)
                {
                    xScaleKelembapan.Max = waktu + xScaleKelembapan.MajorStep;
                    xScaleKelembapan.Min = xScaleKelembapan.Max - 30.0;
                }

                Scale xScaleTemperature = zedGraphTemperature.GraphPane.XAxis.Scale;
                if (waktu > xScaleTemperature.Max - xScaleTemperature.MajorStep)
                {
                    xScaleTemperature.Max = waktu + xScaleTemperature.MajorStep;
                    xScaleTemperature.Min = xScaleTemperature.Max - 30.0;
                }

                // Pastikan Y axis di scale ulang untuk mengakomodir data aktual
                zedGraphKelembapan.AxisChange();
                zedGraphTemperature.AxisChange();

                // Redraw paksa
                zedGraphKelembapan.Invalidate();
                zedGraphTemperature.Invalidate();

                /** 
                 * Mencatat suhu ke database
                 * **/
                //lakukan hanya pada interval yang telah ditentukan
                //intervalSimpan (menit) x 60 x 2, karena 1 detak = 500 milidetik / 1/2 detik
                //Buat query untuk insert catatan
                // rekam data
                KelembapanSuhu oKelembapanSuhu = new KelembapanSuhu();
                oKelembapanSuhu.kode_setting_kumbung = lblSettingKumbung1.Text;
                oKelembapanSuhu.nilai_kelembapan = dataKelembapan;
                oKelembapanSuhu.nilai_temperature = dataTemperature;

                KelembapanSuhuFacade oKelembapanSuhuFacade = new KelembapanSuhuFacade();
                tbl = oKelembapanSuhuFacade.Insert(oKelembapanSuhu);

                //reset pencacah
                counter = 0;
            }
            catch (Exception gagal)
            {
                //error handling
                //tutup komunikasi dengan arduino jika masih terhubung
                if (arduino.IsOpen)
                {
                    arduino.Close();
                }
                //MessageBox.Show("Maaf Terjadi Error Cek Port dan Koneksi , Tutup pesan ini dan tekan button STOP", "Error | Kumbung Khoirul Mustofa", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private void btnCariTemperature_Click(object sender, EventArgs e)
        {
            string tanggalawal = dpMulaiTemperature.Text;
            string tanggalakhir = dpSampaiTemperature.Text;
            tbl = new KelembapanSuhuFacade().GetReportTemperature(tanggalawal, tanggalakhir);
            ReportDataSource oReportDataSource = new ReportDataSource("DataSet1", tbl);
            rvTemperature.LocalReport.DataSources.Clear();
            rvTemperature.LocalReport.DataSources.Add(oReportDataSource);
            rvTemperature.RefreshReport();
        }

        private void btnCariKelembapan_Click(object sender, EventArgs e)
        {

            string tanggalawal = dpMulaiKelembapan.Text;
            string tanggalakhir = dpSampaiKelembapan.Text;
            tbl = new KelembapanSuhuFacade().GetReportKelembapan(tanggalawal, tanggalakhir);
            ReportDataSource oReportDataSource = new ReportDataSource("DataSet1", tbl);
            rvKelembapan.LocalReport.DataSources.Clear();
            rvKelembapan.LocalReport.DataSources.Add(oReportDataSource);
            rvKelembapan.RefreshReport();
        }

        private void btnKeluar_Click(object sender, EventArgs e)
        {

            bool dialogKeluar = MessageBox.Show("Apakah Anda Akan Keluar dari Aplikasi", "Keluar Apliksi", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes;
            if (dialogKeluar)
            {
                FormLogin oFormLogin = new FormLogin();
                this.Username = string.Empty;
                oFormLogin.Show();
                this.Hide();
            }
        }

    }
}