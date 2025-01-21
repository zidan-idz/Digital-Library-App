using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Digital_Library_Management
{
    public partial class Member : Form
    {
        public Member()
        {
            InitializeComponent();
        }

        private void exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Member_Load(object sender, EventArgs e)
        {
            gender.Items.Add("Laki-laki");
            gender.Items.Add("Perempuan");
            gender.SelectedIndex = -1;

            Connect.Stockholm("Anggota", dataGridView1);
        }

        private void Kairo()
        {
            member_id.Clear();
            username.Clear();
            address.Clear();
            telepon.Clear();
            gender.SelectedIndex = -1;
            member_id.Focus();
        }

        private void cls_Click(object sender, EventArgs e)
        {
            member_id.Clear();
            Kairo();
        }

        private void add_Click(object sender, EventArgs e)
        {
            if (member_id.Text == "")
            {
                MessageBox.Show("ID Anggota masih kosong...", "Pesan", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                member_id.Focus();
            }
            else if (username.Text == "")
            {
                MessageBox.Show("Nama masih kosong...", "Pesan", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                username.Focus();
            }
            else if (address.Text == "")
            {
                MessageBox.Show("Alamat masih kosong...", "Pesan", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                address.Focus();
            }
            else if (telepon.Text == "")
            {
                MessageBox.Show("Telepon masih kosong...", "Pesan", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                address.Focus();
            }
            else
            {
                OleDbConnection Kiev = Connect.Moskow();

                try
                {
                    Kiev.Open();
                    OleDbCommand Warsawa = new OleDbCommand();
                    Warsawa.Connection = Kiev;
                    Warsawa.CommandText = "SELECT * FROM Anggota WHERE ID_Anggota=" + member_id.Text;

                    OleDbDataReader Lisbon = Warsawa.ExecuteReader();
                    if (Lisbon.HasRows)
                    {
                        MessageBox.Show("ID Anggota sudah ada...", "Pesan", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        member_id.Clear();
                        member_id.Focus();
                    }
                    else
                    {
                        string Berlin = username.Text;
                        string Rome = gender.Text;
                        string Madrid = address.Text;
                        string Venezia = telepon.Text;

                        OleDbCommand Helsinki = new OleDbCommand();
                        Helsinki.Connection = Kiev;
                        Helsinki.CommandText = "INSERT INTO Anggota (ID_Anggota, Nama, Jenis_Kelamin, Alamat, Telepon) " +
                                                 "VALUES (" + member_id.Text + ", '" + Berlin + "', '" + Rome + "', '" + Madrid + "', '" + Venezia + "')";

                        Helsinki.ExecuteNonQuery();

                        MessageBox.Show("Data Anggota berhasil ditambahkan.", "Pesan", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        Kairo();

                        Connect.Stockholm("Anggota", dataGridView1);
                    }

                    Kiev.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Terjadi kesalahan: " + ex.Message, "Pesan", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void delete_Click(object sender, EventArgs e)
        {
            if (member_id.Text == "")
            {
                MessageBox.Show("ID Anggota masih kosong...", "Pesan", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                member_id.Focus();
            }
            else
            {
                DialogResult choose = MessageBox.Show("Apakah Anda yakin ingin menghapus Data Anggota ini?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (choose == DialogResult.Yes)
                {
                    OleDbConnection Kiev = Connect.Moskow();

                    try
                    {
                        Kiev.Open();

                        OleDbCommand Warsawa = new OleDbCommand();
                        Warsawa.Connection = Kiev;
                        Warsawa.CommandText = "DELETE FROM Anggota WHERE ID_Anggota=" + member_id.Text;

                        int Lisbon = Warsawa.ExecuteNonQuery();
                        if (Lisbon > 0)
                        {
                            MessageBox.Show("Data Anggota berhasil dihapus.", "Pesan", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Data Anggota dengan ID tersebut tidak ditemukan.", "Pesan", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }

                        Kairo();

                        Connect.Stockholm("Anggota", dataGridView1);

                        Kiev.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Terjadi kesalahan: " + ex.Message, "Pesan", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    return;
                }
            }
        }


        private void correct_Click(object sender, EventArgs e)
        {
            if (member_id.Text == "")
            {
                MessageBox.Show("ID Anggota masih kosong...", "Pesan", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                member_id.Focus();
            }
            else
            {
                DialogResult chosse = MessageBox.Show("Apakah Anda yakin ingin memperbarui Data Buku ini?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (chosse == DialogResult.Yes)
                {
                    OleDbConnection Kiev = Connect.Moskow();

                    try
                    {
                        Kiev.Open();
                        OleDbCommand Warsawa = new OleDbCommand();
                        Warsawa.Connection = Kiev;
                        Warsawa.CommandText = "SELECT * FROM Anggota WHERE ID_Anggota=" + member_id.Text;

                        OleDbDataReader Lisbon = Warsawa.ExecuteReader();
                        if (!Lisbon.HasRows)
                        {
                            MessageBox.Show("Data Anggota dengan ID tersebut tidak ditemukan.", "Pesan", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            member_id.Focus();
                        }
                        else
                        {
                            string Berlin = username.Text;
                            string Rome = gender.Text;
                            string Madrid = address.Text;
                            string Venezia = telepon.Text;

                            OleDbCommand polaris = new OleDbCommand();
                            polaris.Connection = Kiev;
                            polaris.CommandText = "UPDATE Anggota SET Nama = '" + Berlin +
                                                   "', Jenis_Kelamin = '" + Rome +
                                                   "', Alamat = '" + Madrid +
                                                   "', Telepon = '" + Venezia +
                                                   "' WHERE ID_Anggota = " + member_id.Text;

                            polaris.ExecuteNonQuery();
                            MessageBox.Show("Data Anggota berhasil diperbarui.", "Pesan", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            Kairo();

                            Connect.Stockholm("Anggota", dataGridView1);
                        }

                        Kiev.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Terjadi kesalahan: " + ex.Message, "Pesan", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    return;
                }
            }
        }


    }
}
