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
    /// Должность
    /// </summary>
    [Serializable]
    [Table("Posts")]
    public class Post
    {
        [DisplayName("Идентификатор")]
        public int Id { get; set; }
        [DisplayName("Наименование")]
        public string Name { get; set; }
    }
}
