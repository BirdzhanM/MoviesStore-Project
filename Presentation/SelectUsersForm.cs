using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using MoviesStore.Data;

namespace MoviesStore.Presentation
{
    public partial class SelectUsersForm : Form
    {
        public SelectUsersForm()
        {
            InitializeComponent();
        }

        private void SelectUsersForm_Load(object sender, EventArgs e)
        {
            List<Role> roles;

            using (MovieStoreContext moviesStoreContext = new MovieStoreContext())
            {
                roles = moviesStoreContext.Roles.OrderBy(role => role.Id).ToList();
            }

            rolesComboBox.ValueMember = "Id";
            rolesComboBox.DisplayMember = "Name";
            rolesComboBox.DataSource = roles;
        }

        private void RolesComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            int roledId = (int)rolesComboBox.SelectedValue;

            using (MovieStoreContext moviesStoreContext = new MovieStoreContext())
            {
                List<User> filteredUsers = moviesStoreContext.Users.Where(user => user.Role == roledId).ToList();

                PopulateListView(filteredUsers);
            }

        }
        private void PopulateListView(List<User> users)
        {
            filteredUsersListView.Items.Clear();

            foreach (User user in users)
            {
                string[] rowData = new string[] { user.FirstName, user.LastName, user.UserName };
                ListViewItem item = new ListViewItem(rowData);
                filteredUsersListView.Items.Add(item);
            }
        }
    }
}
