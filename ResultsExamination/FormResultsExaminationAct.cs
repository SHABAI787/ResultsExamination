﻿using ResultsExamination.DataBase;
using ResultsExamination.DataBase.Tables;
using System;
using System.Data.Entity;
using System.Windows.Forms;

namespace ResultsExamination
{
    public partial class FormResultsExaminationAct : Form
    {
        ContextResultsExamination contex = null;
        public FormResultsExaminationAct()
        {
            InitializeComponent();
            contex = new ContextResultsExamination();
            contex.Database.Initialize(false);
            LoadData();
        }

        private void LoadData()
        {
            contex.ResultsExaminationActs.Include("ActRecipients")
                .Include("ActRecipients.Recipient").Include("ActRecipients.Recipient.Person").Include("ActRecipients.Recipient.Post")
                .Include("ActExecutors").Include("ActExecutors.Executor")
                .Include("ActExecutors.Executor.Person").Include("ActExecutors.Executor.Post")
                .Include("Premise")
                .Include("PlanPremise").Load();

            bindingSource1.DataSource = contex.ResultsExaminationActs.Local.ToBindingList();
            dataGridView1.DataSource = bindingSource1;
        }

        private void FormResultsExaminationAct_Load(object sender, EventArgs e)
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
                contex.ResultsExaminationActs.Remove((ResultsExaminationAct)item.DataBoundItem);
            }
            contex.SaveChanges();
        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            new FormAddOrEditResultsExaminationAct(contex).ShowDialog(this);
            LoadData();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex >= 0)
                new FormAddOrEditResultsExaminationAct(contex, (ResultsExaminationAct)dataGridView1.Rows[e.RowIndex].DataBoundItem).Show();
        }
    }
}