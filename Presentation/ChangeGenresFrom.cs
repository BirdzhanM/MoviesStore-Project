using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using MoviesStore.Data;

namespace MoviesStore.Presentation
{
    public partial class ChangeGenresFrom : Form
    {
        private Genre currentGenre;
        public ChangeGenresFrom()
        {
            InitializeComponent();
        }

        private void ChangeGenresFrom_Load(object sender, EventArgs e)
        {
            using (MovieStoreContext moviesStoreContext = new MovieStoreContext())
            {
                currentGenre = moviesStoreContext.Genres
                    .OrderBy(Genre => Genre.Id)
                    .First();
            }

            genresTextBox.Text = currentGenre.Name;
        }


        private void PrevButton_Click(object sender, EventArgs e)
        {
            nextButton.Enabled = true;

            using (MovieStoreContext moviesStoreContext = new MovieStoreContext())
            {
                List<Genre> prevGenres = moviesStoreContext.Genres
                   .Where(genre => genre.Id < currentGenre.Id)
                    .OrderBy(genre => genre.Id)
                    .ToList();

                if (prevGenres.Count > 0)
                {
                    currentGenre = prevGenres.Last();
                    genresTextBox.Text = currentGenre.Name;
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
                List<Genre> nextGenres = moviesStoreContext.Genres
                    .Where(genre => genre.Id > currentGenre.Id)
                    .OrderBy(genre => genre.Id)
                    .ToList();

                if (nextGenres.Count > 0)
                {
                    currentGenre = nextGenres.First();
                    genresTextBox.Text = currentGenre.Name;
                }
                else
                {
                    nextButton.Enabled = false;
                }
            }
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            using (MovieStoreContext moviesStoreContext = new MovieStoreContext())
            {
                Genre genre = new Genre()
                {
                    Name = genresTextBox.Text
                };

                moviesStoreContext.Genres.Add(genre);
                moviesStoreContext.SaveChanges();
            }

            nextButton.PerformClick();
        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {
            using (MovieStoreContext moviesStoreContext = new MovieStoreContext())
            {
                Genre oldGenre = moviesStoreContext.Genres.Find(currentGenre.Id);

                Genre newGenre = new Genre()
                {
                    Id = currentGenre.Id,
                    Name = genresTextBox.Text
                };

               moviesStoreContext.Entry(oldGenre).CurrentValues.SetValues(newGenre);
               moviesStoreContext.SaveChanges();
            }

            nextButton.PerformClick();
        }

        private void GenresTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
