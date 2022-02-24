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
    /// Кондиционер
    /// </summary>
    [Serializable]
    [Table("Conditioners")]
    public class Conditioner
    {
        [DisplayName("Идентификатор")]
        public int Id { get; set; }

        [DisplayName("Сисема чиллер-фанкойл")]
        public bool SystemFankoil { get; set; }

        [DisplayName("Фреоные системы")]
        public bool SystemFreon { get; set; }

        [DisplayName("Марка оборудования")]
        public string Name { get; set; }

        public override string ToString()
        {
            return $"{Name} {(SystemFankoil ? "Сисема чиллер-фанкойл " : "")}{(SystemFreon ? "Фреоные системы" : "")}";
        }
    }
}
