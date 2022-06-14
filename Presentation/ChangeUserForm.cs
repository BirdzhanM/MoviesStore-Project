using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using MoviesStore.Data;

namespace MoviesStore.Presentation
{
    public partial class ChangeUserForm : Form
    {
        private User currentUser;
        public ChangeUserForm()
        {
            InitializeComponent();
        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {
            using (MovieStoreContext moviesStoreContext = new MovieStoreContext())
            {
                User oldUser = moviesStoreContext.Users.Find(currentUser.Id);

                User newUser = new User()
                {
                    Id = currentUser.Id,
                    FirstName = firstNameDataLabel.Text,
                    LastName = lastNameDataLabel.Text,
                    UserName = usernameDataLabel.Text,
                    Pass = currentUser.Pass,
                    Role = (int)rolesComboBox.SelectedValue
                };

                moviesStoreContext.Entry(oldUser).CurrentValues.SetValues(newUser);
                moviesStoreContext.SaveChanges();
            }

            nextButton.PerformClick();
        }

        private void ChangeUserForm_Load(object sender, EventArgs e)
        {
            List<Role> roles;

            using (MovieStoreContext moviesStoreContext = new MovieStoreContext())
            {
                roles = moviesStoreContext.Roles.OrderBy(role => role.Id).ToList();
                currentUser = moviesStoreContext.Users.First();
            }

            rolesComboBox.ValueMember = "Id";
            rolesComboBox.DisplayMember = "Name";
            rolesComboBox.DataSource = roles;

            PopulateControls();
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            using (MovieStoreContext  moviesStoreContext = new MovieStoreContext())
            {
                User user = moviesStoreContext.Users.Find(currentUser.Id);
                moviesStoreContext.Users.Remove(user);
                moviesStoreContext.SaveChanges();
            }

            nextButton.PerformClick();
        }

        private void PrevButton_Click(object sender, EventArgs e)
        {
            nextButton.Enabled = true;

            using (MovieStoreContext moviesStoreContext = new MovieStoreContext())
            {
                List<User> prevUsers = moviesStoreContext.Users
                    .Where(user => user.Id < currentUser.Id)
                    .OrderBy(user => user.Id)
                    .ToList();

                if (prevUsers.Count > 0)
                {
                    currentUser = prevUsers.Last();
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
                List<User> nextUsers = moviesStoreContext.Users
                    .Where(user => user.Id > currentUser.Id)
                    .OrderBy(user => user.Id)
                    .ToList();

                if (nextUsers.Count > 0)
                {
                    currentUser = nextUsers.First();
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
            firstNameDataLabel.Text = currentUser.FirstName;
            lastNameDataLabel.Text = currentUser.LastName;
            usernameDataLabel.Text = currentUser.UserName;
            rolesComboBox.SelectedValue = currentUser.Role;
        }
    }
}
