using System.ComponentModel;

namespace MMDABrowser {
	partial class UserPage {
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing) {
			if (disposing && (components != null)) {
				components.Dispose();
			}

			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent() {
			this.label_username = new System.Windows.Forms.Label();
			this.label_joindate = new System.Windows.Forms.Label();
			this.label_rank = new System.Windows.Forms.Label();
			this.label_posts = new System.Windows.Forms.Label();
			this.label_favorites = new System.Windows.Forms.Label();
			this.label_comments = new System.Windows.Forms.Label();
			this.label_tagedits = new System.Windows.Forms.Label();
			this.label_forumposts = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// label_username
			// 
			this.label_username.Font = new System.Drawing.Font("Segoe UI", 16F);
			this.label_username.Location = new System.Drawing.Point(13, 9);
			this.label_username.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label_username.Name = "label_username";
			this.label_username.Size = new System.Drawing.Size(906, 35);
			this.label_username.TabIndex = 0;
			this.label_username.Text = "Username";
			// 
			// label_joindate
			// 
			this.label_joindate.Font = new System.Drawing.Font("Segoe UI", 16F);
			this.label_joindate.Location = new System.Drawing.Point(13, 44);
			this.label_joindate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label_joindate.Name = "label_joindate";
			this.label_joindate.Size = new System.Drawing.Size(906, 35);
			this.label_joindate.TabIndex = 1;
			this.label_joindate.Text = "JoinDate";
			// 
			// label_rank
			// 
			this.label_rank.Font = new System.Drawing.Font("Segoe UI", 16F);
			this.label_rank.Location = new System.Drawing.Point(13, 78);
			this.label_rank.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label_rank.Name = "label_rank";
			this.label_rank.Size = new System.Drawing.Size(906, 35);
			this.label_rank.TabIndex = 2;
			this.label_rank.Text = "Rank";
			// 
			// label_posts
			// 
			this.label_posts.Font = new System.Drawing.Font("Segoe UI", 16F);
			this.label_posts.Location = new System.Drawing.Point(13, 114);
			this.label_posts.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label_posts.Name = "label_posts";
			this.label_posts.Size = new System.Drawing.Size(906, 35);
			this.label_posts.TabIndex = 3;
			this.label_posts.Text = "Posts";
			// 
			// label_favorites
			// 
			this.label_favorites.Font = new System.Drawing.Font("Segoe UI", 16F);
			this.label_favorites.Location = new System.Drawing.Point(13, 149);
			this.label_favorites.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label_favorites.Name = "label_favorites";
			this.label_favorites.Size = new System.Drawing.Size(906, 35);
			this.label_favorites.TabIndex = 4;
			this.label_favorites.Text = "Favorites";
			// 
			// label_comments
			// 
			this.label_comments.Font = new System.Drawing.Font("Segoe UI", 16F);
			this.label_comments.Location = new System.Drawing.Point(13, 183);
			this.label_comments.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label_comments.Name = "label_comments";
			this.label_comments.Size = new System.Drawing.Size(906, 35);
			this.label_comments.TabIndex = 5;
			this.label_comments.Text = "Comments";
			// 
			// label_tagedits
			// 
			this.label_tagedits.Font = new System.Drawing.Font("Segoe UI", 16F);
			this.label_tagedits.Location = new System.Drawing.Point(13, 219);
			this.label_tagedits.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label_tagedits.Name = "label_tagedits";
			this.label_tagedits.Size = new System.Drawing.Size(906, 35);
			this.label_tagedits.TabIndex = 6;
			this.label_tagedits.Text = "Tag Edits";
			// 
			// label_forumposts
			// 
			this.label_forumposts.Font = new System.Drawing.Font("Segoe UI", 16F);
			this.label_forumposts.Location = new System.Drawing.Point(13, 254);
			this.label_forumposts.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label_forumposts.Name = "label_forumposts";
			this.label_forumposts.Size = new System.Drawing.Size(906, 35);
			this.label_forumposts.TabIndex = 7;
			this.label_forumposts.Text = "Forum Posts";
			// 
			// UserPage
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(933, 519);
			this.Controls.Add(this.label_forumposts);
			this.Controls.Add(this.label_tagedits);
			this.Controls.Add(this.label_comments);
			this.Controls.Add(this.label_favorites);
			this.Controls.Add(this.label_posts);
			this.Controls.Add(this.label_rank);
			this.Controls.Add(this.label_joindate);
			this.Controls.Add(this.label_username);
			this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.Name = "UserPage";
			this.Text = "UserPage";
			this.ResumeLayout(false);
		}

		#endregion

		public void Load(UserStruct data) {
			this.label_username.Text = string.IsNullOrEmpty(data.Name) ? "Username: n/a" : data.Name;
			this.label_joindate.Text = string.IsNullOrEmpty(data.JoinDate) ? "Join Date: n/a" : data.JoinDate;
			this.label_rank.Text = string.IsNullOrEmpty(data.Level) ? "Rank: n/a" : data.Level;
			this.label_posts.Text = data.Posts.ToString();
			this.label_favorites.Text = data.Favorites.ToString();
			this.label_comments.Text = data.Comments.ToString();
			this.label_tagedits.Text = data.TagEdits.ToString();
			this.label_forumposts.Text = data.ForumPosts.ToString();
		}

		private System.Windows.Forms.Label label_username;
		private System.Windows.Forms.Label label_rank;
		private System.Windows.Forms.Label label_joindate;
		private System.Windows.Forms.Label label_posts;
		private System.Windows.Forms.Label label_favorites;
		private System.Windows.Forms.Label label_comments;
		private System.Windows.Forms.Label label_tagedits;
		private System.Windows.Forms.Label label_forumposts;
	}
}