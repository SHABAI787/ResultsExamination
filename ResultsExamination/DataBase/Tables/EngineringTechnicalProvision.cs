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
    /// Инженерно-техническое обеспечение
    /// </summary>
    [Serializable]
    [Table("EngineringTechnicalProvisions")]
    public class EngineringTechnicalProvision
    {
        [DisplayName("Идентификатор")]
        public int Id { get; set; }

        [DisplayName("Тип вентиляции")]
        public VentilationType Ventilation { get; set; }

        [DisplayName("Система отопления")]
        public HeatingSystemType HeatingSystem { get; set; }

        [DisplayName("Сисема охраны")]
        public bool ExistSecuritySystem { get; set; }

        [DisplayName("Сисема пожарной сигнализации")]
        public bool ExistFireAlarm { get; set; }

        [DisplayName("Наличие помещений сверху потребляемые воду")]
        public bool ExistTopPremisesWaterConsumption { get; set; }

        [DisplayName("Кондиционер")]
        public virtual Conditioner Conditioner { get; set; }

        [DisplayName("Источник освещения")]
        public virtual LightSourse LightSourse { get; set; }

        [DisplayName("Жалюзи")]
        public bool ExistJalousie{ get; set; }

        [DisplayName("Шторы")]
        public bool ExistCurtains { get; set; }

        [DisplayName("Иные затеняющие устройства")]
        public bool ExistOtherShading { get; set; }

        [DisplayName("Наличие мест для отвода дренажа")]
        public bool ExistPlacesWithdrawal { get; set; }
    }

    /// <summary>
    /// Тип вентиляционной системы
    /// </summary>
    [Serializable]
    public enum VentilationType
    {
        Отсутствует,
        Принудительная,
        Естественная
    }

    /// <summary>
    /// Тип системы отопления
    /// </summary>
    [Serializable]
    public enum HeatingSystemType
    {
        Отсутствует,
        Водяная,
        Воздушная,
        Электрическая
    }
}
