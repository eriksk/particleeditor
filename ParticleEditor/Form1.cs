using Microsoft.Xna.Framework.Graphics;
using Newtonsoft.Json;
using ParticleEditor.Controls;
using se.skoggy.utils.Particles;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ParticleEditor
{
    public partial class Form1 : Form
    {
        private string defaultEmitter = @"{ 'Name' : 'Fire', 'emitters': [{'blendState':'Additive','frequency':{'min':5.0,'max':15.0},'lifeTime':{'min':280.0,'max':440.0},'startColor':{'min':{'B':21,'G':126,'R':242,'A':255},'max':{'B':0,'G':0,'R':255,'A':255}},'endColor':{'min':{'B':0,'G':0,'R':0,'A':0},'max':{'B':0,'G':0,'R':0,'A':0}},'position':{'min':{'X':0.0,'Y':0.0},'max':{'X':0.0,'Y':0.0}},'velocity':{'min':{'X':-0.01,'Y':-0.6},'max':{'X':0.01,'Y':-0.2}},'startScale':{'min':{'X':0.3,'Y':0.3},'max':{'X':0.8,'Y':0.8}},'endScale':{'min':{'X':2.0,'Y':2.0},'max':{'X':2.0,'Y':2.0}},'gravity':{'force':{'X':0.0,'Y':0.0}},'rotation':{'min':0.0,'max':20.0},'sources':[0,5,7],'loop':true,'capacity':64, 'Name' : 'Flames' } ] }";

        public Form1()
        {
            InitializeComponent();
        }

        public void LoadParticleSystem(ParticleSystemSettings settings) 
        {
            textBoxName.Text = settings.Name;
            particleSystemWindow1.LoadEmitters(settings);

            tabControlEmitters.TabPages.Clear();

            foreach (var emitter in settings.emitters)
            {
                var page = new TabPage();

                var emitterControl = new ParticleEmitterControl();
                emitterControl.EmitterSettings = emitter;
                emitterControl.OnResetRequested += particleEmitterControl1_OnResetRequested;
                emitterControl.Dock = DockStyle.Fill;
                page.Controls.Add(emitterControl);
                tabControlEmitters.TabPages.Add(page);                
            }
            particleSystemWindow1.Reset();
        }

        void particleEmitterControl1_OnResetRequested()
        {
            particleSystemWindow1.Reset();
        }

        private void particleEmitterControl1_Load(object sender, EventArgs e)
        {

        }

        private void particleSystemWindow1_Load(object sender, EventArgs e)
        {
            LoadDefault();
        }

        private void LoadDefault() 
        {
            LoadParticleSystem(GetParticleSystemFromJson(defaultEmitter));
        }

        private void buttonExport_Click(object sender, EventArgs e)
        {
            var content = ToJson(particleSystemWindow1.Settings);

            var window = new ExportWindow(content);
            window.ShowDialog();
        }

        private void buttonImport_Click(object sender, EventArgs e)
        {
            var window = new ImportWindow();
            if (window.ShowDialog() == DialogResult.OK) 
            {
                string content = window.Content;
                try
                {
                    LoadParticleSystem(GetParticleSystemFromJson(content));
                }
                catch (Exception ex) 
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private ParticleSystemSettings GetParticleSystemFromJson(string content)
        {
            return JsonConvert.DeserializeObject<ParticleSystemSettings>(content, new BlendStateJsonConverter());
        }

        private string ToJson(object obj)
        {
            return JsonConvert.SerializeObject(obj, Formatting.Indented, new BlendStateJsonConverter());
        }

        private void buttonReplay_Click(object sender, EventArgs e)
        {
            particleSystemWindow1.Reset();
        }

        private void buttonBgColor_Click(object sender, EventArgs e)
        {
            var dialog = new ColorDialog();
            if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK) 
            {
                particleSystemWindow1.ClearColor = new Microsoft.Xna.Framework.Color(dialog.Color.R, dialog.Color.G, dialog.Color.B, dialog.Color.A);
            }
        }

        private void buttonAddEmitter_Click(object sender, EventArgs e)
        {
            AddNewEmitterAndTab();
        }

        private void buttonRemoveEmitter_Click(object sender, EventArgs e)
        {
            RemoveSelectedTabAndEmitter();
        }

        private void AddNewEmitterAndTab()
        {
            var particleSystem = particleSystemWindow1.Settings;
            var emitterToAdd = new ParticleEmitterSettings();

            if (particleSystem.emitters.Length > 0)
                emitterToAdd.Set(particleSystem.emitters.Last());
            else 
            {
                LoadDefault();
                return;
            }
            
            var newList = particleSystem.emitters.ToList();
            newList.Add(emitterToAdd);
            
            particleSystem.emitters = newList.ToArray();

            // de-reference
            LoadParticleSystem(GetParticleSystemFromJson(ToJson(particleSystem)));
        }

        private void RemoveSelectedTabAndEmitter()
        {
            if (tabControlEmitters.SelectedTab != null) 
            {
                var settings = (tabControlEmitters.SelectedTab.Controls[0] as ParticleEmitterControl).EmitterSettings;

                var particleSystem = particleSystemWindow1.Settings;
                var newList = particleSystem.emitters.ToList();
                newList.Remove(settings);
                particleSystem.emitters = newList.ToArray();

                // de-reference
                LoadParticleSystem(GetParticleSystemFromJson(ToJson(particleSystem)));
            }
        }

        private void textBoxName_TextChanged(object sender, EventArgs e)
        {
            particleSystemWindow1.Settings.Name = textBoxName.Text;
        }
    }

    class BlendStateJsonConverter : JsonConverter 
    {
        public override bool CanConvert(Type objectType)
        {
            return objectType == typeof(BlendState);
        }

        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {

            switch (reader.Value.ToString().ToLower())
            {
                case "additive": return BlendState.Additive;
                case "alphablend": return BlendState.AlphaBlend;
                case "nonpremultiplied": return BlendState.NonPremultiplied;
            }

            return reader.Value;
        }

        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            serializer.Serialize(writer, (value as BlendState).Name.Replace("BlendState.", ""));
        }
    }
}
