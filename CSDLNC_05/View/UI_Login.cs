﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CSDLNC_05.Controllers;

namespace CSDLNC_05.View.Login
{
    public partial class UI_Login : Form
    {
        public UI_Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            String username = this.txtbox_username.Text;
            String password = this.txtbox_password.Text;

            if (
                String.IsNullOrEmpty(username)
                || String.IsNullOrEmpty(password)
                || String.IsNullOrWhiteSpace(username)
                || String.IsNullOrWhiteSpace(password)
            )
            {
                MessageBox.Show(
                    "Thông tin đăng nhập không hợp lệ!",
                    "Đăng nhập thất bại!",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
                return;
            }

            int login_status = User.login(username, password);

            if (login_status == 1)
            {
                UI_Home home = new UI_Home();
                home.Show();
                this.Hide();
            }
            else if (login_status == 2)
            {
                MessageBox.Show(
                    "Tài khoản vô danh không được phép truy cập!",
                    "Đăng nhập thất bại!",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
                return;
            }
            else
            {
                MessageBox.Show(
                    "Thông tin đăng nhập không chính xác!",
                    "Đăng nhập thất bại!",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
                return;
            }
        }
    }
}
