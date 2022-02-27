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
    /// Исполнитель
    /// </summary>
    [Serializable]
    [Table("Executors")]
    public class Executor
    {
        [Browsable(false)]
        [DisplayName("Идентификатор")]
        public int Id { get; set; }

        [DisplayName("Физ.лицо")]
        [ReadOnly(true)]
        public virtual Person Person { get; set; }

        [DisplayName("Должность")]
        [ReadOnly(true)]
        public virtual Post Post { get; set; }

        public override string ToString()
        {
            return $"{Post?.Name} {Person?.ShortFIO}";
        }
    }
}
