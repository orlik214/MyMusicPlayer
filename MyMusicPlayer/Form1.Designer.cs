namespace MyMusicPlayer
{
    partial class MyMusicPlayer
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MyMusicPlayer));
            this.GornyPanel = new System.Windows.Forms.Panel();
            this.IconExit = new System.Windows.Forms.PictureBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.SongsList = new System.Windows.Forms.ListBox();
            this.WMP = new AxWMPLib.AxWindowsMediaPlayer();
            this.btnStop = new System.Windows.Forms.PictureBox();
            this.btnPrevious = new System.Windows.Forms.PictureBox();
            this.btnNext = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.GornyPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.IconExit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.WMP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnStop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnPrevious)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnNext)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // GornyPanel
            // 
            this.GornyPanel.BackColor = System.Drawing.Color.Turquoise;
            this.GornyPanel.Controls.Add(this.IconExit);
            this.GornyPanel.Controls.Add(this.lblTitle);
            this.GornyPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.GornyPanel.Location = new System.Drawing.Point(0, 0);
            this.GornyPanel.Name = "GornyPanel";
            this.GornyPanel.Size = new System.Drawing.Size(284, 36);
            this.GornyPanel.TabIndex = 0;
            this.GornyPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MyMusicPlayer_MouseDown);
            this.GornyPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MyMusicPlayer_MouseMove);
            // 
            // IconExit
            // 
            this.IconExit.Image = global::MyMusicPlayer.Properties.Resources.icons8_close_window_50;
            this.IconExit.Location = new System.Drawing.Point(252, 3);
            this.IconExit.Name = "IconExit";
            this.IconExit.Size = new System.Drawing.Size(29, 28);
            this.IconExit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.IconExit.TabIndex = 1;
            this.IconExit.TabStop = false;
            this.IconExit.Click += new System.EventHandler(this.pictureBox1_Click);
            this.IconExit.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MyMusicPlayer_MouseDown);
            this.IconExit.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MyMusicPlayer_MouseMove);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Solid Edge Stencil", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(3, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(93, 15);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "MyMusicPlayer";
            this.lblTitle.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MyMusicPlayer_MouseDown);
            this.lblTitle.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MyMusicPlayer_MouseMove);
            // 
            // SongsList
            // 
            this.SongsList.BackColor = System.Drawing.Color.Firebrick;
            this.SongsList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.SongsList.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.SongsList.ForeColor = System.Drawing.SystemColors.Control;
            this.SongsList.FormattingEnabled = true;
            this.SongsList.ItemHeight = 16;
            this.SongsList.Location = new System.Drawing.Point(0, 273);
            this.SongsList.Name = "SongsList";
            this.SongsList.Size = new System.Drawing.Size(284, 176);
            this.SongsList.TabIndex = 1;
            this.SongsList.SelectedIndexChanged += new System.EventHandler(this.SongsList_SelectedIndexChanged);
            this.SongsList.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MyMusicPlayer_MouseDown);
            this.SongsList.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MyMusicPlayer_MouseMove);
            // 
            // WMP
            // 
            this.WMP.Enabled = true;
            this.WMP.Location = new System.Drawing.Point(0, 34);
            this.WMP.Name = "WMP";
            this.WMP.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("WMP.OcxState")));
            this.WMP.Size = new System.Drawing.Size(284, 204);
            this.WMP.TabIndex = 3;
            this.WMP.PlayStateChange += new AxWMPLib._WMPOCXEvents_PlayStateChangeEventHandler(this.WMP_PlayStateChange);
            // 
            // btnStop
            // 
            this.btnStop.Image = global::MyMusicPlayer.Properties.Resources.icons8_stop_24;
            this.btnStop.Location = new System.Drawing.Point(72, 244);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(24, 23);
            this.btnStop.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnStop.TabIndex = 9;
            this.btnStop.TabStop = false;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // btnPrevious
            // 
            this.btnPrevious.Image = global::MyMusicPlayer.Properties.Resources.icons8_previous_24;
            this.btnPrevious.Location = new System.Drawing.Point(113, 244);
            this.btnPrevious.Name = "btnPrevious";
            this.btnPrevious.Size = new System.Drawing.Size(24, 23);
            this.btnPrevious.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnPrevious.TabIndex = 8;
            this.btnPrevious.TabStop = false;
            this.btnPrevious.Click += new System.EventHandler(this.btnPrevious_Click);
            // 
            // btnNext
            // 
            this.btnNext.Image = global::MyMusicPlayer.Properties.Resources.icons8_next_24;
            this.btnNext.Location = new System.Drawing.Point(143, 244);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(24, 23);
            this.btnNext.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnNext.TabIndex = 7;
            this.btnNext.TabStop = false;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::MyMusicPlayer.Properties.Resources.icons8_remove_32;
            this.pictureBox3.Location = new System.Drawing.Point(257, 244);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(24, 23);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 6;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            this.pictureBox3.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MyMusicPlayer_MouseDown);
            this.pictureBox3.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MyMusicPlayer_MouseMove);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::MyMusicPlayer.Properties.Resources.icons8_add_24;
            this.pictureBox2.Location = new System.Drawing.Point(6, 244);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(24, 23);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 5;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            this.pictureBox2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MyMusicPlayer_MouseDown);
            this.pictureBox2.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MyMusicPlayer_MouseMove);
            // 
            // MyMusicPlayer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Firebrick;
            this.ClientSize = new System.Drawing.Size(284, 461);
            this.ControlBox = false;
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.btnPrevious);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.WMP);
            this.Controls.Add(this.SongsList);
            this.Controls.Add(this.GornyPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MyMusicPlayer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MyMusicPlayer";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MyMusicPlayer_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MyMusicPlayer_MouseMove);
            this.GornyPanel.ResumeLayout(false);
            this.GornyPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.IconExit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.WMP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnStop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnPrevious)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnNext)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel GornyPanel;
        private System.Windows.Forms.PictureBox IconExit;
        private System.Windows.Forms.Label lblTitle;
        private AxWMPLib.AxWindowsMediaPlayer WMP;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        public System.Windows.Forms.PictureBox btnNext;
        public System.Windows.Forms.PictureBox btnPrevious;
        private System.Windows.Forms.PictureBox btnStop;
        public System.Windows.Forms.ListBox SongsList;
    }
}

