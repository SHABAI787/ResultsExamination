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
    /// Дверь
    /// </summary>
    [Serializable]
    [Table("Doors")]
    public class Door
    {
        [DisplayName("Идентификатор")]
        public int Id { get; set; }

        [DisplayName("Одинарная")]
        public bool Single { get; set; }

        [DisplayName("Двустворчатая")]
        public bool Dual { get; set; }

        [DisplayName("Материал")]
        public virtual DoorMaterial Material { get; set; }

        [DisplayName("Наличие замка")]
        public bool ExistLock { get; set; }

        [DisplayName("Высота")]
        public double Height { get; set; }

        [DisplayName("Ширина")]
        public double Width { get; set; }

        [DisplayName("Толщина")]
        public double Thickness { get; set; }

        [DisplayName("Наличие уплотнителя")]
        public bool ExistSeal{ get; set; }

        [DisplayName("Ширина тамбура")]
        public double WidthTambour { get; set; }

        public override string ToString()
        {
            return $"{(Single ? "Одинарная" : "")}{(Dual ? "Двустворчатая" : "")} В:{Height} Ш:{Width} Т:{Thickness}";
        }
    }
}
