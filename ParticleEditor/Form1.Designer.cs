namespace ParticleEditor
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.buttonBgColor = new System.Windows.Forms.Button();
            this.buttonReplay = new System.Windows.Forms.Button();
            this.buttonExport = new System.Windows.Forms.Button();
            this.buttonImport = new System.Windows.Forms.Button();
            this.tabControlEmitters = new System.Windows.Forms.TabControl();
            this.buttonAddEmitter = new System.Windows.Forms.Button();
            this.buttonRemoveEmitter = new System.Windows.Forms.Button();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.particleSystemWindow1 = new ParticleEditor.Controls.ParticleSystemWindow();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.splitContainer2);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.particleSystemWindow1);
            this.splitContainer1.Size = new System.Drawing.Size(1297, 735);
            this.splitContainer1.SplitterDistance = 293;
            this.splitContainer1.TabIndex = 0;
            // 
            // splitContainer2
            // 
            this.splitContainer2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.label1);
            this.splitContainer2.Panel1.Controls.Add(this.textBoxName);
            this.splitContainer2.Panel1.Controls.Add(this.buttonRemoveEmitter);
            this.splitContainer2.Panel1.Controls.Add(this.buttonAddEmitter);
            this.splitContainer2.Panel1.Controls.Add(this.buttonBgColor);
            this.splitContainer2.Panel1.Controls.Add(this.buttonReplay);
            this.splitContainer2.Panel1.Controls.Add(this.buttonExport);
            this.splitContainer2.Panel1.Controls.Add(this.buttonImport);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.tabControlEmitters);
            this.splitContainer2.Size = new System.Drawing.Size(293, 735);
            this.splitContainer2.SplitterDistance = 164;
            this.splitContainer2.TabIndex = 0;
            // 
            // buttonBgColor
            // 
            this.buttonBgColor.Location = new System.Drawing.Point(172, 10);
            this.buttonBgColor.Name = "buttonBgColor";
            this.buttonBgColor.Size = new System.Drawing.Size(82, 23);
            this.buttonBgColor.TabIndex = 3;
            this.buttonBgColor.Text = "Background";
            this.buttonBgColor.UseVisualStyleBackColor = true;
            this.buttonBgColor.Click += new System.EventHandler(this.buttonBgColor_Click);
            // 
            // buttonReplay
            // 
            this.buttonReplay.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonReplay.Location = new System.Drawing.Point(3, 136);
            this.buttonReplay.Name = "buttonReplay";
            this.buttonReplay.Size = new System.Drawing.Size(75, 23);
            this.buttonReplay.TabIndex = 2;
            this.buttonReplay.Text = "Replay";
            this.buttonReplay.UseVisualStyleBackColor = true;
            this.buttonReplay.Click += new System.EventHandler(this.buttonReplay_Click);
            // 
            // buttonExport
            // 
            this.buttonExport.Location = new System.Drawing.Point(91, 10);
            this.buttonExport.Name = "buttonExport";
            this.buttonExport.Size = new System.Drawing.Size(75, 23);
            this.buttonExport.TabIndex = 0;
            this.buttonExport.Text = "Export";
            this.buttonExport.UseVisualStyleBackColor = true;
            this.buttonExport.Click += new System.EventHandler(this.buttonExport_Click);
            // 
            // buttonImport
            // 
            this.buttonImport.Location = new System.Drawing.Point(10, 10);
            this.buttonImport.Name = "buttonImport";
            this.buttonImport.Size = new System.Drawing.Size(75, 23);
            this.buttonImport.TabIndex = 1;
            this.buttonImport.Text = "Import";
            this.buttonImport.UseVisualStyleBackColor = true;
            this.buttonImport.Click += new System.EventHandler(this.buttonImport_Click);
            // 
            // tabControlEmitters
            // 
            this.tabControlEmitters.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlEmitters.Location = new System.Drawing.Point(0, 0);
            this.tabControlEmitters.Name = "tabControlEmitters";
            this.tabControlEmitters.SelectedIndex = 0;
            this.tabControlEmitters.Size = new System.Drawing.Size(291, 565);
            this.tabControlEmitters.TabIndex = 0;
            // 
            // buttonAddEmitter
            // 
            this.buttonAddEmitter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonAddEmitter.Location = new System.Drawing.Point(184, 136);
            this.buttonAddEmitter.Name = "buttonAddEmitter";
            this.buttonAddEmitter.Size = new System.Drawing.Size(41, 23);
            this.buttonAddEmitter.TabIndex = 4;
            this.buttonAddEmitter.Text = "Add";
            this.buttonAddEmitter.UseVisualStyleBackColor = true;
            this.buttonAddEmitter.Click += new System.EventHandler(this.buttonAddEmitter_Click);
            // 
            // buttonRemoveEmitter
            // 
            this.buttonRemoveEmitter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonRemoveEmitter.Location = new System.Drawing.Point(231, 136);
            this.buttonRemoveEmitter.Name = "buttonRemoveEmitter";
            this.buttonRemoveEmitter.Size = new System.Drawing.Size(57, 23);
            this.buttonRemoveEmitter.TabIndex = 5;
            this.buttonRemoveEmitter.Text = "Remove";
            this.buttonRemoveEmitter.UseVisualStyleBackColor = true;
            this.buttonRemoveEmitter.Click += new System.EventHandler(this.buttonRemoveEmitter_Click);
            // 
            // textBoxName
            // 
            this.textBoxName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxName.Location = new System.Drawing.Point(3, 110);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(285, 20);
            this.textBoxName.TabIndex = 6;
            this.textBoxName.TextChanged += new System.EventHandler(this.textBoxName_TextChanged);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(0, 94);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Name:";
            // 
            // particleSystemWindow1
            // 
            this.particleSystemWindow1.BackColor = System.Drawing.Color.Black;
            this.particleSystemWindow1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.particleSystemWindow1.Location = new System.Drawing.Point(0, 0);
            this.particleSystemWindow1.Name = "particleSystemWindow1";
            this.particleSystemWindow1.Size = new System.Drawing.Size(998, 733);
            this.particleSystemWindow1.TabIndex = 0;
            this.particleSystemWindow1.VSync = false;
            this.particleSystemWindow1.Load += new System.EventHandler(this.particleSystemWindow1_Load);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1297, 735);
            this.Controls.Add(this.splitContainer1);
            this.Name = "Form1";
            this.Text = "Particle Editor";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel1.PerformLayout();
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private Controls.ParticleSystemWindow particleSystemWindow1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.Button buttonExport;
        private System.Windows.Forms.Button buttonImport;
        private System.Windows.Forms.Button buttonReplay;
        private System.Windows.Forms.Button buttonBgColor;
        private System.Windows.Forms.TabControl tabControlEmitters;
        private System.Windows.Forms.Button buttonRemoveEmitter;
        private System.Windows.Forms.Button buttonAddEmitter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxName;
    }
}

