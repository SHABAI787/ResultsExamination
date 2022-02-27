using ResultsExamination.DataBase;
using ResultsExamination.Reports;
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
    public partial class FormReportResultsExamination : Form
    {
        List<SourseReportResultExamination> sourseReport = new List<SourseReportResultExamination>();
        ContextResultsExamination context = null;
        public FormReportResultsExamination(ContextResultsExamination context)
        {
            InitializeComponent();
            this.context = context;

            this.context.ResultsExaminationActs.Include("ActRecipients")
                .Include("ActRecipients.Recipient").Include("ActRecipients.Recipient.Person").Include("ActRecipients.Recipient.Post")
                .Include("ActExecutors").Include("ActExecutors.Executor")
                .Include("ActExecutors.Executor.Person").Include("ActExecutors.Executor.Post")
                .Include("Premise")
                .Include("PlanPremise").Load();
        }

        private void buttonForm_Click(object sender, EventArgs e)
        {
            foreach (var act in this.context.ResultsExaminationActs.Where(a => a.CorrectionPeriodIn >= dateTimePickerDateIn.Value && a.CorrectionPeriodOut <= dateTimePickerDateOut.Value))
            {
                sourseReport.Add(new SourseReportResultExamination()
                {
                    Itog = act.CommissionConclusion ? "Помещение соответствует" : "Не соответствует",
                    Name = act.NumObject,
                    Period = $"{(act.CorrectionPeriodIn.HasValue ? act.CorrectionPeriodIn.Value.ToShortDateString() : "")} " +
                    $"- {(act.CorrectionPeriodOut.HasValue ? act.CorrectionPeriodOut.Value.ToShortDateString() : "")}"
                });
            }

            SourseReportResultExaminationBindingSource.DataSource = sourseReport;

            this.reportViewer1.RefreshReport();
        }
    }
}
