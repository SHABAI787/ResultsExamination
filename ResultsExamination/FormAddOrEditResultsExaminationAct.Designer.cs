
namespace ResultsExamination
{
    partial class FormAddOrEditResultsExaminationAct
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAddOrEditResultsExaminationAct));
            this.textBoxNumObject = new System.Windows.Forms.TextBox();
            this.textBoxAddresObject = new System.Windows.Forms.TextBox();
            this.dataGridViewActRecipients = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.bindingNavigator1 = new System.Windows.Forms.BindingNavigator(this.components);
            this.toolStripButtonRecipients = new System.Windows.Forms.ToolStripComboBox();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigator2 = new System.Windows.Forms.BindingNavigator(this.components);
            this.toolStripButtonExecutors = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridViewActExecutors = new System.Windows.Forms.DataGridView();
            this.comboBoxPremise = new System.Windows.Forms.ComboBox();
            this.richTextBoxAdditionally = new System.Windows.Forms.RichTextBox();
            this.checkBoxCommissionConclusion = new System.Windows.Forms.CheckBox();
            this.richTextBoxShortcomingEliminate = new System.Windows.Forms.RichTextBox();
            this.dateTimePickerIn = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dateTimePickerOut = new System.Windows.Forms.DateTimePicker();
            this.textBoxFile = new System.Windows.Forms.TextBox();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.buttonOpenFile = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewActRecipients)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).BeginInit();
            this.bindingNavigator1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator2)).BeginInit();
            this.bindingNavigator2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewActExecutors)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxNumObject
            // 
            this.textBoxNumObject.Location = new System.Drawing.Point(113, 12);
            this.textBoxNumObject.Name = "textBoxNumObject";
            this.textBoxNumObject.Size = new System.Drawing.Size(226, 20);
            this.textBoxNumObject.TabIndex = 0;
            this.textBoxNumObject.Text = "Номер объекта";
            // 
            // textBoxAddresObject
            // 
            this.textBoxAddresObject.Location = new System.Drawing.Point(113, 38);
            this.textBoxAddresObject.Name = "textBoxAddresObject";
            this.textBoxAddresObject.Size = new System.Drawing.Size(578, 20);
            this.textBoxAddresObject.TabIndex = 1;
            this.textBoxAddresObject.Text = "Адрес объекта";
            // 
            // dataGridViewActRecipients
            // 
            this.dataGridViewActRecipients.AllowUserToAddRows = false;
            this.dataGridViewActRecipients.AllowUserToDeleteRows = false;
            this.dataGridViewActRecipients.AllowUserToOrderColumns = true;
            this.dataGridViewActRecipients.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewActRecipients.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridViewActRecipients.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewActRecipients.Location = new System.Drawing.Point(12, 106);
            this.dataGridViewActRecipients.Name = "dataGridViewActRecipients";
            this.dataGridViewActRecipients.ReadOnly = true;
            this.dataGridViewActRecipients.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewActRecipients.Size = new System.Drawing.Size(327, 150);
            this.dataGridViewActRecipients.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "От получателя:";
            // 
            // bindingNavigator1
            // 
            this.bindingNavigator1.AddNewItem = null;
            this.bindingNavigator1.AutoSize = false;
            this.bindingNavigator1.CountItem = null;
            this.bindingNavigator1.DeleteItem = null;
            this.bindingNavigator1.Dock = System.Windows.Forms.DockStyle.None;
            this.bindingNavigator1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButtonRecipients,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem});
            this.bindingNavigator1.Location = new System.Drawing.Point(12, 78);
            this.bindingNavigator1.MoveFirstItem = null;
            this.bindingNavigator1.MoveLastItem = null;
            this.bindingNavigator1.MoveNextItem = null;
            this.bindingNavigator1.MovePreviousItem = null;
            this.bindingNavigator1.Name = "bindingNavigator1";
            this.bindingNavigator1.PositionItem = null;
            this.bindingNavigator1.Size = new System.Drawing.Size(327, 25);
            this.bindingNavigator1.TabIndex = 4;
            this.bindingNavigator1.Text = "bindingNavigator1";
            // 
            // toolStripButtonRecipients
            // 
            this.toolStripButtonRecipients.Name = "toolStripButtonRecipients";
            this.toolStripButtonRecipients.Size = new System.Drawing.Size(150, 25);
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Добавить";
            this.bindingNavigatorAddNewItem.Click += new System.EventHandler(this.bindingNavigatorAddNewItem_Click);
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Удалить";
            this.bindingNavigatorDeleteItem.Click += new System.EventHandler(this.bindingNavigatorDeleteItem_Click);
            // 
            // bindingNavigator2
            // 
            this.bindingNavigator2.AddNewItem = null;
            this.bindingNavigator2.AutoSize = false;
            this.bindingNavigator2.CountItem = null;
            this.bindingNavigator2.DeleteItem = null;
            this.bindingNavigator2.Dock = System.Windows.Forms.DockStyle.None;
            this.bindingNavigator2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButtonExecutors,
            this.toolStripButton1,
            this.toolStripButton2});
            this.bindingNavigator2.Location = new System.Drawing.Point(364, 78);
            this.bindingNavigator2.MoveFirstItem = null;
            this.bindingNavigator2.MoveLastItem = null;
            this.bindingNavigator2.MoveNextItem = null;
            this.bindingNavigator2.MovePreviousItem = null;
            this.bindingNavigator2.Name = "bindingNavigator2";
            this.bindingNavigator2.PositionItem = null;
            this.bindingNavigator2.Size = new System.Drawing.Size(327, 25);
            this.bindingNavigator2.TabIndex = 7;
            this.bindingNavigator2.Text = "bindingNavigator2";
            // 
            // toolStripButtonExecutors
            // 
            this.toolStripButtonExecutors.Name = "toolStripButtonExecutors";
            this.toolStripButtonExecutors.Size = new System.Drawing.Size(150, 25);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.RightToLeftAutoMirrorImage = true;
            this.toolStripButton1.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton1.Text = "Добавить";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.RightToLeftAutoMirrorImage = true;
            this.toolStripButton2.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton2.Text = "Удалить";
            this.toolStripButton2.Click += new System.EventHandler(this.toolStripButton2_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(361, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "От исполнителя:";
            // 
            // dataGridViewActExecutors
            // 
            this.dataGridViewActExecutors.AllowUserToAddRows = false;
            this.dataGridViewActExecutors.AllowUserToDeleteRows = false;
            this.dataGridViewActExecutors.AllowUserToOrderColumns = true;
            this.dataGridViewActExecutors.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewActExecutors.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridViewActExecutors.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewActExecutors.Location = new System.Drawing.Point(364, 106);
            this.dataGridViewActExecutors.Name = "dataGridViewActExecutors";
            this.dataGridViewActExecutors.ReadOnly = true;
            this.dataGridViewActExecutors.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewActExecutors.Size = new System.Drawing.Size(327, 150);
            this.dataGridViewActExecutors.TabIndex = 5;
            // 
            // comboBoxPremise
            // 
            this.comboBoxPremise.FormattingEnabled = true;
            this.comboBoxPremise.Location = new System.Drawing.Point(12, 262);
            this.comboBoxPremise.Name = "comboBoxPremise";
            this.comboBoxPremise.Size = new System.Drawing.Size(583, 21);
            this.comboBoxPremise.TabIndex = 8;
            this.comboBoxPremise.Text = "Помещение";
            // 
            // richTextBoxAdditionally
            // 
            this.richTextBoxAdditionally.Location = new System.Drawing.Point(12, 301);
            this.richTextBoxAdditionally.Name = "richTextBoxAdditionally";
            this.richTextBoxAdditionally.Size = new System.Drawing.Size(679, 62);
            this.richTextBoxAdditionally.TabIndex = 9;
            this.richTextBoxAdditionally.Text = "Дополнительно";
            // 
            // checkBoxCommissionConclusion
            // 
            this.checkBoxCommissionConclusion.AutoSize = true;
            this.checkBoxCommissionConclusion.Location = new System.Drawing.Point(12, 369);
            this.checkBoxCommissionConclusion.Name = "checkBoxCommissionConclusion";
            this.checkBoxCommissionConclusion.Size = new System.Drawing.Size(313, 17);
            this.checkBoxCommissionConclusion.TabIndex = 10;
            this.checkBoxCommissionConclusion.Text = "Заключение комиссии(соответствует/не соответствует)";
            this.checkBoxCommissionConclusion.UseVisualStyleBackColor = true;
            // 
            // richTextBoxShortcomingEliminate
            // 
            this.richTextBoxShortcomingEliminate.Location = new System.Drawing.Point(12, 417);
            this.richTextBoxShortcomingEliminate.Name = "richTextBoxShortcomingEliminate";
            this.richTextBoxShortcomingEliminate.Size = new System.Drawing.Size(679, 57);
            this.richTextBoxShortcomingEliminate.TabIndex = 11;
            this.richTextBoxShortcomingEliminate.Text = "Недостатки для устранения";
            // 
            // dateTimePickerIn
            // 
            this.dateTimePickerIn.Location = new System.Drawing.Point(203, 477);
            this.dateTimePickerIn.Name = "dateTimePickerIn";
            this.dateTimePickerIn.Size = new System.Drawing.Size(136, 20);
            this.dateTimePickerIn.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 479);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(185, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Период устранения недостатков с:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(345, 479);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(19, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "до";
            // 
            // dateTimePickerOut
            // 
            this.dateTimePickerOut.Location = new System.Drawing.Point(370, 477);
            this.dateTimePickerOut.Name = "dateTimePickerOut";
            this.dateTimePickerOut.Size = new System.Drawing.Size(136, 20);
            this.dateTimePickerOut.TabIndex = 15;
            // 
            // textBoxFile
            // 
            this.textBoxFile.Location = new System.Drawing.Point(12, 509);
            this.textBoxFile.Name = "textBoxFile";
            this.textBoxFile.Size = new System.Drawing.Size(583, 20);
            this.textBoxFile.TabIndex = 16;
            this.textBoxFile.Text = "План помещения";
            // 
            // buttonAdd
            // 
            this.buttonAdd.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonAdd.Location = new System.Drawing.Point(15, 546);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(676, 50);
            this.buttonAdd.TabIndex = 18;
            this.buttonAdd.Text = "Сохранить";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 15);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 13);
            this.label5.TabIndex = 20;
            this.label5.Text = "Номер объекта:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(60, 38);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 13);
            this.label6.TabIndex = 21;
            this.label6.Text = "Адрес:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 285);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(90, 13);
            this.label7.TabIndex = 22;
            this.label7.Text = "Дополнительно:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 401);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(152, 13);
            this.label8.TabIndex = 23;
            this.label8.Text = "Недостатки для устранения:";
            // 
            // button3
            // 
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button3.Image = global::ResultsExamination.Properties.Resources.addItem;
            this.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button3.Location = new System.Drawing.Point(594, 262);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(97, 21);
            this.button3.TabIndex = 19;
            this.button3.Text = "Добавить";
            this.button3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.UseVisualStyleBackColor = true;
            // 
            // buttonOpenFile
            // 
            this.buttonOpenFile.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonOpenFile.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonOpenFile.Image = global::ResultsExamination.Properties.Resources.Open_folder;
            this.buttonOpenFile.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonOpenFile.Location = new System.Drawing.Point(594, 508);
            this.buttonOpenFile.Name = "buttonOpenFile";
            this.buttonOpenFile.Size = new System.Drawing.Size(97, 21);
            this.buttonOpenFile.TabIndex = 17;
            this.buttonOpenFile.Text = "Открыть";
            this.buttonOpenFile.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonOpenFile.UseVisualStyleBackColor = true;
            this.buttonOpenFile.Click += new System.EventHandler(this.buttonOpen_Click);
            // 
            // FormAddOrEditResultsExaminationAct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(703, 608);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.buttonOpenFile);
            this.Controls.Add(this.textBoxFile);
            this.Controls.Add(this.dateTimePickerOut);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dateTimePickerIn);
            this.Controls.Add(this.richTextBoxShortcomingEliminate);
            this.Controls.Add(this.checkBoxCommissionConclusion);
            this.Controls.Add(this.richTextBoxAdditionally);
            this.Controls.Add(this.comboBoxPremise);
            this.Controls.Add(this.bindingNavigator2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridViewActExecutors);
            this.Controls.Add(this.bindingNavigator1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridViewActRecipients);
            this.Controls.Add(this.textBoxAddresObject);
            this.Controls.Add(this.textBoxNumObject);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FormAddOrEditResultsExaminationAct";
            this.Text = "Добавление результатов обследования";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewActRecipients)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).EndInit();
            this.bindingNavigator1.ResumeLayout(false);
            this.bindingNavigator1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator2)).EndInit();
            this.bindingNavigator2.ResumeLayout(false);
            this.bindingNavigator2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewActExecutors)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxNumObject;
        private System.Windows.Forms.TextBox textBoxAddresObject;
        private System.Windows.Forms.DataGridView dataGridViewActRecipients;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingNavigator bindingNavigator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.BindingNavigator bindingNavigator2;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridViewActExecutors;
        private System.Windows.Forms.ComboBox comboBoxPremise;
        private System.Windows.Forms.RichTextBox richTextBoxAdditionally;
        private System.Windows.Forms.CheckBox checkBoxCommissionConclusion;
        private System.Windows.Forms.RichTextBox richTextBoxShortcomingEliminate;
        private System.Windows.Forms.DateTimePicker dateTimePickerIn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dateTimePickerOut;
        private System.Windows.Forms.TextBox textBoxFile;
        private System.Windows.Forms.Button buttonOpenFile;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ToolStripComboBox toolStripButtonRecipients;
        private System.Windows.Forms.ToolStripComboBox toolStripButtonExecutors;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
    }
}