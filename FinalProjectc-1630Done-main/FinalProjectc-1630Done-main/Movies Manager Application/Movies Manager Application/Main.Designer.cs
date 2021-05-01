
namespace Movies_Manager_Application
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.dgvMovieList = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuRefreshPage = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuExit = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.printToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.maintenanceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuAddMovie = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuUpdateMovie = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuDeleteMovie = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMovieList)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvMovieList
            // 
            this.dgvMovieList.AllowUserToAddRows = false;
            this.dgvMovieList.AllowUserToDeleteRows = false;
            this.dgvMovieList.AllowUserToOrderColumns = true;
            this.dgvMovieList.BackgroundColor = System.Drawing.Color.Beige;
            this.dgvMovieList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMovieList.Location = new System.Drawing.Point(227, 93);
            this.dgvMovieList.Name = "dgvMovieList";
            this.dgvMovieList.ReadOnly = true;
            this.dgvMovieList.Size = new System.Drawing.Size(640, 316);
            this.dgvMovieList.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(369, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(326, 39);
            this.label1.TabIndex = 4;
            this.label1.Text = "Movies Master List";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.OliveDrab;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.maintenanceToolStripMenuItem,
            this.mnuAbout});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(879, 24);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuRefreshPage,
            this.mnuExit,
            this.openToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.printToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // mnuRefreshPage
            // 
            this.mnuRefreshPage.Name = "mnuRefreshPage";
            this.mnuRefreshPage.Size = new System.Drawing.Size(143, 22);
            this.mnuRefreshPage.Text = "Refresh List";
            this.mnuRefreshPage.Click += new System.EventHandler(this.mnuRefreshPage_Click);
            // 
            // mnuExit
            // 
            this.mnuExit.Name = "mnuExit";
            this.mnuExit.Size = new System.Drawing.Size(143, 22);
            this.mnuExit.Text = "Exit";
            this.mnuExit.Click += new System.EventHandler(this.mnuExit_Click);
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("openToolStripMenuItem.BackgroundImage")));
            this.openToolStripMenuItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D0)));
            this.openToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
            this.openToolStripMenuItem.Text = "Open";
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("saveToolStripMenuItem.BackgroundImage")));
            this.saveToolStripMenuItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
            this.saveToolStripMenuItem.Text = "Save";
            // 
            // printToolStripMenuItem
            // 
            this.printToolStripMenuItem.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("printToolStripMenuItem.BackgroundImage")));
            this.printToolStripMenuItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.printToolStripMenuItem.Name = "printToolStripMenuItem";
            this.printToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
            this.printToolStripMenuItem.Text = "Print";
            // 
            // maintenanceToolStripMenuItem
            // 
            this.maintenanceToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuAddMovie,
            this.mnuUpdateMovie,
            this.mnuDeleteMovie});
            this.maintenanceToolStripMenuItem.Name = "maintenanceToolStripMenuItem";
            this.maintenanceToolStripMenuItem.Size = new System.Drawing.Size(88, 20);
            this.maintenanceToolStripMenuItem.Text = "Maintenance";
            this.maintenanceToolStripMenuItem.Click += new System.EventHandler(this.maintenanceToolStripMenuItem_Click);
            // 
            // mnuAddMovie
            // 
            this.mnuAddMovie.Name = "mnuAddMovie";
            this.mnuAddMovie.Size = new System.Drawing.Size(148, 22);
            this.mnuAddMovie.Text = "Add Movie";
            this.mnuAddMovie.Click += new System.EventHandler(this.mnuAddMovie_Click);
            // 
            // mnuUpdateMovie
            // 
            this.mnuUpdateMovie.Name = "mnuUpdateMovie";
            this.mnuUpdateMovie.Size = new System.Drawing.Size(148, 22);
            this.mnuUpdateMovie.Text = "Update Movie";
            this.mnuUpdateMovie.Click += new System.EventHandler(this.mnuUpdateMovie_Click);
            // 
            // mnuDeleteMovie
            // 
            this.mnuDeleteMovie.Name = "mnuDeleteMovie";
            this.mnuDeleteMovie.Size = new System.Drawing.Size(148, 22);
            this.mnuDeleteMovie.Text = "Delete Movie";
            this.mnuDeleteMovie.Click += new System.EventHandler(this.mnuDeleteMovie_Click);
            // 
            // mnuAbout
            // 
            this.mnuAbout.Name = "mnuAbout";
            this.mnuAbout.Size = new System.Drawing.Size(68, 20);
            this.mnuAbout.Text = "About Us";
            this.mnuAbout.Click += new System.EventHandler(this.mnuAbout_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.BackgroundImage")));
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox2.Location = new System.Drawing.Point(12, 38);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(84, 73);
            this.pictureBox2.TabIndex = 21;
            this.pictureBox2.TabStop = false;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(879, 427);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvMovieList);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Main";
            this.Text = "Movie Manager Application";
            ((System.ComponentModel.ISupportInitialize)(this.dgvMovieList)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvMovieList;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnuRefreshPage;
        private System.Windows.Forms.ToolStripMenuItem mnuExit;
        private System.Windows.Forms.ToolStripMenuItem maintenanceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnuAddMovie;
        private System.Windows.Forms.ToolStripMenuItem mnuUpdateMovie;
        private System.Windows.Forms.ToolStripMenuItem mnuDeleteMovie;
        private System.Windows.Forms.ToolStripMenuItem mnuAbout;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem printToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}

