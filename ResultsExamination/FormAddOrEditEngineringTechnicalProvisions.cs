using ResultsExamination.DataBase;
using ResultsExamination.DataBase.Tables;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ResultsExamination
{
    public partial class FormAddOrEditEngineringTechnicalProvisions : Form
    {
        ContextResultsExamination context = null;
        EngineringTechnicalProvision engineringTechnicalProvision = null;
        public FormAddOrEditEngineringTechnicalProvisions(ContextResultsExamination context, EngineringTechnicalProvision engineringTechnicalProvision = null)
        {
            InitializeComponent();
            this.context = context;
            comboBoxConditioner.Items.AddRange(context.Conditioners.ToArray());
            comboBoxLightSourse.Items.AddRange(context.LightSourses.ToArray());
            comboBoxHeatingSystem.Items.AddRange(Enum.GetNames(typeof(HeatingSystemType)));
            comboBoxVentilation.Items.AddRange(Enum.GetNames(typeof(VentilationType)));
            if (engineringTechnicalProvision == null)
            {
                this.engineringTechnicalProvision = new EngineringTechnicalProvision();
                this.engineringTechnicalProvision.Id = -1;
            }
            else
            {
                this.engineringTechnicalProvision = engineringTechnicalProvision;
                comboBoxConditioner.SelectedItem = this.engineringTechnicalProvision.Conditioner;
                comboBoxLightSourse.SelectedItem = this.engineringTechnicalProvision.LightSourse;
                comboBoxVentilation.SelectedItem = Enum.GetName(typeof(VentilationType), this.engineringTechnicalProvision.Ventilation);
                comboBoxHeatingSystem.SelectedItem = Enum.GetName(typeof(HeatingSystemType), this.engineringTechnicalProvision.HeatingSystem);
            }
            checkBoxExistSecuritySystem.DataBindings.Add(new Binding("Checked", this.engineringTechnicalProvision, "ExistSecuritySystem"));
            checkBoxExistFireAlarm.DataBindings.Add(new Binding("Checked", this.engineringTechnicalProvision, "ExistFireAlarm"));
            checkBoxExistTopPremisesWaterConsumption.DataBindings.Add(new Binding("Checked", this.engineringTechnicalProvision, "ExistTopPremisesWaterConsumption"));
            checkBoxExistJalousie.DataBindings.Add(new Binding("Checked", this.engineringTechnicalProvision, "ExistJalousie"));
            checkBoxExistCurtains.DataBindings.Add(new Binding("Checked", this.engineringTechnicalProvision, "ExistCurtains"));
            checkBoxExistOtherShading.DataBindings.Add(new Binding("Checked", this.engineringTechnicalProvision, "ExistOtherShading"));
            checkBoxExistPlacesWithdrawal.DataBindings.Add(new Binding("Checked", this.engineringTechnicalProvision, "ExistPlacesWithdrawal"));
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            engineringTechnicalProvision.Ventilation = comboBoxVentilation.SelectedIndex >= 0 ? (VentilationType)Enum.Parse(typeof(VentilationType), comboBoxVentilation.SelectedItem.ToString()) : VentilationType.Отсутствует;
            engineringTechnicalProvision.HeatingSystem = comboBoxHeatingSystem.SelectedIndex >= 0 ? (HeatingSystemType)Enum.Parse(typeof(HeatingSystemType), comboBoxHeatingSystem.SelectedItem.ToString()) : HeatingSystemType.Отсутствует;
            engineringTechnicalProvision.LightSourse = comboBoxLightSourse.SelectedIndex >= 0 ? (LightSourse)comboBoxLightSourse.SelectedItem : null;
            engineringTechnicalProvision.Conditioner = comboBoxConditioner.SelectedIndex >= 0 ? (Conditioner)comboBoxConditioner.SelectedItem : null;
            if (engineringTechnicalProvision.Id == -1)
                context.EngineringTechnicalProvisions.Add(engineringTechnicalProvision);

            context.SaveChanges();
        }
    }
}
