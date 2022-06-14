
namespace MoviesStore.Presentation
{
    partial class ChangeGenresFrom
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
            this.nextButton = new System.Windows.Forms.Button();
            this.prevButton = new System.Windows.Forms.Button();
            this.engineTypeLabel = new System.Windows.Forms.Label();
            this.updateButton = new System.Windows.Forms.Button();
            this.addButton = new System.Windows.Forms.Button();
            this.genresTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // nextButton
            // 
            this.nextButton.Font = new System.Drawing.Font("Arial", 10F);
            this.nextButton.Location = new System.Drawing.Point(199, 73);
            this.nextButton.Name = "nextButton";
            this.nextButton.Size = new System.Drawing.Size(39, 23);
            this.nextButton.TabIndex = 8;
            this.nextButton.Text = ">";
            this.nextButton.UseVisualStyleBackColor = true;
            this.nextButton.Click += new System.EventHandler(this.NextButton_Click);
            // 
            // prevButton
            // 
            this.prevButton.Font = new System.Drawing.Font("Arial", 10F);
            this.prevButton.Location = new System.Drawing.Point(31, 73);
            this.prevButton.Name = "prevButton";
            this.prevButton.Size = new System.Drawing.Size(39, 23);
            this.prevButton.TabIndex = 7;
            this.prevButton.Text = "<";
            this.prevButton.UseVisualStyleBackColor = true;
            this.prevButton.Click += new System.EventHandler(this.PrevButton_Click);
            // 
            // engineTypeLabel
            // 
            this.engineTypeLabel.AutoSize = true;
            this.engineTypeLabel.Font = new System.Drawing.Font("Arial", 10F);
            this.engineTypeLabel.Location = new System.Drawing.Point(28, 26);
            this.engineTypeLabel.Name = "engineTypeLabel";
            this.engineTypeLabel.Size = new System.Drawing.Size(113, 16);
            this.engineTypeLabel.TabIndex = 11;
            this.engineTypeLabel.Text = "Different Genres";
            // 
            // updateButton
            // 
            this.updateButton.Font = new System.Drawing.Font("Arial", 10F);
            this.updateButton.Location = new System.Drawing.Point(147, 102);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(91, 26);
            this.updateButton.TabIndex = 10;
            this.updateButton.Text = "Change";
            this.updateButton.UseVisualStyleBackColor = true;
            this.updateButton.Click += new System.EventHandler(this.UpdateButton_Click);
            // 
            // addButton
            // 
            this.addButton.Font = new System.Drawing.Font("Arial", 10F);
            this.addButton.Location = new System.Drawing.Point(31, 102);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(91, 26);
            this.addButton.TabIndex = 9;
            this.addButton.Text = "Add";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // genresTextBox
            // 
            this.genresTextBox.Font = new System.Drawing.Font("Arial", 10F);
            this.genresTextBox.Location = new System.Drawing.Point(31, 45);
            this.genresTextBox.Name = "genresTextBox";
            this.genresTextBox.Size = new System.Drawing.Size(207, 23);
            this.genresTextBox.TabIndex = 6;
            this.genresTextBox.TextChanged += new System.EventHandler(this.GenresTextBox_TextChanged);
            // 
            // ChangeGenresFrom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(288, 169);
            this.Controls.Add(this.nextButton);
            this.Controls.Add(this.prevButton);
            this.Controls.Add(this.engineTypeLabel);
            this.Controls.Add(this.updateButton);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.genresTextBox);
            this.Name = "ChangeGenresFrom";
            this.Text = "ChangeGenresFrom";
            this.Load += new System.EventHandler(this.ChangeGenresFrom_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button nextButton;
        private System.Windows.Forms.Button prevButton;
        private System.Windows.Forms.Label engineTypeLabel;
        private System.Windows.Forms.Button updateButton;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.TextBox genresTextBox;
    }
}