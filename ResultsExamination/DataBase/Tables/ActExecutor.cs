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
    /// Исполнитель акта
    /// </summary>
    [Serializable]
    [Table("ActExecutors")]
    public class ActExecutor
    {
        [DisplayName("Идентификатор")]
        public int Id { get; set; }

        [DisplayName("Исполнитель")]
        public virtual Executor Executor { get; set; }
        [Browsable(false)]
        public int? ResultsExaminationActId { get; set; }

        [Browsable(false)]
        [DisplayName("Акт")]
        public virtual ResultsExaminationAct Act { get; set; }

        public override string ToString()
        {
            return $"{Executor} {Act}";
        }
    }
}
