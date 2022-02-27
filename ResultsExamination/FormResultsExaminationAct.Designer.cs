
namespace ResultsExamination
{
    partial class FormResultsExaminationAct
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormResultsExaminationAct));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.bindingNavigator1 = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.отчётыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.результатыОбследованийToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.помещенийToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.инженернотехническоеОбеспечениеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.строительныеДефектыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.физическиеЛицаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).BeginInit();
            this.bindingNavigator1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(0, 46);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(904, 399);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // bindingNavigator1
            // 
            this.bindingNavigator1.AddNewItem = null;
            this.bindingNavigator1.BindingSource = this.bindingSource1;
            this.bindingNavigator1.CountItem = null;
            this.bindingNavigator1.DeleteItem = null;
            this.bindingNavigator1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorSeparator,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.toolStripButton1});
            this.bindingNavigator1.Location = new System.Drawing.Point(0, 24);
            this.bindingNavigator1.MoveFirstItem = null;
            this.bindingNavigator1.MoveLastItem = null;
            this.bindingNavigator1.MoveNextItem = null;
            this.bindingNavigator1.MovePreviousItem = null;
            this.bindingNavigator1.Name = "bindingNavigator1";
            this.bindingNavigator1.PositionItem = null;
            this.bindingNavigator1.Size = new System.Drawing.Size(904, 25);
            this.bindingNavigator1.TabIndex = 1;
            this.bindingNavigator1.Text = "bindingNavigator1";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.результатыОбследованийToolStripMenuItem,
            this.помещенийToolStripMenuItem,
            this.инженернотехническоеОбеспечениеToolStripMenuItem,
            this.строительныеДефектыToolStripMenuItem,
            this.физическиеЛицаToolStripMenuItem,
            this.отчётыToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(904, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // отчётыToolStripMenuItem
            // 
            this.отчётыToolStripMenuItem.Image = global::ResultsExamination.Properties.Resources.reports;
            this.отчётыToolStripMenuItem.Name = "отчётыToolStripMenuItem";
            this.отчётыToolStripMenuItem.Size = new System.Drawing.Size(76, 20);
            this.отчётыToolStripMenuItem.Text = "Отчёты";
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
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = global::ResultsExamination.Properties.Resources.icons8_microsoft_excel_23;
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton1.Text = "Экспорт в Excel";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // результатыОбследованийToolStripMenuItem
            // 
            this.результатыОбследованийToolStripMenuItem.Image = global::ResultsExamination.Properties.Resources.result_clipboard_check_mark_list_icon_153875;
            this.результатыОбследованийToolStripMenuItem.Name = "результатыОбследованийToolStripMenuItem";
            this.результатыОбследованийToolStripMenuItem.Size = new System.Drawing.Size(179, 20);
            this.результатыОбследованийToolStripMenuItem.Text = "Результаты обследований";
            this.результатыОбследованийToolStripMenuItem.Click += new System.EventHandler(this.результатыОбследованийToolStripMenuItem_Click);
            // 
            // помещенийToolStripMenuItem
            // 
            this.помещенийToolStripMenuItem.Image = global::ResultsExamination.Properties.Resources.diagram_06_24511;
            this.помещенийToolStripMenuItem.Name = "помещенийToolStripMenuItem";
            this.помещенийToolStripMenuItem.Size = new System.Drawing.Size(84, 20);
            this.помещенийToolStripMenuItem.Text = "Объекты";
            // 
            // инженернотехническоеОбеспечениеToolStripMenuItem
            // 
            this.инженернотехническоеОбеспечениеToolStripMenuItem.Image = global::ResultsExamination.Properties.Resources.injener;
            this.инженернотехническоеОбеспечениеToolStripMenuItem.Name = "инженернотехническоеОбеспечениеToolStripMenuItem";
            this.инженернотехническоеОбеспечениеToolStripMenuItem.Size = new System.Drawing.Size(249, 20);
            this.инженернотехническоеОбеспечениеToolStripMenuItem.Text = "Инженерно-техническое обеспечение";
            // 
            // строительныеДефектыToolStripMenuItem
            // 
            this.строительныеДефектыToolStripMenuItem.Image = global::ResultsExamination.Properties.Resources.defects;
            this.строительныеДефектыToolStripMenuItem.Name = "строительныеДефектыToolStripMenuItem";
            this.строительныеДефектыToolStripMenuItem.Size = new System.Drawing.Size(165, 20);
            this.строительныеДефектыToolStripMenuItem.Text = "Строительные дефекты";
            // 
            // физическиеЛицаToolStripMenuItem
            // 
            this.физическиеЛицаToolStripMenuItem.Image = global::ResultsExamination.Properties.Resources.person;
            this.физическиеЛицаToolStripMenuItem.Name = "физическиеЛицаToolStripMenuItem";
            this.физическиеЛицаToolStripMenuItem.Size = new System.Drawing.Size(131, 20);
            this.физическиеЛицаToolStripMenuItem.Text = "Физические лица";
            // 
            // FormResultsExaminationAct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(904, 450);
            this.Controls.Add(this.bindingNavigator1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.dataGridView1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormResultsExaminationAct";
            this.Text = "Результаты обследований";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).EndInit();
            this.bindingNavigator1.ResumeLayout(false);
            this.bindingNavigator1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingNavigator bindingNavigator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem результатыОбследованийToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem помещенийToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem инженернотехническоеОбеспечениеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem строительныеДефектыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem физическиеЛицаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem отчётыToolStripMenuItem;
    }
}