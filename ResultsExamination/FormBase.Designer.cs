
namespace ResultsExamination
{
    partial class FormBase
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonResultsExaminationAct = new System.Windows.Forms.Button();
            this.buttonPremise = new System.Windows.Forms.Button();
            this.buttonEngineringTechnicalProvision = new System.Windows.Forms.Button();
            this.buttonPersons = new System.Windows.Forms.Button();
            this.buttonConstructionDefect = new System.Windows.Forms.Button();
            this.labelState = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonResultsExaminationAct
            // 
            this.buttonResultsExaminationAct.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonResultsExaminationAct.Location = new System.Drawing.Point(49, 47);
            this.buttonResultsExaminationAct.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonResultsExaminationAct.Name = "buttonResultsExaminationAct";
            this.buttonResultsExaminationAct.Size = new System.Drawing.Size(344, 35);
            this.buttonResultsExaminationAct.TabIndex = 0;
            this.buttonResultsExaminationAct.Text = "Результаты обследований";
            this.buttonResultsExaminationAct.UseVisualStyleBackColor = true;
            this.buttonResultsExaminationAct.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonPremise
            // 
            this.buttonPremise.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonPremise.Location = new System.Drawing.Point(49, 225);
            this.buttonPremise.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonPremise.Name = "buttonPremise";
            this.buttonPremise.Size = new System.Drawing.Size(344, 35);
            this.buttonPremise.TabIndex = 1;
            this.buttonPremise.Text = "Объекты";
            this.buttonPremise.UseVisualStyleBackColor = true;
            // 
            // buttonEngineringTechnicalProvision
            // 
            this.buttonEngineringTechnicalProvision.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonEngineringTechnicalProvision.Location = new System.Drawing.Point(49, 92);
            this.buttonEngineringTechnicalProvision.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonEngineringTechnicalProvision.Name = "buttonEngineringTechnicalProvision";
            this.buttonEngineringTechnicalProvision.Size = new System.Drawing.Size(344, 35);
            this.buttonEngineringTechnicalProvision.TabIndex = 2;
            this.buttonEngineringTechnicalProvision.Text = "Инженерно-техническое обеспечение";
            this.buttonEngineringTechnicalProvision.UseVisualStyleBackColor = true;
            // 
            // buttonPersons
            // 
            this.buttonPersons.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonPersons.Location = new System.Drawing.Point(49, 180);
            this.buttonPersons.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonPersons.Name = "buttonPersons";
            this.buttonPersons.Size = new System.Drawing.Size(344, 35);
            this.buttonPersons.TabIndex = 3;
            this.buttonPersons.Text = "Физические лица";
            this.buttonPersons.UseVisualStyleBackColor = true;
            // 
            // buttonConstructionDefect
            // 
            this.buttonConstructionDefect.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonConstructionDefect.Location = new System.Drawing.Point(49, 135);
            this.buttonConstructionDefect.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonConstructionDefect.Name = "buttonConstructionDefect";
            this.buttonConstructionDefect.Size = new System.Drawing.Size(344, 35);
            this.buttonConstructionDefect.TabIndex = 4;
            this.buttonConstructionDefect.Text = "Строительные дефекты";
            this.buttonConstructionDefect.UseVisualStyleBackColor = true;
            // 
            // labelState
            // 
            this.labelState.AutoSize = true;
            this.labelState.Location = new System.Drawing.Point(143, 13);
            this.labelState.Name = "labelState";
            this.labelState.Size = new System.Drawing.Size(149, 20);
            this.labelState.TabIndex = 5;
            this.labelState.Text = "Загрузка данных...";
            this.labelState.Visible = false;
            // 
            // FormBase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(445, 274);
            this.Controls.Add(this.labelState);
            this.Controls.Add(this.buttonConstructionDefect);
            this.Controls.Add(this.buttonPersons);
            this.Controls.Add(this.buttonEngineringTechnicalProvision);
            this.Controls.Add(this.buttonPremise);
            this.Controls.Add(this.buttonResultsExaminationAct);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "FormBase";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Система хранения результатов обследования";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonResultsExaminationAct;
        private System.Windows.Forms.Button buttonPremise;
        private System.Windows.Forms.Button buttonEngineringTechnicalProvision;
        private System.Windows.Forms.Button buttonPersons;
        private System.Windows.Forms.Button buttonConstructionDefect;
        private System.Windows.Forms.Label labelState;
    }
}

