﻿namespace SF_Memory
{
    partial class Main
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.AddButton = new System.Windows.Forms.Button();
            this.ROMListPanel = new System.Windows.Forms.Panel();
            this.SpaceLabel = new System.Windows.Forms.Label();
            this.CreateBinariesButton = new System.Windows.Forms.Button();
            this.MenuSpace = new System.Windows.Forms.Label();
            this.MAPButton = new System.Windows.Forms.Button();
            this.ImportButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // AddButton
            // 
            this.AddButton.Location = new System.Drawing.Point(12, 12);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(75, 23);
            this.AddButton.TabIndex = 0;
            this.AddButton.Text = "Add";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButtonClick);
            // 
            // ROMListPanel
            // 
            this.ROMListPanel.AllowDrop = true;
            this.ROMListPanel.AutoScroll = true;
            this.ROMListPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.ROMListPanel.Location = new System.Drawing.Point(12, 41);
            this.ROMListPanel.Name = "ROMListPanel";
            this.ROMListPanel.Size = new System.Drawing.Size(423, 393);
            this.ROMListPanel.TabIndex = 1;
            this.ROMListPanel.ControlRemoved += new System.Windows.Forms.ControlEventHandler(this.ROMListPanel_ControlRemoved);
            this.ROMListPanel.DragDrop += new System.Windows.Forms.DragEventHandler(this.FileDrop);
            this.ROMListPanel.DragEnter += new System.Windows.Forms.DragEventHandler(this.FileEnter);
            this.ROMListPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.ROMListPanel_Paint);
            // 
            // SpaceLabel
            // 
            this.SpaceLabel.AutoSize = true;
            this.SpaceLabel.Location = new System.Drawing.Point(324, 22);
            this.SpaceLabel.Name = "SpaceLabel";
            this.SpaceLabel.Size = new System.Drawing.Size(119, 13);
            this.SpaceLabel.TabIndex = 3;
            this.SpaceLabel.Text = "Free Space: 3584kByte";
            // 
            // CreateBinariesButton
            // 
            this.CreateBinariesButton.Location = new System.Drawing.Point(93, 12);
            this.CreateBinariesButton.Name = "CreateBinariesButton";
            this.CreateBinariesButton.Size = new System.Drawing.Size(88, 23);
            this.CreateBinariesButton.TabIndex = 4;
            this.CreateBinariesButton.Text = "Create binaries";
            this.CreateBinariesButton.UseVisualStyleBackColor = true;
            this.CreateBinariesButton.Click += new System.EventHandler(this.CreateBinariesButtonClick);
            // 
            // MenuSpace
            // 
            this.MenuSpace.AutoSize = true;
            this.MenuSpace.Location = new System.Drawing.Point(182, 22);
            this.MenuSpace.Name = "MenuSpace";
            this.MenuSpace.Size = new System.Drawing.Size(150, 13);
            this.MenuSpace.TabIndex = 5;
            this.MenuSpace.Text = "512kByte reserved for menu -";
            // 
            // MAPButton
            // 
            this.MAPButton.Location = new System.Drawing.Point(12, 468);
            this.MAPButton.Name = "MAPButton";
            this.MAPButton.Size = new System.Drawing.Size(423, 23);
            this.MAPButton.TabIndex = 6;
            this.MAPButton.Text = "Create MAP data for standalone ROM (Up to 4096kByte)";
            this.MAPButton.UseVisualStyleBackColor = true;
            this.MAPButton.Click += new System.EventHandler(this.MAPButtonClick);
            // 
            // ImportButton
            // 
            this.ImportButton.Enabled = false;
            this.ImportButton.Location = new System.Drawing.Point(12, 440);
            this.ImportButton.Name = "ImportButton";
            this.ImportButton.Size = new System.Drawing.Size(423, 23);
            this.ImportButton.TabIndex = 7;
            this.ImportButton.Text = "Import ROMs from 4096kByte SFM binary";
            this.ImportButton.UseVisualStyleBackColor = true;
            this.ImportButton.Visible = false;
            this.ImportButton.Click += new System.EventHandler(this.ImportButtonClick);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(447, 497);
            this.Controls.Add(this.ImportButton);
            this.Controls.Add(this.MAPButton);
            this.Controls.Add(this.MenuSpace);
            this.Controls.Add(this.CreateBinariesButton);
            this.Controls.Add(this.SpaceLabel);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.ROMListPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Main";
            this.Text = "SF Memory Binary Maker";
            this.Load += new System.EventHandler(this.Main_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.Panel ROMListPanel;
        private System.Windows.Forms.Label SpaceLabel;
        private System.Windows.Forms.Button CreateBinariesButton;
        private System.Windows.Forms.Label MenuSpace;
        private System.Windows.Forms.Button MAPButton;
        private System.Windows.Forms.Button ImportButton;
    }
}

