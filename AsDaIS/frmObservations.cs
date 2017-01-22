using System;
using Telerik.WinControls.UI;

namespace AsDaIS
{
    public partial class RadForm2 : RadForm
    {
        public RadForm2()
        {
            InitializeComponent();
        }

        private void RadForm2_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'asDaISDataSet.observation_vstars_visual' table. You can move, or remove it, as needed.
            observation_vstars_visualTableAdapter.Fill(asDaISDataSet.observation_vstars_visual);
        }

        private void radGridView1_Click(object sender, EventArgs e)
        {
        }
    }
}