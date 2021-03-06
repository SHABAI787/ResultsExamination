using ResultsExamination.DataBase;
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
    public partial class FormPersons : Form
    {
        ContextResultsExamination contex = null;
        public FormPersons(ContextResultsExamination contex)
        {
            InitializeComponent();
            this.contex = contex;
            contex.Persons.Load();
            bindingSource1.DataSource = contex.Persons.Local.ToBindingList();
            dataGridView1.DataSource = bindingSource1;
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            dataGridView1.ExportToExcel();
        }

        private void FormConstructionDefects_FormClosed(object sender, FormClosedEventArgs e)
        {
            dataGridView1.EndEdit();
            contex.SaveChanges();
        }
    }
}
