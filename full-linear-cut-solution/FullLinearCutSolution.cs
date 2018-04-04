using System;
using System.Collections.Generic;
using System.Reflection;
using System.Security.Policy;
using System.Threading;
using System.Windows.Forms;
using FullLinearCutSolution.Core;
using FullLinearCutSolution.Core.Model;
using LinealCutOptimizer;
using LinealCutOptimizer.Core;
using LinealCutOptimizer.Core.Helpers;
using LinealCutOptimizer.Core.Repository;

namespace FullLinearCutSolution
{
    public partial class frmMain : Form
    {
        private Settings _settingsForm;

        private IBarPatternRepository _bpRepository;
        private IParamsRepository _paramsRepository;
        private Params _paramsModel;
        private IList<BarPattern> _patterns;
        private IList<OrderItem> _items;

        public frmMain()
        {
            InitializeComponent();
        }

        private void miSettings_Click(object sender, EventArgs e)
        {
            SetStatus("Cargando configuración...");
            _settingsForm = new Settings();
            _settingsForm.Shown += (o, args) => SetStatus("");
            _settingsForm.ShowDialog();
        }

        private void SetStatus(string status)
        {
            var t = new Thread(delegate(object form) { ((frmMain) form).statusLabel.Text = status; });
            t.Start(this);
            t.Join();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Seeder.Seed();
            openFileDialog1.ShowDialog();
        }

        private bool LoadData()
        {
            try
            {
                var repositoryFactory = RepositoryFactory.GetInstance();

                _bpRepository = repositoryFactory.CreateBarPatternRepository();
                _paramsRepository = repositoryFactory.CreateParamsRepository();

                _patterns = _bpRepository.GetAll();
                _paramsModel = _paramsRepository.Get();
            }
            catch (Exception)
            {
                if (_settingsForm == null)
                {
                    MessageBox.Show(
                        "No se pudo obtener la conf. de la base de datos. Por favor vaya a Archivo/Configuración para ajustar la misma.");
                    return false;
                }
                _paramsModel = _settingsForm?.GetParams();
                _patterns = _settingsForm?.GetBarPatterns();
            }
            return true;
        }

        private void openFileDialog1_FileOk(object sender, System.ComponentModel.CancelEventArgs e)
        {
            try
            {
                _items = ExcelLoader.Load<OrderItem>(openFileDialog1.FileName);
            }
            catch (Exception exception)
            {
                MessageBox.Show(
                    $"No se pudo cargar el archivo con las líneas de la orden, Detalles: {exception.Message}");
            }

            orderItemBindingSource.DataSource = _items;
        }

        private void orderItemDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            /*var fileUrl =
                $"file:///{Assembly.GetCallingAssembly().Location}/template.html"
                    .Replace($"\\{nameof(FullLinearCutSolution)}.exe", "").Replace("\\", "/");
            var uri = new Uri("http://gmail.com");*/

            

            //webBrowser.Refresh();
        }
    }
}