
namespace MoviesStore.Presentation
{
    partial class ChangeUserForm
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
            this.usernameDataLabel = new System.Windows.Forms.Label();
            this.lastNameDataLabel = new System.Windows.Forms.Label();
            this.firstNameDataLabel = new System.Windows.Forms.Label();
            this.rolesComboBox = new System.Windows.Forms.ComboBox();
            this.deleteButton = new System.Windows.Forms.Button();
            this.updateButton = new System.Windows.Forms.Button();
            this.nextButton = new System.Windows.Forms.Button();
            this.prevButton = new System.Windows.Forms.Button();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.usernameLabel = new System.Windows.Forms.Label();
            this.lastNameLabel = new System.Windows.Forms.Label();
            this.firstNameLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // usernameDataLabel
            // 
            this.usernameDataLabel.AutoSize = true;
            this.usernameDataLabel.Font = new System.Drawing.Font("Arial", 10F);
            this.usernameDataLabel.Location = new System.Drawing.Point(169, 93);
            this.usernameDataLabel.Name = "usernameDataLabel";
            this.usernameDataLabel.Size = new System.Drawing.Size(0, 16);
            this.usernameDataLabel.TabIndex = 27;
            // 
            // lastNameDataLabel
            // 
            this.lastNameDataLabel.AutoSize = true;
            this.lastNameDataLabel.Font = new System.Drawing.Font("Arial", 10F);
            this.lastNameDataLabel.Location = new System.Drawing.Point(169, 63);
            this.lastNameDataLabel.Name = "lastNameDataLabel";
            this.lastNameDataLabel.Size = new System.Drawing.Size(0, 16);
            this.lastNameDataLabel.TabIndex = 26;
            // 
            // firstNameDataLabel
            // 
            this.firstNameDataLabel.AutoSize = true;
            this.firstNameDataLabel.Font = new System.Drawing.Font("Arial", 10F);
            this.firstNameDataLabel.Location = new System.Drawing.Point(169, 33);
            this.firstNameDataLabel.Name = "firstNameDataLabel";
            this.firstNameDataLabel.Size = new System.Drawing.Size(0, 16);
            this.firstNameDataLabel.TabIndex = 25;
            // 
            // rolesComboBox
            // 
            this.rolesComboBox.Font = new System.Drawing.Font("Arial", 10F);
            this.rolesComboBox.FormattingEnabled = true;
            this.rolesComboBox.Location = new System.Drawing.Point(75, 142);
            this.rolesComboBox.Name = "rolesComboBox";
            this.rolesComboBox.Size = new System.Drawing.Size(148, 24);
            this.rolesComboBox.TabIndex = 24;
            // 
            // deleteButton
            // 
            this.deleteButton.Font = new System.Drawing.Font("Arial", 10F);
            this.deleteButton.Location = new System.Drawing.Point(330, 80);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(113, 29);
            this.deleteButton.TabIndex = 17;
            this.deleteButton.Text = "Delete";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // updateButton
            // 
            this.updateButton.Font = new System.Drawing.Font("Arial", 10F);
            this.updateButton.Location = new System.Drawing.Point(330, 33);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(113, 29);
            this.updateButton.TabIndex = 16;
            this.updateButton.Text = "Change";
            this.updateButton.UseVisualStyleBackColor = true;
            this.updateButton.Click += new System.EventHandler(this.UpdateButton_Click);
            // 
            // nextButton
            // 
            this.nextButton.Font = new System.Drawing.Font("Arial", 10F);
            this.nextButton.Location = new System.Drawing.Point(413, 137);
            this.nextButton.Name = "nextButton";
            this.nextButton.Size = new System.Drawing.Size(30, 29);
            this.nextButton.TabIndex = 19;
            this.nextButton.Text = ">";
            this.nextButton.UseVisualStyleBackColor = true;
            this.nextButton.Click += new System.EventHandler(this.NextButton_Click);
            // 
            // prevButton
            // 
            this.prevButton.Font = new System.Drawing.Font("Arial", 10F);
            this.prevButton.Location = new System.Drawing.Point(330, 137);
            this.prevButton.Name = "prevButton";
            this.prevButton.Size = new System.Drawing.Size(30, 29);
            this.prevButton.TabIndex = 18;
            this.prevButton.Text = "<";
            this.prevButton.UseVisualStyleBackColor = true;
            this.prevButton.Click += new System.EventHandler(this.PrevButton_Click);
            // 
            // passwordLabel
            // 
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.Font = new System.Drawing.Font("Arial", 10F);
            this.passwordLabel.Location = new System.Drawing.Point(28, 145);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(41, 16);
            this.passwordLabel.TabIndex = 23;
            this.passwordLabel.Text = "Role:";
            // 
            // usernameLabel
            // 
            this.usernameLabel.AutoSize = true;
            this.usernameLabel.Font = new System.Drawing.Font("Arial", 10F);
            this.usernameLabel.Location = new System.Drawing.Point(28, 93);
            this.usernameLabel.Name = "usernameLabel";
            this.usernameLabel.Size = new System.Drawing.Size(76, 16);
            this.usernameLabel.TabIndex = 22;
            this.usernameLabel.Text = "Username:";
            // 
            // lastNameLabel
            // 
            this.lastNameLabel.AutoSize = true;
            this.lastNameLabel.Font = new System.Drawing.Font("Arial", 10F);
            this.lastNameLabel.Location = new System.Drawing.Point(28, 63);
            this.lastNameLabel.Name = "lastNameLabel";
            this.lastNameLabel.Size = new System.Drawing.Size(79, 16);
            this.lastNameLabel.TabIndex = 21;
            this.lastNameLabel.Text = "Last Name:";
            // 
            // firstNameLabel
            // 
            this.firstNameLabel.AutoSize = true;
            this.firstNameLabel.Font = new System.Drawing.Font("Arial", 10F);
            this.firstNameLabel.Location = new System.Drawing.Point(28, 33);
            this.firstNameLabel.Name = "firstNameLabel";
            this.firstNameLabel.Size = new System.Drawing.Size(48, 16);
            this.firstNameLabel.TabIndex = 20;
            this.firstNameLabel.Text = "Name:";
            // 
            // ChangeUserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(482, 242);
            this.Controls.Add(this.usernameDataLabel);
            this.Controls.Add(this.lastNameDataLabel);
            this.Controls.Add(this.firstNameDataLabel);
            this.Controls.Add(this.rolesComboBox);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.updateButton);
            this.Controls.Add(this.nextButton);
            this.Controls.Add(this.prevButton);
            this.Controls.Add(this.passwordLabel);
            this.Controls.Add(this.usernameLabel);
            this.Controls.Add(this.lastNameLabel);
            this.Controls.Add(this.firstNameLabel);
            this.Name = "ChangeUserForm";
            this.Text = "ChangeUserForm";
            this.Load += new System.EventHandler(this.ChangeUserForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label usernameDataLabel;
        private System.Windows.Forms.Label lastNameDataLabel;
        private System.Windows.Forms.Label firstNameDataLabel;
        private System.Windows.Forms.ComboBox rolesComboBox;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Button updateButton;
        private System.Windows.Forms.Button nextButton;
        private System.Windows.Forms.Button prevButton;
        private System.Windows.Forms.Label passwordLabel;
        private System.Windows.Forms.Label usernameLabel;
        private System.Windows.Forms.Label lastNameLabel;
        private System.Windows.Forms.Label firstNameLabel;
    }
}