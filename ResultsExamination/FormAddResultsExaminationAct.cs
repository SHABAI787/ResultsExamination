using ResultsExamination.DataBase;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Entity;

namespace ResultsExamination
{
    public partial class FormAddResultsExaminationAct : Form
    {
        ContextResultsExamination context = null;
        public FormAddResultsExaminationAct(ContextResultsExamination context)
        {
            InitializeComponent();
            this.context = context;
        }

        private void FormAddResultsExaminationAct_Load(object sender, EventArgs e)
        {
            dataGridViewActExecutors.DataSource = context.ActExecutors.Local.ToBindingList();
            dataGridViewActRecipients.DataSource = context.ActRecipients.Local.ToBindingList();
            comboBoxPremise.Items.AddRange(context.Premises.ToArray());
        }
    }
}
