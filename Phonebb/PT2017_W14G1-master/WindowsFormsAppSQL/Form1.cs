using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsAppSQL
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        MySqlConnection mySqlConnection;
        MySqlDataAdapter mySqlDataAdapter;
        MySqlCommandBuilder mySqlCommandBuilder;
        DataTable dataTable;
        BindingSource bindingSource;
       

        private void button1_Click(object sender, EventArgs e)
        {

            mySqlDataAdapter.Update(dataTable);
        }
        

        private void button2_Click(object sender, EventArgs e)
        {
            mySqlConnection = new MySqlConnection(
                "server=localhost;user id=root;database=phonebook;");

            mySqlConnection.Open();

            string query = "SELECT * FROM bookicheck ORDER BY DATE ";

            mySqlDataAdapter = new MySqlDataAdapter(query, mySqlConnection);
            mySqlCommandBuilder = new MySqlCommandBuilder(mySqlDataAdapter);

            mySqlDataAdapter.UpdateCommand = mySqlCommandBuilder.GetUpdateCommand();
            mySqlDataAdapter.DeleteCommand = mySqlCommandBuilder.GetDeleteCommand();
            mySqlDataAdapter.InsertCommand = mySqlCommandBuilder.GetInsertCommand();

            dataTable = new DataTable();
            mySqlDataAdapter.Fill(dataTable);

            bindingSource = new BindingSource();
            bindingSource.DataSource = dataTable;

            dataGridView1.DataSource = bindingSource;
            bindingNavigator1.BindingSource = bindingSource;
  

        }

        private void bindingNavigator1_RefreshItems(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Search_click(object sender, EventArgs e) //search
        {
            var Search = textBoxSearch.Text;
            mySqlConnection = new MySqlConnection(
                "server=localhost;user id=root;database=phonebook;");

            mySqlConnection.Open();

            var query = "SELECT * FROM bookicheck WHERE NAME LIKE '%" + Search + "%'";

            mySqlDataAdapter = new MySqlDataAdapter(query, mySqlConnection);
            mySqlCommandBuilder = new MySqlCommandBuilder(mySqlDataAdapter);

          
            dataTable = new DataTable();
            mySqlDataAdapter.Fill(dataTable);

            bindingSource = new BindingSource();
            bindingSource.DataSource = dataTable;

            dataGridView1.DataSource = bindingSource;
            bindingNavigator1.BindingSource = bindingSource;
        }

        private void Descbtn_click(object sender, EventArgs e)
        {
            mySqlConnection = new MySqlConnection(
                 "server=localhost;user id=root;database=phonebook;");

            mySqlConnection.Open();

            string query = "SELECT * FROM bookicheck ORDER BY DATE desc";

            mySqlDataAdapter = new MySqlDataAdapter(query, mySqlConnection);
            mySqlCommandBuilder = new MySqlCommandBuilder(mySqlDataAdapter);

            mySqlDataAdapter.UpdateCommand = mySqlCommandBuilder.GetUpdateCommand();
            mySqlDataAdapter.DeleteCommand = mySqlCommandBuilder.GetDeleteCommand();
            mySqlDataAdapter.InsertCommand = mySqlCommandBuilder.GetInsertCommand();

            dataTable = new DataTable();
            mySqlDataAdapter.Fill(dataTable);

            bindingSource = new BindingSource();
            bindingSource.DataSource = dataTable;

            dataGridView1.DataSource = bindingSource;
            bindingNavigator1.BindingSource = bindingSource;
        }

        private void bindingNavigatorPositionItem_Click(object sender, EventArgs e)
        {

        }



        private void button5_Click(object sender, EventArgs e)
        {
            /*for (int i=0; i<100; i++)
            {
                mySqlConnection = new MySqlConnection(
                "server=localhost;user id=root;database=phonebook;");

                mySqlConnection.Open();

                int c = 5 * i;
                string query = "SELECT * FROM bookicheck Limit , 5 ";
                mySqlDataAdapter = new MySqlDataAdapter(query, mySqlConnection);
                mySqlCommandBuilder = new MySqlCommandBuilder(mySqlDataAdapter);

                dataTable = new DataTable();
                mySqlDataAdapter.Fill(dataTable);

                bindingSource = new BindingSource();
                bindingSource.DataSource = dataTable;

                dataGridView1.DataSource = bindingSource;
                bindingNavigator1.BindingSource = bindingSource;
            }*/
            if ((int)numericUpDown1.Value == 1) { 


            mySqlConnection = new MySqlConnection(
                "server=localhost;user id=root;database=phonebook;");

            mySqlConnection.Open();


            string query = "SELECT * FROM bookicheck Limit 0, 5 ";
            mySqlDataAdapter = new MySqlDataAdapter(query, mySqlConnection);
            mySqlCommandBuilder = new MySqlCommandBuilder(mySqlDataAdapter);

            dataTable = new DataTable();
            mySqlDataAdapter.Fill(dataTable);

            bindingSource = new BindingSource();
            bindingSource.DataSource = dataTable;

            dataGridView1.DataSource = bindingSource;
            bindingNavigator1.BindingSource = bindingSource;

        }
            else if ((int)numericUpDown1.Value == 2)
            {
                mySqlConnection = new MySqlConnection(
    "server=localhost;user id=root;database=phonebook;");

                mySqlConnection.Open();


                string query = "SELECT * FROM bookicheck Limit 5, 5 ";
                mySqlDataAdapter = new MySqlDataAdapter(query, mySqlConnection);
                mySqlCommandBuilder = new MySqlCommandBuilder(mySqlDataAdapter);

                dataTable = new DataTable();
                mySqlDataAdapter.Fill(dataTable);

                bindingSource = new BindingSource();
                bindingSource.DataSource = dataTable;

                dataGridView1.DataSource = bindingSource;
                bindingNavigator1.BindingSource = bindingSource;
            }
            else if ((int)numericUpDown1.Value == 3)
            {
                mySqlConnection = new MySqlConnection(
    "server=localhost;user id=root;database=phonebook;");

                mySqlConnection.Open();


                string query = "SELECT * FROM bookicheck Limit 10, 5 ";
                mySqlDataAdapter = new MySqlDataAdapter(query, mySqlConnection);
                mySqlCommandBuilder = new MySqlCommandBuilder(mySqlDataAdapter);

                dataTable = new DataTable();
                mySqlDataAdapter.Fill(dataTable);

                bindingSource = new BindingSource();
                bindingSource.DataSource = dataTable;

                dataGridView1.DataSource = bindingSource;
                bindingNavigator1.BindingSource = bindingSource;
            }
            else if ((int)numericUpDown1.Value == 4)
            {
                mySqlConnection = new MySqlConnection(
    "server=localhost;user id=root;database=phonebook;");

                mySqlConnection.Open();


                string query = "SELECT * FROM bookicheck Limit 15, 5 ";
                mySqlDataAdapter = new MySqlDataAdapter(query, mySqlConnection);
                mySqlCommandBuilder = new MySqlCommandBuilder(mySqlDataAdapter);

                dataTable = new DataTable();
                mySqlDataAdapter.Fill(dataTable);

                bindingSource = new BindingSource();
                bindingSource.DataSource = dataTable;

                dataGridView1.DataSource = bindingSource;
                bindingNavigator1.BindingSource = bindingSource;
            }
            else if ((int)numericUpDown1.Value == 5)
            {
                mySqlConnection = new MySqlConnection(
    "server=localhost;user id=root;database=phonebook;");

                mySqlConnection.Open();


                string query = "SELECT * FROM bookicheck Limit 20, 5 ";
                mySqlDataAdapter = new MySqlDataAdapter(query, mySqlConnection);
                mySqlCommandBuilder = new MySqlCommandBuilder(mySqlDataAdapter);

                dataTable = new DataTable();
                mySqlDataAdapter.Fill(dataTable);

                bindingSource = new BindingSource();
                bindingSource.DataSource = dataTable;

                dataGridView1.DataSource = bindingSource;
                bindingNavigator1.BindingSource = bindingSource;
            }
            else if ((int)numericUpDown1.Value == 6)
            {
                mySqlConnection = new MySqlConnection(
    "server=localhost;user id=root;database=phonebook;");

                mySqlConnection.Open();


                string query = "SELECT * FROM bookicheck Limit 25, 5 ";
                mySqlDataAdapter = new MySqlDataAdapter(query, mySqlConnection);
                mySqlCommandBuilder = new MySqlCommandBuilder(mySqlDataAdapter);

                dataTable = new DataTable();
                mySqlDataAdapter.Fill(dataTable);

                bindingSource = new BindingSource();
                bindingSource.DataSource = dataTable;

                dataGridView1.DataSource = bindingSource;
                bindingNavigator1.BindingSource = bindingSource;
            }
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
          

        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {

        }

        private void textBoxSearch_TextChanged(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            var Search = textBoxSearch.Text;
            mySqlConnection = new MySqlConnection(
                "server=localhost;user id=root;database=phonebook;");

            mySqlConnection.Open();

            var query = "SELECT * FROM bookicheck WHERE ID LIKE '%" + Search + "%'";

            mySqlDataAdapter = new MySqlDataAdapter(query, mySqlConnection);
            mySqlCommandBuilder = new MySqlCommandBuilder(mySqlDataAdapter);


            dataTable = new DataTable();
            mySqlDataAdapter.Fill(dataTable);

            bindingSource = new BindingSource();
            bindingSource.DataSource = dataTable;

            dataGridView1.DataSource = bindingSource;
            bindingNavigator1.BindingSource = bindingSource;
        }
    }
}
