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

namespace WindowsFormsApplication1
{
    public partial class CategoryForm : Form
    {
        private MySqlConnection connection;
        String ConnectionString = "Server=192.168.0.24;Database=inventory_items;Uid=tina;Pwd=!ojt2015;";
        public CategoryForm()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            connection = new MySqlConnection(ConnectionString);
            try
            {

                connection.Open();
                MySqlCommand cmd = new MySqlCommand("insert into item_cat(icid, cat_name, cat_description ) value('" + txticid.Text + "', '" + txtcatname.Text + "', '" + txtcatdes.Text + "')", connection);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Added Succesfully!");
                LoadAllEmployee();
               connection.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            connection = new MySqlConnection(ConnectionString);
            try
            {

                connection.Open();
                MySqlCommand cmd = new MySqlCommand("update item_cat set icid = '" + txtupicid.Text + "', cat_name = '" + txtupcatname.Text + "', cat_description ='" + txtupcatdes.Text + "' where icid = '" + txtupicid.Text + "'", connection);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Updated Succesfully!");
                LoadAllUpdate();
                connection.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btncancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btndelexit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btndel_Click(object sender, EventArgs e)
        {
            connection = new MySqlConnection(ConnectionString);
            try
            {

                connection.Open();
                MySqlCommand cmd = new MySqlCommand("delete from item_cat where icid = '" + txtdelicid.Text + "'", connection);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Deleted Succesfully!");
                LoadAllDelete();
                connection.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
              private void LoadAllEmployee()
        {
            connection = new MySqlConnection(ConnectionString);
            dataGridView1.Rows.Clear();
            try
            {

                connection.Open();

                MySqlCommand cmd = new MySqlCommand("select * from item_cat", connection);

                MySqlDataReader dataReader = cmd.ExecuteReader();

                while (dataReader.Read())
                {
                    dataGridView1.Rows.Add(dataReader["icid"] + "", dataReader["cat_name"] + "", dataReader["cat_description"] + "");
                }

                connection.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

              private void LoadAllUpdate()
              {
                  connection = new MySqlConnection(ConnectionString);
                  dataGridView2.Rows.Clear();
                  try
                  {

                      connection.Open();

                      MySqlCommand cmd = new MySqlCommand("select * from item_cat", connection);

                      MySqlDataReader dataReader = cmd.ExecuteReader();

                      while (dataReader.Read())
                      {
                          dataGridView2.Rows.Add(dataReader["icid"] + "", dataReader["cat_name"] + "", dataReader["cat_description"] + "");
                      }

                      connection.Close();

                  }
                  catch (Exception ex)
                  {
                      MessageBox.Show(ex.Message);
                  }
              }

                   private void LoadAllDelete()
        {
            connection = new MySqlConnection(ConnectionString);
            dataGridView3.Rows.Clear();
            try
            {

                connection.Open();

                MySqlCommand cmd = new MySqlCommand("select * from item_cat", connection);

                MySqlDataReader dataReader = cmd.ExecuteReader();

                while (dataReader.Read())
                {
                    dataGridView3.Rows.Add(dataReader["icid"] + "", dataReader["cat_name"] + "", dataReader["cat_description"] + "");
                }

                connection.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
