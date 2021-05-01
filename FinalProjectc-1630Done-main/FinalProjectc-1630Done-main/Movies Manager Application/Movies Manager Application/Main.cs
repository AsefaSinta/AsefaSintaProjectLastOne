using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Movies_Manager_Application;


namespace Movies_Manager_Application
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
            UpdateDataSource();
        }

        private void mnuRefreshPage_Click(object sender, EventArgs e)
        {
            if (UpdateDataSource())
                MessageBox.Show("The information has been updated succesfully", "Done!");
        }

       

        private void mnuAddMovie_Click(object sender, EventArgs e)
        {
            AddMovie form = new AddMovie();
            form.ShowDialog();
        }

        private void mnuUpdateMovie_Click(object sender, EventArgs e)
        {
            UpdateMovie form = new UpdateMovie();
            form.ShowDialog();
        }

        private void mnuDeleteMovie_Click(object sender, EventArgs e)
        {
            DeleteMovie form = new DeleteMovie();
            form.ShowDialog();
        }

        private void mnuAbout_Click(object sender, EventArgs e)
        {
            About form = new About();
            form.ShowDialog();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            //UpdateDataSource();
        }
        private bool UpdateDataSource()
        {
            //Getting the movies as a list
            try
            {
                List<Movie> movies = Movie.GetMovies();
                DataTable dTable = new DataTable();

                dTable.Columns.Add("Movie title");
                dTable.Columns.Add("Year");
                dTable.Columns.Add("Director");
                dTable.Columns.Add("Genre");
                dTable.Columns.Add("Rotten Tomatoes Score");
                dTable.Columns.Add("Total at the box office");

                foreach (var movie in movies)
                {
                    DataRow dr = dTable.NewRow();
                    dr["Movie title"] = movie.Title;
                    dr["Year"] = movie.Year;
                    dr["Director"] = movie.Director;
                    dr["Genre"] = movie.Genre;
                    dr["Rotten Tomatoes Score"] = movie.RottenTomatoesScore;
                    dr["Total at the box office"] = movie.TotalBoxOffice;
                    dTable.Rows.Add(dr);
                }

                dgvMovieList.DataSource = dTable;
                return true;
            }
            catch (Exception err)
            {
                MessageBox.Show("There was an error connecting to the database..", "Error!",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        private void dgvMovieList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void maintenanceToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void mnuExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
