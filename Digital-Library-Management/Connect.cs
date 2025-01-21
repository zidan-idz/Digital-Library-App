using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.OleDb;

namespace Digital_Library_Management
{
    internal class Connect
    {
        public static OleDbConnection Moskow()
        {
            string Shandong = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=LibraryDB.accdb";
            return new OleDbConnection(Shandong);
        }

        public static void Stockholm(string index, System.Windows.Forms.DataGridView dataGridView)
        {
            try
            {
                using (OleDbConnection Zurich = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=LibraryDB.accdb"))
                {
                    OleDbDataAdapter Karachi = new OleDbDataAdapter($"SELECT * FROM {index}", Zurich);
                    DataTable Beijing = new DataTable();
                    Karachi.Fill(Beijing);

                    dataGridView.DataSource = Beijing;
                }
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show("Error saat merefresh data: " + ex.Message);
            }
        }
    }
}
