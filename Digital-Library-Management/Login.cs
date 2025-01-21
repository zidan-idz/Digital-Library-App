using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Digital_Library_Management
{
    public partial class Login : Form
    {
        public bool LoginSuccessful { get; private set; } = false;

        public Login()
        {
            InitializeComponent();
        }

        private void tombol1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "admin" && textBox2.Text == "qwerty123")
            {
                LoginSuccessful = true;
                this.Close();
            }
            else
            {
                MessageBox.Show("Username atau Password salah");
            }
        }

        private void tombol2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
