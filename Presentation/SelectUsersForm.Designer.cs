
namespace MoviesStore.Presentation
{
    partial class SelectUsersForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.filteredUsersListView = new System.Windows.Forms.ListView();
            this.firstNameColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lastNameColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.usernameColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.usersLabel = new System.Windows.Forms.Label();
            this.roleLabel = new System.Windows.Forms.Label();
            this.rolesComboBox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // filteredUsersListView
            // 
            this.filteredUsersListView.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.filteredUsersListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.firstNameColumnHeader,
            this.lastNameColumnHeader,
            this.usernameColumnHeader});
            this.filteredUsersListView.Font = new System.Drawing.Font("Arial", 10F);
            this.filteredUsersListView.GridLines = true;
            this.filteredUsersListView.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.filteredUsersListView.HideSelection = false;
            this.filteredUsersListView.Location = new System.Drawing.Point(12, 104);
            this.filteredUsersListView.MultiSelect = false;
            this.filteredUsersListView.Name = "filteredUsersListView";
            this.filteredUsersListView.ShowGroups = false;
            this.filteredUsersListView.Size = new System.Drawing.Size(407, 141);
            this.filteredUsersListView.TabIndex = 9;
            this.filteredUsersListView.UseCompatibleStateImageBehavior = false;
            this.filteredUsersListView.View = System.Windows.Forms.View.Details;
            // 
            // firstNameColumnHeader
            // 
            this.firstNameColumnHeader.Text = "First Name";
            this.firstNameColumnHeader.Width = 100;
            // 
            // lastNameColumnHeader
            // 
            this.lastNameColumnHeader.Text = "Last Name";
            this.lastNameColumnHeader.Width = 150;
            // 
            // usernameColumnHeader
            // 
            this.usernameColumnHeader.Text = "Username";
            this.usernameColumnHeader.Width = 150;
            // 
            // usersLabel
            // 
            this.usersLabel.AutoSize = true;
            this.usersLabel.Font = new System.Drawing.Font("Arial", 10F);
            this.usersLabel.Location = new System.Drawing.Point(12, 74);
            this.usersLabel.Name = "usersLabel";
            this.usersLabel.Size = new System.Drawing.Size(48, 16);
            this.usersLabel.TabIndex = 8;
            this.usersLabel.Text = "Users:";
            // 
            // roleLabel
            // 
            this.roleLabel.AutoSize = true;
            this.roleLabel.Font = new System.Drawing.Font("Arial", 10F);
            this.roleLabel.Location = new System.Drawing.Point(9, 14);
            this.roleLabel.Name = "roleLabel";
            this.roleLabel.Size = new System.Drawing.Size(41, 16);
            this.roleLabel.TabIndex = 7;
            this.roleLabel.Text = "Role:";
            // 
            // rolesComboBox
            // 
            this.rolesComboBox.Font = new System.Drawing.Font("Arial", 10F);
            this.rolesComboBox.FormattingEnabled = true;
            this.rolesComboBox.Location = new System.Drawing.Point(12, 33);
            this.rolesComboBox.Name = "rolesComboBox";
            this.rolesComboBox.Size = new System.Drawing.Size(173, 24);
            this.rolesComboBox.TabIndex = 6;
            this.rolesComboBox.SelectedIndexChanged += new System.EventHandler(this.RolesComboBox_SelectedIndexChanged);
            // 
            // SelectUsersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(429, 266);
            this.Controls.Add(this.filteredUsersListView);
            this.Controls.Add(this.usersLabel);
            this.Controls.Add(this.roleLabel);
            this.Controls.Add(this.rolesComboBox);
            this.Name = "SelectUsersForm";
            this.Text = "SelectUsersForm";
            this.Load += new System.EventHandler(this.SelectUsersForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView filteredUsersListView;
        private System.Windows.Forms.ColumnHeader firstNameColumnHeader;
        private System.Windows.Forms.ColumnHeader lastNameColumnHeader;
        private System.Windows.Forms.ColumnHeader usernameColumnHeader;
        private System.Windows.Forms.Label usersLabel;
        private System.Windows.Forms.Label roleLabel;
        private System.Windows.Forms.ComboBox rolesComboBox;
    }
}