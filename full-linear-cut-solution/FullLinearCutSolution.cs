using System;
using System.Threading;
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
            SetStatus("Cargando configuración...");
            var settingsForm = new Settings();
            settingsForm.Shown += (o, args) => SetStatus("");
            settingsForm.ShowDialog();
        }

        private void SetStatus(string status)
        {
            var t = new Thread(delegate(object form) { ((frmMain) form).statusLabel.Text = status; });
            t.Start(this);
            t.Join();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Seeder.Seed();
        }
    }
}