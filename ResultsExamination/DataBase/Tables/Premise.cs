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
    /// Помещение
    /// </summary>
    [Serializable]
    [Table("Premises")]
    public class Premise
    {
        [DisplayName("Идентификатор")]
        public int Id { get; set; }

        [DisplayName("Высота")]
        public double Height { get; set; }

        [DisplayName("Ширина")]
        public double Width { get; set; }

        [DisplayName("Глубина")]
        public double Depth { get; set; }

        [DisplayName("Название")]
        public string Name { get; set; }

        [DisplayName("Номер")]
        public string Num { get; set; }

        [DisplayName("Этаж")]
        public int Floor { get; set; }

        [DisplayName("Первый этаж")]
        public bool FirstFloor { get; set; }

        [DisplayName("Последний этаж")]
        public bool LastFloor { get; set; }

        [DisplayName("Размещено оборудование")]
        public string EquipmentStorage { get; set; }

        [DisplayName("Стены между служебными помещениями")]
        public virtual ICollection<WallPremiseType> WallsServisePremises { get; set; }

        [DisplayName("Стена, граничащая с коридором")]
        public virtual WallPremiseType WallPremiseCorridor { get; set; }

        [DisplayName("Высота до потолка")]
        public double HeightCeiling { get; set; }

        [DisplayName("Высота до подвестного потолка")]
        public double? FakeHeightCeiling { get; set; }

        [DisplayName("Наличие подвестного потолка")]
        [NotMapped]
        public bool ExistSuspendedCeiling { get { return FakeHeightCeiling != null; } }

        [DisplayName("Толщина стен")]
        public double WallThickness { get; set; }
        
        [DisplayName("Покрытие стен")]
        public virtual WallСovering WallСovering { get; set; }

        [DisplayName("Глубина фальшпола")]
        public double? FakeDepthFloor { get; set; }

        [DisplayName("Наличие фальшпола")]
        [NotMapped]
        public bool ExistFakeFloor { get { return FakeDepthFloor != null; } }

        [DisplayName("Чистовая отделка потолка")]
        public bool PureCeiling { get; set; }

        [DisplayName("Наличие антитстатического покрытия пола")]
        public bool ExistAntistaticFloor { get; set; }

        [DisplayName("Величина перепада пола")] //  между данным помещением и корридором
        public double DefferenceSizeFloorBetweenCorridor { get; set; }

        public override string ToString()
        {
            return $"{Name} {Num} В:{Height} Ш:{Width} Г:{Depth}";
        }
    }
}

