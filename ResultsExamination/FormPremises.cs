using ResultsExamination.DataBase;
using ResultsExamination.DataBase.Tables;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ResultsExamination
{
    public partial class FormPremises : Form
    {
        ContextResultsExamination contex = null;
        public FormPremises(ContextResultsExamination contex)
        {
            InitializeComponent();
            this.contex = contex;
            LoadData();
        }

        private void LoadData()
        {
            contex.Premises.Include("WallsServisePremises")
                .Include("WallPremiseCorridor")
                .Include("WallСovering")
                .Include("ConstructionDefects")
                .Include("FloorType")
                .Include("FloorPerformanse")
                .Include("Door")
                .Include("Windows")
                .Include("EngineringTechnicalProvision")
                .Include("FakeFloorMaterial").Load();

            bindingSource1.DataSource = contex.Premises.Local.ToBindingList();
            dataGridView1.DataSource = bindingSource1;
        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
           
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            dataGridView1.ExportToExcel();
        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow item in dataGridView1.SelectedRows)
            {
                contex.Premises.Remove((Premise)item.DataBoundItem);
            }
            contex.SaveChanges();
        }
    }
}
