
namespace WindowsFormsApp1
{
    partial class movie
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
            this.movieList = new System.Windows.Forms.ListBox();
            this.favoriteMovieList = new System.Windows.Forms.ListBox();
            this.searchMovieButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.searchMovie = new System.Windows.Forms.TextBox();
            this.favoriteButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // movieList
            // 
            this.movieList.FormattingEnabled = true;
            this.movieList.Location = new System.Drawing.Point(75, 35);
            this.movieList.Name = "movieList";
            this.movieList.Size = new System.Drawing.Size(157, 173);
            this.movieList.TabIndex = 0;
            this.movieList.SelectedIndexChanged += new System.EventHandler(this.movieList_SelectedIndexChanged);
            // 
            // favoriteMovieList
            // 
            this.favoriteMovieList.FormattingEnabled = true;
            this.favoriteMovieList.Location = new System.Drawing.Point(569, 35);
            this.favoriteMovieList.Name = "favoriteMovieList";
            this.favoriteMovieList.Size = new System.Drawing.Size(151, 186);
            this.favoriteMovieList.TabIndex = 1;
            // 
            // searchMovieButton
            // 
            this.searchMovieButton.Location = new System.Drawing.Point(262, 77);
            this.searchMovieButton.Name = "searchMovieButton";
            this.searchMovieButton.Size = new System.Drawing.Size(143, 23);
            this.searchMovieButton.TabIndex = 2;
            this.searchMovieButton.Text = "SEARCH";
            this.searchMovieButton.UseVisualStyleBackColor = true;
            this.searchMovieButton.Click += new System.EventHandler(this.searchMovieButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(259, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "SEARCH";
            // 
            // searchMovie
            // 
            this.searchMovie.Location = new System.Drawing.Point(262, 51);
            this.searchMovie.Name = "searchMovie";
            this.searchMovie.Size = new System.Drawing.Size(100, 20);
            this.searchMovie.TabIndex = 4;
            // 
            // favoriteButton
            // 
            this.favoriteButton.Location = new System.Drawing.Point(262, 165);
            this.favoriteButton.Name = "favoriteButton";
            this.favoriteButton.Size = new System.Drawing.Size(143, 23);
            this.favoriteButton.TabIndex = 5;
            this.favoriteButton.Text = "<-- Favorite -->";
            this.favoriteButton.UseVisualStyleBackColor = true;
            this.favoriteButton.Click += new System.EventHandler(this.favoriteButton_Click);
            // 
            // movie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.favoriteButton);
            this.Controls.Add(this.searchMovie);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.searchMovieButton);
            this.Controls.Add(this.favoriteMovieList);
            this.Controls.Add(this.movieList);
            this.Name = "movie";
            this.Text = "movie";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox movieList;
        private System.Windows.Forms.ListBox favoriteMovieList;
        private System.Windows.Forms.Button searchMovieButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox searchMovie;
        private System.Windows.Forms.Button favoriteButton;
    }
}