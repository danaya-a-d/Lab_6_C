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
namespace Lab_6_C
{
    public partial class Procrutka : Form
    {
        private System.Windows.Forms.ContextMenu contextMenu1;
        private System.Windows.Forms.MenuItem cmnuResize;
        private System.Windows.Forms.MenuItem cmnuActual;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.MainMenu mainMenu1;
        private System.Windows.Forms.MenuItem mnuFile;
        private System.Windows.Forms.MenuItem mnuOpen;
        private System.Windows.Forms.MenuItem mnuView;
        private System.Windows.Forms.MenuItem mnuResize;
        private System.Windows.Forms.MenuItem mnuActual;
        private System.Windows.Forms.MenuItem cmnuOpen;
        private PictureElement.NamePictureElement namePictureElement1;


        private System.ComponentModel.Container components = null;

        public Procrutka()
        {
            InitializeComponent();
        }


        private void mnuOpen_Click(object sender, System.EventArgs e)
        {
            this.openFileDialog1.ShowDialog();
            string path = this.openFileDialog1.FileName;
            this.namePictureElement1.Izobrajenie = Image.FromFile(path);
        }

        private void mnuResize_Click(object sender, System.EventArgs e)
        {
            this.namePictureElement1.UserPropRejimProsmotra = PictureElement.RejimProsmotra.PodgonRazmera;
        }

        private void mnuActual_Click(object sender, System.EventArgs e)
        {
            this.namePictureElement1.UserPropRejimProsmotra = PictureElement.RejimProsmotra.Prokrutka;
        }
    }
}
