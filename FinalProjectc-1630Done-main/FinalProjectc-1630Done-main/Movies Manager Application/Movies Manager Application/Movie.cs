using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Movies_Manager_Application
{
    public class Movie
    {
        public static string[] genreMap = { "Independent", "Animation", "Action", "Comedy", "Drama", "Horror", "Mystery", "Romance", "Science Fiction", "Western" };
        public int Id { get; private set; }
        public string Title { get; private set; }
        public uint Year { get; private set; }
        public string Director { get; private set; }
        public string Genre { get; private set; }
        public int RottenTomatoesScore { get; set; }
        public decimal TotalBoxOffice { get; set; }
        public int IndexGenre
        {
            get
            {
                for (int i = 0; i < genreMap.Length; i++)
                {
                    if (Genre == genreMap[i])
                        return i;
                }
                return -1;
            }
        }

        public Movie(int id, string title, uint year, string director, string genre, int score, decimal boxOffice)
        {
            this.Id = id;
            this.Title = title;
            this.Year = year;
            this.Director = director;
            this.Genre = genre;
            this.RottenTomatoesScore = score;
            this.TotalBoxOffice = boxOffice;
        }

        public Movie(string title, uint year, string director, string genre, int score, decimal boxOffice)
        {
            this.Title = title;
            this.Year = year;
            this.Director = director;
            this.Genre = genre;
            this.RottenTomatoesScore = score;
            this.TotalBoxOffice = boxOffice;
        }

        public Movie(string title, uint year, string director, string genre)
        {
            this.Title = title;
            this.Year = year;
            this.Director = director;
            this.Genre = genre;
            this.RottenTomatoesScore = -1;
            this.TotalBoxOffice = -1;
        }

        public Movie(int id, string title, uint year, string director, string genre)
        {
            this.Id = id;
            this.Title = title;
            this.Year = year;
            this.Director = director;
            this.Genre = genre;
            this.RottenTomatoesScore = -1;
            this.TotalBoxOffice = -1;
        }
        /// <summary>
        /// Inserts this instance of a movie to the database if it is not already there
        /// </summary>
        public bool InsertToDatabase()
        {
            //Check if the id is present in the db
            if (DatabaseManager.ExistsMovie(this))
                return false;
            SqlConnection conn = DatabaseManager.GetConnection();
            string query = $"Insert into Movies" +
                $" values ('{Title}', {Year}, '{Director}', {IndexGenre}";
            if (RottenTomatoesScore >= 0)
                query += $", {RottenTomatoesScore}";
            else
                query += ", null";
            if (TotalBoxOffice >= 0)
                query += $", {TotalBoxOffice}";
            else
                query += ", null";
            query += ");";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.ExecuteNonQuery();
            conn.Close();
            return true;
        }

        /// <summary>
        /// Looks at the database and stores the records in a list of movies
        /// </summary>
        /// <returns>A list with all the movies that are currently in our database</returns>
        public static List<Movie> GetMovies()
        {
            List<Movie> res = new List<Movie>();
            SqlConnection conn = DatabaseManager.GetConnection();
            string query = "Select * from Movies order by title";
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                Movie m;
                int id = reader.GetInt32(0);
                string t = reader.GetString(1);
                uint year = (uint)reader.GetInt32(2);
                string dir = reader.GetString(3);
                string genre = genreMap[reader.GetInt32(4)];
                try
                {
                    int score = reader.GetInt32(5);
                    decimal total = reader.GetDecimal(6);
                    m = new Movie(id, t, year, dir, genre, score, total);
                }
                catch (System.Data.SqlTypes.SqlNullValueException)
                {
                    m = new Movie(id, t, year, dir, genre);
                }
                res.Add(m);
            }
            conn.Close();
            return res;
        }


    }
}

