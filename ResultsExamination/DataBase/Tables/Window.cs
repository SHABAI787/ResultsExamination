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
    /// Окно
    /// </summary>
    [Serializable]
    [Table("Windows")]
    public class Window
    {
        [DisplayName("Идентификатор")]
        public int Id { get; set; }

        [DisplayName("Кол-во стекол")]
        public int AmmountGlass { get; set; }

        [DisplayName("Кол-во фрамуг")]
        public int AmmountTransom { get; set; }

        [DisplayName("Материал из дерева")]
        public bool IsWoodMaterial { get; set; }

        [DisplayName("Материал из пластика")]
        public bool IsPlasticMaterial { get; set; }

        [DisplayName("Высота")]
        public double Height { get; set; }

        [DisplayName("Ширина")]
        public double Width { get; set; }

        [DisplayName("Исполнение защит.решёток")]
        public virtual ProtectGridPerfomanse ProtectGridPerfomanse { get; set; }

        public override string ToString()
        {
            return $"{(IsWoodMaterial ? "Материал из дерева" : "")} {(IsPlasticMaterial ? "Материал из пластика" : "")} " +
                $"Кол-во стекол:{AmmountGlass} В:{Height} Ш:{Width}";
        }
    }
}
