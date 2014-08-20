using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using se.skoggy.utils.Particles;
using Microsoft.Xna.Framework.Graphics;

namespace ParticleEditor.Controls
{
    public partial class ParticleEmitterControl : UserControl
    {
        ParticleEmitterSettings _emitterSettings;
        public ParticleEmitterSettings EmitterSettings 
        {
            get { return _emitterSettings; }
            set 
            {
                _emitterSettings = value;
                if (_emitterSettings != null)
                    OnEmitterLoaded();
            }
        }

        public delegate void ResetRequest();
        public event ResetRequest OnResetRequested;

        public ParticleEmitterControl()
        {
            InitializeComponent();
        }

        private void textBoxSources_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                try
                {
                    EmitterSettings.sources = textBoxSources.Text.Split(',').Select(x => int.Parse(x.Trim())).ToArray();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void OnEmitterLoaded()
        {
            floatRangeSliderFrequency.SetRange(EmitterSettings.frequency, 500f);
            floatRangeSliderLifeTime.SetRange(EmitterSettings.lifeTime, 2000f);
            floatRangeSliderRotation.SetRange(EmitterSettings.rotation, 10f);
            vectorRangeSliderPosition.SetRange(EmitterSettings.position);
            vectorRangeSliderVelocity.SetRange(EmitterSettings.velocity);
            vectorRangeSliderStartScale.SetRange(EmitterSettings.startScale);
            vectorRangeSliderEndScale.SetRange(EmitterSettings.endScale);
            textBoxSources.Text = string.Join(",",  EmitterSettings.sources.Select(x => x.ToString()));
            colorRangePicker1.SetRange(EmitterSettings.startColor);
            vector2Picker1.SetVector2(EmitterSettings.gravity);
            comboBoxBlendMode.SelectedIndex = ParseBlendState(EmitterSettings.blendState);
            checkBox1.Checked = EmitterSettings.loop;
            numericUpDownCapacity.Value = EmitterSettings.capacity;
            textBoxName.Text = EmitterSettings.Name;
            textBoxSpawnCount.Text = EmitterSettings.spawnCount.ToString();
        }


        private void BlendModeChanged(object sender, EventArgs e)
        {
            EmitterSettings.blendState = ParseBlendState(comboBoxBlendMode.Text);
        }

        private BlendState ParseBlendState(string text)
        {
            switch (text.ToLower())
            {
                case "additive":
                    return BlendState.Additive;
                case "alphablend":
                    return BlendState.AlphaBlend;
                case "nonpremultiplied":
                    return BlendState.NonPremultiplied;
            }
            return BlendState.Opaque;
        }

        private int ParseBlendState(BlendState state)
        {
            var name = state.Name.Replace("BlendState.", "");

            switch (name.ToLower())
            {
                case "additive":
                    return 0;
                case "alphablend":
                    return 1;
                case "nonpremultiplied":
                    return 2;
            }
            return 0;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            EmitterSettings.loop = checkBox1.Checked;
        }


        private void numericUpDownCapacity_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) 
            {
                EmitterSettings.capacity = (int)numericUpDownCapacity.Value;
                if (OnResetRequested != null)
                    OnResetRequested();
            }
        }

        private void textBoxName_TextChanged(object sender, EventArgs e)
        {
            EmitterSettings.Name = textBoxName.Text;
        }

        private void textBoxSpawnCount_TextChanged(object sender, EventArgs e)
        {
            try
            {
                EmitterSettings.spawnCount = int.Parse(textBoxSpawnCount.Text);
            }
            catch (Exception ex) 
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
