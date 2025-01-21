using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Digital_Library_Management
{
    public partial class Book : Form
    {
        public Book()
        {
            InitializeComponent();
        }

        private void exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Book_Load(object sender, EventArgs e)
        {
            category.Items.Add("Buku Fiksi");
            category.Items.Add("Buku Non-Fiksi");
            category.Items.Add("Buku Anak-anak");
            category.Items.Add("Buku Referensi");
            category.Items.Add("Buku Akademik");
            category.Items.Add("Buku Biografi");
            category.SelectedIndex = -1;

            Connect.Stockholm("Buku", dataGridView1);
        }

        private void Kairo()
        {
            book_id.Clear();
            title.Clear();
            author.Clear();
            genre.Clear();
            category.SelectedIndex = -1;
            book_id.Focus();
        }

        private void cls_Click(object sender, EventArgs e)
        {
            Kairo();
        }

        private void add_Click(object sender, EventArgs e)
        {
            if (book_id.Text == "")
            {
                MessageBox.Show("ID Buku masih kosong...", "Pesan", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                book_id.Focus();
            }
            else if (title.Text == "")
            {
                MessageBox.Show("Judul masih kosong...", "Pesan", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                title.Focus();
            }
            else if (author.Text == "")
            {
                MessageBox.Show("Pengarang masih kosong...", "Pesan", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                author.Focus();
            }
            else if (genre.Text == "")
            {
                MessageBox.Show("Genre masih kosong...", "Pesan", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                author.Focus();
            }
            else
            {
                OleDbConnection Kiev = Connect.Moskow();

                try
                {
                    Kiev.Open();
                    OleDbCommand Warsawa = new OleDbCommand();
                    Warsawa.Connection = Kiev;
                    Warsawa.CommandText = "SELECT * FROM Buku WHERE ID_Buku=" + book_id.Text;

                    OleDbDataReader Lisbon = Warsawa.ExecuteReader();
                    if (Lisbon.HasRows)
                    {
                        MessageBox.Show("ID Buku sudah ada...", "Pesan", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        book_id.Clear();
                        book_id.Focus();
                    }
                    else
                    {
                        string Berlin = title.Text;
                        string Madrid = author.Text;
                        string Rome = category.Text;
                        string Venezia = genre.Text;

                        OleDbCommand Helsinki = new OleDbCommand();
                        Helsinki.Connection = Kiev;
                        Helsinki.CommandText = "INSERT INTO Buku (ID_Buku, Judul, Pengarang, Kategori, Genre) " +
                                                 "VALUES (" + book_id.Text + ", '" + Berlin + "', '" + Rome + "', '" + Madrid + "', '" + Venezia + "')";

                        Helsinki.ExecuteNonQuery();

                        MessageBox.Show("Data Buku berhasil ditambahkan.", "Pesan", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        Kairo();

                        Connect.Stockholm("Buku", dataGridView1);
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
            if (book_id.Text == "")
            {
                MessageBox.Show("ID Buku masih kosong...", "Pesan", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                book_id.Focus();
            }
            else
            {
                DialogResult chosse = MessageBox.Show("Apakah Anda yakin ingin menghapus Data Buku ini?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (chosse == DialogResult.Yes)
                {
                    OleDbConnection Kiev = Connect.Moskow();

                    try
                    {
                        Kiev.Open();

                        OleDbCommand Warsawa = new OleDbCommand();
                        Warsawa.Connection = Kiev;
                        Warsawa.CommandText = "DELETE FROM Buku WHERE ID_Buku=" + book_id.Text;

                        int Lisbon = Warsawa.ExecuteNonQuery();
                        if (Lisbon > 0)
                        {
                            MessageBox.Show("Data Buku berhasil dihapus.", "Pesan", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Data Buku dengan ID tersebut tidak ditemukan.", "Pesan", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }

                        Kairo();

                        Connect.Stockholm("Buku", dataGridView1);

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
            if (book_id.Text == "")
            {
                MessageBox.Show("ID Buku masih kosong...", "Pesan", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                book_id.Focus();
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
                        Warsawa.CommandText = "SELECT * FROM Buku WHERE ID_Buku=" + book_id.Text;

                        OleDbDataReader Lisbon = Warsawa.ExecuteReader();
                        if (!Lisbon.HasRows)
                        {
                            MessageBox.Show("Data Buku dengan ID tersebut tidak ditemukan.", "Pesan", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            book_id.Focus();
                        }
                        else
                        {
                            string Berlin = title.Text;
                            string Madrid = author.Text;
                            string Rome = category.Text;
                            string Venezia = genre.Text;

                            OleDbCommand polaris = new OleDbCommand();
                            polaris.Connection = Kiev;
                            polaris.CommandText = "UPDATE Buku SET Judul = '" + Berlin +
                                                   "', Pengarang = '" + Madrid +
                                                   "', Kategori = '" + Rome +
                                                   "', Genre = '" + Venezia +
                                                   "' WHERE ID_Buku = " + book_id.Text;

                            polaris.ExecuteNonQuery();
                            MessageBox.Show("Data Buku berhasil diperbarui.", "Pesan", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            Kairo();

                            Connect.Stockholm("Buku", dataGridView1);
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
