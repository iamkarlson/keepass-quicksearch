namespace QuickSearch
{
    partial class OptionsControl
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
            this.MainOptionsPanel = new System.Windows.Forms.TableLayoutPanel();
            this.colorSelectButtonPending = new QuickSearch.ColorSelectButton();
            this.labelSearchPending = new System.Windows.Forms.Label();
            this.labelBGColor = new System.Windows.Forms.Label();
            this.labelBGColorError = new System.Windows.Forms.Label();
            this.colorSelectButtonSuccess = new QuickSearch.ColorSelectButton();
            this.colorSelectButtonError = new QuickSearch.ColorSelectButton();
            this.colorSelectButtonUnfocused = new QuickSearch.ColorSelectButton();
            this.colorSelectButtonFocused = new QuickSearch.ColorSelectButton();
            this.labelBGColorFocused = new System.Windows.Forms.Label();
            this.labelBGColorNormalUnFocused = new System.Windows.Forms.Label();
            this.labelBGColorSuccess = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.chBoxRemoveQuickFind = new System.Windows.Forms.CheckBox();
            this.labelWidth = new System.Windows.Forms.Label();
            this.labelFocusOnOpen = new System.Windows.Forms.Label();
            this.ControlWidth = new System.Windows.Forms.NumericUpDown();
            this.chBoxFocusOnOpen = new System.Windows.Forms.CheckBox();
            this.MainOptionsPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ControlWidth)).BeginInit();
            this.SuspendLayout();
            // 
            // MainOptionsPanel
            // 
            this.MainOptionsPanel.AutoSize = true;
            this.MainOptionsPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.MainOptionsPanel.ColumnCount = 3;
            this.MainOptionsPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.MainOptionsPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.MainOptionsPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.MainOptionsPanel.Controls.Add(this.colorSelectButtonPending, 2, 2);
            this.MainOptionsPanel.Controls.Add(this.labelSearchPending, 1, 2);
            this.MainOptionsPanel.Controls.Add(this.labelBGColor, 0, 0);
            this.MainOptionsPanel.Controls.Add(this.labelBGColorError, 1, 3);
            this.MainOptionsPanel.Controls.Add(this.colorSelectButtonSuccess, 2, 1);
            this.MainOptionsPanel.Controls.Add(this.colorSelectButtonError, 2, 3);
            this.MainOptionsPanel.Controls.Add(this.colorSelectButtonUnfocused, 2, 4);
            this.MainOptionsPanel.Controls.Add(this.colorSelectButtonFocused, 2, 5);
            this.MainOptionsPanel.Controls.Add(this.labelBGColorFocused, 1, 5);
            this.MainOptionsPanel.Controls.Add(this.labelBGColorNormalUnFocused, 1, 4);
            this.MainOptionsPanel.Controls.Add(this.labelBGColorSuccess, 1, 1);
            this.MainOptionsPanel.Controls.Add(this.label1, 0, 6);
            this.MainOptionsPanel.Controls.Add(this.chBoxRemoveQuickFind, 2, 6);
            this.MainOptionsPanel.Controls.Add(this.labelWidth, 0, 8);
            this.MainOptionsPanel.Controls.Add(this.labelFocusOnOpen, 0, 7);
            this.MainOptionsPanel.Controls.Add(this.ControlWidth, 2, 8);
            this.MainOptionsPanel.Controls.Add(this.chBoxFocusOnOpen, 2, 7);
            this.MainOptionsPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainOptionsPanel.Location = new System.Drawing.Point(0, 12);
            this.MainOptionsPanel.Margin = new System.Windows.Forms.Padding(3, 12, 3, 3);
            this.MainOptionsPanel.Name = "MainOptionsPanel";
            this.MainOptionsPanel.RowCount = 9;
            this.MainOptionsPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.MainOptionsPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.MainOptionsPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.MainOptionsPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.MainOptionsPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.MainOptionsPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.MainOptionsPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.MainOptionsPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.MainOptionsPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.MainOptionsPanel.Size = new System.Drawing.Size(204, 262);
            this.MainOptionsPanel.TabIndex = 0;
            // 
            // colorSelectButtonPending
            // 
            this.colorSelectButtonPending.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.colorSelectButtonPending.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.colorSelectButtonPending.BackColor = System.Drawing.SystemColors.Control;
            this.colorSelectButtonPending.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.colorSelectButtonPending.Color = System.Drawing.SystemColors.Control;
            this.colorSelectButtonPending.Location = new System.Drawing.Point(157, 55);
            this.colorSelectButtonPending.Name = "colorSelectButtonPending";
            this.colorSelectButtonPending.Size = new System.Drawing.Size(40, 30);
            this.colorSelectButtonPending.TabIndex = 17;
            // 
            // labelSearchPending
            // 
            this.labelSearchPending.AutoSize = true;
            this.labelSearchPending.Dock = System.Windows.Forms.DockStyle.Left;
            this.labelSearchPending.Location = new System.Drawing.Point(23, 52);
            this.labelSearchPending.Name = "labelSearchPending";
            this.labelSearchPending.Size = new System.Drawing.Size(96, 36);
            this.labelSearchPending.TabIndex = 16;
            this.labelSearchPending.Text = "Search in Progress";
            this.labelSearchPending.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelBGColor
            // 
            this.labelBGColor.AutoSize = true;
            this.MainOptionsPanel.SetColumnSpan(this.labelBGColor, 3);
            this.labelBGColor.Dock = System.Windows.Forms.DockStyle.Left;
            this.labelBGColor.Location = new System.Drawing.Point(3, 0);
            this.labelBGColor.Margin = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.labelBGColor.Name = "labelBGColor";
            this.labelBGColor.Size = new System.Drawing.Size(95, 13);
            this.labelBGColor.TabIndex = 0;
            this.labelBGColor.Text = "Background Color:";
            this.labelBGColor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelBGColorError
            // 
            this.labelBGColorError.AutoSize = true;
            this.labelBGColorError.Dock = System.Windows.Forms.DockStyle.Left;
            this.labelBGColorError.Location = new System.Drawing.Point(23, 88);
            this.labelBGColorError.Name = "labelBGColorError";
            this.labelBGColorError.Size = new System.Drawing.Size(108, 36);
            this.labelBGColorError.TabIndex = 2;
            this.labelBGColorError.Text = "Search Unsuccessful";
            this.labelBGColorError.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // colorSelectButtonSuccess
            // 
            this.colorSelectButtonSuccess.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.colorSelectButtonSuccess.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.colorSelectButtonSuccess.BackColor = System.Drawing.SystemColors.Control;
            this.colorSelectButtonSuccess.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.colorSelectButtonSuccess.Color = System.Drawing.SystemColors.Control;
            this.colorSelectButtonSuccess.Location = new System.Drawing.Point(157, 19);
            this.colorSelectButtonSuccess.Name = "colorSelectButtonSuccess";
            this.colorSelectButtonSuccess.Size = new System.Drawing.Size(40, 30);
            this.colorSelectButtonSuccess.TabIndex = 5;
            // 
            // colorSelectButtonError
            // 
            this.colorSelectButtonError.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.colorSelectButtonError.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.colorSelectButtonError.BackColor = System.Drawing.SystemColors.Control;
            this.colorSelectButtonError.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.colorSelectButtonError.Color = System.Drawing.SystemColors.Control;
            this.colorSelectButtonError.Location = new System.Drawing.Point(157, 91);
            this.colorSelectButtonError.Name = "colorSelectButtonError";
            this.colorSelectButtonError.Size = new System.Drawing.Size(40, 30);
            this.colorSelectButtonError.TabIndex = 6;
            // 
            // colorSelectButtonUnfocused
            // 
            this.colorSelectButtonUnfocused.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.colorSelectButtonUnfocused.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.colorSelectButtonUnfocused.BackColor = System.Drawing.SystemColors.Control;
            this.colorSelectButtonUnfocused.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.colorSelectButtonUnfocused.Color = System.Drawing.SystemColors.Control;
            this.colorSelectButtonUnfocused.Location = new System.Drawing.Point(157, 127);
            this.colorSelectButtonUnfocused.Name = "colorSelectButtonUnfocused";
            this.colorSelectButtonUnfocused.Size = new System.Drawing.Size(40, 30);
            this.colorSelectButtonUnfocused.TabIndex = 7;
            // 
            // colorSelectButtonFocused
            // 
            this.colorSelectButtonFocused.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.colorSelectButtonFocused.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.colorSelectButtonFocused.BackColor = System.Drawing.SystemColors.Control;
            this.colorSelectButtonFocused.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.colorSelectButtonFocused.Color = System.Drawing.SystemColors.Control;
            this.colorSelectButtonFocused.Location = new System.Drawing.Point(157, 163);
            this.colorSelectButtonFocused.Name = "colorSelectButtonFocused";
            this.colorSelectButtonFocused.Size = new System.Drawing.Size(40, 30);
            this.colorSelectButtonFocused.TabIndex = 8;
            // 
            // labelBGColorFocused
            // 
            this.labelBGColorFocused.AutoSize = true;
            this.labelBGColorFocused.Dock = System.Windows.Forms.DockStyle.Left;
            this.labelBGColorFocused.Location = new System.Drawing.Point(23, 160);
            this.labelBGColorFocused.Name = "labelBGColorFocused";
            this.labelBGColorFocused.Size = new System.Drawing.Size(84, 36);
            this.labelBGColorFocused.TabIndex = 4;
            this.labelBGColorFocused.Text = "Normal Focused";
            this.labelBGColorFocused.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelBGColorNormalUnFocused
            // 
            this.labelBGColorNormalUnFocused.AutoSize = true;
            this.labelBGColorNormalUnFocused.Dock = System.Windows.Forms.DockStyle.Left;
            this.labelBGColorNormalUnFocused.Location = new System.Drawing.Point(23, 124);
            this.labelBGColorNormalUnFocused.Name = "labelBGColorNormalUnFocused";
            this.labelBGColorNormalUnFocused.Size = new System.Drawing.Size(95, 36);
            this.labelBGColorNormalUnFocused.TabIndex = 3;
            this.labelBGColorNormalUnFocused.Text = "Normal Unfocused";
            this.labelBGColorNormalUnFocused.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelBGColorSuccess
            // 
            this.labelBGColorSuccess.AutoSize = true;
            this.labelBGColorSuccess.Dock = System.Windows.Forms.DockStyle.Left;
            this.labelBGColorSuccess.Location = new System.Drawing.Point(23, 16);
            this.labelBGColorSuccess.Name = "labelBGColorSuccess";
            this.labelBGColorSuccess.Size = new System.Drawing.Size(96, 36);
            this.labelBGColorSuccess.TabIndex = 1;
            this.labelBGColorSuccess.Text = "Search Successful";
            this.labelBGColorSuccess.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.MainOptionsPanel.SetColumnSpan(this.label1, 2);
            this.label1.Location = new System.Drawing.Point(3, 196);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 20);
            this.label1.TabIndex = 12;
            this.label1.Text = "Hide QuickFind from Toolbar";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // chBoxRemoveQuickFind
            // 
            this.chBoxRemoveQuickFind.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.chBoxRemoveQuickFind.AutoSize = true;
            this.chBoxRemoveQuickFind.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.chBoxRemoveQuickFind.Location = new System.Drawing.Point(170, 199);
            this.chBoxRemoveQuickFind.Name = "chBoxRemoveQuickFind";
            this.chBoxRemoveQuickFind.Size = new System.Drawing.Size(15, 14);
            this.chBoxRemoveQuickFind.TabIndex = 9;
            this.chBoxRemoveQuickFind.UseVisualStyleBackColor = true;
            // 
            // labelWidth
            // 
            this.labelWidth.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)));
            this.labelWidth.AutoSize = true;
            this.MainOptionsPanel.SetColumnSpan(this.labelWidth, 2);
            this.labelWidth.Location = new System.Drawing.Point(3, 236);
            this.labelWidth.Name = "labelWidth";
            this.labelWidth.Size = new System.Drawing.Size(111, 26);
            this.labelWidth.TabIndex = 11;
            this.labelWidth.Text = "ToolBar Control Width";
            this.labelWidth.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelFocusOnOpen
            // 
            this.labelFocusOnOpen.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)));
            this.labelFocusOnOpen.AutoSize = true;
            this.MainOptionsPanel.SetColumnSpan(this.labelFocusOnOpen, 2);
            this.labelFocusOnOpen.Location = new System.Drawing.Point(3, 216);
            this.labelFocusOnOpen.Name = "labelFocusOnOpen";
            this.labelFocusOnOpen.Size = new System.Drawing.Size(145, 20);
            this.labelFocusOnOpen.TabIndex = 15;
            this.labelFocusOnOpen.Text = "Focus On Database Opening";
            this.labelFocusOnOpen.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ControlWidth
            // 
            this.ControlWidth.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ControlWidth.AutoSize = true;
            this.ControlWidth.Location = new System.Drawing.Point(154, 239);
            this.ControlWidth.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.ControlWidth.Minimum = new decimal(new int[] {
            40,
            0,
            0,
            0});
            this.ControlWidth.Name = "ControlWidth";
            this.ControlWidth.Size = new System.Drawing.Size(47, 20);
            this.ControlWidth.TabIndex = 10;
            this.ControlWidth.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ControlWidth.Value = new decimal(new int[] {
            80,
            0,
            0,
            0});
            // 
            // chBoxFocusOnOpen
            // 
            this.chBoxFocusOnOpen.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.chBoxFocusOnOpen.AutoSize = true;
            this.chBoxFocusOnOpen.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.chBoxFocusOnOpen.Location = new System.Drawing.Point(170, 219);
            this.chBoxFocusOnOpen.Name = "chBoxFocusOnOpen";
            this.chBoxFocusOnOpen.Size = new System.Drawing.Size(15, 14);
            this.chBoxFocusOnOpen.TabIndex = 14;
            this.chBoxFocusOnOpen.UseVisualStyleBackColor = true;
            // 
            // OptionsControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Controls.Add(this.MainOptionsPanel);
            this.Name = "OptionsControl";
            this.Padding = new System.Windows.Forms.Padding(0, 12, 0, 12);
            this.Size = new System.Drawing.Size(204, 286);
            this.MainOptionsPanel.ResumeLayout(false);
            this.MainOptionsPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ControlWidth)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel MainOptionsPanel;
        private System.Windows.Forms.Label labelBGColor;
        private System.Windows.Forms.Label labelBGColorSuccess;
        private System.Windows.Forms.Label labelBGColorError;
        private System.Windows.Forms.Label labelBGColorNormalUnFocused;
        private System.Windows.Forms.Label labelBGColorFocused;
        private ColorSelectButton colorSelectButtonSuccess;
        private ColorSelectButton colorSelectButtonError;
        private ColorSelectButton colorSelectButtonUnfocused;
        private ColorSelectButton colorSelectButtonFocused;
        private System.Windows.Forms.CheckBox chBoxRemoveQuickFind;
        private System.Windows.Forms.NumericUpDown ControlWidth;
        private System.Windows.Forms.Label labelWidth;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelFocusOnOpen;
        private System.Windows.Forms.CheckBox chBoxFocusOnOpen;
        private ColorSelectButton colorSelectButtonPending;
        private System.Windows.Forms.Label labelSearchPending;

    }
}
