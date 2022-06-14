using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using MoviesStore.Data;


namespace MoviesStore.Presentation
{
    public partial class ChangeMoviesForm : Form
    {
        private Movie currentMovie;

        public ChangeMoviesForm()
        {
            InitializeComponent();
        }

        private void ChangeMoviesForm_Load(object sender, EventArgs e)
        {
            List<Author> author ;
            List<Genre> genres ;

            using (MovieStoreContext moviesStoreContext = new MovieStoreContext())
            {
                author = moviesStoreContext.Authors.OrderBy(Author => Author.Id).ToList();
                genres = moviesStoreContext.Genres.OrderBy(genre => genre.Id).ToList();

                currentMovie = moviesStoreContext.Movies1.First();
            }

            authorsComboBox.ValueMember = "Id";
            authorsComboBox.DisplayMember = "Name";
            authorsComboBox.DataSource = genres;

            GenresComboBox.ValueMember = "Id";
            GenresComboBox.DisplayMember = "Name";
            GenresComboBox.DataSource = genres;

            PopulateControls();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            Movie movie = new Movie()
            {
                Name = nameTextBox.Text,
                Author = (int)authorsComboBox.SelectedValue,
                Genre = (int)GenresComboBox.SelectedValue,
                Price = (int)priceNumericUpDown.Value
            };


        }
        private void UpdateButton_Click(object sender, EventArgs e)
        {
            using (MovieStoreContext moviesStoreContext = new MovieStoreContext())
            {
                Movie oldMovie = moviesStoreContext.Movies1.Find(currentMovie.Id);

                Movie newMovie = new Movie()
                {
                    Id = currentMovie.Id,
                    Name = nameTextBox.Text,
                    Author = (int)authorsComboBox.SelectedValue,
                    Genre = (int)GenresComboBox.SelectedValue,
                    Price = (int)priceNumericUpDown.Value
                };

                moviesStoreContext.Entry(oldMovie).CurrentValues.SetValues(newMovie);
                moviesStoreContext.SaveChanges();
            }

            nextButton.PerformClick();
        }
        private void DeleteButton_Click(object sender, EventArgs e)
        {
            using (MovieStoreContext moviesStoreContext = new MovieStoreContext())
            {
                Movie movie = moviesStoreContext.Movies1.Find(currentMovie.Id);
                moviesStoreContext.Movies1.Remove(movie);
                moviesStoreContext.SaveChanges();
            }

            nextButton.PerformClick();
        }

        private void PrevButton_Click(object sender, EventArgs e)
        {
            nextButton.Enabled = true;

            using (MovieStoreContext moviesStoreContext = new MovieStoreContext())
            {
                List<Movie> prevMovies = moviesStoreContext.Movies1
                    .Where(movie => movie.Id < currentMovie.Id)
                    .OrderBy(car => car.Id)
                    .ToList();

                if (prevMovies.Count > 0)
                {
                    currentMovie = prevMovies.Last();
                    PopulateControls();
                }
                else
                {
                    prevButton.Enabled = false;
                }
            }
        }
        private void NextButton_Click(object sender, EventArgs e)
        {
            prevButton.Enabled = true;

            using (MovieStoreContext moviesStoreContext = new MovieStoreContext())
            {
                List<Movie> nextMovies = moviesStoreContext.Movies1
                    .Where(movie => movie.Id > currentMovie.Id)
                    .OrderBy(movie => movie.Id)
                    .ToList();

                if (nextMovies.Count > 0)
                {
                    currentMovie = nextMovies.First();
                    PopulateControls();
                }
                else
                {
                    nextButton.Enabled = false;
                }
            }
        }
        private void PopulateControls()
        {
            nameTextBox.Text = currentMovie.Name;
            priceNumericUpDown.Value = currentMovie.Price;
            authorsComboBox.SelectedValue = currentMovie.Author;
            GenresComboBox.SelectedValue = currentMovie.Genre;
        }

        private void AuthorsComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
