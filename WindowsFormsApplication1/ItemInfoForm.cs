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
    public partial class ItemInfoForm : Form
    {
        private MySqlConnection connection;
        String ConnectionString = "Server=192.168.0.24;Database=inventory_items;Uid=tina;Pwd=!ojt2015;";
       
        public ItemInfoForm()
        {
            InitializeComponent();
        }

        private void btncancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            connection = new MySqlConnection(ConnectionString);
            try
            {

                connection.Open();
                MySqlCommand cmd = new MySqlCommand("insert into item_info(iiid, item_name, item_serial, item_brand, item_color, item_descrip) value('" + txtiiid.Text + "', '" + txtitemname.Text + "', '" + txtitemserial.Text + "', '" + txtitembrand.Text + "', '" + txtitemcolor.Text + "', '" + txtitemdes.Text + "')", connection);
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
             private void LoadAllEmployee()
             {
            connection = new MySqlConnection(ConnectionString);
            dataGridView1.Rows.Clear();
            try
            {

                connection.Open();

                MySqlCommand cmd = new MySqlCommand("select * from item_info", connection);

                MySqlDataReader dataReader = cmd.ExecuteReader();

                while (dataReader.Read())
                {
                    dataGridView1.Rows.Add(dataReader["iiid"] + "", dataReader["item_name"] + "", dataReader["item_serial"] + "", dataReader["item_brand"] + "", dataReader["item_color"] + "", dataReader["item_descrip"] + "");
                }

                connection.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

             private void btnupdate_Click(object sender, EventArgs e)
             {
                 connection = new MySqlConnection(ConnectionString);
                 try
                 {

                     connection.Open();
                     MySqlCommand cmd = new MySqlCommand("update item_info set item_name = '" + txtupname.Text + "', item_serial ='" + txtupserial.Text + "', item_brand ='"+txtupbrand.Text+"', item_color='"+txtupcolor.Text+"', item_descrip='"+txtupitemdes.Text+"' where iiid = '" + txtupiiid.Text + "'", connection);
                     cmd.ExecuteNonQuery();
                     MessageBox.Show("Updated Succesfully!");
                     LoadAllUpdates();
                     connection.Close();

                 }
                 catch (Exception ex)
                 {
                     MessageBox.Show(ex.Message);
                 }

             }
             private void LoadAllUpdates()
             {
                 connection = new MySqlConnection(ConnectionString);
                 dataGridView2.Rows.Clear();
                 try
                 {

                     connection.Open();

                     MySqlCommand cmd = new MySqlCommand("select * from item_info", connection);

                     MySqlDataReader dataReader = cmd.ExecuteReader();

                     while (dataReader.Read())
                     {
                         dataGridView2.Rows.Add(dataReader["iiid"] + "", dataReader["item_name"] + "", dataReader["item_serial"] + "", dataReader["item_brand"] + "", dataReader["item_color"] + "", dataReader["item_descrip"] + "");
                     }

                     connection.Close();

                 }
                 catch (Exception ex)
                 {
                     MessageBox.Show(ex.Message);
                 }
             }

             private void textBox1_TextChanged(object sender, EventArgs e)
             {

             }

             private void button2_Click(object sender, EventArgs e)
             {
                 this.Close();
             }

             private void button3_Click(object sender, EventArgs e)
             {
                 this.Close();
             }

             private void button1_Click(object sender, EventArgs e)
             {
                 connection = new MySqlConnection(ConnectionString);
                 try
                 {

                     connection.Open();
                     MySqlCommand cmd = new MySqlCommand("delete from item_info where iiid = '" + txtdeliiid.Text + "'", connection);
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
             private void LoadAllDelete()
             {
                 connection = new MySqlConnection(ConnectionString);
                 dataGridView3.Rows.Clear();
                 try
                 {

                     connection.Open();

                     MySqlCommand cmd = new MySqlCommand("select * from item_info", connection);

                     MySqlDataReader dataReader = cmd.ExecuteReader();

                     while (dataReader.Read())
                     {
                         dataGridView3.Rows.Add(dataReader["iiid"] + "", dataReader["item_name"] + "", dataReader["item_serial"] + "", dataReader["item_brand"] + "", dataReader["item_color"] + "", dataReader["item_descrip"] + "");
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

