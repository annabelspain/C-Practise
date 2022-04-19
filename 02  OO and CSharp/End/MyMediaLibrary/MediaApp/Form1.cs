using MyMediaLibrary.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MediaApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void CountItems_Click(object sender, EventArgs e)
        {
            MediaLibrary mediaLibrary = new MediaLibrary();
            MediaItem mediaItem = new MediaItem();
            mediaItem.Title = "Jaws";

            mediaLibrary.Add(mediaItem);

            int count = mediaLibrary.GetMediaItemCount();
            MessageBox.Show($"There are {count} items in the Media Library", "Media Library");
        }
    }
}
