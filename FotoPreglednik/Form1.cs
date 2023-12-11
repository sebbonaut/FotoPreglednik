using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FotoPreglednik
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void gumbPrikaži_Klik(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
                preglednik.Load(openFileDialog1.FileName);
        }

        private void gumbOčisti_Klik(object sender, EventArgs e)
        {
            preglednik.Image = null;
        }

        private void gumbPostavi_Klik(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
                preglednik.BackColor = colorDialog1.Color;
        }

        private void gumbZatvori_Klik(object sender, EventArgs e)
        {
            Close();
        }

        private void potvrdniRastegni_Promjena(object sender, EventArgs e)
        {
            if (potvrdniRastegni.Checked)
                preglednik.SizeMode = PictureBoxSizeMode.StretchImage;
            else
                preglednik.SizeMode = PictureBoxSizeMode.Normal;
        }
    }
}
