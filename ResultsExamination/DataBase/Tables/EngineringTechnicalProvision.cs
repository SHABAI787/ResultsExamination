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
