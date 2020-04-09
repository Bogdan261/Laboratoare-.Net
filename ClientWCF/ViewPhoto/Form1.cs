using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace ViewPhoto
{
    public partial class Form1 : Form
    {   private string path;
        public Form1(string Path)
        {
            this.path = Path;
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Picture.Hide();
            MediaPlayer.Hide();
            Close.Hide();
            string PhotoExtensions = "All Image files | *.bmp; *.gif, *.jpg, *.ico; " + " *.emf;, .wmf | Bitmap files(.bmp; *.gif; *.jpg; " + " *.ico) | *.bmp; *.gif; *.jpg; *.ico | " + "Meta Files(*.emf; *.wmf; *.png) | *.emf; *.wmf; *.png ; *.PNG";
            string VideoExtensions = " *.avi , *.m4v , *.mp4, *.mkv";
            if (PhotoExtensions.Contains(Path.GetExtension(path)))
            {
                Picture.Show();
                Picture.ImageLocation = this.path;
                Picture.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            else
            {
                MediaPlayer.Show();
                Close.Show();
                MediaPlayer.URL += path;
                WMPLib.IWMPControls3 controls = (WMPLib.IWMPControls3)MediaPlayer.Ctlcontrols;

                // Check first to be sure the operation is valid. 
                if (controls.get_isAvailable("stop"))
                {
                    controls.stop();
                }

            }

        }

        private void Close_Click(object sender, EventArgs e)
        {
            WMPLib.IWMPControls3 controls = (WMPLib.IWMPControls3)MediaPlayer.Ctlcontrols;

            // Check first to be sure the operation is valid. 
            if (controls.get_isAvailable("stop"))
            {
                controls.stop();
            }
            this.Close();
        }

        private void MediaPlayer_Enter(object sender, EventArgs e)
        {

        }
    }
}
