using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using se.skoggy.utils.Ranges;

namespace ParticleEditor.Controls
{
    public partial class ColorRangePicker : UserControl
    {
        ColorRange range;

        public ColorRangePicker()
        {
            InitializeComponent();
        }

        public void SetRange(ColorRange range) 
        {
            this.range = range;
            buttonMin.BackColor = Color.FromArgb(range.min.A, range.min.R, range.min.G, range.min.B);
            buttonMax.BackColor = Color.FromArgb(range.max.A, range.max.R, range.max.G, range.max.B);
        }

        private void buttonMin_Click(object sender, EventArgs e)
        {
            ColorDialog dialog = new ColorDialog();
            if (dialog.ShowDialog() == DialogResult.OK) 
            {
                range.min.A = dialog.Color.A;
                range.min.R = dialog.Color.R;
                range.min.G = dialog.Color.G;
                range.min.B = dialog.Color.B;
                buttonMin.BackColor = dialog.Color;
            }
        }

        private void buttonMax_Click(object sender, EventArgs e)
        {
            ColorDialog dialog = new ColorDialog();
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                range.max.A = dialog.Color.A;
                range.max.R = dialog.Color.R;
                range.max.G = dialog.Color.G;
                range.max.B = dialog.Color.B;
                buttonMax.BackColor = dialog.Color;
            }
        }
    }
}
