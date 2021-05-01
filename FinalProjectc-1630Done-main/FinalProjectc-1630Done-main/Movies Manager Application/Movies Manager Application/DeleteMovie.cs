using Movies_Manager_Application;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Movies_Manager_Application
{
    public partial class DeleteMovie : Form
    {
        private List<Movie> movieList;
        //ConnectionString cs = new ConnectionString();
        public DeleteMovie()
        {
            InitializeComponent();
            LoadMovies();
        }

        private void LoadMovies()
        {
            movieList = Movie.GetMovies();
            //Put it into the combo box
            foreach (var movie in movieList)
                moviesBox.Items.Add(movie.Title);
        }

        

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Are you sure you want to Delete '" + txtTitle.Text + "' Movie", "Confirmation", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            if (res == DialogResult.OK)
            {
                try
                {
                    //delete from database
                    SqlConnection conn = DatabaseManager.GetConnection();
                    string query = $"Delete from Movies where Id = {movieList[moviesBox.SelectedIndex].Id}";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    if (cmd.ExecuteNonQuery() < 1)
                        throw new Exception("Movie not found, please refresh this page");
                    MessageBox.Show("Movie succesfully deleted!");
                    conn.Close();
                }
                catch (Exception err)
                {
                    MessageBox.Show(err.Message);
                }
            }
            if (res == DialogResult.Cancel)
            {
                txtTitle.Focus();
            }
        }
            

       

        private void btnClear_Click(object sender, EventArgs e)
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

        private void moviesBox_SelectedIndexChanged(object sender, EventArgs e)
        {

            Movie currMovie = movieList[moviesBox.SelectedIndex];

            txtTitle.Text = currMovie.Title;
            txtDirector.Text = currMovie.Director;
            txtYear.Text = currMovie.Year.ToString();
            cboxGenre.SelectedIndex = currMovie.IndexGenre;
            if (currMovie.TotalBoxOffice >= 0)
                txtEarnings.Text = currMovie.TotalBoxOffice.ToString();
            if (currMovie.RottenTomatoesScore >= 0)
                txtScore.Text = currMovie.RottenTomatoesScore.ToString();

       } 

        private void cboxGenre_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtTitle_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtYear_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtDirector_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtScore_TextChanged(object sender, EventArgs e)
        {

        }

        private void DeleteMovie_Load(object sender, EventArgs e)
        {
            cboxGenre.Items.Add("Independent");
            cboxGenre.Items.Add("Aninmation");
            cboxGenre.Items.Add("Action");
            cboxGenre.Items.Add("Comedy");
            cboxGenre.Items.Add("Drama");
            cboxGenre.Items.Add("Horror");
            cboxGenre.Items.Add("stery");
            cboxGenre.Items.Add("Romance");
            cboxGenre.Items.Add("Science Fiction");
            cboxGenre.Items.Add("Western");
        }
    }
}
