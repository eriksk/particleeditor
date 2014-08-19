using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ParticleEditor.Controls
{
    public partial class ImportWindow : Form
    {
        public string Content { get; set; }

        public ImportWindow()
        {
            InitializeComponent();
        }

        private void buttonOk_Click(object sender, EventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.OK;
            Content = richTextBox1.Text;
            this.Close();
        }
    }
}
