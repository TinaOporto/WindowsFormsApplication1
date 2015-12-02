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
    public partial class user : Form
    {
        private MySqlConnection connection;
        String ConnectionString = "Server=192.168.0.24;Database=inventory_items;Uid=tina;Pwd=!ojt2015;";
        public user()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            groupBox1.Visible = true;
            groupBox2.Visible = true;
            groupBox3.Visible = true;
        }



        private void textBox12_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtfname_Click(object sender, EventArgs e)
        {

        }



        private void button4_Click_1(object sender, EventArgs e)
        {
            connection = new MySqlConnection(ConnectionString);
            try
            {

                connection.Open();
                MySqlCommand cmd = new MySqlCommand("update users set uname = '" + txtuname.Text + "', pword = '" + txtpword.Text + "', email ='" + txtmail.Text + "', fname = '" + txtfname.Text + "', lname = '" + txtlname.Text + "', acct_type = '" + txtacc.Text + "' where uid = '" + txtuid.Text + "'", connection);
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

        private void button2_Click_1(object sender, EventArgs e)
        {
            connection = new MySqlConnection(ConnectionString);
            try
            {

                connection.Open();
                MySqlCommand cmd = new MySqlCommand("insert into users(uid, uname, pword, email, fname, lname, acct_type ) value('" + textBox1.Text + "', '" + textBox2.Text + "', '" + textBox3.Text + "', '" + textBox4.Text + "', '" + textBox5.Text + "', '" + textBox6.Text + "','" + textBox7.Text + "' )", connection);
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

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            connection = new MySqlConnection(ConnectionString);
            try
            {

                connection.Open();
                MySqlCommand cmd = new MySqlCommand("delete from users where uid = '" + txtdeluid.Text + "'", connection);
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

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        public Main UserForm { get; set; }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void LoadAllEmployee()
        {
            connection = new MySqlConnection(ConnectionString);
            dataGridView1.Rows.Clear();
            try
            {

                connection.Open();

                MySqlCommand cmd = new MySqlCommand("select * from users", connection);

                MySqlDataReader dataReader = cmd.ExecuteReader();

                while (dataReader.Read())
                {
                    dataGridView1.Rows.Add(dataReader["uid"] + "", dataReader["uname"] + "", dataReader["pword"] + "", dataReader["email"] + "", dataReader["fname"] + "", dataReader["lname"] + "", dataReader["acct_type"]);
                }

                connection.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void LoadAllUpdate()
        {
            connection = new MySqlConnection(ConnectionString);
            dataGridView2.Rows.Clear();
            try
            {

                connection.Open();

                MySqlCommand cmd = new MySqlCommand("select * from users", connection);

                MySqlDataReader dataReader = cmd.ExecuteReader();

                while (dataReader.Read())
                {
                    dataGridView2.Rows.Add(dataReader["uid"] + "", dataReader["uname"] + "", dataReader["pword"] + "", dataReader["email"] + "", dataReader["fname"] + "", dataReader["lname"] + "", dataReader["acct_type"]);
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

                MySqlCommand cmd = new MySqlCommand("select * from users", connection);

                MySqlDataReader dataReader = cmd.ExecuteReader();

                while (dataReader.Read())
                {
                    dataGridView3.Rows.Add(dataReader["uid"] + "", dataReader["uname"] + "", dataReader["pword"] + "", dataReader["email"] + "", dataReader["fname"] + "", dataReader["lname"] + "", dataReader["acct_type"]);
                }

                connection.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public Main CategoryForm { get; set; }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button10_Click(object sender, EventArgs e)
        {
            connection = new MySqlConnection(ConnectionString);
            try
            {

                connection.Open();
                MySqlCommand cmd = new MySqlCommand("insert into users(uid, uname, pword, email, fname, lname, acct_type ) value('" + txtid.Text + "', '" + txtadduname.Text + "', '" + txtaddpword.Text + "', '" + txtaddemail.Text + "', '" + txtaddfname.Text + "', '" + txtaddlname.Text + "','" + txtaddacct.Text + "' )", connection);
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

        private void button11_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
