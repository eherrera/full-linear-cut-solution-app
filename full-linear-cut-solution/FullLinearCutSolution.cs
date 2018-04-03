using System;
using System.Windows.Forms;
using LinealCutOptimizer;
using LinealCutOptimizer.Core.Data;

namespace FullLinearCutSolution
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void miSettings_Click(object sender, EventArgs e)
        {
            var settingsForm = new Settings();
            settingsForm.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Seeder.Seed();
        }
    }
}
