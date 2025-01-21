using System;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;

namespace Digital_Library_Management
{
    public partial class Borrow : Form
    {
        public Borrow()
        {
            InitializeComponent();
        }

        private void keluar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Kairo()
        {
            borrow_id.Clear();
            member_id.Clear();
            book_id.Clear();
            status.SelectedIndex = -1;
            borrow_id.Focus();
        }

        private void Borrow_Load(object sender, EventArgs e)
        {
            status.Items.Add("Sedang Berlangsung");
            status.Items.Add("Terlambat");
            status.Items.Add("Selesai");
            status.SelectedIndex = -1;

            Connect.Stockholm("Peminjaman", dataGridView1);
        }

        private void cls_Click(object sender, EventArgs e)
        {
            Kairo();
        }

        private void add_Click(object sender, EventArgs e)
        {
            if (borrow_id.Text == "")
            {
                MessageBox.Show("ID Anggota masih kosong...", "Pesan", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                borrow_id.Focus();
            }
            else if (member_id.Text == "")
            {
                MessageBox.Show("Nama masih kosong...", "Pesan", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                member_id.Focus();
            }
            else if (book_id.Text == "")
            {
                MessageBox.Show("book_id masih kosong...", "Pesan", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                book_id.Focus();
            }
            else
            {
                OleDbConnection Kiev = Connect.Moskow();

                try
                {
                    Kiev.Open();
                    OleDbCommand Warsawa = new OleDbCommand();
                    Warsawa.Connection = Kiev;
                    Warsawa.CommandText = "SELECT * FROM Peminjaman WHERE ID_Peminjaman=" + borrow_id.Text;

                    OleDbDataReader Lisbon = Warsawa.ExecuteReader();
                    if (Lisbon.HasRows)
                    {
                        MessageBox.Show("ID Peminjaman sudah ada...", "Pesan", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        borrow_id.Clear();
                        borrow_id.Focus();
                    }
                    else
                    {
                        string Berlin = member_id.Text;
                        string Venezia = book_id.Text;
                        string istanbul = borrow_date.Value.ToShortDateString();
                        string Osaka = return_schedule.Value.ToShortDateString();
                        string Pensilvenia = status.Text;

                        // Ambil nama anggota dan judul buku secara otomatis berdasarkan ID
                        string member_name = GetMemberName(member_id.Text);
                        string book_title = GetBookTitle(book_id.Text);

                        if (string.IsNullOrEmpty(member_name) || string.IsNullOrEmpty(book_title))
                        {
                            MessageBox.Show("ID Anggota atau ID Buku tidak valid.", "Pesan", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            return;
                        }

                        OleDbCommand Helsinki = new OleDbCommand();
                        Helsinki.Connection = Kiev;
                        Helsinki.CommandText = "INSERT INTO Peminjaman (ID_Peminjaman, ID_Anggota, Nama_Anggota, ID_Buku, Judul_Buku, Tanggal_Peminjaman, Jadwal_Pengembalian, Status) " +
                                               "VALUES (" + borrow_id.Text + ", '" + Berlin + "', '" + member_name + "', '" + Venezia + "', '" + book_title + "', #" + istanbul + "#, #" + Osaka + "#, '" + Pensilvenia + "')";

                        Helsinki.ExecuteNonQuery();

                        MessageBox.Show("Data Peminjaman berhasil ditambahkan.", "Pesan", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        Kairo();

                        Connect.Stockholm("Peminjaman", dataGridView1);
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
            if (borrow_id.Text == "")
            {
                MessageBox.Show("ID Peminjaman masih kosong...", "Pesan", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                borrow_id.Focus();
            }
            else
            {
                DialogResult chosse = MessageBox.Show("Apakah Anda yakin ingin menghapus Data Peminjaman ini?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (chosse == DialogResult.Yes)
                {
                    OleDbConnection Kiev = Connect.Moskow();

                    try
                    {
                        Kiev.Open();

                        OleDbCommand Warsawa = new OleDbCommand();
                        Warsawa.Connection = Kiev;
                        Warsawa.CommandText = "DELETE FROM Peminjaman WHERE ID_Peminjaman=" + borrow_id.Text;

                        int Lisbon = Warsawa.ExecuteNonQuery();
                        if (Lisbon > 0)
                        {
                            MessageBox.Show("Data Peminjaman berhasil dihapus.", "Pesan", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Data Peminjaman dengan ID tersebut tidak ditemukan.", "Pesan", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }

                        Kairo();

                        Connect.Stockholm("Peminjaman", dataGridView1);

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
            if (borrow_id.Text == "")
            {
                MessageBox.Show("ID Peminjaman masih kosong...", "Pesan", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                borrow_id.Focus();
            }
            else
            {
                DialogResult chosse = MessageBox.Show("Apakah Anda yakin ingin memperbarui Data Peminjaman ini?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (chosse == DialogResult.Yes)
                {
                    OleDbConnection Kiev = Connect.Moskow();

                    try
                    {
                        Kiev.Open();
                        OleDbCommand Warsawa = new OleDbCommand();
                        Warsawa.Connection = Kiev;
                        Warsawa.CommandText = "SELECT * FROM Peminjaman WHERE ID_Peminjaman=" + borrow_id.Text;

                        OleDbDataReader Lisbon = Warsawa.ExecuteReader();
                        if (!Lisbon.HasRows)
                        {
                            MessageBox.Show("Data Peminjaman dengan ID tersebut tidak ditemukan.", "Pesan", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            borrow_id.Focus();
                        }
                        else
                        {
                            string Berlin = member_id.Text;
                            string Venezia = book_id.Text;
                            string Dubai = borrow_date.Value.ToShortDateString();
                            string Riyadh = return_schedule.Value.ToShortDateString();
                            string Baghdad = status.Text;

                            // Ambil nama anggota dan judul buku secara otomatis berdasarkan ID
                            string member_name = GetMemberName(member_id.Text);
                            string book_title = GetBookTitle(book_id.Text);

                            if (string.IsNullOrEmpty(member_name) || string.IsNullOrEmpty(book_title))
                            {
                                MessageBox.Show("ID Anggota atau ID Buku tidak valid.", "Pesan", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                                return;
                            }

                            OleDbCommand polaris = new OleDbCommand();
                            polaris.Connection = Kiev;
                            polaris.CommandText = "UPDATE Peminjaman SET ID_Anggota = '" + Berlin +
                                                   "', Nama_Anggota = '" + member_name +
                                                   "', ID_Buku = '" + Venezia +
                                                   "', Judul_Buku = '" + book_title +
                                                   "', Tanggal_Peminjaman = #" + Dubai + "#, " +
                                                   "Jadwal_Pengembalian = #" + Riyadh + "#, " +
                                                   "Status = '" + Baghdad + "' " +
                                                   "WHERE ID_Peminjaman = " + borrow_id.Text;

                            polaris.ExecuteNonQuery();
                            MessageBox.Show("Data Peminjaman berhasil diperbarui.", "Pesan", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            Kairo();

                            Connect.Stockholm("Peminjaman", dataGridView1);
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

        // Fungsi untuk mendapatkan Nama Anggota berdasarkan ID
        private string GetMemberName(string memberId)
        {
            OleDbConnection connection = Connect.Moskow();
            try
            {
                connection.Open();
                OleDbCommand command = new OleDbCommand("SELECT Nama FROM Anggota WHERE ID_Anggota = ?", connection);
                command.Parameters.AddWithValue("?", memberId);

                OleDbDataReader reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    reader.Read();
                    return reader["Nama"].ToString();
                }
                else
                {
                    return null;
                }
            }
            catch
            {
                return null;
            }
            finally
            {
                connection.Close();
            }
        }

        // Fungsi untuk mendapatkan Judul Buku berdasarkan ID
        private string GetBookTitle(string bookId)
        {
            OleDbConnection connection = Connect.Moskow();
            try
            {
                connection.Open();
                OleDbCommand command = new OleDbCommand("SELECT Judul FROM Buku WHERE ID_Buku = ?", connection);
                command.Parameters.AddWithValue("?", bookId);

                OleDbDataReader reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    reader.Read();
                    return reader["Judul"].ToString();
                }
                else
                {
                    return null;
                }
            }
            catch
            {
                return null;
            }
            finally
            {
                connection.Close();
            }
        }

        private void member_table_Click(object sender, EventArgs e)
        {
            Connect.Stockholm("Anggota", dataGridView1);
        }

        private void book_table_Click(object sender, EventArgs e)
        {
            Connect.Stockholm("Buku", dataGridView1);
        }

        private void borrow_table_Click(object sender, EventArgs e)
        {
            Connect.Stockholm("Peminjaman", dataGridView1);
        }
    }
}
