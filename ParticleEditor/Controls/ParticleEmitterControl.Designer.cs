namespace ParticleEditor.Controls
{
    partial class ParticleEmitterControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxBlendMode = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.floatRangeSliderFrequency = new ParticleEditor.Controls.FloatRangeSlider();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.floatRangeSliderLifeTime = new ParticleEditor.Controls.FloatRangeSlider();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.floatRangeSliderRotation = new ParticleEditor.Controls.FloatRangeSlider();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.vectorRangeSliderVelocity = new ParticleEditor.Controls.VectorRangeSlider();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.vectorRangeSliderPosition = new ParticleEditor.Controls.VectorRangeSlider();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.vectorRangeSliderStartScale = new ParticleEditor.Controls.VectorRangeSlider();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.vectorRangeSliderEndScale = new ParticleEditor.Controls.VectorRangeSlider();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxSources = new System.Windows.Forms.TextBox();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.colorRangePicker1 = new ParticleEditor.Controls.ColorRangePicker();
            this.groupBox9 = new System.Windows.Forms.GroupBox();
            this.vector2Picker1 = new ParticleEditor.Controls.Vector2Picker();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.numericUpDownCapacity = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox10 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.groupBox8.SuspendLayout();
            this.groupBox9.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCapacity)).BeginInit();
            this.groupBox10.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "BlendState:";
            // 
            // comboBoxBlendMode
            // 
            this.comboBoxBlendMode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxBlendMode.FormattingEnabled = true;
            this.comboBoxBlendMode.Items.AddRange(new object[] {
            "Additive",
            "AlphaBlend",
            "NonPremultiplied"});
            this.comboBoxBlendMode.Location = new System.Drawing.Point(9, 71);
            this.comboBoxBlendMode.Name = "comboBoxBlendMode";
            this.comboBoxBlendMode.Size = new System.Drawing.Size(158, 21);
            this.comboBoxBlendMode.TabIndex = 1;
            this.comboBoxBlendMode.SelectedIndexChanged += new System.EventHandler(this.BlendModeChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.groupBox1.Controls.Add(this.floatRangeSliderFrequency);
            this.groupBox1.Location = new System.Drawing.Point(0, 385);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(402, 148);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Frequency";
            // 
            // floatRangeSliderFrequency
            // 
            this.floatRangeSliderFrequency.Dock = System.Windows.Forms.DockStyle.Fill;
            this.floatRangeSliderFrequency.Location = new System.Drawing.Point(3, 16);
            this.floatRangeSliderFrequency.Name = "floatRangeSliderFrequency";
            this.floatRangeSliderFrequency.Size = new System.Drawing.Size(396, 129);
            this.floatRangeSliderFrequency.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.floatRangeSliderLifeTime);
            this.groupBox2.Location = new System.Drawing.Point(0, 539);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(402, 148);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "LifeTime";
            // 
            // floatRangeSliderLifeTime
            // 
            this.floatRangeSliderLifeTime.Dock = System.Windows.Forms.DockStyle.Fill;
            this.floatRangeSliderLifeTime.Location = new System.Drawing.Point(3, 16);
            this.floatRangeSliderLifeTime.Name = "floatRangeSliderLifeTime";
            this.floatRangeSliderLifeTime.Size = new System.Drawing.Size(396, 129);
            this.floatRangeSliderLifeTime.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this.floatRangeSliderRotation);
            this.groupBox3.Location = new System.Drawing.Point(0, 693);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(402, 148);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Rotation";
            // 
            // floatRangeSliderRotation
            // 
            this.floatRangeSliderRotation.Dock = System.Windows.Forms.DockStyle.Fill;
            this.floatRangeSliderRotation.Location = new System.Drawing.Point(3, 16);
            this.floatRangeSliderRotation.Name = "floatRangeSliderRotation";
            this.floatRangeSliderRotation.Size = new System.Drawing.Size(396, 129);
            this.floatRangeSliderRotation.TabIndex = 0;
            // 
            // groupBox4
            // 
            this.groupBox4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox4.Controls.Add(this.vectorRangeSliderVelocity);
            this.groupBox4.Location = new System.Drawing.Point(3, 847);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(402, 80);
            this.groupBox4.TabIndex = 5;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Velocity";
            // 
            // vectorRangeSliderVelocity
            // 
            this.vectorRangeSliderVelocity.Dock = System.Windows.Forms.DockStyle.Fill;
            this.vectorRangeSliderVelocity.Location = new System.Drawing.Point(3, 16);
            this.vectorRangeSliderVelocity.Name = "vectorRangeSliderVelocity";
            this.vectorRangeSliderVelocity.Size = new System.Drawing.Size(396, 61);
            this.vectorRangeSliderVelocity.TabIndex = 0;
            // 
            // groupBox5
            // 
            this.groupBox5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox5.Controls.Add(this.vectorRangeSliderPosition);
            this.groupBox5.Location = new System.Drawing.Point(3, 933);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(402, 80);
            this.groupBox5.TabIndex = 6;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Position";
            // 
            // vectorRangeSliderPosition
            // 
            this.vectorRangeSliderPosition.Dock = System.Windows.Forms.DockStyle.Fill;
            this.vectorRangeSliderPosition.Location = new System.Drawing.Point(3, 16);
            this.vectorRangeSliderPosition.Name = "vectorRangeSliderPosition";
            this.vectorRangeSliderPosition.Size = new System.Drawing.Size(396, 61);
            this.vectorRangeSliderPosition.TabIndex = 0;
            // 
            // groupBox6
            // 
            this.groupBox6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox6.Controls.Add(this.vectorRangeSliderStartScale);
            this.groupBox6.Location = new System.Drawing.Point(3, 1019);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(402, 80);
            this.groupBox6.TabIndex = 7;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Start Scale";
            // 
            // vectorRangeSliderStartScale
            // 
            this.vectorRangeSliderStartScale.Dock = System.Windows.Forms.DockStyle.Fill;
            this.vectorRangeSliderStartScale.Location = new System.Drawing.Point(3, 16);
            this.vectorRangeSliderStartScale.Name = "vectorRangeSliderStartScale";
            this.vectorRangeSliderStartScale.Size = new System.Drawing.Size(396, 61);
            this.vectorRangeSliderStartScale.TabIndex = 0;
            // 
            // groupBox7
            // 
            this.groupBox7.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox7.Controls.Add(this.vectorRangeSliderEndScale);
            this.groupBox7.Location = new System.Drawing.Point(3, 1105);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(402, 80);
            this.groupBox7.TabIndex = 8;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "End Scale";
            // 
            // vectorRangeSliderEndScale
            // 
            this.vectorRangeSliderEndScale.Dock = System.Windows.Forms.DockStyle.Fill;
            this.vectorRangeSliderEndScale.Location = new System.Drawing.Point(3, 16);
            this.vectorRangeSliderEndScale.Name = "vectorRangeSliderEndScale";
            this.vectorRangeSliderEndScale.Size = new System.Drawing.Size(396, 61);
            this.vectorRangeSliderEndScale.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Sources:";
            // 
            // textBoxSources
            // 
            this.textBoxSources.Location = new System.Drawing.Point(9, 111);
            this.textBoxSources.Name = "textBoxSources";
            this.textBoxSources.Size = new System.Drawing.Size(168, 20);
            this.textBoxSources.TabIndex = 10;
            this.textBoxSources.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxSources_KeyDown);
            // 
            // groupBox8
            // 
            this.groupBox8.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox8.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.groupBox8.Controls.Add(this.colorRangePicker1);
            this.groupBox8.Location = new System.Drawing.Point(0, 210);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Size = new System.Drawing.Size(396, 64);
            this.groupBox8.TabIndex = 3;
            this.groupBox8.TabStop = false;
            this.groupBox8.Text = "Colors";
            // 
            // colorRangePicker1
            // 
            this.colorRangePicker1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.colorRangePicker1.Location = new System.Drawing.Point(3, 16);
            this.colorRangePicker1.Name = "colorRangePicker1";
            this.colorRangePicker1.Size = new System.Drawing.Size(390, 45);
            this.colorRangePicker1.TabIndex = 0;
            // 
            // groupBox9
            // 
            this.groupBox9.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox9.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.groupBox9.Controls.Add(this.vector2Picker1);
            this.groupBox9.Location = new System.Drawing.Point(0, 280);
            this.groupBox9.Name = "groupBox9";
            this.groupBox9.Size = new System.Drawing.Size(402, 99);
            this.groupBox9.TabIndex = 3;
            this.groupBox9.TabStop = false;
            this.groupBox9.Text = "Gravity";
            // 
            // vector2Picker1
            // 
            this.vector2Picker1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.vector2Picker1.Location = new System.Drawing.Point(3, 16);
            this.vector2Picker1.Name = "vector2Picker1";
            this.vector2Picker1.Size = new System.Drawing.Size(396, 80);
            this.vector2Picker1.TabIndex = 0;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(9, 176);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(50, 17);
            this.checkBox1.TabIndex = 12;
            this.checkBox1.Text = "Loop";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // numericUpDownCapacity
            // 
            this.numericUpDownCapacity.Location = new System.Drawing.Point(9, 150);
            this.numericUpDownCapacity.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.numericUpDownCapacity.Name = "numericUpDownCapacity";
            this.numericUpDownCapacity.Size = new System.Drawing.Size(120, 20);
            this.numericUpDownCapacity.TabIndex = 13;
            this.numericUpDownCapacity.KeyDown += new System.Windows.Forms.KeyEventHandler(this.numericUpDownCapacity_KeyDown);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 134);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "Max particles:";
            // 
            // groupBox10
            // 
            this.groupBox10.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox10.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.groupBox10.Controls.Add(this.textBoxName);
            this.groupBox10.Controls.Add(this.label4);
            this.groupBox10.Controls.Add(this.label1);
            this.groupBox10.Controls.Add(this.numericUpDownCapacity);
            this.groupBox10.Controls.Add(this.label3);
            this.groupBox10.Controls.Add(this.comboBoxBlendMode);
            this.groupBox10.Controls.Add(this.label2);
            this.groupBox10.Controls.Add(this.checkBox1);
            this.groupBox10.Controls.Add(this.textBoxSources);
            this.groupBox10.Location = new System.Drawing.Point(3, 3);
            this.groupBox10.Name = "groupBox10";
            this.groupBox10.Size = new System.Drawing.Size(396, 201);
            this.groupBox10.TabIndex = 4;
            this.groupBox10.TabStop = false;
            this.groupBox10.Text = "Properties";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "Name:";
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(9, 32);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(168, 20);
            this.textBoxName.TabIndex = 16;
            this.textBoxName.TextChanged += new System.EventHandler(this.textBoxName_TextChanged);
            // 
            // ParticleEmitterControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.Controls.Add(this.groupBox10);
            this.Controls.Add(this.groupBox9);
            this.Controls.Add(this.groupBox8);
            this.Controls.Add(this.groupBox7);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "ParticleEmitterControl";
            this.Size = new System.Drawing.Size(411, 767);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.groupBox7.ResumeLayout(false);
            this.groupBox8.ResumeLayout(false);
            this.groupBox9.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCapacity)).EndInit();
            this.groupBox10.ResumeLayout(false);
            this.groupBox10.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxBlendMode;
        private System.Windows.Forms.GroupBox groupBox1;
        private FloatRangeSlider floatRangeSliderFrequency;
        private System.Windows.Forms.GroupBox groupBox2;
        private FloatRangeSlider floatRangeSliderLifeTime;
        private System.Windows.Forms.GroupBox groupBox3;
        private FloatRangeSlider floatRangeSliderRotation;
        private System.Windows.Forms.GroupBox groupBox4;
        private VectorRangeSlider vectorRangeSliderVelocity;
        private System.Windows.Forms.GroupBox groupBox5;
        private VectorRangeSlider vectorRangeSliderPosition;
        private System.Windows.Forms.GroupBox groupBox6;
        private VectorRangeSlider vectorRangeSliderStartScale;
        private System.Windows.Forms.GroupBox groupBox7;
        private VectorRangeSlider vectorRangeSliderEndScale;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxSources;
        private System.Windows.Forms.GroupBox groupBox8;
        private ColorRangePicker colorRangePicker1;
        private System.Windows.Forms.GroupBox groupBox9;
        private Vector2Picker vector2Picker1;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.NumericUpDown numericUpDownCapacity;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox10;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Label label4;
    }
}
