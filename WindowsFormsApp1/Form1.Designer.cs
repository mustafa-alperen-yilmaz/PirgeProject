
namespace WindowsFormsApp1
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.channelListBox = new System.Windows.Forms.ListBox();
            this.newChannel = new System.Windows.Forms.TextBox();
            this.addButton = new System.Windows.Forms.Button();
            this.removeButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.changeButton = new System.Windows.Forms.Button();
            this.changeChannel = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.serachChannel = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.searchChannelButton = new System.Windows.Forms.Button();
            this.favoriteChannelListBox = new System.Windows.Forms.ListBox();
            this.makeFavoriteButton = new System.Windows.Forms.Button();
            this.removeFromFavoriteButton = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.downButton = new System.Windows.Forms.Button();
            this.upButton = new System.Windows.Forms.Button();
            this.soundOnButton = new System.Windows.Forms.Button();
            this.openButton = new System.Windows.Forms.Button();
            this.soundOfButton = new System.Windows.Forms.Button();
            this.movieButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // channelListBox
            // 
            this.channelListBox.FormattingEnabled = true;
            this.channelListBox.Location = new System.Drawing.Point(331, 29);
            this.channelListBox.Name = "channelListBox";
            this.channelListBox.Size = new System.Drawing.Size(142, 160);
            this.channelListBox.TabIndex = 0;
            // 
            // newChannel
            // 
            this.newChannel.Location = new System.Drawing.Point(15, 29);
            this.newChannel.Name = "newChannel";
            this.newChannel.Size = new System.Drawing.Size(127, 20);
            this.newChannel.TabIndex = 1;
            this.newChannel.TextChanged += new System.EventHandler(this.newChannel_TextChanged);
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(205, 27);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(94, 23);
            this.addButton.TabIndex = 2;
            this.addButton.Text = "ADD -->";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // removeButton
            // 
            this.removeButton.Location = new System.Drawing.Point(205, 87);
            this.removeButton.Name = "removeButton";
            this.removeButton.Size = new System.Drawing.Size(94, 23);
            this.removeButton.TabIndex = 3;
            this.removeButton.Text = "<-- REMOVE";
            this.removeButton.UseVisualStyleBackColor = true;
            this.removeButton.Click += new System.EventHandler(this.removeButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Write New Channel Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(150, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Delete The Selected Channel ";
            // 
            // changeButton
            // 
            this.changeButton.Location = new System.Drawing.Point(205, 166);
            this.changeButton.Name = "changeButton";
            this.changeButton.Size = new System.Drawing.Size(94, 23);
            this.changeButton.TabIndex = 6;
            this.changeButton.Text = "<-- CHANGE -->";
            this.changeButton.UseVisualStyleBackColor = true;
            this.changeButton.Click += new System.EventHandler(this.changeButton_Click);
            // 
            // changeChannel
            // 
            this.changeChannel.Location = new System.Drawing.Point(15, 169);
            this.changeChannel.Name = "changeChannel";
            this.changeChannel.Size = new System.Drawing.Size(127, 20);
            this.changeChannel.TabIndex = 7;
            this.changeChannel.TextChanged += new System.EventHandler(this.changeChannel_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 141);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(156, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Change The Selected Channel ";
            // 
            // serachChannel
            // 
            this.serachChannel.Location = new System.Drawing.Point(524, 29);
            this.serachChannel.Name = "serachChannel";
            this.serachChannel.Size = new System.Drawing.Size(127, 20);
            this.serachChannel.TabIndex = 9;
           
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(521, 13);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Search Channel";
            // 
            // searchChannelButton
            // 
            this.searchChannelButton.Location = new System.Drawing.Point(524, 55);
            this.searchChannelButton.Name = "searchChannelButton";
            this.searchChannelButton.Size = new System.Drawing.Size(94, 23);
            this.searchChannelButton.TabIndex = 11;
            this.searchChannelButton.Text = "SEARCH";
            this.searchChannelButton.UseVisualStyleBackColor = true;
            this.searchChannelButton.Click += new System.EventHandler(this.searchChannelButton_Click);
            // 
            // favoriteChannelListBox
            // 
            this.favoriteChannelListBox.FormattingEnabled = true;
            this.favoriteChannelListBox.Location = new System.Drawing.Point(695, 29);
            this.favoriteChannelListBox.Name = "favoriteChannelListBox";
            this.favoriteChannelListBox.Size = new System.Drawing.Size(160, 160);
            this.favoriteChannelListBox.TabIndex = 12;
            // 
            // makeFavoriteButton
            // 
            this.makeFavoriteButton.Location = new System.Drawing.Point(524, 131);
            this.makeFavoriteButton.Name = "makeFavoriteButton";
            this.makeFavoriteButton.Size = new System.Drawing.Size(127, 23);
            this.makeFavoriteButton.TabIndex = 13;
            this.makeFavoriteButton.Text = "<-- FAVORITE -->";
            this.makeFavoriteButton.UseVisualStyleBackColor = true;
            this.makeFavoriteButton.Click += new System.EventHandler(this.makeFavoriteButton_Click);
            // 
            // removeFromFavoriteButton
            // 
            this.removeFromFavoriteButton.Location = new System.Drawing.Point(879, 115);
            this.removeFromFavoriteButton.Name = "removeFromFavoriteButton";
            this.removeFromFavoriteButton.Size = new System.Drawing.Size(123, 64);
            this.removeFromFavoriteButton.TabIndex = 14;
            this.removeFromFavoriteButton.Text = "<-- REMOVE FROM FAVORITE";
            this.removeFromFavoriteButton.UseVisualStyleBackColor = true;
            this.removeFromFavoriteButton.Click += new System.EventHandler(this.removeFromFavoriteButton_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(94, 386);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "CONTROLLER";
            // 
            // downButton
            // 
            this.downButton.Location = new System.Drawing.Point(97, 516);
            this.downButton.Name = "downButton";
            this.downButton.Size = new System.Drawing.Size(94, 23);
            this.downButton.TabIndex = 17;
            this.downButton.Text = "↓";
            this.downButton.UseVisualStyleBackColor = true;
            this.downButton.Click += new System.EventHandler(this.downButton_Click);
            // 
            // upButton
            // 
            this.upButton.Location = new System.Drawing.Point(97, 431);
            this.upButton.Name = "upButton";
            this.upButton.Size = new System.Drawing.Size(94, 23);
            this.upButton.TabIndex = 18;
            this.upButton.Text = "^";
            this.upButton.UseVisualStyleBackColor = true;
            this.upButton.Click += new System.EventHandler(this.upButton_Click);
            // 
            // soundOnButton
            // 
            this.soundOnButton.Location = new System.Drawing.Point(15, 478);
            this.soundOnButton.Name = "soundOnButton";
            this.soundOnButton.Size = new System.Drawing.Size(94, 23);
            this.soundOnButton.TabIndex = 20;
            this.soundOnButton.Text = "Sound On";
            this.soundOnButton.UseVisualStyleBackColor = true;
            this.soundOnButton.Click += new System.EventHandler(this.soundOnButton_Click);
            // 
            // openButton
            // 
            this.openButton.Location = new System.Drawing.Point(28, 583);
            this.openButton.Name = "openButton";
            this.openButton.Size = new System.Drawing.Size(114, 38);
            this.openButton.TabIndex = 22;
            this.openButton.Text = "Open";
            this.openButton.UseVisualStyleBackColor = true;
            this.openButton.Click += new System.EventHandler(this.openButton_Click);
            // 
            // soundOfButton
            // 
            this.soundOfButton.Location = new System.Drawing.Point(178, 478);
            this.soundOfButton.Name = "soundOfButton";
            this.soundOfButton.Size = new System.Drawing.Size(94, 23);
            this.soundOfButton.TabIndex = 23;
            this.soundOfButton.Text = "Sound Off";
            this.soundOfButton.UseVisualStyleBackColor = true;
            this.soundOfButton.Click += new System.EventHandler(this.soundOfButton_Click);
            // 
            // movieButton
            // 
            this.movieButton.Location = new System.Drawing.Point(205, 583);
            this.movieButton.Name = "movieButton";
            this.movieButton.Size = new System.Drawing.Size(114, 38);
            this.movieButton.TabIndex = 24;
            this.movieButton.Text = "Movie";
            this.movieButton.UseVisualStyleBackColor = true;
            this.movieButton.Click += new System.EventHandler(this.movieButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1073, 644);
            this.Controls.Add(this.movieButton);
            this.Controls.Add(this.soundOfButton);
            this.Controls.Add(this.openButton);
            this.Controls.Add(this.soundOnButton);
            this.Controls.Add(this.upButton);
            this.Controls.Add(this.downButton);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.removeFromFavoriteButton);
            this.Controls.Add(this.makeFavoriteButton);
            this.Controls.Add(this.favoriteChannelListBox);
            this.Controls.Add(this.searchChannelButton);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.serachChannel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.changeChannel);
            this.Controls.Add(this.changeButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.removeButton);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.newChannel);
            this.Controls.Add(this.channelListBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox channelListBox;
        private System.Windows.Forms.TextBox newChannel;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button removeButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button changeButton;
        private System.Windows.Forms.TextBox changeChannel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox serachChannel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button searchChannelButton;
        private System.Windows.Forms.ListBox favoriteChannelListBox;
        private System.Windows.Forms.Button makeFavoriteButton;
        private System.Windows.Forms.Button removeFromFavoriteButton;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button downButton;
        private System.Windows.Forms.Button upButton;
        private System.Windows.Forms.Button soundOnButton;
        private System.Windows.Forms.Button openButton;
        private System.Windows.Forms.Button soundOfButton;
        private System.Windows.Forms.Button movieButton;
    }
}

