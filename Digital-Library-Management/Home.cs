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
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void keluar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void tombol1_Click(object sender, EventArgs e)
        {
            Book formBook = new Book();
            formBook.Show();
        }

        private void tombol2_Click(object sender, EventArgs e)
        {
            Member formMember = new Member();
            formMember.Show();
        }

        private void tombol3_Click(object sender, EventArgs e)
        {
            Borrow formBorrow = new Borrow();
            formBorrow.Show();
        }

        private void Home_Load(object sender, EventArgs e)
        {
            Connect.Stockholm("Peminjaman", dataGridView1);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Connect.Stockholm("Peminjaman", dataGridView1);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Report formReport = new Report();
            formReport.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            About formAbout = new About();
            formAbout.Show();

        }
    }
}
