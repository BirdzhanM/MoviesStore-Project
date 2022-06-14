using System.Collections.Generic;
using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using MoviesStore.Data;
using MoviesStore.Properties;

namespace MoviesStore.Presentation
{
    public partial class SelectMoviesForm : Form
    {
        private string filter = "author";
        public SelectMoviesForm()
        {
            InitializeComponent();
        }

        private void SelectMoviesForm_Load(object sender, EventArgs e)
        {
            List<Author> authors;
            List<Genre> genres;

            using (MovieStoreContext carDealerContext = new MovieStoreContext())
            {
                authors = carDealerContext.Authors.OrderBy(author => author.Id).ToList();
                genres = carDealerContext.Genres.OrderBy(genre => genre.Id).ToList();
            }

            authorsComboBox.ValueMember = "Id";
            authorsComboBox.DisplayMember = "Name";
            authorsComboBox.DataSource = authors;

            genreTypesComboBox.ValueMember = "Id";
            genreTypesComboBox.DisplayMember = "Name";
            genreTypesComboBox.DataSource = genres;

            combineFiltersButton.BackgroundImage = filter == "author" || filter == "genre"
                ? Resources.unlocked
                : Resources.locked;
        }
        private void AuthorsComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (filter != "author & genre")
            {
                filter = "author";
            }

            ApplyFilters();
        }
        private void GenreTypesComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (filter != "author & genre")
            {
                filter = "genre";
            }

            ApplyFilters();
        }

        private void CombineFiltersButton_Click(object sender, EventArgs e)
        {
            if (filter == "author" || filter == "genre")
            {
                filter = "author & genre";
            }
            else
            {
                filter = "author";
            }

            combineFiltersButton.BackgroundImage = filter == "author" || filter == "genre"
                ? Resources.unlocked
                : Resources.locked;

            ApplyFilters();
        }
        private void ApplyFilters()
        {
            int authorId;
            int genreId;
            List<Movie> filteredMovie = null;

            using (MovieStoreContext moviesStoreContext = new MovieStoreContext())
            {
                if (filter == " & genre")
                {
                    authorId = (int)authorsComboBox.SelectedValue;
                    genreId = (int)genreTypesComboBox.SelectedValue;

                    filteredMovie = moviesStoreContext.Movies1
                        .Where(movie => movie.Author == authorId && movie.Genre == genreId)
                        .ToList();
                }
                else
                {
                    if (filter == "author")
                    {
                        authorId = (int)authorsComboBox.SelectedValue;

                        filteredMovie = moviesStoreContext.Movies1
                        .Where(movie => movie.Author == authorId)
                        .ToList();
                    }
                    else if (filter == "genre")
                    {
                        genreId = (int)genreTypesComboBox.SelectedValue;

                        filteredMovie = moviesStoreContext.Movies1
                        .Where(movie => movie.Genre == genreId)
                        .ToList();
                    }
                }

                PopulateListView(filteredMovie);
            }
        }

        private void PopulateListView(List<Movie> movies)
        {
            ImageList imageListSmall = new ImageList();
            imageListSmall.ImageSize = new Size(200, 100);

            filteredMoviesListView.Items.Clear();

            for (int index = 0; index < movies.Count; index++)
            {
                Movie movie = movies[index];

                string[] rowData = new string[]
                {
                    movie.Author1.Name,
                    movie.Name,
                    movie.Genre1.Name,
                    movie.Price.ToString() + " лв."
                };

                ListViewItem item = new ListViewItem(rowData);
                item.ImageIndex = index;
                filteredMoviesListView.Items.Add(item);

                Image image = Bitmap.FromFile($"..\\..\\Images\\{movie.Name}.jpg");
                imageListSmall.Images.Add(image);
            }

            filteredMoviesListView.SmallImageList = imageListSmall;
        }

    }
}
