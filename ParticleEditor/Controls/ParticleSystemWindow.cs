using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OpenTK;
using WinFormsGraphicsDevice;
using se.skoggy.utils.Screens;
using Color = Microsoft.Xna.Framework.Color;
using ParticleEditor.Screens;
using System.Diagnostics;
using se.skoggy.utils.Particles;

namespace ParticleEditor.Controls
{
    public partial class ParticleSystemWindow : GraphicsDeviceControl, IGameContext
    {        
        ParticleEditorScreen screen;

        public Color ClearColor 
        {
            set { screen.ClearColor = value; } 
        }

        public ParticleSystemWindow()
        {
            
        }

        protected override void Initialize()
        {
            Application.Idle += (sender, e) => 
            {
                this.Invalidate();
            };

            time = DateTime.Now;
            oldTime = time;
            Resize += ResizeWindow;
            screen = new ParticleEditorScreen(this, Width, Height);
            screen.Load();
        }


        internal void LoadEmitters(ParticleSystemSettings settings)
        {
            screen.LoadEmitters(settings);
        }

        public void Reset()
        {
            screen.ResetAndRecreate();
        }

        public ParticleSystemSettings Settings { get { return screen.Settings;  } }

        void ResizeWindow(object sender, EventArgs e)
        {
            screen.Camera.SetSize(Width, Height);
        }

        DateTime time, oldTime;

        protected override void Draw()
        {
            if ((DateTime.Now - oldTime).Milliseconds < 1f)
                return;

            time = DateTime.Now;
            TimeSpan diff = time - oldTime;

            float dt = diff.Milliseconds;

            screen.Update(dt);
            GraphicsDevice.Clear(Color.CornflowerBlue);
            screen.Draw();
            
            oldTime = time;
        }

        #region IGameContext Members

        public IServiceProvider ServiceProvider
        {
            get { return this.Services; }
        }

        public string ContentRoot
        {
            get { return "Content"; }
        }

        public void ChangeScreen(IScreen screen)
        {
        }

        public void Exit()
        {
        }
        
        #endregion
    }
}
