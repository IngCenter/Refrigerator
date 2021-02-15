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

        private void CookButton_Click(object sender, EventArgs e)
        {
            List<string> products = Program.Select("SELECT `Type`, `Count`, `Unit` FROM Products WHERE DATEDIFF(CURDATE(), DateBegin) < LifeTime");

            if(products[0] == "12345678765432")
                Program.Insert($"INSERT INTO `RecipesHistory` (`Recipe`, `Portions`, `CookDate`) VALUES (`{comboRecipe.Text}`, {1}, STR_TO_DATE({DateTime.Today.ToShortDateString()}, %d.%m.%y))");
        }

        private void AddRecipeButton_Click(object sender, EventArgs e)
        {
            AddRecipe ar = new AddRecipe();
            ar.Show();
        }

        private void ComboRecipe_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateDataGridView();

            List<string> products = Program.Select("SELECT `Type`, `Count`, `Unit` FROM Products ");// + 
                                                                                                    //"WHERE DATEDIFF(CURDATE(), DateBegin) < LifeTime");

            cookButton.Enabled = false;
        }

        private void UpdateDataGridView()
        {
            dataGridView1.Rows.Clear();

            List<string> contents = Program.Select($"SELECT `Product`, `Count`, `Unit` FROM RecipesContents WHERE RecipeName = '{comboRecipe.Text}'");

            for (int i = 0; i < contents.Count; i += 3)
            {
                string[] row = new string[3];

                row[0] = contents[i];
                row[1] = contents[i + 1];
                row[2] = contents[i + 2];

                dataGridView1.Rows.Add(row);
            }
        }

        private void Recipe_Load(object sender, EventArgs e)
        {

        }
    }
}
