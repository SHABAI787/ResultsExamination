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
    /// Материал двери
    /// </summary>
    [Serializable]
    [Table("DoorMaterials")]
    public class DoorMaterial
    {
        [DisplayName("Идентификатор")]
        public int Id { get; set; }

        [DisplayName("Название")]
        public string Name { get; set; }

        public override string ToString()
        {
            return Name;
        }
    }
}
