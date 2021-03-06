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
    /// Покрытие стен
    /// </summary>
    [Serializable]
    [Table("WallСoverings")]
    public class WallСovering
    {
        [DisplayName("Идентификатор")]
        public int Id { get; set; }

        [DisplayName("Наименование")]
        public string Name { get; set; }

        [DisplayName("Описание покрытия")]
        public string Description { get; set; }

        public override string ToString()
        {
            return Name;
        }
    }
}
