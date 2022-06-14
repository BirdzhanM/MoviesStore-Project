
namespace MoviesStore.Presentation
{
    partial class MenuForm
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
            this.usersGroupBox = new System.Windows.Forms.GroupBox();
            this.selectUsersButton = new System.Windows.Forms.Button();
            this.changeUsersButton = new System.Windows.Forms.Button();
            this.GenresGroupBox = new System.Windows.Forms.GroupBox();
            this.GenreButton = new System.Windows.Forms.Button();
            this.authorsGroupBox = new System.Windows.Forms.GroupBox();
            this.changeAuthorButton = new System.Windows.Forms.Button();
            this.moviesGroupBox = new System.Windows.Forms.GroupBox();
            this.selectMoviesButton = new System.Windows.Forms.Button();
            this.changeMoviesButton = new System.Windows.Forms.Button();
            this.usersGroupBox.SuspendLayout();
            this.GenresGroupBox.SuspendLayout();
            this.authorsGroupBox.SuspendLayout();
            this.moviesGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // usersGroupBox
            // 
            this.usersGroupBox.Controls.Add(this.selectUsersButton);
            this.usersGroupBox.Controls.Add(this.changeUsersButton);
            this.usersGroupBox.Font = new System.Drawing.Font("Arial", 10F);
            this.usersGroupBox.Location = new System.Drawing.Point(492, 12);
            this.usersGroupBox.Name = "usersGroupBox";
            this.usersGroupBox.Size = new System.Drawing.Size(125, 107);
            this.usersGroupBox.TabIndex = 13;
            this.usersGroupBox.TabStop = false;
            this.usersGroupBox.Text = "Users:";
            this.usersGroupBox.Visible = false;
            this.usersGroupBox.Enter += new System.EventHandler(this.UsersGroupBox_Enter);
            // 
            // selectUsersButton
            // 
            this.selectUsersButton.Location = new System.Drawing.Point(16, 20);
            this.selectUsersButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.selectUsersButton.Name = "selectUsersButton";
            this.selectUsersButton.Size = new System.Drawing.Size(87, 28);
            this.selectUsersButton.TabIndex = 4;
            this.selectUsersButton.Text = "View";
            this.selectUsersButton.UseVisualStyleBackColor = true;
            this.selectUsersButton.Click += new System.EventHandler(this.SelectUsersButton_Click);
            // 
            // changeUsersButton
            // 
            this.changeUsersButton.Location = new System.Drawing.Point(16, 58);
            this.changeUsersButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.changeUsersButton.Name = "changeUsersButton";
            this.changeUsersButton.Size = new System.Drawing.Size(87, 28);
            this.changeUsersButton.TabIndex = 5;
            this.changeUsersButton.Text = "Change";
            this.changeUsersButton.UseVisualStyleBackColor = true;
            this.changeUsersButton.Click += new System.EventHandler(this.ChangeUsersButton_Click);
            // 
            // GenresGroupBox
            // 
            this.GenresGroupBox.Controls.Add(this.GenreButton);
            this.GenresGroupBox.Font = new System.Drawing.Font("Arial", 10F);
            this.GenresGroupBox.Location = new System.Drawing.Point(332, 12);
            this.GenresGroupBox.Name = "GenresGroupBox";
            this.GenresGroupBox.Size = new System.Drawing.Size(125, 107);
            this.GenresGroupBox.TabIndex = 12;
            this.GenresGroupBox.TabStop = false;
            this.GenresGroupBox.Text = "Genres:";
            this.GenresGroupBox.Visible = false;
            this.GenresGroupBox.Enter += new System.EventHandler(this.GenresGroupBox_Enter);
            // 
            // GenreButton
            // 
            this.GenreButton.Location = new System.Drawing.Point(18, 42);
            this.GenreButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.GenreButton.Name = "GenreButton";
            this.GenreButton.Size = new System.Drawing.Size(87, 28);
            this.GenreButton.TabIndex = 3;
            this.GenreButton.Text = "Change";
            this.GenreButton.UseVisualStyleBackColor = true;
            this.GenreButton.Click += new System.EventHandler(this.GenreButton_Click);
            // 
            // authorsGroupBox
            // 
            this.authorsGroupBox.Controls.Add(this.changeAuthorButton);
            this.authorsGroupBox.Font = new System.Drawing.Font("Arial", 10F);
            this.authorsGroupBox.Location = new System.Drawing.Point(172, 12);
            this.authorsGroupBox.Name = "authorsGroupBox";
            this.authorsGroupBox.Size = new System.Drawing.Size(125, 107);
            this.authorsGroupBox.TabIndex = 11;
            this.authorsGroupBox.TabStop = false;
            this.authorsGroupBox.Text = "Author:";
            this.authorsGroupBox.Visible = false;
            this.authorsGroupBox.Enter += new System.EventHandler(this.AuthorsGroupBox_Enter);
            // 
            // changeAuthorButton
            // 
            this.changeAuthorButton.Location = new System.Drawing.Point(16, 39);
            this.changeAuthorButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.changeAuthorButton.Name = "changeAuthorButton";
            this.changeAuthorButton.Size = new System.Drawing.Size(87, 28);
            this.changeAuthorButton.TabIndex = 2;
            this.changeAuthorButton.Text = "Change";
            this.changeAuthorButton.UseVisualStyleBackColor = true;
            this.changeAuthorButton.Click += new System.EventHandler(this.ChangeAuthorButton_Click);
            // 
            // moviesGroupBox
            // 
            this.moviesGroupBox.Controls.Add(this.selectMoviesButton);
            this.moviesGroupBox.Controls.Add(this.changeMoviesButton);
            this.moviesGroupBox.Font = new System.Drawing.Font("Arial", 10F);
            this.moviesGroupBox.Location = new System.Drawing.Point(12, 12);
            this.moviesGroupBox.Name = "moviesGroupBox";
            this.moviesGroupBox.Size = new System.Drawing.Size(125, 107);
            this.moviesGroupBox.TabIndex = 10;
            this.moviesGroupBox.TabStop = false;
            this.moviesGroupBox.Text = "Movies";
            // 
            // selectMoviesButton
            // 
            this.selectMoviesButton.Location = new System.Drawing.Point(21, 22);
            this.selectMoviesButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.selectMoviesButton.Name = "selectMoviesButton";
            this.selectMoviesButton.Size = new System.Drawing.Size(87, 28);
            this.selectMoviesButton.TabIndex = 0;
            this.selectMoviesButton.Text = "View";
            this.selectMoviesButton.UseVisualStyleBackColor = true;
            this.selectMoviesButton.Click += new System.EventHandler(this.SelectMoviesButton_Click);
            // 
            // changeMoviesButton
            // 
            this.changeMoviesButton.Location = new System.Drawing.Point(21, 58);
            this.changeMoviesButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.changeMoviesButton.Name = "changeMoviesButton";
            this.changeMoviesButton.Size = new System.Drawing.Size(87, 28);
            this.changeMoviesButton.TabIndex = 1;
            this.changeMoviesButton.Text = "Change";
            this.changeMoviesButton.UseVisualStyleBackColor = true;
            this.changeMoviesButton.Click += new System.EventHandler(this.ChangeMoviesButton_Click);
            // 
            // MenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(630, 131);
            this.Controls.Add(this.usersGroupBox);
            this.Controls.Add(this.GenresGroupBox);
            this.Controls.Add(this.authorsGroupBox);
            this.Controls.Add(this.moviesGroupBox);
            this.Name = "MenuForm";
            this.Text = "MenuForm";
            this.Load += new System.EventHandler(this.MenuForm_Load);
            this.usersGroupBox.ResumeLayout(false);
            this.GenresGroupBox.ResumeLayout(false);
            this.authorsGroupBox.ResumeLayout(false);
            this.moviesGroupBox.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox usersGroupBox;
        private System.Windows.Forms.Button selectUsersButton;
        private System.Windows.Forms.Button changeUsersButton;
        private System.Windows.Forms.GroupBox GenresGroupBox;
        private System.Windows.Forms.Button GenreButton;
        private System.Windows.Forms.GroupBox authorsGroupBox;
        private System.Windows.Forms.Button changeAuthorButton;
        private System.Windows.Forms.GroupBox moviesGroupBox;
        private System.Windows.Forms.Button selectMoviesButton;
        private System.Windows.Forms.Button changeMoviesButton;
    }
}