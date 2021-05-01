using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Movies_Manager_Application
{
    public partial class AddMovie : Form
    {
        public AddMovie()
        {
            InitializeComponent();
        }

        

        private void btnAdd_Click(object sender, EventArgs e)
        {
            //Validate information
            try
            {
                //Create the movie obj
                Movie m;
                string title = txtTitle.Text;
                string dir = txtDirector.Text;
                uint year = Convert.ToUInt32(txtYear.Text);
                string genre = Movie.genreMap[cboxGenre.SelectedIndex];
                if (txtTitle.Text.Length > 50 || txtDirector.Text.Length > 50)
                    throw new Exception("The name of either the title or the director must be less than 50 characters!");

                m = new Movie(title, year, dir, genre);

                m.RottenTomatoesScore = txtScore.Text != "" ? Convert.ToInt32(txtScore.Text) : -1;
                m.TotalBoxOffice = txtEarnings.Text != "" ? Convert.ToInt32(txtEarnings.Text) : -1;

                m.InsertToDatabase();
                MessageBox.Show("New Movie Submitted!");
                Clear();
                /*------textbox clearance---*/
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
        }
                      

      

        private void btnClear_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void Clear()
        {
            txtTitle.Clear();
            txtDirector.Clear();
            txtEarnings.Clear();
            txtScore.Clear();
            txtYear.Clear();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cboxGenre_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void AddMovie_Load(object sender, EventArgs e)
        {
            cboxGenre.Items.Add("Independent");
            cboxGenre.Items.Add("Aninmation");
            cboxGenre.Items.Add("Action");
            cboxGenre.Items.Add("Comedy");
            cboxGenre.Items.Add("Drama");
            cboxGenre.Items.Add("Horror");
            cboxGenre.Items.Add("Mystery");
            cboxGenre.Items.Add("Romance");
            cboxGenre.Items.Add("Science Fiction");
            cboxGenre.Items.Add("Western");
        }
    }
}

