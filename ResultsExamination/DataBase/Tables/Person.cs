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
    /// Физическое лицо
    /// </summary>
    [Serializable]
    [Table("Persons")]
    public class Person
    {
        [DisplayName("Идентификатор")]
        public int Id { get; set; }

        [DisplayName("Фамилия")]
        public string LastName { get; set; }

        [DisplayName("Имя")]
        public string Name { get; set; }

        [DisplayName("Отчество")]
        public string MiddleName { get; set; }

        [DisplayName("Дата рождения")]
        public DateTime? DataBirth { get; set; }

        [DisplayName("Краткое ФИО")]
        [NotMapped]
        public string ShortFIO
        {
            get { return $"{LastName} {Name?.ElementAt(0).ToString()}.{MiddleName?.ElementAt(0).ToString()}."; }
        }

        public override string ToString()
        {
            return ShortFIO;
        }
    }
}
