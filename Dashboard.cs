using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RegisterUser_CSharp
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        private void textEditorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textEditor textEditor = new textEditor();
            textEditor.MdiParent = this;
            textEditor.Show();
        }

        private void stopWatchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            stopWatch stopWatch = new stopWatch();
            stopWatch.MdiParent = this;
            stopWatch.Show();
        }
    }
}
