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

namespace DataGridView
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public void LoadDB(string name)
        {
            string connectionString =
                "Server=LAPTOP-ARI;" +
                "Database=DataGridView;" +
                "User Id=sa;" +
                "Password=211488770;";
            using (SqlConnection connection = new SqlConnection(connectionString));

        }
    }
}
