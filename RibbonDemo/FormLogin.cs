using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using RibbonDemo.Facade;
using RibbonDemo.Entity;

namespace RibbonDemo
{
    public partial class FormLogin : Form
    {
        private DataTable tbl;
        string userName = "";
        string FullName = "";
        string Levels = "";
        public FormLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string userName = txtUserName.Text;
            //string userID = "111";
            try
            {
                getUserNameForLogin(userName);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Eroor Aplikasi Adalah : " + ex.ToString(), "Error Aplikasi");
            }
        }

        private void getUserNameForLogin(string userName)
        {
            // cek user aktif atau tidak terdaftar
            if (IsUserActive(userName))
            {
                string pass = txtPassword.Text;
                //string pass = "123";
                if (verifycationUser(userName, pass))
                {
                    FormMainTab oFormMain = new FormMainTab();
                    oFormMain.Username = userName;
                    oFormMain.Namelengkap = FullName;
                    oFormMain.Level = Levels;
                    oFormMain.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Password Yang Anda Masukan SALAH , Periksa Kembali Password Anda !!", "Password Salah", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtPassword.Focus();
                }
            }
            else
            {
                MessageBox.Show("UserID Anda Tidak Terdaftar , Periksa Kembali UserID Anda Atau Hubungi Admin Extruder Management System !!", "Error User", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtUserName.Clear();
                txtPassword.Clear();
                txtUserName.Focus();
            }
        }

        private bool verifycationUser(string userName, string pass)
        {
            tbl = new UsersFacede().GetUserByIdTbl(userName, pass);
            if (tbl.Rows.Count > 0)
            {
                foreach (DataRow kolom in tbl.Rows)
                {
                    userName = kolom["user_name"].ToString();
                    FullName = kolom["full_name"].ToString();
                    Levels = kolom["levels"].ToString();
                }
                return true;
            }
            else
            {
                return false;
            }
        }

        private bool IsUserActive(string userName)
        {
            tbl = new UsersFacede().GetUserByIdTbl(userName);
            if (tbl.Rows.Count > 0)
            {

                return true;
            }
            else
            {
                return false;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            try
            {
                bool dialogKeluar = MessageBox.Show("Apakah Anda Akan Keluar dari Aplikasi", "Keluar Apliksi", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes;
                if (dialogKeluar)
                {
                    Application.Exit();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Eroor Aplikasi Adalah : " + ex.ToString(), "Error Aplikasi");
            }
        }
    }
}
