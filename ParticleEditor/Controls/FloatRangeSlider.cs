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
using Microsoft.Xna.Framework;

namespace ParticleEditor.Controls
{
    public partial class FloatRangeSlider : UserControl
    {
        FloatRange floatRange;
        float maxValue;

        public FloatRangeSlider()
        {
            InitializeComponent();
        }

        public void SetRange(FloatRange floatRange, float maxValue)
        {
            this.maxValue = maxValue;
            this.floatRange = floatRange;

            floatRange.min = MathHelper.Clamp(floatRange.min, 0f, maxValue);
            floatRange.max = MathHelper.Clamp(floatRange.max, 0f, maxValue);

            trackBarMin.Value = (int)((floatRange.min / maxValue) * 100f);
            trackBarMax.Value = (int)((floatRange.max / maxValue) * 100f);
        }

        private void trackBarMin_Scroll(object sender, EventArgs e)
        {
            if (trackBarMin.Value > trackBarMax.Value) 
            {
                trackBarMax.Value = trackBarMin.Value;
            }

            floatRange.min = ((float)trackBarMin.Value / 100f) * maxValue;
        }

        private void trackBarMax_Scroll(object sender, EventArgs e)
        {
            if (trackBarMax.Value < trackBarMin.Value)
            {
                trackBarMax.Value = trackBarMin.Value;
            }

            floatRange.max = ((float)trackBarMax.Value / 100f) * maxValue;
        }
    }
}
