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
    public partial class Login : Form
    {
        private MySqlConnection connection;
        String ConnectionString = "Server=192.168.0.24;Database=inventory_items;Uid=tina;Pwd=!ojt2015;";
        public Login()
        {
            InitializeComponent();
        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void btncancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            /*MySqlConnection con = new MySqlConnection(@"Server=192.168.0.24;Database=inventory_items;Uid=tina;Pwd=!ojt2015;");
            MySqlDataAdapter sda = new MySqlDataAdapter("Select acct_type from users where uname  ='"+textBox1.Text+"' and pword ='"+txtpword.Text+"'", con);
            DataTable dt = new System.Data.DataTable();
            sda.Fill(dt);
            if(dt.Rows.Count ==1)
            {

            }
            else
            {

            }*/

            this.Hide();
            Main main = new Main();
            main.Show();


        }

        private void txtuname_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
