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
    public partial class Vector2Picker : UserControl
    {
        Gravity gravity;

        public Vector2Picker()
        {
            InitializeComponent();
        }

        public void SetVector2(Gravity gravity) 
        {
            this.gravity = gravity;
            numericUpDownX.Value = (decimal)gravity.force.X;
            numericUpDownY.Value = (decimal)gravity.force.Y;
        }

        private void numericUpDownX_ValueChanged(object sender, EventArgs e)
        {
            gravity.force.X = (float)numericUpDownX.Value;
        }

        private void numericUpDownY_ValueChanged(object sender, EventArgs e)
        {
            gravity.force.Y = (float)numericUpDownY.Value;
        }
    }
}
