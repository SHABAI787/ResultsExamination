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
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ResultsExamination
{
    public partial class FormEngineringTechnicalProvisions : Form
    {
        ContextResultsExamination contex = null;
        public FormEngineringTechnicalProvisions(ContextResultsExamination contex)
        {
            InitializeComponent();
            this.contex = contex;
            LoadData();
        }

        private void LoadData()
        {
            contex.EngineringTechnicalProvisions
                .Include("Conditioner")
                .Include("LightSourse")
                .Load();

            bindingSource1.DataSource = contex.EngineringTechnicalProvisions.Local.ToBindingList();
            dataGridView1.DataSource = bindingSource1;
        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow item in dataGridView1.SelectedRows)
            {
                contex.EngineringTechnicalProvisions.Remove((EngineringTechnicalProvision)item.DataBoundItem);
            }
            contex.SaveChanges();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            dataGridView1.ExportToExcel();
        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            new FormAddOrEditEngineringTechnicalProvisions(contex).Show();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex >= 0)
                new FormAddOrEditEngineringTechnicalProvisions(contex, (EngineringTechnicalProvision)dataGridView1.Rows[e.RowIndex].DataBoundItem).Show();
        }
    }
}
