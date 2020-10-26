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
    public partial class Recipe : Form
    {
        public Recipe()
        {
            InitializeComponent();

            List<string> recipes = Program.Select("SELECT OutName FROM Recipes");

            for (int i = 0; i < recipes.Count; i = i + 1)
                comboRecipe.Items.Add(recipes[i]);
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            AddRecipe ar = new AddRecipe();
            ar.Show();
        }
    }
}
