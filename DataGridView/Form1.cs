using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace DataGridView
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            LoadDB();
        }
        public void LoadDB()
        {
            string connectionString =
                "Server=LAPTOP-ARI;" +
                "Database=DataGridView;" +
                "User Id=sa;" +
                "Password=211488770;";
            using (SqlConnection connection = new SqlConnection(connectionString))

            {
                try
                {

                    connection.Open();

                    SqlDataAdapter adapter = new SqlDataAdapter($"SELECT * FROM Person", connection);

                    DataTable table = new DataTable();

                    adapter.Fill(table);
                    if (table.Rows.Count == 0) { MessageBox.Show("Table does not exist"); }
                    dataGridView1.DataSource = table;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(
                        "An error occurred: " + ex.Message,
                        "Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error,
                        MessageBoxDefaultButton.Button1,
                        MessageBoxOptions.RtlReading | MessageBoxOptions.RightAlign
                    );
                }
            }
        }
    }
}