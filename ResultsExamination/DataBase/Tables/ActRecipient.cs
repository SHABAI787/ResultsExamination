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
    /// Получатель акта
    /// </summary>
    [Serializable]
    [Table("ActRecipients")]
    public class ActRecipient
    {
        [DisplayName("Идентификатор")]
        public int Id { get; set; }

        [DisplayName("Получатель")]
        public virtual Recipient Recipient { get; set; }
        [Browsable(false)]
        public int? ResultsExaminationActId { get; set; }

        [DisplayName("Акт")]
        public virtual ResultsExaminationAct Act { get; set; }

        public override string ToString()
        {
            return $"{Recipient} {Act}";
        }
    }
}
