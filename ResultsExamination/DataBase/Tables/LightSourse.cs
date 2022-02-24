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
    /// Источник освещения
    /// </summary>
    [Serializable]
    [Table("LightSourses")]
    public class LightSourse
    {
        [DisplayName("Идентификатор")]
        public int Id { get; set; }

        [DisplayName("Кол-во люминисцентных ламп")]
        public int AmountLumLamps { get; set; }

        [DisplayName("Кол-во ламп накаливания")]
        public int AmountIncLamps { get; set; }

        [DisplayName("Кол-во мест с постоянным прибыванием людей")]
        public int AmountPlacesPeople { get; set; }

        public override string ToString()
        {
            return $"Люминисцентных ламп:{AmountLumLamps} Ламп накаливания:{AmountIncLamps}" +
                $"Мест с постоянным прибыванием людей:{AmountPlacesPeople}";
        }
    }
}
