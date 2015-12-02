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
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            user a = new user();
            a.UserForm = this;
            a.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            CategoryForm cat = new CategoryForm();
            cat.Show();
        }

        private void btninfo_Click(object sender, EventArgs e)
        {
            this.Hide();
            ItemInfoForm iif = new ItemInfoForm();
            iif.Show();
        }

       
    }
}
