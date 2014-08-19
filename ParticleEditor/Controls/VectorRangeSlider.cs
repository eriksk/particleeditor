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
    public partial class VectorRangeSlider : UserControl
    {
        Vector2Range range;

        public VectorRangeSlider()
        {
            InitializeComponent();
        }

        public void SetRange(Vector2Range range) 
        {
            this.range = range;
            numericUpDownMinX.Value = (decimal)range.min.X;
            numericUpDownMinY.Value = (decimal)range.min.Y;
            numericUpDownMaxX.Value = (decimal)range.max.X;
            numericUpDownMaxY.Value = (decimal)range.max.Y;
        }

        private void numericUpDownMinX_ValueChanged(object sender, EventArgs e)
        {
            range.min.X = (float)numericUpDownMinX.Value;
        }

        private void numericUpDownMinY_ValueChanged(object sender, EventArgs e)
        {
            range.min.Y = (float)numericUpDownMinY.Value;
        }

        private void numericUpDownMaxX_ValueChanged(object sender, EventArgs e)
        {
            range.max.X = (float)numericUpDownMaxX.Value;
        }

        private void numericUpDownMaxY_ValueChanged(object sender, EventArgs e)
        {
            range.max.Y = (float)numericUpDownMaxY.Value;

        }
    }
}
