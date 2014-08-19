using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using se.skoggy.utils.Cameras;
using se.skoggy.utils.Particles;
using se.skoggy.utils.Ranges;
using se.skoggy.utils.Screens;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParticleEditor.Screens
{
    public class ParticleEditorScreen :BaseScreen
    {
        ParticleManager particleManager;
        ParticleSystemSettings settings;
        ParticleSystem system;

        public ParticleEditorScreen(IGameContext context, int width, int height)
            :base(context, "", width, height)
        {
            ClearColor = Color.Black;
        }

        public Camera Camera { get { return cam; } }

        public Color ClearColor { get; set; }

        public ParticleSystemSettings Settings { get { return settings; } }

        public override void Load()
        {
            base.Load();
            particleManager = new ParticleManager();
            particleManager.Load(content);

            settings = new ParticleSystemSettings(new ParticleEmitterSettings[]{
                new ParticleEmitterSettings()
                {
                    frequency = new FloatRange(){ min = 60, max = 100},
                    lifeTime = new FloatRange(){ min = 500, max = 1000},
                    startScale = new Vector2Range(){ min = new Vector2(0.1f, 0.1f), max = new Vector2(0.4f, 0.4f)},
                    endScale = new Vector2Range(){ min = new Vector2(0.6f, 0.6f), max = new Vector2(1f, 1f) },
                    position = new Vector2Range(){ min = Vector2.Zero, max = Vector2.Zero },
                    velocity = new Vector2Range(){ min = -Vector2.One, max = Vector2.One },
                    startColor = new ColorRange(){ min = Color.Orange, max = Color.Red },
                    endColor = new ColorRange(){ min = new Color(0, 0, 0, 0), max = Color.Transparent }
                }
            });
            system = new ParticleSystem(settings);
            particleManager.AddSystem(system);
        }


        internal void LoadEmitters(ParticleSystemSettings settings)
        {
            this.settings = settings;
            system.Initialize(settings);
        }

        public void Reset()
        {
            system.Reset();
        }

        public void ResetAndRecreate() 
        {
            system.ResetAndRecreate();
        }

        public override void Update(float dt)
        {
            particleManager.Update(dt);



            base.Update(dt);
        }

        public override void Draw()
        {
            base.Draw();
            context.GraphicsDevice.Clear(ClearColor);
            particleManager.Draw(spriteBatch, cam);
        }
    }
}
