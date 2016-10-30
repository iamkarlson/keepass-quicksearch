namespace QuickSearch
{
    partial class QuickSearchControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(QuickSearchControl));
            this.ButtonDropdownSettings = new System.Windows.Forms.Button();
            this.imageListSearchButton = new System.Windows.Forms.ImageList(this.components);
            this.toolStripDropDownSettings = new System.Windows.Forms.ToolStripDropDown();
            this.tableLayoutPanelMain = new System.Windows.Forms.TableLayoutPanel();
            this.groupBoxSearchIn = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanelSearchIn = new System.Windows.Forms.TableLayoutPanel();
            this.checkBoxTitle = new System.Windows.Forms.CheckBox();
            this.checkBoxUserName = new System.Windows.Forms.CheckBox();
            this.checkBoxNotes = new System.Windows.Forms.CheckBox();
            this.checkBoxGroupName = new System.Windows.Forms.CheckBox();
            this.checkBoxOther = new System.Windows.Forms.CheckBox();
            this.checkBoxPassword = new System.Windows.Forms.CheckBox();
            this.checkBoxUrl = new System.Windows.Forms.CheckBox();
            this.groupBoxOptions = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanelOptions = new System.Windows.Forms.TableLayoutPanel();
            this.checkBoxCase = new System.Windows.Forms.CheckBox();
            this.checkBoxExclude = new System.Windows.Forms.CheckBox();
            this.comboBoxSearch = new System.Windows.Forms.ComboBox();
            this.tableLayoutPanelMain.SuspendLayout();
            this.groupBoxSearchIn.SuspendLayout();
            this.tableLayoutPanelSearchIn.SuspendLayout();
            this.groupBoxOptions.SuspendLayout();
            this.tableLayoutPanelOptions.SuspendLayout();
            this.SuspendLayout();
            // 
            // ButtonDropdownSettings
            // 
            this.ButtonDropdownSettings.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ButtonDropdownSettings.BackColor = System.Drawing.SystemColors.Window;
            this.ButtonDropdownSettings.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.ButtonDropdownSettings.FlatAppearance.BorderSize = 0;
            this.ButtonDropdownSettings.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.ButtonDropdownSettings.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.ButtonDropdownSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonDropdownSettings.ForeColor = System.Drawing.Color.Transparent;
            this.ButtonDropdownSettings.ImageIndex = 0;
            this.ButtonDropdownSettings.ImageList = this.imageListSearchButton;
            this.ButtonDropdownSettings.Location = new System.Drawing.Point(1, 1);
            this.ButtonDropdownSettings.Margin = new System.Windows.Forms.Padding(0);
            this.ButtonDropdownSettings.Name = "ButtonDropdownSettings";
            this.ButtonDropdownSettings.Size = new System.Drawing.Size(19, 19);
            this.ButtonDropdownSettings.TabIndex = 0;
            this.ButtonDropdownSettings.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.ButtonDropdownSettings.UseVisualStyleBackColor = false;
            this.ButtonDropdownSettings.Click += new System.EventHandler(this.ButtonDropdownSettings_Click);
            this.ButtonDropdownSettings.MouseEnter += new System.EventHandler(this.buttonConfig_MouseEnter);
            this.ButtonDropdownSettings.MouseLeave += new System.EventHandler(this.buttonConfig_MouseLeave);
            // 
            // imageListSearchButton
            // 
            this.imageListSearchButton.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageListSearchButton.ImageStream")));
            this.imageListSearchButton.TransparentColor = System.Drawing.Color.Transparent;
            this.imageListSearchButton.Images.SetKeyName(0, "16-search-icon.png");
            this.imageListSearchButton.Images.SetKeyName(1, "16-settings-icon.png");
            // 
            // toolStripDropDownSettings
            // 
            this.toolStripDropDownSettings.BackColor = System.Drawing.SystemColors.ControlText;
            this.toolStripDropDownSettings.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Flow;
            this.toolStripDropDownSettings.Name = "toolStripDropDown1";
            this.toolStripDropDownSettings.Padding = new System.Windows.Forms.Padding(1);
            this.toolStripDropDownSettings.Size = new System.Drawing.Size(2, 2);
            this.toolStripDropDownSettings.Closed += new System.Windows.Forms.ToolStripDropDownClosedEventHandler(this.toolStripDropDownSettings_Closed);
            this.toolStripDropDownSettings.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.Control_PreviewKeyDown);
            // 
            // tableLayoutPanelMain
            // 
            this.tableLayoutPanelMain.AutoSize = true;
            this.tableLayoutPanelMain.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanelMain.BackColor = System.Drawing.SystemColors.Control;
            this.tableLayoutPanelMain.ColumnCount = 1;
            this.tableLayoutPanelMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanelMain.Controls.Add(this.groupBoxSearchIn, 0, 0);
            this.tableLayoutPanelMain.Controls.Add(this.groupBoxOptions, 0, 1);
            this.tableLayoutPanelMain.Location = new System.Drawing.Point(51, 81);
            this.tableLayoutPanelMain.Name = "tableLayoutPanelMain";
            this.tableLayoutPanelMain.RowCount = 2;
            this.tableLayoutPanelMain.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanelMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelMain.Size = new System.Drawing.Size(270, 165);
            this.tableLayoutPanelMain.TabIndex = 3;
            this.tableLayoutPanelMain.Visible = false;
            // 
            // groupBoxSearchIn
            // 
            this.groupBoxSearchIn.AutoSize = true;
            this.groupBoxSearchIn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.groupBoxSearchIn.Controls.Add(this.tableLayoutPanelSearchIn);
            this.groupBoxSearchIn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxSearchIn.Location = new System.Drawing.Point(3, 3);
            this.groupBoxSearchIn.Name = "groupBoxSearchIn";
            this.groupBoxSearchIn.Size = new System.Drawing.Size(264, 88);
            this.groupBoxSearchIn.TabIndex = 0;
            this.groupBoxSearchIn.TabStop = false;
            this.groupBoxSearchIn.Text = "Search in";
            // 
            // tableLayoutPanelSearchIn
            // 
            this.tableLayoutPanelSearchIn.AutoSize = true;
            this.tableLayoutPanelSearchIn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanelSearchIn.ColumnCount = 3;
            this.tableLayoutPanelSearchIn.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanelSearchIn.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanelSearchIn.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanelSearchIn.Controls.Add(this.checkBoxTitle, 0, 0);
            this.tableLayoutPanelSearchIn.Controls.Add(this.checkBoxUserName, 0, 1);
            this.tableLayoutPanelSearchIn.Controls.Add(this.checkBoxNotes, 0, 2);
            this.tableLayoutPanelSearchIn.Controls.Add(this.checkBoxGroupName, 1, 0);
            this.tableLayoutPanelSearchIn.Controls.Add(this.checkBoxOther, 2, 0);
            this.tableLayoutPanelSearchIn.Controls.Add(this.checkBoxPassword, 1, 2);
            this.tableLayoutPanelSearchIn.Controls.Add(this.checkBoxUrl, 1, 1);
            this.tableLayoutPanelSearchIn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelSearchIn.GrowStyle = System.Windows.Forms.TableLayoutPanelGrowStyle.FixedSize;
            this.tableLayoutPanelSearchIn.Location = new System.Drawing.Point(3, 16);
            this.tableLayoutPanelSearchIn.Name = "tableLayoutPanelSearchIn";
            this.tableLayoutPanelSearchIn.RowCount = 3;
            this.tableLayoutPanelSearchIn.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanelSearchIn.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanelSearchIn.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanelSearchIn.Size = new System.Drawing.Size(258, 69);
            this.tableLayoutPanelSearchIn.TabIndex = 0;
            // 
            // checkBoxTitle
            // 
            this.checkBoxTitle.AutoSize = true;
            this.checkBoxTitle.Checked = global::QuickSearch.Properties.Settings.Default.SearchInTitle;
            this.checkBoxTitle.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxTitle.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::QuickSearch.Properties.Settings.Default, "SearchInTitle", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.checkBoxTitle.Location = new System.Drawing.Point(3, 3);
            this.checkBoxTitle.Name = "checkBoxTitle";
            this.checkBoxTitle.Size = new System.Drawing.Size(46, 17);
            this.checkBoxTitle.TabIndex = 0;
            this.checkBoxTitle.Text = "Title";
            this.checkBoxTitle.UseVisualStyleBackColor = true;
            this.checkBoxTitle.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.Control_PreviewKeyDown);
            // 
            // checkBoxUserName
            // 
            this.checkBoxUserName.AutoSize = true;
            this.checkBoxUserName.Checked = global::QuickSearch.Properties.Settings.Default.SearchInUserName;
            this.checkBoxUserName.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::QuickSearch.Properties.Settings.Default, "SearchInUserName", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.checkBoxUserName.Location = new System.Drawing.Point(3, 26);
            this.checkBoxUserName.Name = "checkBoxUserName";
            this.checkBoxUserName.Size = new System.Drawing.Size(77, 17);
            this.checkBoxUserName.TabIndex = 1;
            this.checkBoxUserName.Text = "User name";
            this.checkBoxUserName.UseVisualStyleBackColor = true;
            this.checkBoxUserName.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.Control_PreviewKeyDown);
            // 
            // checkBoxNotes
            // 
            this.checkBoxNotes.AutoSize = true;
            this.checkBoxNotes.Checked = global::QuickSearch.Properties.Settings.Default.SearchInNotes;
            this.checkBoxNotes.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::QuickSearch.Properties.Settings.Default, "SearchInNotes", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.checkBoxNotes.Location = new System.Drawing.Point(3, 49);
            this.checkBoxNotes.Name = "checkBoxNotes";
            this.checkBoxNotes.Size = new System.Drawing.Size(54, 17);
            this.checkBoxNotes.TabIndex = 2;
            this.checkBoxNotes.Text = "Notes";
            this.checkBoxNotes.UseVisualStyleBackColor = true;
            this.checkBoxNotes.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.Control_PreviewKeyDown);
            // 
            // checkBoxGroupName
            // 
            this.checkBoxGroupName.AutoSize = true;
            this.checkBoxGroupName.Checked = global::QuickSearch.Properties.Settings.Default.SearchInGroupName;
            this.checkBoxGroupName.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::QuickSearch.Properties.Settings.Default, "SearchInGroupName", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.checkBoxGroupName.Enabled = false;
            this.checkBoxGroupName.Location = new System.Drawing.Point(86, 3);
            this.checkBoxGroupName.Name = "checkBoxGroupName";
            this.checkBoxGroupName.Size = new System.Drawing.Size(84, 17);
            this.checkBoxGroupName.TabIndex = 3;
            this.checkBoxGroupName.Text = "Group name";
            this.checkBoxGroupName.UseVisualStyleBackColor = true;
            this.checkBoxGroupName.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.Control_PreviewKeyDown);
            // 
            // checkBoxOther
            // 
            this.checkBoxOther.AutoSize = true;
            this.checkBoxOther.Checked = global::QuickSearch.Properties.Settings.Default.SearchInOther;
            this.checkBoxOther.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::QuickSearch.Properties.Settings.Default, "SearchInOther", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.checkBoxOther.Location = new System.Drawing.Point(176, 3);
            this.checkBoxOther.Name = "checkBoxOther";
            this.checkBoxOther.Size = new System.Drawing.Size(79, 17);
            this.checkBoxOther.TabIndex = 6;
            this.checkBoxOther.Text = "Other fields";
            this.checkBoxOther.UseVisualStyleBackColor = true;
            this.checkBoxOther.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.Control_PreviewKeyDown);
            // 
            // checkBoxPassword
            // 
            this.checkBoxPassword.AutoSize = true;
            this.checkBoxPassword.Checked = global::QuickSearch.Properties.Settings.Default.SearchInPassword;
            this.checkBoxPassword.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::QuickSearch.Properties.Settings.Default, "SearchInPassword", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.checkBoxPassword.Location = new System.Drawing.Point(86, 49);
            this.checkBoxPassword.Name = "checkBoxPassword";
            this.checkBoxPassword.Size = new System.Drawing.Size(72, 17);
            this.checkBoxPassword.TabIndex = 4;
            this.checkBoxPassword.Text = "Password";
            this.checkBoxPassword.UseVisualStyleBackColor = true;
            this.checkBoxPassword.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.Control_PreviewKeyDown);
            // 
            // checkBoxUrl
            // 
            this.checkBoxUrl.AutoSize = true;
            this.checkBoxUrl.Checked = global::QuickSearch.Properties.Settings.Default.SearchInUrl;
            this.checkBoxUrl.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxUrl.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::QuickSearch.Properties.Settings.Default, "SearchInUrl", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.checkBoxUrl.Location = new System.Drawing.Point(86, 26);
            this.checkBoxUrl.Name = "checkBoxUrl";
            this.checkBoxUrl.Size = new System.Drawing.Size(48, 17);
            this.checkBoxUrl.TabIndex = 5;
            this.checkBoxUrl.Text = "URL";
            this.checkBoxUrl.UseVisualStyleBackColor = true;
            this.checkBoxUrl.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.Control_PreviewKeyDown);
            // 
            // groupBoxOptions
            // 
            this.groupBoxOptions.AutoSize = true;
            this.groupBoxOptions.Controls.Add(this.tableLayoutPanelOptions);
            this.groupBoxOptions.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxOptions.Location = new System.Drawing.Point(3, 97);
            this.groupBoxOptions.Name = "groupBoxOptions";
            this.groupBoxOptions.Size = new System.Drawing.Size(264, 65);
            this.groupBoxOptions.TabIndex = 1;
            this.groupBoxOptions.TabStop = false;
            this.groupBoxOptions.Text = "Options";
            // 
            // tableLayoutPanelOptions
            // 
            this.tableLayoutPanelOptions.AutoSize = true;
            this.tableLayoutPanelOptions.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanelOptions.ColumnCount = 1;
            this.tableLayoutPanelOptions.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanelOptions.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 17F));
            this.tableLayoutPanelOptions.Controls.Add(this.checkBoxCase, 0, 0);
            this.tableLayoutPanelOptions.Controls.Add(this.checkBoxExclude, 0, 1);
            this.tableLayoutPanelOptions.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelOptions.Location = new System.Drawing.Point(3, 16);
            this.tableLayoutPanelOptions.Name = "tableLayoutPanelOptions";
            this.tableLayoutPanelOptions.RowCount = 2;
            this.tableLayoutPanelOptions.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanelOptions.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanelOptions.Size = new System.Drawing.Size(258, 46);
            this.tableLayoutPanelOptions.TabIndex = 0;
            // 
            // checkBoxCase
            // 
            this.checkBoxCase.AutoSize = true;
            this.checkBoxCase.Checked = global::QuickSearch.Properties.Settings.Default.SearchCaseSensitive;
            this.checkBoxCase.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::QuickSearch.Properties.Settings.Default, "SearchCaseSensitive", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.checkBoxCase.Location = new System.Drawing.Point(3, 3);
            this.checkBoxCase.Name = "checkBoxCase";
            this.checkBoxCase.Size = new System.Drawing.Size(94, 17);
            this.checkBoxCase.TabIndex = 0;
            this.checkBoxCase.Text = "Case-sensitive";
            this.checkBoxCase.UseVisualStyleBackColor = true;
            this.checkBoxCase.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.Control_PreviewKeyDown);
            // 
            // checkBoxExclude
            // 
            this.checkBoxExclude.AutoSize = true;
            this.checkBoxExclude.Checked = global::QuickSearch.Properties.Settings.Default.SearchExcludeExpired;
            this.checkBoxExclude.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::QuickSearch.Properties.Settings.Default, "SearchExcludeExpired", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.checkBoxExclude.Location = new System.Drawing.Point(3, 26);
            this.checkBoxExclude.Name = "checkBoxExclude";
            this.checkBoxExclude.Size = new System.Drawing.Size(135, 17);
            this.checkBoxExclude.TabIndex = 1;
            this.checkBoxExclude.Text = "Exclude expired entries";
            this.checkBoxExclude.UseVisualStyleBackColor = true;
            this.checkBoxExclude.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.Control_PreviewKeyDown);
            // 
            // comboBoxSearch
            // 
            this.comboBoxSearch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxSearch.Location = new System.Drawing.Point(19, 0);
            this.comboBoxSearch.Margin = new System.Windows.Forms.Padding(0);
            this.comboBoxSearch.MinimumSize = new System.Drawing.Size(80, 0);
            this.comboBoxSearch.Name = "comboBoxSearch";
            this.comboBoxSearch.Size = new System.Drawing.Size(412, 21);
            this.comboBoxSearch.TabIndex = 2;
            // 
            // QuickSearchControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.Controls.Add(this.ButtonDropdownSettings);
            this.Controls.Add(this.comboBoxSearch);
            this.Controls.Add(this.tableLayoutPanelMain);
            this.MinimumSize = new System.Drawing.Size(180, 0);
            this.Name = "QuickSearchControl";
            this.Size = new System.Drawing.Size(432, 249);
            this.tableLayoutPanelMain.ResumeLayout(false);
            this.tableLayoutPanelMain.PerformLayout();
            this.groupBoxSearchIn.ResumeLayout(false);
            this.groupBoxSearchIn.PerformLayout();
            this.tableLayoutPanelSearchIn.ResumeLayout(false);
            this.tableLayoutPanelSearchIn.PerformLayout();
            this.groupBoxOptions.ResumeLayout(false);
            this.groupBoxOptions.PerformLayout();
            this.tableLayoutPanelOptions.ResumeLayout(false);
            this.tableLayoutPanelOptions.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ButtonDropdownSettings;
        private System.Windows.Forms.ToolStripDropDown toolStripDropDownSettings;
        private System.Windows.Forms.ImageList imageListSearchButton;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelMain;
        private System.Windows.Forms.GroupBox groupBoxSearchIn;
        private System.Windows.Forms.GroupBox groupBoxOptions;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelSearchIn;
        private System.Windows.Forms.CheckBox checkBoxTitle;
        private System.Windows.Forms.CheckBox checkBoxUserName;
        private System.Windows.Forms.CheckBox checkBoxNotes;
        private System.Windows.Forms.CheckBox checkBoxGroupName;
        private System.Windows.Forms.CheckBox checkBoxPassword;
        private System.Windows.Forms.CheckBox checkBoxUrl;
        private System.Windows.Forms.CheckBox checkBoxOther;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelOptions;
        private System.Windows.Forms.CheckBox checkBoxCase;
        private System.Windows.Forms.CheckBox checkBoxExclude;
        public System.Windows.Forms.ComboBox comboBoxSearch;

    }
}
