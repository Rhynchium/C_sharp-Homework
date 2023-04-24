using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Homework1
{
    public partial class Homework_pictureViewer_Viewer : Form
    {
        public Homework_pictureViewer_Viewer()
        {
            InitializeComponent();
        }
        public PictureBox Vpicture { get; set; }
        private void Homework_pictureViewer_Viewer_Load(object sender, EventArgs e)
        {
            pictureBox.Image = Vpicture.Image;
        }
    }
}
