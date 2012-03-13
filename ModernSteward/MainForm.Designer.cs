﻿namespace ModernSteward
{
    partial class MainForm
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
			Telerik.WinControls.UI.GridViewCheckBoxColumn gridViewCheckBoxColumn3 = new Telerik.WinControls.UI.GridViewCheckBoxColumn();
			Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn3 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
			Telerik.WinControls.UI.GridViewCommandColumn gridViewCommandColumn3 = new Telerik.WinControls.UI.GridViewCommandColumn();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			this.gridViewPlugins = new Telerik.WinControls.UI.RadGridView();
			this.groupBoxPlugins = new Telerik.WinControls.UI.RadGroupBox();
			this.groupBoxAddPlugin = new Telerik.WinControls.UI.RadGroupBox();
			this.textBoxPluginPath = new Telerik.WinControls.UI.RadTextBox();
			this.buttonBrowseForPlugin = new Telerik.WinControls.UI.RadButton();
			this.textBoxPluginName = new Telerik.WinControls.UI.RadTextBox();
			this.labelPluginName = new Telerik.WinControls.UI.RadLabel();
			this.buttonAddPlugin = new Telerik.WinControls.UI.RadButton();
			this.groupBoxStatus = new Telerik.WinControls.UI.RadGroupBox();
			this.labelStartStop = new Telerik.WinControls.UI.RadLabel();
			this.buttonStartStop = new Telerik.WinControls.UI.RadButton();
			this.menuItemFile = new Telerik.WinControls.UI.RadMenuItem();
			this.menuItemOpenFile = new Telerik.WinControls.UI.RadMenuItem();
			this.MenuItemSave = new Telerik.WinControls.UI.RadMenuItem();
			this.menuItemAdvanced = new Telerik.WinControls.UI.RadMenuItem();
			this.radMenuItemPluginWizard = new Telerik.WinControls.UI.RadMenuItem();
			this.menuItemMasterDictionary = new Telerik.WinControls.UI.RadMenuItem();
			this.statusStrip = new Telerik.WinControls.UI.RadStatusStrip();
			this.labelStatusInStatusStrip = new Telerik.WinControls.UI.RadLabelElement();
			this.MenuItem1 = new Telerik.WinControls.UI.RadMenuItem();
			this.menuItemPluginCommands = new Telerik.WinControls.UI.RadMenuItem();
			this.menuMain = new Telerik.WinControls.UI.RadMenu();
			this.notifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
			((System.ComponentModel.ISupportInitialize)(this.gridViewPlugins)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.groupBoxPlugins)).BeginInit();
			this.groupBoxPlugins.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.groupBoxAddPlugin)).BeginInit();
			this.groupBoxAddPlugin.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.textBoxPluginPath)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.buttonBrowseForPlugin)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.textBoxPluginName)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.labelPluginName)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.buttonAddPlugin)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.groupBoxStatus)).BeginInit();
			this.groupBoxStatus.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.labelStartStop)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.buttonStartStop)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.statusStrip)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.menuMain)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
			this.SuspendLayout();
			// 
			// gridViewPlugins
			// 
			this.gridViewPlugins.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(219)))), ((int)(((byte)(255)))));
			this.gridViewPlugins.Cursor = System.Windows.Forms.Cursors.Default;
			this.gridViewPlugins.Font = new System.Drawing.Font("Segoe UI", 8.25F);
			this.gridViewPlugins.ForeColor = System.Drawing.Color.Black;
			this.gridViewPlugins.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.gridViewPlugins.Location = new System.Drawing.Point(7, 21);
			// 
			// gridViewPlugins
			// 
			this.gridViewPlugins.MasterTemplate.AllowAddNewRow = false;
			gridViewCheckBoxColumn3.FieldName = "Checkbox";
			gridViewCheckBoxColumn3.HeaderText = "";
			gridViewCheckBoxColumn3.MaxWidth = 20;
			gridViewCheckBoxColumn3.Name = "Checkbox";
			gridViewCheckBoxColumn3.ReadOnly = true;
			gridViewCheckBoxColumn3.Width = 20;
			gridViewTextBoxColumn3.EnableExpressionEditor = false;
			gridViewTextBoxColumn3.FieldName = "Name";
			gridViewTextBoxColumn3.HeaderText = "Име";
			gridViewTextBoxColumn3.Name = "Name";
			gridViewTextBoxColumn3.ReadOnly = true;
			gridViewCommandColumn3.EnableExpressionEditor = false;
			gridViewCommandColumn3.FieldName = "Button";
			gridViewCommandColumn3.MaxWidth = 130;
			gridViewCommandColumn3.MinWidth = 130;
			gridViewCommandColumn3.Name = "Button";
			gridViewCommandColumn3.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
			gridViewCommandColumn3.Width = 130;
			this.gridViewPlugins.MasterTemplate.Columns.AddRange(new Telerik.WinControls.UI.GridViewDataColumn[] {
            gridViewCheckBoxColumn3,
            gridViewTextBoxColumn3,
            gridViewCommandColumn3});
			this.gridViewPlugins.MasterTemplate.EnableGrouping = false;
			this.gridViewPlugins.MasterTemplate.ShowRowHeaderColumn = false;
			this.gridViewPlugins.Name = "gridViewPlugins";
			this.gridViewPlugins.ReadOnly = true;
			this.gridViewPlugins.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.gridViewPlugins.ShowGroupPanel = false;
			this.gridViewPlugins.Size = new System.Drawing.Size(661, 233);
			this.gridViewPlugins.TabIndex = 0;
			// 
			// groupBoxPlugins
			// 
			this.groupBoxPlugins.AccessibleName = "";
			this.groupBoxPlugins.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping;
			this.groupBoxPlugins.Controls.Add(this.gridViewPlugins);
			this.groupBoxPlugins.FooterImageIndex = -1;
			this.groupBoxPlugins.FooterImageKey = "";
			this.groupBoxPlugins.HeaderImageIndex = -1;
			this.groupBoxPlugins.HeaderImageKey = "";
			this.groupBoxPlugins.HeaderMargin = new System.Windows.Forms.Padding(0);
			this.groupBoxPlugins.HeaderText = "Добавени добавки";
			this.groupBoxPlugins.Location = new System.Drawing.Point(12, 26);
			this.groupBoxPlugins.Name = "groupBoxPlugins";
			this.groupBoxPlugins.Padding = new System.Windows.Forms.Padding(2, 18, 2, 2);
			// 
			// 
			// 
			this.groupBoxPlugins.RootElement.Padding = new System.Windows.Forms.Padding(2, 18, 2, 2);
			this.groupBoxPlugins.Size = new System.Drawing.Size(674, 261);
			this.groupBoxPlugins.TabIndex = 1;
			this.groupBoxPlugins.Text = "Добавени добавки";
			// 
			// groupBoxAddPlugin
			// 
			this.groupBoxAddPlugin.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping;
			this.groupBoxAddPlugin.Controls.Add(this.textBoxPluginPath);
			this.groupBoxAddPlugin.Controls.Add(this.buttonBrowseForPlugin);
			this.groupBoxAddPlugin.Controls.Add(this.textBoxPluginName);
			this.groupBoxAddPlugin.Controls.Add(this.labelPluginName);
			this.groupBoxAddPlugin.Controls.Add(this.buttonAddPlugin);
			this.groupBoxAddPlugin.FooterImageIndex = -1;
			this.groupBoxAddPlugin.FooterImageKey = "";
			this.groupBoxAddPlugin.HeaderImageIndex = -1;
			this.groupBoxAddPlugin.HeaderImageKey = "";
			this.groupBoxAddPlugin.HeaderMargin = new System.Windows.Forms.Padding(0);
			this.groupBoxAddPlugin.HeaderText = "Добави добавка";
			this.groupBoxAddPlugin.Location = new System.Drawing.Point(12, 294);
			this.groupBoxAddPlugin.Name = "groupBoxAddPlugin";
			this.groupBoxAddPlugin.Padding = new System.Windows.Forms.Padding(2, 18, 2, 2);
			// 
			// 
			// 
			this.groupBoxAddPlugin.RootElement.Padding = new System.Windows.Forms.Padding(2, 18, 2, 2);
			this.groupBoxAddPlugin.Size = new System.Drawing.Size(334, 102);
			this.groupBoxAddPlugin.TabIndex = 2;
			this.groupBoxAddPlugin.Text = "Добави добавка";
			// 
			// textBoxPluginPath
			// 
			this.textBoxPluginPath.Location = new System.Drawing.Point(7, 21);
			this.textBoxPluginPath.Name = "textBoxPluginPath";
			this.textBoxPluginPath.Size = new System.Drawing.Size(291, 20);
			this.textBoxPluginPath.TabIndex = 0;
			this.textBoxPluginPath.TabStop = false;
			// 
			// buttonBrowseForPlugin
			// 
			this.buttonBrowseForPlugin.Location = new System.Drawing.Point(304, 21);
			this.buttonBrowseForPlugin.Name = "buttonBrowseForPlugin";
			this.buttonBrowseForPlugin.Size = new System.Drawing.Size(24, 21);
			this.buttonBrowseForPlugin.TabIndex = 1;
			this.buttonBrowseForPlugin.Text = "...";
			this.buttonBrowseForPlugin.Click += new System.EventHandler(this.buttonBrowseForPlugin_Click);
			// 
			// textBoxPluginName
			// 
			this.textBoxPluginName.Location = new System.Drawing.Point(45, 46);
			this.textBoxPluginName.Name = "textBoxPluginName";
			this.textBoxPluginName.Size = new System.Drawing.Size(283, 20);
			this.textBoxPluginName.TabIndex = 3;
			this.textBoxPluginName.TabStop = false;
			this.textBoxPluginName.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textBoxPluginName_KeyUp);
			// 
			// labelPluginName
			// 
			this.labelPluginName.Location = new System.Drawing.Point(7, 49);
			this.labelPluginName.Name = "labelPluginName";
			this.labelPluginName.Size = new System.Drawing.Size(31, 18);
			this.labelPluginName.TabIndex = 2;
			this.labelPluginName.Text = "Име:";
			// 
			// buttonAddPlugin
			// 
			this.buttonAddPlugin.Image = global::ModernSteward.Properties.Resources.pluginIcon;
			this.buttonAddPlugin.ImageAlignment = System.Drawing.ContentAlignment.MiddleRight;
			this.buttonAddPlugin.Location = new System.Drawing.Point(194, 72);
			this.buttonAddPlugin.Name = "buttonAddPlugin";
			this.buttonAddPlugin.Size = new System.Drawing.Size(135, 24);
			this.buttonAddPlugin.TabIndex = 4;
			this.buttonAddPlugin.Text = "Добави добавка";
			this.buttonAddPlugin.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
			this.buttonAddPlugin.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.buttonAddPlugin.Click += new System.EventHandler(this.buttonAddPlugin_Click);
			// 
			// groupBoxStatus
			// 
			this.groupBoxStatus.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping;
			this.groupBoxStatus.Controls.Add(this.labelStartStop);
			this.groupBoxStatus.Controls.Add(this.buttonStartStop);
			this.groupBoxStatus.FooterImageIndex = -1;
			this.groupBoxStatus.FooterImageKey = "";
			this.groupBoxStatus.HeaderImageIndex = -1;
			this.groupBoxStatus.HeaderImageKey = "";
			this.groupBoxStatus.HeaderMargin = new System.Windows.Forms.Padding(0);
			this.groupBoxStatus.HeaderText = "Статус";
			this.groupBoxStatus.Location = new System.Drawing.Point(352, 294);
			this.groupBoxStatus.Name = "groupBoxStatus";
			this.groupBoxStatus.Padding = new System.Windows.Forms.Padding(2, 18, 2, 2);
			// 
			// 
			// 
			this.groupBoxStatus.RootElement.Padding = new System.Windows.Forms.Padding(2, 18, 2, 2);
			this.groupBoxStatus.Size = new System.Drawing.Size(334, 102);
			this.groupBoxStatus.TabIndex = 3;
			this.groupBoxStatus.Text = "Статус";
			// 
			// labelStartStop
			// 
			this.labelStartStop.Font = new System.Drawing.Font("Segoe UI", 18F);
			this.labelStartStop.ForeColor = System.Drawing.Color.Maroon;
			this.labelStartStop.Location = new System.Drawing.Point(19, 41);
			this.labelStartStop.Name = "labelStartStop";
			this.labelStartStop.Size = new System.Drawing.Size(164, 37);
			this.labelStartStop.TabIndex = 0;
			this.labelStartStop.Text = "ИЗКЛЮЧЕНО";
			// 
			// buttonStartStop
			// 
			this.buttonStartStop.Image = global::ModernSteward.Properties.Resources.iconRun;
			this.buttonStartStop.ImageAlignment = System.Drawing.ContentAlignment.MiddleRight;
			this.buttonStartStop.Location = new System.Drawing.Point(189, 21);
			this.buttonStartStop.Name = "buttonStartStop";
			this.buttonStartStop.Size = new System.Drawing.Size(139, 73);
			this.buttonStartStop.TabIndex = 1;
			this.buttonStartStop.Text = "Стартирай";
			this.buttonStartStop.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
			this.buttonStartStop.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.buttonStartStop.Click += new System.EventHandler(this.buttonStartStop_Click);
			// 
			// menuItemFile
			// 
			this.menuItemFile.AccessibleDescription = "Файл";
			this.menuItemFile.AccessibleName = "Файл";
			this.menuItemFile.AutoSize = true;
			this.menuItemFile.Items.AddRange(new Telerik.WinControls.RadItem[] {
            this.menuItemOpenFile,
            this.MenuItemSave});
			this.menuItemFile.Name = "menuItemFile";
			this.menuItemFile.Text = "Файл";
			this.menuItemFile.Visibility = Telerik.WinControls.ElementVisibility.Visible;
			// 
			// menuItemOpenFile
			// 
			this.menuItemOpenFile.AccessibleDescription = "Отвори";
			this.menuItemOpenFile.AccessibleName = "Отвори";
			this.menuItemOpenFile.Image = global::ModernSteward.Properties.Resources.iconOpen;
			this.menuItemOpenFile.Name = "menuItemOpenFile";
			this.menuItemOpenFile.Text = "Отвори";
			this.menuItemOpenFile.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
			this.menuItemOpenFile.Visibility = Telerik.WinControls.ElementVisibility.Visible;
			this.menuItemOpenFile.Click += new System.EventHandler(this.menuItemOpenFile_Click);
			// 
			// MenuItemSave
			// 
			this.MenuItemSave.AccessibleDescription = "Запази";
			this.MenuItemSave.AccessibleName = "Запази";
			this.MenuItemSave.Image = global::ModernSteward.Properties.Resources.iconSave;
			this.MenuItemSave.Name = "MenuItemSave";
			this.MenuItemSave.Text = "Запази";
			this.MenuItemSave.Visibility = Telerik.WinControls.ElementVisibility.Visible;
			this.MenuItemSave.Click += new System.EventHandler(this.MenuItemSave_Click);
			// 
			// menuItemAdvanced
			// 
			this.menuItemAdvanced.AccessibleDescription = "Напреднали";
			this.menuItemAdvanced.AccessibleName = "Напреднали";
			this.menuItemAdvanced.Items.AddRange(new Telerik.WinControls.RadItem[] {
            this.radMenuItemPluginWizard,
            this.menuItemMasterDictionary});
			this.menuItemAdvanced.Name = "menuItemAdvanced";
			this.menuItemAdvanced.Text = "Напреднали";
			this.menuItemAdvanced.Visibility = Telerik.WinControls.ElementVisibility.Visible;
			// 
			// radMenuItemPluginWizard
			// 
			this.radMenuItemPluginWizard.AccessibleDescription = "radMenuItem3";
			this.radMenuItemPluginWizard.AccessibleName = "radMenuItem3";
			this.radMenuItemPluginWizard.Image = global::ModernSteward.Properties.Resources.wizardIcon;
			this.radMenuItemPluginWizard.Name = "radMenuItemPluginWizard";
			this.radMenuItemPluginWizard.Text = "Магьосник за добавки";
			this.radMenuItemPluginWizard.Visibility = Telerik.WinControls.ElementVisibility.Visible;
			this.radMenuItemPluginWizard.Click += new System.EventHandler(this.radMenuItemPluginWizard_Click);
			// 
			// menuItemMasterDictionary
			// 
			this.menuItemMasterDictionary.AccessibleDescription = "Главен речник";
			this.menuItemMasterDictionary.AccessibleName = "Главен речник";
			this.menuItemMasterDictionary.Image = global::ModernSteward.Properties.Resources.iconDictionary;
			this.menuItemMasterDictionary.Name = "menuItemMasterDictionary";
			this.menuItemMasterDictionary.Text = "Главен речник";
			this.menuItemMasterDictionary.Visibility = Telerik.WinControls.ElementVisibility.Visible;
			this.menuItemMasterDictionary.Click += new System.EventHandler(this.menuItemMasterDictionary_Click);
			// 
			// statusStrip
			// 
			this.statusStrip.AutoSize = true;
			this.statusStrip.Items.AddRange(new Telerik.WinControls.RadItem[] {
            this.labelStatusInStatusStrip});
			this.statusStrip.LayoutStyle = Telerik.WinControls.UI.RadStatusBarLayoutStyle.Stack;
			this.statusStrip.Location = new System.Drawing.Point(0, 401);
			this.statusStrip.Name = "statusStrip";
			this.statusStrip.Size = new System.Drawing.Size(698, 24);
			this.statusStrip.TabIndex = 4;
			this.statusStrip.Text = "radStatusStrip1";
			// 
			// labelStatusInStatusStrip
			// 
			this.labelStatusInStatusStrip.AccessibleDescription = "status";
			this.labelStatusInStatusStrip.AccessibleName = "status";
			this.labelStatusInStatusStrip.Name = "labelStatusInStatusStrip";
			this.statusStrip.SetSpring(this.labelStatusInStatusStrip, false);
			this.labelStatusInStatusStrip.Text = "";
			this.labelStatusInStatusStrip.TextWrap = true;
			this.labelStatusInStatusStrip.Visibility = Telerik.WinControls.ElementVisibility.Visible;
			// 
			// MenuItem1
			// 
			this.MenuItem1.AccessibleDescription = "Помощ";
			this.MenuItem1.AccessibleName = "Помощ";
			this.MenuItem1.Items.AddRange(new Telerik.WinControls.RadItem[] {
            this.menuItemPluginCommands});
			this.MenuItem1.Name = "MenuItem1";
			this.MenuItem1.Text = "Помощ";
			this.MenuItem1.Visibility = Telerik.WinControls.ElementVisibility.Visible;
			// 
			// menuItemPluginCommands
			// 
			this.menuItemPluginCommands.AccessibleDescription = "Команди";
			this.menuItemPluginCommands.AccessibleName = "Команди";
			this.menuItemPluginCommands.Name = "menuItemPluginCommands";
			this.menuItemPluginCommands.Text = "Команди";
			this.menuItemPluginCommands.Visibility = Telerik.WinControls.ElementVisibility.Visible;
			this.menuItemPluginCommands.Click += new System.EventHandler(this.menuItemPluginCommands_Click);
			// 
			// menuMain
			// 
			this.menuMain.Items.AddRange(new Telerik.WinControls.RadItem[] {
            this.menuItemFile,
            this.menuItemAdvanced,
            this.MenuItem1});
			this.menuMain.Location = new System.Drawing.Point(0, 0);
			this.menuMain.Name = "menuMain";
			this.menuMain.Size = new System.Drawing.Size(698, 20);
			this.menuMain.TabIndex = 0;
			this.menuMain.Text = "radMenu1";
			// 
			// notifyIcon
			// 
			this.notifyIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon.Icon")));
			this.notifyIcon.Text = "Модерният иконом";
			this.notifyIcon.Visible = true;
			this.notifyIcon.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon_MouseDoubleClick);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(698, 425);
			this.Controls.Add(this.statusStrip);
			this.Controls.Add(this.menuMain);
			this.Controls.Add(this.groupBoxStatus);
			this.Controls.Add(this.groupBoxAddPlugin);
			this.Controls.Add(this.groupBoxPlugins);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "MainForm";
			// 
			// 
			// 
			this.RootElement.ApplyShapeToControl = true;
			this.Text = "Модерният иконом";
			this.ThemeName = "ControlDefault";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
			this.Resize += new System.EventHandler(this.MainForm_Resize);
			((System.ComponentModel.ISupportInitialize)(this.gridViewPlugins)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.groupBoxPlugins)).EndInit();
			this.groupBoxPlugins.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.groupBoxAddPlugin)).EndInit();
			this.groupBoxAddPlugin.ResumeLayout(false);
			this.groupBoxAddPlugin.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.textBoxPluginPath)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.buttonBrowseForPlugin)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.textBoxPluginName)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.labelPluginName)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.buttonAddPlugin)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.groupBoxStatus)).EndInit();
			this.groupBoxStatus.ResumeLayout(false);
			this.groupBoxStatus.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.labelStartStop)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.buttonStartStop)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.statusStrip)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.menuMain)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private Telerik.WinControls.UI.RadGridView gridViewPlugins;
        private Telerik.WinControls.UI.RadButton buttonAddPlugin;
        private Telerik.WinControls.UI.RadGroupBox groupBoxPlugins;
        private Telerik.WinControls.UI.RadGroupBox groupBoxAddPlugin;
        private Telerik.WinControls.UI.RadButton buttonStartStop;
        private Telerik.WinControls.UI.RadGroupBox groupBoxStatus;
        private Telerik.WinControls.UI.RadLabel labelStartStop;
        private Telerik.WinControls.UI.RadMenuItem menuItemFile;
        private Telerik.WinControls.UI.RadMenuItem menuItemAdvanced;
        private Telerik.WinControls.UI.RadMenuItem radMenuItemPluginWizard;
		private Telerik.WinControls.UI.RadMenuItem menuItemMasterDictionary;
        private Telerik.WinControls.UI.RadTextBox textBoxPluginName;
        private Telerik.WinControls.UI.RadLabel labelPluginName;
        private Telerik.WinControls.UI.RadTextBox textBoxPluginPath;
        private Telerik.WinControls.UI.RadButton buttonBrowseForPlugin;
		private Telerik.WinControls.UI.RadStatusStrip statusStrip;
		private Telerik.WinControls.UI.RadLabelElement labelStatusInStatusStrip;
		private Telerik.WinControls.UI.RadMenuItem menuItemOpenFile;
		private Telerik.WinControls.UI.RadMenuItem MenuItemSave;
		private Telerik.WinControls.UI.RadMenuItem MenuItem1;
		private Telerik.WinControls.UI.RadMenuItem menuItemPluginCommands;
		private Telerik.WinControls.UI.RadMenu menuMain;
        private System.Windows.Forms.NotifyIcon notifyIcon;

    }
}
