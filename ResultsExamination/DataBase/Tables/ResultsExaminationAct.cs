using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResultsExamination.DataBase.Tables
{
    /// <summary>
    /// Акт результатов обследования
    /// </summary>
    [Serializable]
    [Table("ResultsExaminationActs")]
    public class ResultsExaminationAct
    {
        [DisplayName("Идентификатор")]
        public int Id { get; set; }
        [DisplayName("Дата создания")]
        public DateTime DataCreate { get; set; }

        [DisplayName("Номер объекта")]
        public string NumObject { get; set; }

        [DisplayName("Адрес объекта")]
        public string AddresObject { get; set; }

        [ReadOnly(true)]
        [Browsable(false)]
        public virtual ICollection<ActRecipient> ActRecipients { get; set; }

        [ReadOnly(true)]
        [Browsable(false)]
        public virtual ICollection<ActExecutor> ActExecutors { get; set; }

        [DisplayName("От получателя")]
        [ReadOnly(true)]
        [NotMapped]
        public string ActRecipientsText
        {
            get 
            {
                string text = string.Empty;
                if(ActRecipients != null && ActRecipients.Count > 0 && ActRecipients.Any(a => a.Recipient != null))
                    text = $"{string.Join(",", ActRecipients?.Where(a => a.Recipient != null).Select(a => a.Recipient.ToString()).ToArray())}";

                return text;
            }
        }

        [DisplayName("От исполнителя")]
        [ReadOnly(true)]
        [NotMapped]
        public string ActExecutersText
        {
            get 
            {
                string text = string.Empty;
                if (ActExecutors != null && ActExecutors.Count > 0 && ActExecutors.Any(a => a.Executor != null))
                    text = $"{string.Join(",", ActExecutors?.Where(a => a.Executor != null).Select(a => a.Executor.ToString()).ToArray())}";

                return text;
            }
        }

        [DisplayName("Помещение")]
        [ReadOnly(true)]
        public virtual Premise Premise { get; set; }

        [DisplayName("Дополнительно")]
        public string Additionally { get; set; }

        [DisplayName("Заключение комиссии")] // помещение соответствует/не соответствует
        public bool CommissionConclusion { get; set; }

        [DisplayName("Недостатки для устранения")]
        public string ShortcomingEliminate { get; set; }

        [DisplayName("Начало периода устраненя")]
        public DateTime? CorrectionPeriodIn { get; set; }

        [DisplayName("Конец периода устраненя")]
        public DateTime? CorrectionPeriodOut { get; set; }

        [Browsable(false)]
        [ReadOnly(true)]
        public File PlanPremise { get; set; }

        [DisplayName("Наличие плана помещения")]
        [ReadOnly(true)]
        [NotMapped]
        public bool ExistPlanPremise
        {
            get { return PlanPremise != null; }
        }


        public ResultsExaminationAct()
        {
            DataCreate = DateTime.Now;
        }
    }
}
