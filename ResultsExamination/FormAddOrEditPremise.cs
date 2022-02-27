using ResultsExamination.DataBase;
using ResultsExamination.DataBase.Tables;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ResultsExamination
{
    public partial class FormAddOrEditPremise : Form
    {
        ContextResultsExamination context = null;
        Premise premise = null;
        BindingList<WallPremiseType> wallsServisePremises = new BindingList<WallPremiseType>();
        BindingList<ConstructionDefect> constructionDefects = new BindingList<ConstructionDefect>();
        BindingList<Window> windows = new BindingList<Window>();
        public FormAddOrEditPremise(ContextResultsExamination context, Premise premise = null)
        {
            InitializeComponent();
            this.context = context;
            dataGridViewWallsServisePremises.DataSource = wallsServisePremises;
            dataGridViewConstructionDefects.DataSource = constructionDefects;
            dataGridViewWindows.DataSource = windows;
            comboBoxDoor.Items.AddRange(context.Doors.ToArray());
            comboBoxEngineringTechnicalProvision.Items.AddRange(context.EngineringTechnicalProvisions.ToArray());
            comboBoxFloorType.Items.AddRange(context.FloorTypes.ToArray());
            comboBoxFakeFloorMaterial.Items.AddRange(context.FakeFloorMaterials.ToArray());
            comboBoxFloorPerformanse.Items.AddRange(context.FloorPerformanses.ToArray());
            toolStripButtonRecipientsWallPremiseType.Items.AddRange(context.WallPremiseTypes.ToArray());
            comboBoxWallPremiseCorridor.Items.AddRange(context.WallPremiseTypes.ToArray());
            comboBoxWallСovering.Items.AddRange(context.WallСoverings.ToArray());
            toolStripComboBoxConstructionDefect.Items.AddRange(context.ConstructionDefects.ToArray());
            toolStripComboBoxWindows.Items.AddRange(context.Windows.ToArray());

            if(premise == null)
            {
                this.premise = new Premise();
                this.premise.Id = -1;
            }
            else
            {
                this.premise = premise;
                if(this.premise.WallsServisePremises != null)
                    foreach (var item in this.premise.WallsServisePremises)
                        wallsServisePremises.Add(item);

                if (this.premise.ConstructionDefects != null)
                    foreach (var item in this.premise.ConstructionDefects)
                        constructionDefects.Add(item);

                if (this.premise.Windows != null)
                    foreach (var item in this.premise.Windows)
                        windows.Add(item);
            }
            numericUpDownHeight.DataBindings.Add(new Binding("Value", this.premise, "Height"));
            numericUpDownWidth.DataBindings.Add(new Binding("Value", this.premise, "Width"));
            numericUpDownDepth.DataBindings.Add(new Binding("Value", this.premise, "Depth"));
            textBoxName.DataBindings.Add(new Binding("Text", this.premise, "Name"));
            textBoxNum.DataBindings.Add(new Binding("Text", this.premise, "Num"));
            numericUpDownFloor.DataBindings.Add(new Binding("Value", this.premise, "Floor"));
            radioButtonFirstFloor.DataBindings.Add(new Binding("Checked", this.premise, "FirstFloor"));
            radioButtonLastFloor.DataBindings.Add(new Binding("Checked", this.premise, "LastFloor"));
            textBoxEquipmentStorage.DataBindings.Add(new Binding("Text", this.premise, "EquipmentStorage"));
            numericUpDownHeightCeiling.DataBindings.Add(new Binding("Value", this.premise, "HeightCeiling"));
            numericUpDownFakeHeightCeiling.Value = this.premise.FakeHeightCeiling.HasValue ? (decimal)this.premise.FakeHeightCeiling.Value : 0;
            checkBoxPureCeiling.DataBindings.Add(new Binding("Checked", this.premise, "PureCeiling"));
            checkBoxExistAntistaticFloor.DataBindings.Add(new Binding("Checked", this.premise, "ExistAntistaticFloor"));
            numericUpDownDefferenceSizeFloorBetweenCorridor.DataBindings.Add(new Binding("Value", this.premise, "DefferenceSizeFloorBetweenCorridor"));
            numericUpDownFakeDepthFloor.Value = this.premise.FakeDepthFloor.HasValue ? (decimal)this.premise.FakeDepthFloor.Value : 0;
            comboBoxDoor.SelectedItem = this.premise.Door;
            comboBoxEngineringTechnicalProvision.SelectedItem = this.premise.EngineringTechnicalProvision;
            comboBoxFloorType.SelectedItem = this.premise.FloorType;
            comboBoxFakeFloorMaterial.SelectedItem = this.premise.FakeFloorMaterial;
            comboBoxFloorPerformanse.SelectedItem = this.premise.FloorPerformanse;
            comboBoxWallPremiseCorridor.SelectedItem = this.premise.WallPremiseCorridor;
            comboBoxWallСovering.SelectedItem = this.premise.WallСovering;
        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            if (toolStripButtonRecipientsWallPremiseType.SelectedIndex >= 0)
            {
                wallsServisePremises.Add((WallPremiseType)toolStripButtonRecipientsWallPremiseType.SelectedItem);
            }
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            premise.FakeHeightCeiling = (double?)numericUpDownFakeHeightCeiling.Value == 0 ? null : (double?)numericUpDownFakeHeightCeiling.Value;
            premise.FakeDepthFloor = (double?)numericUpDownFakeDepthFloor.Value == 0 ? null : (double?)numericUpDownFakeDepthFloor.Value;
            premise.Door = comboBoxDoor.SelectedIndex >= 0 ? (Door)comboBoxDoor.SelectedItem : null;
            premise.EngineringTechnicalProvision = comboBoxEngineringTechnicalProvision.SelectedIndex >= 0 ? (EngineringTechnicalProvision)comboBoxEngineringTechnicalProvision.SelectedItem : null;
            premise.FloorType = comboBoxFloorType.SelectedIndex >= 0 ? (FloorType)comboBoxFloorType.SelectedItem : null;
            premise.FakeFloorMaterial = comboBoxFakeFloorMaterial.SelectedIndex >= 0 ? (FakeFloorMaterial)comboBoxFakeFloorMaterial.SelectedItem : null;
            premise.FloorPerformanse = comboBoxFloorPerformanse.SelectedIndex >= 0 ? (FloorPerformanse)comboBoxFloorPerformanse.SelectedItem : null;
            premise.WallPremiseCorridor = comboBoxWallPremiseCorridor.SelectedIndex >= 0 ? (WallPremiseType)comboBoxWallPremiseCorridor.SelectedItem : null;
            premise.WallСovering = comboBoxWallСovering.SelectedIndex >= 0 ? (WallСovering)comboBoxWallСovering.SelectedItem : null;

            if (dataGridViewWindows.Rows.Count > 0)
                premise.Windows = dataGridViewWindows.Rows.Cast<DataGridViewRow>().Select(d => (Window)d.DataBoundItem).ToList();

            if (dataGridViewConstructionDefects.Rows.Count > 0)
                premise.ConstructionDefects = dataGridViewConstructionDefects.Rows.Cast<DataGridViewRow>().Select(d => (ConstructionDefect)d.DataBoundItem).ToList();

            if (dataGridViewWallsServisePremises.Rows.Count > 0)
                premise.WallsServisePremises = dataGridViewWallsServisePremises.Rows.Cast<DataGridViewRow>().Select(d => (WallPremiseType)d.DataBoundItem).ToList();

            if (premise.Id == -1)
                context.Premises.Add(premise);

            context.SaveChanges();
        }

        private void toolStripButtonAddStrDef_Click(object sender, EventArgs e)
        {
            if (toolStripComboBoxConstructionDefect.SelectedIndex >= 0)
            {
                constructionDefects.Add((ConstructionDefect)toolStripComboBoxConstructionDefect.SelectedItem);
            }
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            if (toolStripComboBoxWindows.SelectedIndex >= 0)
            {
                windows.Add((Window)toolStripComboBoxWindows.SelectedItem);
            }
        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            ICollection<WallPremiseType> delItems = new Collection<WallPremiseType>();
            foreach (DataGridViewRow item in dataGridViewWallsServisePremises.SelectedRows)
                delItems.Add((WallPremiseType)item.DataBoundItem);

            foreach (var item in delItems)
                wallsServisePremises.Remove(item);
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            ICollection<ConstructionDefect> delItems = new Collection<ConstructionDefect>();
            foreach (DataGridViewRow item in dataGridViewConstructionDefects.SelectedRows)
                delItems.Add((ConstructionDefect)item.DataBoundItem);

            foreach (var item in delItems)
                constructionDefects.Remove(item);
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            ICollection<Window> delItems = new Collection<Window>();
            foreach (DataGridViewRow item in dataGridViewWindows.SelectedRows)
                delItems.Add((Window)item.DataBoundItem);

            foreach (var item in delItems)
                windows.Remove(item);
        }
    }
}
