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
    /// Исполнение защитной решётки
    /// </summary>
    [Serializable]
    [Table("ProtectGridPerfomanses")]
    public class ProtectGridPerfomanse
    {
        [DisplayName("Идентификатор")]
        public int Id { get; set; }

        [DisplayName("Наименование")]
        public string Name { get; set; }

        public override string ToString()
        {
            return Name;
        }
    }
}
