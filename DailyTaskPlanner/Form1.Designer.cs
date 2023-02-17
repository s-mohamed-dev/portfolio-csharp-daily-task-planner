namespace DailyTaskPlanner
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl_Main = new System.Windows.Forms.TabControl();
            this.tabPage_TodoToday = new System.Windows.Forms.TabPage();
            this.groupBox_Action = new System.Windows.Forms.GroupBox();
            this.button_ActionModify = new System.Windows.Forms.Button();
            this.button_ActionDelete = new System.Windows.Forms.Button();
            this.button_ActionAdd = new System.Windows.Forms.Button();
            this.button_ActionSave = new System.Windows.Forms.Button();
            this.groupBox_TodoToday = new System.Windows.Forms.GroupBox();
            this.checkedListBox_TodoToday = new System.Windows.Forms.CheckedListBox();
            this.tabPage_TodoOld = new System.Windows.Forms.TabPage();
            this.tabControl_Main.SuspendLayout();
            this.tabPage_TodoToday.SuspendLayout();
            this.groupBox_Action.SuspendLayout();
            this.groupBox_TodoToday.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl_Main
            // 
            this.tabControl_Main.Controls.Add(this.tabPage_TodoToday);
            this.tabControl_Main.Controls.Add(this.tabPage_TodoOld);
            this.tabControl_Main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl_Main.Location = new System.Drawing.Point(0, 0);
            this.tabControl_Main.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabControl_Main.Name = "tabControl_Main";
            this.tabControl_Main.SelectedIndex = 0;
            this.tabControl_Main.Size = new System.Drawing.Size(1258, 664);
            this.tabControl_Main.TabIndex = 6;
            // 
            // tabPage_TodoToday
            // 
            this.tabPage_TodoToday.Controls.Add(this.groupBox_Action);
            this.tabPage_TodoToday.Controls.Add(this.groupBox_TodoToday);
            this.tabPage_TodoToday.Location = new System.Drawing.Point(4, 29);
            this.tabPage_TodoToday.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabPage_TodoToday.Name = "tabPage_TodoToday";
            this.tabPage_TodoToday.Padding = new System.Windows.Forms.Padding(16);
            this.tabPage_TodoToday.Size = new System.Drawing.Size(1250, 631);
            this.tabPage_TodoToday.TabIndex = 0;
            this.tabPage_TodoToday.Text = "Today";
            this.tabPage_TodoToday.UseVisualStyleBackColor = true;
            // 
            // groupBox_Action
            // 
            this.groupBox_Action.Controls.Add(this.button_ActionModify);
            this.groupBox_Action.Controls.Add(this.button_ActionDelete);
            this.groupBox_Action.Controls.Add(this.button_ActionAdd);
            this.groupBox_Action.Controls.Add(this.button_ActionSave);
            this.groupBox_Action.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox_Action.Location = new System.Drawing.Point(16, 485);
            this.groupBox_Action.Name = "groupBox_Action";
            this.groupBox_Action.Padding = new System.Windows.Forms.Padding(16);
            this.groupBox_Action.Size = new System.Drawing.Size(1218, 130);
            this.groupBox_Action.TabIndex = 5;
            this.groupBox_Action.TabStop = false;
            this.groupBox_Action.Text = "Actions";
            // 
            // button_ActionModify
            // 
            this.button_ActionModify.Dock = System.Windows.Forms.DockStyle.Left;
            this.button_ActionModify.Location = new System.Drawing.Point(216, 35);
            this.button_ActionModify.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button_ActionModify.Name = "button_ActionModify";
            this.button_ActionModify.Size = new System.Drawing.Size(100, 79);
            this.button_ActionModify.TabIndex = 10;
            this.button_ActionModify.Text = "Modify";
            this.button_ActionModify.UseVisualStyleBackColor = true;
            this.button_ActionModify.Click += new System.EventHandler(this.button_ActionModify_Click);
            // 
            // button_ActionDelete
            // 
            this.button_ActionDelete.Dock = System.Windows.Forms.DockStyle.Left;
            this.button_ActionDelete.Location = new System.Drawing.Point(116, 35);
            this.button_ActionDelete.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button_ActionDelete.Name = "button_ActionDelete";
            this.button_ActionDelete.Size = new System.Drawing.Size(100, 79);
            this.button_ActionDelete.TabIndex = 9;
            this.button_ActionDelete.Text = "Delete";
            this.button_ActionDelete.UseVisualStyleBackColor = true;
            this.button_ActionDelete.Click += new System.EventHandler(this.button_ActionDelete_Click);
            // 
            // button_ActionAdd
            // 
            this.button_ActionAdd.Dock = System.Windows.Forms.DockStyle.Left;
            this.button_ActionAdd.Location = new System.Drawing.Point(16, 35);
            this.button_ActionAdd.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button_ActionAdd.Name = "button_ActionAdd";
            this.button_ActionAdd.Size = new System.Drawing.Size(100, 79);
            this.button_ActionAdd.TabIndex = 5;
            this.button_ActionAdd.Text = "Add";
            this.button_ActionAdd.UseVisualStyleBackColor = true;
            this.button_ActionAdd.Click += new System.EventHandler(this.button_ActionAdd_Click);
            // 
            // button_ActionSave
            // 
            this.button_ActionSave.Dock = System.Windows.Forms.DockStyle.Right;
            this.button_ActionSave.Location = new System.Drawing.Point(1102, 35);
            this.button_ActionSave.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button_ActionSave.Name = "button_ActionSave";
            this.button_ActionSave.Size = new System.Drawing.Size(100, 79);
            this.button_ActionSave.TabIndex = 3;
            this.button_ActionSave.Text = "Save";
            this.button_ActionSave.UseVisualStyleBackColor = true;
            this.button_ActionSave.Click += new System.EventHandler(this.button_ActionSave_Click);
            // 
            // groupBox_TodoToday
            // 
            this.groupBox_TodoToday.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.groupBox_TodoToday.Controls.Add(this.checkedListBox_TodoToday);
            this.groupBox_TodoToday.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox_TodoToday.Location = new System.Drawing.Point(16, 16);
            this.groupBox_TodoToday.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox_TodoToday.Name = "groupBox_TodoToday";
            this.groupBox_TodoToday.Padding = new System.Windows.Forms.Padding(24);
            this.groupBox_TodoToday.Size = new System.Drawing.Size(1218, 461);
            this.groupBox_TodoToday.TabIndex = 0;
            this.groupBox_TodoToday.TabStop = false;
            this.groupBox_TodoToday.Text = "...";
            // 
            // checkedListBox_TodoToday
            // 
            this.checkedListBox_TodoToday.Dock = System.Windows.Forms.DockStyle.Fill;
            this.checkedListBox_TodoToday.FormattingEnabled = true;
            this.checkedListBox_TodoToday.HorizontalScrollbar = true;
            this.checkedListBox_TodoToday.IntegralHeight = false;
            this.checkedListBox_TodoToday.Location = new System.Drawing.Point(24, 43);
            this.checkedListBox_TodoToday.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.checkedListBox_TodoToday.MinimumSize = new System.Drawing.Size(4, 100);
            this.checkedListBox_TodoToday.Name = "checkedListBox_TodoToday";
            this.checkedListBox_TodoToday.Size = new System.Drawing.Size(1170, 394);
            this.checkedListBox_TodoToday.TabIndex = 0;
            this.checkedListBox_TodoToday.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.checkedListBox_TodoToday_ItemCheck);
            // 
            // tabPage_TodoOld
            // 
            this.tabPage_TodoOld.AutoScroll = true;
            this.tabPage_TodoOld.Location = new System.Drawing.Point(4, 29);
            this.tabPage_TodoOld.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabPage_TodoOld.Name = "tabPage_TodoOld";
            this.tabPage_TodoOld.Padding = new System.Windows.Forms.Padding(16);
            this.tabPage_TodoOld.Size = new System.Drawing.Size(1250, 631);
            this.tabPage_TodoOld.TabIndex = 1;
            this.tabPage_TodoOld.Text = "Previously";
            this.tabPage_TodoOld.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1258, 664);
            this.Controls.Add(this.tabControl_Main);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MinimumSize = new System.Drawing.Size(640, 480);
            this.Name = "Form1";
            this.Text = "Daily Task Planner";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Resize += new System.EventHandler(this.Form1_Resize);
            this.tabControl_Main.ResumeLayout(false);
            this.tabPage_TodoToday.ResumeLayout(false);
            this.groupBox_Action.ResumeLayout(false);
            this.groupBox_TodoToday.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TabControl tabControl_Main;
        private System.Windows.Forms.TabPage tabPage_TodoToday;
        private System.Windows.Forms.TabPage tabPage_TodoOld;
        private System.Windows.Forms.GroupBox groupBox_TodoToday;
        private System.Windows.Forms.Button button_ActionSave;
        private System.Windows.Forms.CheckedListBox checkedListBox_TodoToday;
        private System.Windows.Forms.GroupBox groupBox_Action;
        private System.Windows.Forms.Button button_ActionAdd;
        private System.Windows.Forms.Button button_ActionModify;
        private System.Windows.Forms.Button button_ActionDelete;
    }
}

