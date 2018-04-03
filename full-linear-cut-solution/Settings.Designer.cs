namespace LinealCutOptimizer
{
    partial class Settings
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
            this.components = new System.ComponentModel.Container();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnLoadPatterns = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.barPatternDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.barPatternBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.measurementUnitComboBox = new System.Windows.Forms.ComboBox();
            this._params = new System.Windows.Forms.BindingSource(this.components);
            this._measurements = new System.Windows.Forms.BindingSource(this.components);
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnOk = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.barPatternDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barPatternBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._params)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._measurements)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(681, 472);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.panel1);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.barPatternDataGridView);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Controls.Add(this.measurementUnitComboBox);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(673, 446);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "General";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnLoadPatterns);
            this.panel1.Location = new System.Drawing.Point(17, 85);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(638, 34);
            this.panel1.TabIndex = 4;
            // 
            // btnLoadPatterns
            // 
            this.btnLoadPatterns.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnLoadPatterns.Location = new System.Drawing.Point(488, 0);
            this.btnLoadPatterns.Name = "btnLoadPatterns";
            this.btnLoadPatterns.Size = new System.Drawing.Size(150, 34);
            this.btnLoadPatterns.TabIndex = 0;
            this.btnLoadPatterns.Text = "Cargar desde archivo...";
            this.btnLoadPatterns.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(172, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Patrones de barra predeterminados";
            // 
            // barPatternDataGridView
            // 
            this.barPatternDataGridView.AllowUserToAddRows = false;
            this.barPatternDataGridView.AllowUserToDeleteRows = false;
            this.barPatternDataGridView.AllowUserToOrderColumns = true;
            this.barPatternDataGridView.AutoGenerateColumns = false;
            this.barPatternDataGridView.BackgroundColor = System.Drawing.SystemColors.Info;
            this.barPatternDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.barPatternDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.barPatternDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.barPatternDataGridView.DataSource = this.barPatternBindingSource;
            this.barPatternDataGridView.Location = new System.Drawing.Point(17, 125);
            this.barPatternDataGridView.Name = "barPatternDataGridView";
            this.barPatternDataGridView.ReadOnly = true;
            this.barPatternDataGridView.RowHeadersWidth = 20;
            this.barPatternDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.barPatternDataGridView.Size = new System.Drawing.Size(638, 269);
            this.barPatternDataGridView.TabIndex = 2;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Diameter";
            this.dataGridViewTextBoxColumn2.HeaderText = "Diámetro";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 10;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 200;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Length";
            this.dataGridViewTextBoxColumn3.HeaderText = "Longitud";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 10;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Width = 200;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "MinLengthReusable";
            this.dataGridViewTextBoxColumn4.HeaderText = "Min. long. reusable";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 10;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Width = 200;
            // 
            // barPatternBindingSource
            // 
            this.barPatternBindingSource.DataSource = typeof(LinealCutOptimizer.Core.BarPattern);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "UM predeterminada";
            // 
            // measurementUnitComboBox
            // 
            this.measurementUnitComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedItem", this._params, "MeasurementUnit", true));
            this.measurementUnitComboBox.DataSource = this._measurements;
            this.measurementUnitComboBox.DisplayMember = "Name";
            this.measurementUnitComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.measurementUnitComboBox.FormattingEnabled = true;
            this.measurementUnitComboBox.Location = new System.Drawing.Point(17, 36);
            this.measurementUnitComboBox.Name = "measurementUnitComboBox";
            this.measurementUnitComboBox.Size = new System.Drawing.Size(300, 21);
            this.measurementUnitComboBox.TabIndex = 0;
            this.measurementUnitComboBox.ValueMember = "Id";
            this.measurementUnitComboBox.SelectedIndexChanged += new System.EventHandler(this.measurementUnitComboBox_SelectedIndexChanged);
            // 
            // _params
            // 
            this._params.DataSource = typeof(LinealCutOptimizer.Core.Params);
            // 
            // _measurements
            // 
            this._measurements.DataSource = typeof(LinealCutOptimizer.Core.MeasurementUnit);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnCancel);
            this.panel2.Controls.Add(this.btnOk);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 440);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(681, 32);
            this.panel2.TabIndex = 1;
            // 
            // btnCancel
            // 
            this.btnCancel.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnCancel.Location = new System.Drawing.Point(531, 0);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 32);
            this.btnCancel.TabIndex = 1;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnOk
            // 
            this.btnOk.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnOk.Location = new System.Drawing.Point(606, 0);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(75, 32);
            this.btnOk.TabIndex = 0;
            this.btnOk.Text = "OK";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(681, 472);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.tabControl1);
            this.Name = "Settings";
            this.Text = "Configuración";
            this.Load += new System.EventHandler(this.Settings_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.barPatternDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barPatternBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._params)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._measurements)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.BindingSource _params;
        private System.Windows.Forms.ComboBox measurementUnitComboBox;
        private System.Windows.Forms.BindingSource _measurements;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView barPatternDataGridView;
        private System.Windows.Forms.BindingSource barPatternBindingSource;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.Button btnLoadPatterns;
    }
}