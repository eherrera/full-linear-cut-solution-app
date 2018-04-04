using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using FullLinearCutSolution.Core;
using LinealCutOptimizer.Core.Helpers;
using LinealCutOptimizer.Core.Repository;

namespace LinealCutOptimizer
{
    public partial class Settings : Form
    {
        private Params _paramsModel;
        private IList<MeasurementUnit> _muModel;
        private IList<BarPattern> _patterns; 
        private readonly IBarPatternRepository _bpRepository;
        private readonly IParamsRepository _paramsRepository;
        private readonly IMesurementRepository _mesurementRepository;

        public Settings()
        {
            InitializeComponent();

            var repositoryFactory = RepositoryFactory.GetInstance();
            _bpRepository = repositoryFactory.CreateBarPatternRepository();
            _paramsRepository = repositoryFactory.CreateParamsRepository();
            _mesurementRepository = repositoryFactory.CreateMesurementRepository();
        }

        private void Settings_Load(object sender, EventArgs e)
        {
            LoadParams();
            LoadMeasurements();
            LoadBarPatterns();
        }

        private void LoadBarPatterns()
        {
            try
            {
                _patterns = _bpRepository.GetAll();
            }
            catch (Exception)
            {
                _patterns = new List<BarPattern> {new BarPattern {Diameter = "10mm", Length = 9, MinLengthReusable = 1}};
            }
            barPatternBindingSource.DataSource = _patterns;
        }

        private void LoadParams()
        {
            try
            {
                _paramsModel = _paramsRepository.Get();
            }
            catch (Exception e)
            {
                Console.WriteLine($"Error accediendo a la base de datos. Detalles:{e.Message}.");
                _paramsModel = new Params {Id = 1, MeasurementUnitId = 1};
            }

            if (_paramsModel != null)
            {
                _params.DataSource = _paramsModel;
            }
        }

        private void LoadMeasurements()
        {
            try
            {
                _muModel = _mesurementRepository.GetAll();
            }
            catch (Exception)
            {
                _muModel = new List<MeasurementUnit> {new MeasurementUnit {Code = "m", Name = "Metros", Id = 1}};
            }

            _measurements.DataSource = _muModel;

            //@fixme resolve binding
            measurementUnitComboBox.SelectedIndex =
                _muModel.IndexOf(_muModel.FirstOrDefault(m => m.Id == _paramsModel?.MeasurementUnit?.Id));
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            if (measurementUnitComboBox.SelectedIndex != -1)
            {
                try
                {
                    //Saving params
                    var repositoryFactory = RepositoryFactory.GetInstance();
                    var paramsRepository = repositoryFactory.CreateParamsRepository();
                    var vParams = paramsRepository.Get(false);
                    vParams.MeasurementUnitId = _paramsModel.MeasurementUnitId;
                    paramsRepository.Save();

                    //Saving bar patterns


                    Close();
                }
                catch (Exception exception)
                {
                    MessageBox.Show($"Error guardando los parámetros. Detalles: {exception.Message}");
                }
            }
            else
            {
                MessageBox.Show("Debe seleccionar la UM predeterminada.");
            }
        }

        private void measurementUnitComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (measurementUnitComboBox.SelectedIndex == -1) return;
            var model = _muModel[measurementUnitComboBox.SelectedIndex];
            _paramsModel.MeasurementUnitId = model.Id;
        }

        private void btnLoadPatterns_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
        }

        private void openFileDialog1_FileOk(object sender, System.ComponentModel.CancelEventArgs e)
        {
            var fileName = openFileDialog1.FileName;
            try
            {
                _patterns = ExcelLoader.Load<BarPattern>(fileName);
                barPatternBindingSource.DataSource = _patterns;
            }
            catch (Exception exception)
            {
                MessageBox.Show($"Error cargando archivo. Detalles: {exception.Message}");
            }
        }

        public Params GetParams()
        {
            return _paramsModel;
        }

        public IList<BarPattern> GetBarPatterns()
        {
            return _patterns;
        }
    }
}