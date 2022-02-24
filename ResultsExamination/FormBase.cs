using ResultsExamination.DataBase;
using ResultsExamination.DataBase.Tables;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ResultsExamination
{
    public partial class FormBase : Form
    {
        public FormBase()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            labelState.Visible = true;
            new FormResultsExaminationAct().Show(this);
            labelState.Visible = false;
        }
    }
}
