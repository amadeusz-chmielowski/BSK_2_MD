namespace BSK_2_MD
{
    partial class Main
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
            this.mainTab = new MaterialSkin.Controls.MaterialTabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.selectTextOutput = new System.Windows.Forms.TextBox();
            this.selectButton = new System.Windows.Forms.Button();
            this.selectListBox = new System.Windows.Forms.CheckedListBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.insertTexBoxOutput = new System.Windows.Forms.TextBox();
            this.insertButton = new System.Windows.Forms.Button();
            this.insertListBox = new System.Windows.Forms.CheckedListBox();
            this.materialTabSelector1 = new MaterialSkin.Controls.MaterialTabSelector();
            this.mainTab.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainTab
            // 
            this.mainTab.Controls.Add(this.tabPage1);
            this.mainTab.Controls.Add(this.tabPage2);
            this.mainTab.Depth = 0;
            this.mainTab.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.mainTab.Location = new System.Drawing.Point(0, 116);
            this.mainTab.Margin = new System.Windows.Forms.Padding(0);
            this.mainTab.MouseState = MaterialSkin.MouseState.HOVER;
            this.mainTab.Name = "mainTab";
            this.mainTab.SelectedIndex = 0;
            this.mainTab.Size = new System.Drawing.Size(957, 492);
            this.mainTab.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.selectTextOutput);
            this.tabPage1.Controls.Add(this.selectButton);
            this.tabPage1.Controls.Add(this.selectListBox);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(949, 463);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Read";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // selectTextOutput
            // 
            this.selectTextOutput.Dock = System.Windows.Forms.DockStyle.Right;
            this.selectTextOutput.Location = new System.Drawing.Point(0, 3);
            this.selectTextOutput.Multiline = true;
            this.selectTextOutput.Name = "selectTextOutput";
            this.selectTextOutput.ReadOnly = true;
            this.selectTextOutput.Size = new System.Drawing.Size(665, 457);
            this.selectTextOutput.TabIndex = 2;
            // 
            // selectButton
            // 
            this.selectButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.selectButton.Location = new System.Drawing.Point(665, 3);
            this.selectButton.Name = "selectButton";
            this.selectButton.Size = new System.Drawing.Size(94, 457);
            this.selectButton.TabIndex = 1;
            this.selectButton.Text = "Run Selected";
            this.selectButton.UseVisualStyleBackColor = true;
            this.selectButton.Click += new System.EventHandler(this.selectButton_Click);
            // 
            // selectListBox
            // 
            this.selectListBox.Dock = System.Windows.Forms.DockStyle.Right;
            this.selectListBox.FormattingEnabled = true;
            this.selectListBox.Location = new System.Drawing.Point(759, 3);
            this.selectListBox.Name = "selectListBox";
            this.selectListBox.ScrollAlwaysVisible = true;
            this.selectListBox.Size = new System.Drawing.Size(187, 457);
            this.selectListBox.TabIndex = 0;
            this.selectListBox.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.selectListBox_ItemCheck);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.insertTexBoxOutput);
            this.tabPage2.Controls.Add(this.insertButton);
            this.tabPage2.Controls.Add(this.insertListBox);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(949, 463);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Write";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // insertTexBoxOutput
            // 
            this.insertTexBoxOutput.Dock = System.Windows.Forms.DockStyle.Right;
            this.insertTexBoxOutput.Location = new System.Drawing.Point(6, 3);
            this.insertTexBoxOutput.Multiline = true;
            this.insertTexBoxOutput.Name = "insertTexBoxOutput";
            this.insertTexBoxOutput.ReadOnly = true;
            this.insertTexBoxOutput.Size = new System.Drawing.Size(523, 457);
            this.insertTexBoxOutput.TabIndex = 5;
            // 
            // insertButton
            // 
            this.insertButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.insertButton.Location = new System.Drawing.Point(529, 3);
            this.insertButton.Name = "insertButton";
            this.insertButton.Size = new System.Drawing.Size(94, 457);
            this.insertButton.TabIndex = 4;
            this.insertButton.Text = "Run Selected";
            this.insertButton.UseVisualStyleBackColor = true;
            this.insertButton.Click += new System.EventHandler(this.insertButton_Click);
            // 
            // insertListBox
            // 
            this.insertListBox.Dock = System.Windows.Forms.DockStyle.Right;
            this.insertListBox.FormattingEnabled = true;
            this.insertListBox.Location = new System.Drawing.Point(623, 3);
            this.insertListBox.Name = "insertListBox";
            this.insertListBox.ScrollAlwaysVisible = true;
            this.insertListBox.Size = new System.Drawing.Size(323, 457);
            this.insertListBox.TabIndex = 3;
            this.insertListBox.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.insertListBox_ItemCheck);
            // 
            // materialTabSelector1
            // 
            this.materialTabSelector1.BaseTabControl = this.mainTab;
            this.materialTabSelector1.Depth = 0;
            this.materialTabSelector1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.materialTabSelector1.Location = new System.Drawing.Point(0, 80);
            this.materialTabSelector1.Margin = new System.Windows.Forms.Padding(0);
            this.materialTabSelector1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialTabSelector1.Name = "materialTabSelector1";
            this.materialTabSelector1.Size = new System.Drawing.Size(957, 36);
            this.materialTabSelector1.TabIndex = 1;
            this.materialTabSelector1.Text = "materialTabSelector1";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(957, 608);
            this.Controls.Add(this.materialTabSelector1);
            this.Controls.Add(this.mainTab);
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main Window";
            this.mainTab.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialTabControl mainTab;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private MaterialSkin.Controls.MaterialTabSelector materialTabSelector1;
        private System.Windows.Forms.TextBox selectTextOutput;
        private System.Windows.Forms.Button selectButton;
        private System.Windows.Forms.CheckedListBox selectListBox;
        private System.Windows.Forms.TextBox insertTexBoxOutput;
        private System.Windows.Forms.Button insertButton;
        private System.Windows.Forms.CheckedListBox insertListBox;
    }
}

