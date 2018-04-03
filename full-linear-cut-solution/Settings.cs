﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using LinealCutOptimizer.Core;
using LinealCutOptimizer.Core.Repository;

namespace LinealCutOptimizer
{
    public partial class Settings : Form
    {
        private Params _paramsModel;
        private IList<MeasurementUnit> _muModel;
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
            barPatternBindingSource.DataSource = _bpRepository.GetAll();
        }

        private void LoadParams()
        {
            _paramsModel = _paramsRepository.Get();
            if (_paramsModel != null)
            {
                _params.DataSource = _paramsModel;
            }
        }

        private void LoadMeasurements()
        {
            _muModel = _mesurementRepository.GetAll();
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
                //Saving params
                var repositoryFactory = RepositoryFactory.GetInstance();
                var paramsRepository = repositoryFactory.CreateParamsRepository();
                var vParams = paramsRepository.Get(false);
                vParams.MeasurementUnitId = _paramsModel.MeasurementUnitId;
                paramsRepository.Save();

                Close();
            }
            else
            {
                MessageBox.Show("Debe seleccionar la UM predeterminada.");
            }
        }

        private void measurementUnitComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            var model = _muModel[measurementUnitComboBox.SelectedIndex];
            _paramsModel.MeasurementUnitId = model.Id;
        }
    }
}