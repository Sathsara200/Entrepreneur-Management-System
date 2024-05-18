using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Entrepreneur_Management_System
{
    public partial class Form2 : Form

    {
        private string connectionString = "Data Source=DESKTOP-J1972OJ\\SQLEXPRESS;Initial Catalog=\"Entrepreneur Management System\";Integrated Security=True;Encrypt=False";   // Replace with your actual connection string
        private DataTable dataTable;
        public Form2()
        {
            InitializeComponent();
            dataTable  = new DataTable();
            LoadData();
        }

       

        private void LoadData()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string sql = "SELECT * FROM Entrepreneur "; // Replace "YourTable" with your actual table name
                connection.Open();
                SqlCommand command = new SqlCommand(sql, connection);
                dataTable.Load(command.ExecuteReader());
                dataGridView1.DataSource = dataTable;
            }
        }


        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string searchText = textBox1.Text.ToLower();
            if (searchText != "")
            {
                DataView dataView = new DataView(dataTable);
                string filter = "([Name] LIKE '%" + searchText + "%') "; // Add more columns for filtering
                dataView.RowFilter = filter;
                dataGridView1.DataSource = dataView;
            }
            else
            {
                dataGridView1.DataSource = dataTable; // Reset to full data if search text is empty
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            string searchText = button6.Text.ToLower();
            if (searchText != "")
            {
                DataView dataView = new DataView(dataTable);
                string filter = "([Name] LIKE '%" + searchText + "%')  "; // Add more columns for filtering
                dataView.RowFilter = filter;
                dataGridView1.DataSource = dataView;
            }
            else
            {
                dataGridView1.DataSource = dataTable; // Reset to full data if search text is empty
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form3 frm1 = new Form3();
            frm1.Show();
            this.Close();
            
        }

        private void button7_Click(object sender, EventArgs e)
        {

        }
    }
}
