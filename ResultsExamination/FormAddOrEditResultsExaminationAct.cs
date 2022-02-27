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
using ResultsExamination.DataBase.Tables;
using System.IO;
using File = ResultsExamination.DataBase.Tables.File;
using System.Collections.ObjectModel;

namespace ResultsExamination
{
    public partial class FormAddOrEditResultsExaminationAct : Form
    {
        ContextResultsExamination context = null;
        ResultsExaminationAct resultsExaminationAct = null;
        BindingList<Executor> executor = new BindingList<Executor>();
        BindingList<Recipient> recipient = new BindingList<Recipient>();
        public FormAddOrEditResultsExaminationAct(ContextResultsExamination context, ResultsExaminationAct resultsExaminationAct = null)
        {
            InitializeComponent();
            this.context = context;
            comboBoxPremise.Items.AddRange(context.Premises.ToArray());
            dataGridViewActExecutors.DataSource = executor;
            dataGridViewActRecipients.DataSource = recipient;
            toolStripButtonExecutors.Items.AddRange(context.Executors.ToArray());
            toolStripButtonRecipients.Items.AddRange(context.Recipients.ToArray());

            if (resultsExaminationAct == null)
            {
                this.resultsExaminationAct = new ResultsExaminationAct();
                this.resultsExaminationAct.Id = -1;
            }
            else
            {
                this.resultsExaminationAct = resultsExaminationAct;

                foreach (var item in this.resultsExaminationAct.ActExecutors.Select(r => r.Executor))
                    executor.Add(item);

                foreach (var item in this.resultsExaminationAct.ActRecipients.Select(r => r.Recipient))
                    recipient.Add(item);
               comboBoxPremise.SelectedItem = this.resultsExaminationAct.Premise;
            }

            textBoxNumObject.DataBindings.Add(new Binding("Text", this.resultsExaminationAct, "NumObject"));
            textBoxAddresObject.DataBindings.Add(new Binding("Text", this.resultsExaminationAct, "AddresObject"));
            richTextBoxAdditionally.DataBindings.Add(new Binding("Text", this.resultsExaminationAct, "Additionally"));
            checkBoxCommissionConclusion.DataBindings.Add(new Binding("Checked", this.resultsExaminationAct, "CommissionConclusion"));
            richTextBoxShortcomingEliminate.DataBindings.Add(new Binding("Text", this.resultsExaminationAct, "ShortcomingEliminate"));
            dateTimePickerIn.Value = this.resultsExaminationAct.CorrectionPeriodIn.HasValue ? this.resultsExaminationAct.CorrectionPeriodIn.Value : DateTime.Now;
            dateTimePickerOut.Value = this.resultsExaminationAct.CorrectionPeriodOut.HasValue ? this.resultsExaminationAct.CorrectionPeriodOut.Value : DateTime.Now.AddMonths(3);
            textBoxFile.Text = this.resultsExaminationAct.PlanPremise?.Name;
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if(dataGridViewActExecutors.Rows.Count > 0)
                resultsExaminationAct.ActExecutors = dataGridViewActExecutors.Rows.Cast<DataGridViewRow>().Select(d => new ActExecutor() { Executor = (Executor)d.DataBoundItem }).ToList();
            if(dataGridViewActRecipients.Rows.Count > 0)
                resultsExaminationAct.ActRecipients = dataGridViewActRecipients.Rows.Cast<DataGridViewRow>().Select(d => new ActRecipient() { Recipient = (Recipient)d.DataBoundItem }).ToList();
           
            resultsExaminationAct.Premise = comboBoxPremise.SelectedIndex >= 0 ? (Premise)comboBoxPremise.SelectedItem : null;
            resultsExaminationAct.CorrectionPeriodIn = dateTimePickerIn.Value == dateTimePickerIn.MinDate ? null : (DateTime?)dateTimePickerIn.Value;
            resultsExaminationAct.CorrectionPeriodOut = dateTimePickerOut.Value == dateTimePickerOut.MinDate ? null : (DateTime?)dateTimePickerOut.Value;
            if (System.IO.File.Exists(textBoxFile.Text))
            {
                File file = new File(textBoxFile.Text);
                resultsExaminationAct.PlanPremise = file;
            }

            if(resultsExaminationAct.Id == -1)
                context.ResultsExaminationActs.Add(resultsExaminationAct);

            context.SaveChanges();
        }

        private void buttonOpen_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                if(openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    textBoxFile.Text = openFileDialog.FileName;
                }
            }
        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            if(toolStripButtonRecipients.SelectedIndex >= 0)
            {
                recipient.Add((Recipient)toolStripButtonRecipients.SelectedItem);
            }
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            if (toolStripButtonExecutors.SelectedIndex >= 0)
            {
                executor.Add((Executor)toolStripButtonExecutors.SelectedItem);
            }
        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            ICollection<Recipient> delItems = new Collection<Recipient>();
            foreach (DataGridViewRow item in dataGridViewActRecipients.SelectedRows)
                delItems.Add((Recipient)item.DataBoundItem);
            
            foreach (var item in delItems)
                recipient.Remove(item);

        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            ICollection<Executor> delItems = new Collection<Executor>();
            foreach (DataGridViewRow item in dataGridViewActExecutors.SelectedRows)
            {
                delItems.Add((Executor)item.DataBoundItem);
            }

            foreach (var item in delItems)
                executor.Remove(item);
        }
    }
}
