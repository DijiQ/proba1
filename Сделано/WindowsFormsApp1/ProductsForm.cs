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

namespace WindowsFormsApp1
{
    public partial class ProductsForm : Form
    {
        public ProductsForm()
        {
            InitializeComponent();
            LoadProductData();
        }
        private void LoadProductData(string productFilter = "", bool sortByPrice = false, bool sortAscending = false)
        {
            using (SqlConnection sqlConnection = new SqlConnection(databaseConnectionString))
            {
                sqlConnection.Open();
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("SELECT * FROM Блюдо$", sqlConnection);
                DataTable productTable = new DataTable();
                sqlDataAdapter.Fill(productTable);

                // Фильтрация по названию продукта  
                if (!string.IsNullOrEmpty(productFilter))
                {
                    productTable.DefaultView.RowFilter = $"Название LIKE '%{productFilter}%'";
                }

                // Сортировка по цене  
                if (sortByPrice)
                {
                    if (sortAscending)
                    {
                        productTable.DefaultView.Sort = $"[Стоимость] ASC"; // Сортировка по возрастанию  
                    }
                    else
                    {
                        productTable.DefaultView.Sort = $"[Стоимость] DESC"; // Сортировка по убыванию  
                    }
                }

                // Подключаем таблицу к DataGridView  
                dataGridView1.DataSource = productTable;
            }
        }
        private void saveButton_Click(object sender, EventArgs e)
        {
            using (SqlConnection sqlConnection = new SqlConnection(databaseConnectionString))
            {
                sqlConnection.Open();
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("SELECT * FROM Блюдо$", sqlConnection);
                SqlCommandBuilder commandBuilder = new SqlCommandBuilder(sqlDataAdapter);
                DataTable productTable = (DataTable)dataGridView1.DataSource;

                sqlDataAdapter.Update(productTable);
                MessageBox.Show("Изменения сохранены", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void search_Button_Click(object sender, EventArgs e)
        {
            string searchKeyword = textBox1.Text.Trim();
            LoadProductData(searchKeyword);
        }

        private void close_Button_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void descending_Button_Click(object sender, EventArgs e)
        {
            string searchKeyword = textBox1.Text.Trim();
            bool sortByPrice = true; // Сортировать по цене  
            bool sortAscending = false; // По убыванию  

            LoadProductData(searchKeyword, sortByPrice, sortAscending);
        }

        private void ascending_Button_Click(object sender, EventArgs e)
        {
            string searchKeyword = textBox1.Text.Trim();
            bool sortByPrice = true; // Сортировать по цене  
            bool sortAscending = true; // По возрастанию  

            LoadProductData(searchKeyword, sortByPrice, sortAscending);
        }

        private void resetButton_Click(object sender, EventArgs e)
        {
            textBox1.Text = string.Empty;
            LoadProductData();
        }
    }
}
