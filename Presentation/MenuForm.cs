using System;
using System.Windows.Forms;
using MoviesStore.Common;
using MoviesStore.Data;

namespace MoviesStore.Presentation
{
    public partial class MenuForm : Form
    {
        public MenuForm()
        {
            InitializeComponent();
        }
        private void MenuForm_Load(object sender, EventArgs e)
        {
            User loggedUser = Registrator.LoggedUser;

            using (MovieStoreContext moviesStoreContext = new MovieStoreContext())
            {
                User foundUser = moviesStoreContext.Users.Find(loggedUser.Id);

                if (foundUser.Role1.Name == "Admin")
                {
                    authorsGroupBox.Visible = true;
                    GenresGroupBox.Visible = true;
                    usersGroupBox.Visible = true;
                }
                if (foundUser.Role1.Name == "Guest")
                {
                    authorsGroupBox.Visible = true;
                    GenresGroupBox.Visible = true;
                    usersGroupBox.Visible = false;
                }
            }
        }
        private void SelectMoviesButton_Click(object sender, EventArgs e)
        {
            SelectMoviesForm selectMovieForm = new SelectMoviesForm();
            selectMovieForm.Show();
        }

        private void ChangeMoviesButton_Click(object sender, EventArgs e)
        {
            ChangeMoviesForm changeMoviesForm = new ChangeMoviesForm();
            changeMoviesForm.Show();
        }

        private void AuthorsGroupBox_Enter(object sender, EventArgs e)
        {

        }

        private void ChangeAuthorButton_Click(object sender, EventArgs e)
        {
            ChangeAuthorsForm changeAuthorsForm = new ChangeAuthorsForm();
            changeAuthorsForm.Show();
        }

        private void GenresGroupBox_Enter(object sender, EventArgs e)
        {

        }

        private void GenreButton_Click(object sender, EventArgs e)
        {
            ChangeGenresFrom changeGenresForm = new ChangeGenresFrom();
            changeGenresForm.Show();
        }

        private void UsersGroupBox_Enter(object sender, EventArgs e)
        {

        }

        private void SelectUsersButton_Click(object sender, EventArgs e)
        {
            SelectUsersForm selectUsersForm = new SelectUsersForm();
            selectUsersForm.Show();
        }

            private void ChangeUsersButton_Click(object sender, EventArgs e)
        {
            ChangeUserForm changeUserForm = new ChangeUserForm();
            changeUserForm.Show();
        }

     

    }
}
