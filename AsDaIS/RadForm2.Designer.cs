namespace AsDaIS
{
    partial class RadForm2
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
            Telerik.WinControls.UI.GridViewDecimalColumn gridViewDecimalColumn1 = new Telerik.WinControls.UI.GridViewDecimalColumn();
            Telerik.WinControls.UI.GridViewDecimalColumn gridViewDecimalColumn2 = new Telerik.WinControls.UI.GridViewDecimalColumn();
            Telerik.WinControls.UI.GridViewDecimalColumn gridViewDecimalColumn3 = new Telerik.WinControls.UI.GridViewDecimalColumn();
            Telerik.WinControls.UI.GridViewDateTimeColumn gridViewDateTimeColumn1 = new Telerik.WinControls.UI.GridViewDateTimeColumn();
            Telerik.WinControls.UI.GridViewDecimalColumn gridViewDecimalColumn4 = new Telerik.WinControls.UI.GridViewDecimalColumn();
            Telerik.WinControls.UI.GridViewDecimalColumn gridViewDecimalColumn5 = new Telerik.WinControls.UI.GridViewDecimalColumn();
            Telerik.WinControls.UI.GridViewDecimalColumn gridViewDecimalColumn6 = new Telerik.WinControls.UI.GridViewDecimalColumn();
            Telerik.WinControls.UI.GridViewDecimalColumn gridViewDecimalColumn7 = new Telerik.WinControls.UI.GridViewDecimalColumn();
            Telerik.WinControls.UI.GridViewDecimalColumn gridViewDecimalColumn8 = new Telerik.WinControls.UI.GridViewDecimalColumn();
            Telerik.WinControls.UI.GridViewDecimalColumn gridViewDecimalColumn9 = new Telerik.WinControls.UI.GridViewDecimalColumn();
            Telerik.WinControls.UI.GridViewDecimalColumn gridViewDecimalColumn10 = new Telerik.WinControls.UI.GridViewDecimalColumn();
            Telerik.WinControls.UI.TableViewDefinition tableViewDefinition1 = new Telerik.WinControls.UI.TableViewDefinition();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RadForm2));
            this.asDaISDataSet = new AsDaIS.AsDaISDataSet();
            this.observationvstarsvisualBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.observation_vstars_visualTableAdapter = new AsDaIS.AsDaISDataSetTableAdapters.observation_vstars_visualTableAdapter();
            this.radGridView1 = new Telerik.WinControls.UI.RadGridView();
            this.visualStudio2012DarkTheme1 = new Telerik.WinControls.Themes.VisualStudio2012DarkTheme();
            ((System.ComponentModel.ISupportInitialize)(this.asDaISDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.observationvstarsvisualBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGridView1.MasterTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            //
            // asDaISDataSet
            //
            this.asDaISDataSet.DataSetName = "AsDaISDataSet";
            this.asDaISDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            //
            // observationvstarsvisualBindingSource
            //
            this.observationvstarsvisualBindingSource.DataMember = "observation_vstars_visual";
            this.observationvstarsvisualBindingSource.DataSource = this.asDaISDataSet;
            //
            // observation_vstars_visualTableAdapter
            //
            this.observation_vstars_visualTableAdapter.ClearBeforeFill = true;
            //
            // radGridView1
            //
            this.radGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.radGridView1.Location = new System.Drawing.Point(0, 0);
            //
            //
            //
            this.radGridView1.MasterTemplate.AutoSizeColumnsMode = Telerik.WinControls.UI.GridViewAutoSizeColumnsMode.Fill;
            gridViewDecimalColumn1.DataType = typeof(int);
            gridViewDecimalColumn1.FieldName = "id";
            gridViewDecimalColumn1.HeaderText = "id";
            gridViewDecimalColumn1.IsAutoGenerated = true;
            gridViewDecimalColumn1.Name = "id";
            gridViewDecimalColumn1.Width = 56;
            gridViewDecimalColumn2.DataType = typeof(int);
            gridViewDecimalColumn2.FieldName = "starname";
            gridViewDecimalColumn2.HeaderText = "starname";
            gridViewDecimalColumn2.IsAutoGenerated = true;
            gridViewDecimalColumn2.Name = "starname";
            gridViewDecimalColumn2.Width = 167;
            gridViewDecimalColumn3.DataType = typeof(int);
            gridViewDecimalColumn3.FieldName = "session";
            gridViewDecimalColumn3.HeaderText = "session";
            gridViewDecimalColumn3.IsAutoGenerated = true;
            gridViewDecimalColumn3.Name = "session";
            gridViewDecimalColumn3.Width = 136;
            gridViewDateTimeColumn1.FieldName = "date";
            gridViewDateTimeColumn1.HeaderText = "date";
            gridViewDateTimeColumn1.IsAutoGenerated = true;
            gridViewDateTimeColumn1.Name = "date";
            gridViewDateTimeColumn1.Width = 93;
            gridViewDecimalColumn4.DataType = typeof(int);
            gridViewDecimalColumn4.FieldName = "comp_set";
            gridViewDecimalColumn4.HeaderText = "comp_set";
            gridViewDecimalColumn4.IsAutoGenerated = true;
            gridViewDecimalColumn4.Name = "comp_set";
            gridViewDecimalColumn4.Width = 173;
            gridViewDecimalColumn5.DataType = typeof(double);
            gridViewDecimalColumn5.FieldName = "comp1";
            gridViewDecimalColumn5.HeaderText = "comp1";
            gridViewDecimalColumn5.IsAutoGenerated = true;
            gridViewDecimalColumn5.Name = "comp1";
            gridViewDecimalColumn5.Width = 133;
            gridViewDecimalColumn6.DataType = typeof(double);
            gridViewDecimalColumn6.FieldName = "comp2";
            gridViewDecimalColumn6.HeaderText = "comp2";
            gridViewDecimalColumn6.IsAutoGenerated = true;
            gridViewDecimalColumn6.Name = "comp2";
            gridViewDecimalColumn6.Width = 133;
            gridViewDecimalColumn7.DataType = typeof(double);
            gridViewDecimalColumn7.FieldName = "comp3";
            gridViewDecimalColumn7.HeaderText = "comp3";
            gridViewDecimalColumn7.IsAutoGenerated = true;
            gridViewDecimalColumn7.Name = "comp3";
            gridViewDecimalColumn7.Width = 133;
            gridViewDecimalColumn8.DataType = typeof(int);
            gridViewDecimalColumn8.FieldName = "mag";
            gridViewDecimalColumn8.HeaderText = "mag";
            gridViewDecimalColumn8.IsAutoGenerated = true;
            gridViewDecimalColumn8.Name = "mag";
            gridViewDecimalColumn8.Width = 93;
            gridViewDecimalColumn9.DataType = typeof(int);
            gridViewDecimalColumn9.FieldName = "comment";
            gridViewDecimalColumn9.HeaderText = "comment";
            gridViewDecimalColumn9.IsAutoGenerated = true;
            gridViewDecimalColumn9.Name = "comment";
            gridViewDecimalColumn9.Width = 173;
            gridViewDecimalColumn10.DataType = typeof(int);
            gridViewDecimalColumn10.FieldName = "chart";
            gridViewDecimalColumn10.HeaderText = "chart";
            gridViewDecimalColumn10.IsAutoGenerated = true;
            gridViewDecimalColumn10.Name = "chart";
            gridViewDecimalColumn10.Width = 98;
            this.radGridView1.MasterTemplate.Columns.AddRange(new Telerik.WinControls.UI.GridViewDataColumn[] {
            gridViewDecimalColumn1,
            gridViewDecimalColumn2,
            gridViewDecimalColumn3,
            gridViewDateTimeColumn1,
            gridViewDecimalColumn4,
            gridViewDecimalColumn5,
            gridViewDecimalColumn6,
            gridViewDecimalColumn7,
            gridViewDecimalColumn8,
            gridViewDecimalColumn9,
            gridViewDecimalColumn10});
            this.radGridView1.MasterTemplate.DataSource = this.observationvstarsvisualBindingSource;
            this.radGridView1.MasterTemplate.ViewDefinition = tableViewDefinition1;
            this.radGridView1.Name = "radGridView1";
            this.radGridView1.Size = new System.Drawing.Size(1397, 553);
            this.radGridView1.TabIndex = 0;
            this.radGridView1.Text = "radGridView1";
            this.radGridView1.ThemeName = "VisualStudio2012Dark";
            this.radGridView1.Click += new System.EventHandler(this.radGridView1_Click);
            //
            // RadForm2
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1397, 553);
            this.Controls.Add(this.radGridView1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "RadForm2";
            //
            //
            //
            this.RootElement.ApplyShapeToControl = true;
            this.Text = "Observations - list";
            this.ThemeName = "VisualStudio2012Dark";
            this.Load += new System.EventHandler(this.RadForm2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.asDaISDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.observationvstarsvisualBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGridView1.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private AsDaISDataSet asDaISDataSet;
        private System.Windows.Forms.BindingSource observationvstarsvisualBindingSource;
        private AsDaISDataSetTableAdapters.observation_vstars_visualTableAdapter observation_vstars_visualTableAdapter;
        private Telerik.WinControls.UI.RadGridView radGridView1;
        private Telerik.WinControls.Themes.VisualStudio2012DarkTheme visualStudio2012DarkTheme1;
    }
}
