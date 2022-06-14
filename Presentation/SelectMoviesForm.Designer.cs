
namespace MoviesStore.Presentation
{
    partial class SelectMoviesForm
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
            this.combineFiltersButton = new System.Windows.Forms.Button();
            this.filteredMoviesListView = new System.Windows.Forms.ListView();
            this.authorColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.nameColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.genreColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.priceColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.genreLabel = new System.Windows.Forms.Label();
            this.genreTypesComboBox = new System.Windows.Forms.ComboBox();
            this.authorLabel = new System.Windows.Forms.Label();
            this.authorsComboBox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // combineFiltersButton
            // 
            this.combineFiltersButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.combineFiltersButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.combineFiltersButton.Location = new System.Drawing.Point(335, 16);
            this.combineFiltersButton.Name = "combineFiltersButton";
            this.combineFiltersButton.Size = new System.Drawing.Size(32, 32);
            this.combineFiltersButton.TabIndex = 11;
            this.combineFiltersButton.UseVisualStyleBackColor = true;
            this.combineFiltersButton.Click += new System.EventHandler(this.CombineFiltersButton_Click);
            // 
            // filteredMoviesListView
            // 
            this.filteredMoviesListView.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.filteredMoviesListView.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.filteredMoviesListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.authorColumnHeader,
            this.nameColumnHeader,
            this.genreColumnHeader,
            this.priceColumnHeader});
            this.filteredMoviesListView.GridLines = true;
            this.filteredMoviesListView.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.filteredMoviesListView.HideSelection = false;
            this.filteredMoviesListView.Location = new System.Drawing.Point(21, 53);
            this.filteredMoviesListView.MultiSelect = false;
            this.filteredMoviesListView.Name = "filteredMoviesListView";
            this.filteredMoviesListView.ShowGroups = false;
            this.filteredMoviesListView.Size = new System.Drawing.Size(665, 475);
            this.filteredMoviesListView.TabIndex = 10;
            this.filteredMoviesListView.UseCompatibleStateImageBehavior = false;
            this.filteredMoviesListView.View = System.Windows.Forms.View.Details;
            // 
            // authorColumnHeader
            // 
            this.authorColumnHeader.Text = "Author";
            this.authorColumnHeader.Width = 320;
            // 
            // nameColumnHeader
            // 
            this.nameColumnHeader.Text = "Name";
            this.nameColumnHeader.Width = 100;
            // 
            // genreColumnHeader
            // 
            this.genreColumnHeader.Text = "Genre";
            this.genreColumnHeader.Width = 100;
            // 
            // priceColumnHeader
            // 
            this.priceColumnHeader.Text = "Price";
            this.priceColumnHeader.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.priceColumnHeader.Width = 100;
            // 
            // genreLabel
            // 
            this.genreLabel.AutoSize = true;
            this.genreLabel.Location = new System.Drawing.Point(510, 5);
            this.genreLabel.Name = "genreLabel";
            this.genreLabel.Size = new System.Drawing.Size(39, 13);
            this.genreLabel.TabIndex = 9;
            this.genreLabel.Text = "Genre:";
            // 
            // genreTypesComboBox
            // 
            this.genreTypesComboBox.FormattingEnabled = true;
            this.genreTypesComboBox.Location = new System.Drawing.Point(431, 24);
            this.genreTypesComboBox.Name = "genreTypesComboBox";
            this.genreTypesComboBox.Size = new System.Drawing.Size(255, 21);
            this.genreTypesComboBox.TabIndex = 8;
            this.genreTypesComboBox.SelectedIndexChanged += new System.EventHandler(this.GenreTypesComboBox_SelectedIndexChanged);
            // 
            // authorLabel
            // 
            this.authorLabel.AutoSize = true;
            this.authorLabel.Location = new System.Drawing.Point(18, 5);
            this.authorLabel.Name = "authorLabel";
            this.authorLabel.Size = new System.Drawing.Size(41, 13);
            this.authorLabel.TabIndex = 7;
            this.authorLabel.Text = "Author:";
            // 
            // authorsComboBox
            // 
            this.authorsComboBox.FormattingEnabled = true;
            this.authorsComboBox.Location = new System.Drawing.Point(21, 24);
            this.authorsComboBox.Name = "authorsComboBox";
            this.authorsComboBox.Size = new System.Drawing.Size(259, 21);
            this.authorsComboBox.TabIndex = 6;
            this.authorsComboBox.SelectedIndexChanged += new System.EventHandler(this.AuthorsComboBox_SelectedIndexChanged);
            // 
            // SelectMoviesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(698, 540);
            this.Controls.Add(this.combineFiltersButton);
            this.Controls.Add(this.filteredMoviesListView);
            this.Controls.Add(this.genreLabel);
            this.Controls.Add(this.genreTypesComboBox);
            this.Controls.Add(this.authorLabel);
            this.Controls.Add(this.authorsComboBox);
            this.Name = "SelectMoviesForm";
            this.Text = "SelectMoviesForm";
            this.Load += new System.EventHandler(this.SelectMoviesForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button combineFiltersButton;
        private System.Windows.Forms.ListView filteredMoviesListView;
        private System.Windows.Forms.ColumnHeader authorColumnHeader;
        private System.Windows.Forms.ColumnHeader nameColumnHeader;
        private System.Windows.Forms.ColumnHeader genreColumnHeader;
        private System.Windows.Forms.ColumnHeader priceColumnHeader;
        private System.Windows.Forms.Label genreLabel;
        private System.Windows.Forms.ComboBox genreTypesComboBox;
        private System.Windows.Forms.Label authorLabel;
        private System.Windows.Forms.ComboBox authorsComboBox;
    }
}