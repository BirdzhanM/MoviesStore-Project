using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using MoviesStore.Data;

namespace MoviesStore.Presentation
{
    public partial class ChangeAuthorsForm : Form
    {
        private Author currentAuthors;
        public ChangeAuthorsForm()
        {
            InitializeComponent();
        }

        private void ChangeAuthorForm_Load(object sender, EventArgs e)
        {

            using (MovieStoreContext moviesStoreContext = new MovieStoreContext())
            {
                currentAuthors = moviesStoreContext.Authors
                    .OrderBy(author => author.Id)
                    .First();
            }

            authorTextBox.Text = currentAuthors.Name;
        }

        private void PrevButton_Click(object sender, EventArgs e)
        {
            nextButton.Enabled = true;

            using (MovieStoreContext moviesStoreContext = new MovieStoreContext())
            {
                List<Author> prevAuthors = moviesStoreContext.Authors
                    .Where(author => author.Id < currentAuthors.Id)
                    .OrderBy(author => author.Id)
                    .ToList();

                if (prevAuthors.Count > 0)
                {
                    currentAuthors = prevAuthors.Last();
                    authorTextBox.Text = currentAuthors.Name;
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
                List<Author> nextAuthors = moviesStoreContext.Authors
                    .Where(author => author.Id > currentAuthors.Id)
                    .OrderBy(author => author.Id)
                    .ToList();

                if (nextAuthors.Count > 0)
                {
                    currentAuthors = nextAuthors.First();
                    authorTextBox.Text = currentAuthors.Name;
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
                Author author = new Author()
                {
                    Name = authorTextBox.Text
                };

                moviesStoreContext.Authors.Add(author);
                moviesStoreContext.SaveChanges();
            }

            nextButton.PerformClick();
        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {
            using (MovieStoreContext moviesStoreContext = new MovieStoreContext())
            {
                Author oldAuthor = moviesStoreContext.Authors.Find(currentAuthors.Id);

                Author newAuthor = new Author()
                {
                    Id = currentAuthors.Id,
                    Name = authorTextBox.Text
                };

                moviesStoreContext.Entry(oldAuthor).CurrentValues.SetValues(newAuthor);
                moviesStoreContext.SaveChanges();
            }

            nextButton.PerformClick();


            
        }
    }
}
