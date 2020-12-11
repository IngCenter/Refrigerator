using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fridgerator
{
    public partial class Autarization : Form
    {
        public Autarization()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            string Logged = Program.Select("SELECT COUNT(*) From Users " + 
                $"WHERE Login = '{textBox1.Text}' AND Password = '{textBox2.Text}'")[0];

            string WrongPass = Program.Select("SELECT COUNT(*) From Users " +
                $"WHERE Login = '{textBox1.Text}'")[0];

            if (Logged != "0")
            {
                Program.CurrentUser = textBox1.Text;
                Close();
            }

            else if (WrongPass != "0")
                MessageBox.Show("Wrong password");

            else
                MessageBox.Show("This login is dead");
        }
    }
}
