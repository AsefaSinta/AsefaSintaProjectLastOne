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
    public partial class UpdateMovie : Form
    {
        private List<Movie> movieList;
        //ConnectionString cs = new ConnectionString();
        public UpdateMovie()
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


        private void UpdateMovie_Load(object sender, EventArgs e)
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

        private void btnUpdate_Click(object sender, EventArgs e)
        {

            DialogResult res = MessageBox.Show("Are you sure you want to update '" + txtTitle.Text + "'s information?", "Confirmation", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            if (res == DialogResult.OK)
            {
                try
                {
                    Movie currMovie = movieList[moviesBox.SelectedIndex];
                    SqlConnection conn = DatabaseManager.GetConnection();
                    StringBuilder sb = new StringBuilder("Update Movies set ");
                    bool changed = txtDirector.Text != currMovie.Director || txtTitle.Text != currMovie.Title ||
                        txtYear.Text != currMovie.Year.ToString() || txtScore.Text != currMovie.RottenTomatoesScore.ToString()
                        || txtEarnings.Text != currMovie.TotalBoxOffice.ToString() || cboxGenre.SelectedIndex != currMovie.IndexGenre;
                    if (!changed)
                        throw new Exception("The movie's information remains the same, please change a field to update it in the database!");
                    if (txtDirector.Text != currMovie.Director)
                        sb.Append($"Director = '{txtDirector.Text}'");
                    if (txtTitle.Text != currMovie.Title)
                        sb.Append($"Title = '{txtTitle.Text}'");
                    if (txtYear.Text != currMovie.Year.ToString())
                        sb.Append($"Year = {txtYear.Text}");
                    if (txtScore.Text != currMovie.RottenTomatoesScore.ToString())
                        sb.Append($"RottenTomatoesScore = {txtScore.Text}");
                    if (txtEarnings.Text != currMovie.TotalBoxOffice.ToString())
                        sb.Append($"TotalEarned = {Convert.ToDecimal(txtEarnings.Text)}");
                    if (cboxGenre.SelectedIndex != currMovie.IndexGenre)
                        sb.Append($"Genre = {cboxGenre.SelectedIndex}");

                    sb.Append($" where Id = {currMovie.Id};");
                    SqlCommand cmd = new SqlCommand(sb.ToString(), conn);
                    if (cmd.ExecuteNonQuery() < 1)
                        throw new Exception("Movie not found, please refresh this page");
                    MessageBox.Show("Movie succesfully updated!");
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
            cboxGenre.SelectedIndex =-1;
            moviesBox.SelectedIndex = 1;
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
    }
}

