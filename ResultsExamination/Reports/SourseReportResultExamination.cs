using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResultsExamination.Reports
{
    [Serializable]
    public class SourseReportResultExamination
    {
        [DisplayName("Объект")]
        public string Name { get; set; }

        [DisplayName("Период устранения недостатков")]
        public string Period { get; set; }

        [DisplayName("Заключение")]
        public string Itog  { get; set; }
    }
}
