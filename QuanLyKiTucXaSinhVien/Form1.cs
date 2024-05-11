using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyKiTucXaSinhVien
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(UserName.Text=="Nhat" && MK.Text == "1234")
            {
                Form f2 = new SauKhiDangNhap();
                f2.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Sai tài khoản hoặc mật khẩu","Thông báo");
            }           
        }
        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();   
        }

        private void Password_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
