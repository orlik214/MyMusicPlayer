using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;



namespace MyMusicPlayer
{
    /// <summary>
    /// Class <c>MyMusicPlayer</c> inherits from the base class Form.
    /// </summary>
    public partial class MyMusicPlayer : Form
    {
        /// <summary>
        /// This method instructs all the components on form to initialize, position and display as desired.
        /// </summary>
        public MyMusicPlayer()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Models a point in a two-dimensional plane
        /// </summary>
        Point lastPoint; 
        /// <summary>
        /// Creates array of Strings for storing File names and paths of tracks.
        /// </summary>
        String[] paths, titles;
        /// <summary>
        /// This method loads form
        /// </summary>
        /// <param name="sender">The source of an event</param>
        /// <param name="e">Instance containing the event data</param>
        public void Form1_Load(object sender, EventArgs e)
        {
            
        }

        /// <summary>
        /// This event handler sends path of choosen file to Windows Media Player.
        /// </summary>
        /// <param name="sender">The source of an event</param>
        /// <param name="e">Instance containing the event data</param>

        public void SongsList_SelectedIndexChanged(object sender, EventArgs e)
        {
             WMP.URL = paths[SongsList.SelectedIndex]; 
        }

        /// <summary>
        /// This event handler closes program
        /// </summary>
        /// <param name="sender">The source of an event</param>
        /// <param name="e">Instance containing the event data</param>
        
        public void pictureBox1_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }


        /// <summary>
        /// This event handler allows adding elements to listbox
        /// </summary>
        /// <param name="sender">The source of an event</param>
        /// <param name="e">Instance containing the event data</param>
        public void pictureBox2_Click(object sender, EventArgs e)
        {
           
            titles = null;
            paths = null;
            SongsList.Items.Clear();
            /// <summary>
            /// Creates an object of OpenFileDialog which opens an dialog thats lets user choose files.
            /// </summary>
            OpenFileDialog ofd = new OpenFileDialog(); 
            ofd.Multiselect = true; 
            ofd.Filter = "All Supported Audio | *.mp3;  | MP3s | *.mp3 | WMAs | *.wma"; 
            
            if (ofd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                titles = ofd.SafeFileNames; 
                paths = ofd.FileNames; 
                
                
                /// <summary>
                /// This loop adds choosen elements to listbox
                /// </summary>
                for (int i = 0; i < titles.Length; i++)
                {
                    int nrOnPlaylist = i + 1;
                    SongsList.Items.Add(nrOnPlaylist + ". " + titles[i]);
                }

                /// <summary>
                /// Automatically starts to play first of the added songs to playlists
                /// </summary>
                BeginInvoke(new Action(() => {
                    SongsList.SelectedIndex = SongsList.SelectedIndex = 0;
                }));
            }
        }



        /// <summary>
        /// This handler allows to move App on screen
        /// </summary>
        /// <param name="sender">The source of an event</param>
        /// <param name="e">Instance containing the event data</param>
        public void MyMusicPlayer_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }
        /// <summary>
        /// This event handler saves new coordinates of app
        /// </summary>
        /// <param name="sender">The source of an event</param>
        /// <param name="e">Instance containing the event data</param>
        public void MyMusicPlayer_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }
        /// <summary>
        /// This event handler allows to automaticlly play next song after previous one is finished.
        /// </summary>
        /// <param name="sender">The source of an event</param>
        /// <param name="e">Instance containing the event data</param>

        public void WMP_PlayStateChange(object sender, AxWMPLib._WMPOCXEvents_PlayStateChangeEvent e)
        {
            if (e.newState == 1)
            {
                if (SongsList.SelectedIndex != SongsList.Items.Count - 1)
                {
                    BeginInvoke(new Action(() => {
                        SongsList.SelectedIndex = SongsList.SelectedIndex + 1;
                    }));
                }
            }
        }


        /// <summary>
        /// This event handler allows to go to the next track on playlist.
        /// </summary>
        /// <param name="sender">The source of an event</param>
        /// <param name="e">Instance containing the event data</param>
        public void btnNext_Click(object sender, EventArgs e)
        {
            if (SongsList.SelectedIndex != SongsList.Items.Count - 1)
                SongsList.SelectedIndex = SongsList.SelectedIndex + 1;
            
        }


        /// <summary>
        /// This event handler allows to go to the previous track on playlist.
        /// </summary>
        /// <param name="sender">The source of an event</param>
        /// <param name="e">Instance containing the event data</param>
        public void btnPrevious_Click(object sender, EventArgs e)
        {
            if (SongsList.SelectedIndex != 0 && SongsList.SelectedIndex != -1)
                SongsList.SelectedIndex = SongsList.SelectedIndex - 1;
        }

        


        /// <summary>
        /// This event handler allows to stop playing.
        /// </summary>
        /// <param name="sender">The source of an event</param>
        /// <param name="e">Instance containing the event data</param>
        public void btnStop_Click(object sender, EventArgs e)
        {
            BeginInvoke(new Action(() =>
            {
                WMP.close();
            }));
        }



        /// <summary>
        /// This event handler allows to clear playlist.
        /// </summary>
        /// <param name="sender">The source of an event</param>
        /// <param name="e">Instance containing the event data</param>
        public void pictureBox3_Click(object sender, EventArgs e)
        {
            SongsList.Items.Clear();
            paths = null;
            titles = null;
        }

        
    }
    

    
}


//Icons for buttons used from https://icons8.com