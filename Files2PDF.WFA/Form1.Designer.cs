﻿namespace Files2PDFWFA
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            fileListBox = new ListBox();
            UploadButton = new Button();
            ConvertToPDFButton = new Button();
            ClearAllButton = new Button();
            MoveUpButton = new Button();
            MoveDownButton = new Button();
            RemoveButton = new Button();
            HelpToolTip = new ToolTip(components);
            pictureBoxLoader = new PictureBox();
            folderBrowserDialog = new FolderBrowserDialog();
            menuStrip1 = new MenuStrip();
            toolStripMenuItem1 = new ToolStripMenuItem();
            LoadFilesToolStripMenuItem = new ToolStripMenuItem();
            ExportToolStripMenuItem = new ToolStripMenuItem();
            clearAllToolStripMenuItem = new ToolStripMenuItem();
            OpenLogsToolStripMenuItem = new ToolStripMenuItem();
            helpToolStripMenuItem = new ToolStripMenuItem();
            labelPlaceholder = new Label();
            VersionLabel = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBoxLoader).BeginInit();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // fileListBox
            // 
            fileListBox.FormattingEnabled = true;
            fileListBox.ItemHeight = 20;
            fileListBox.Location = new Point(194, 60);
            fileListBox.Name = "fileListBox";
            fileListBox.Size = new Size(797, 504);
            fileListBox.TabIndex = 0;
            // 
            // UploadButton
            // 
            UploadButton.BackColor = Color.FromArgb(251, 251, 251);
            UploadButton.FlatAppearance.BorderColor = Color.LightGray;
            UploadButton.FlatAppearance.BorderSize = 2;
            UploadButton.Font = new Font("Arial Narrow", 16F, FontStyle.Regular, GraphicsUnit.Point);
            UploadButton.ForeColor = Color.FromArgb(38, 144, 148);
            UploadButton.Image = (Image)resources.GetObject("UploadButton.Image");
            UploadButton.ImageAlign = ContentAlignment.MiddleLeft;
            UploadButton.Location = new Point(11, 60);
            UploadButton.Name = "UploadButton";
            UploadButton.Padding = new Padding(5, 0, 0, 0);
            UploadButton.RightToLeft = RightToLeft.No;
            UploadButton.Size = new Size(173, 41);
            UploadButton.TabIndex = 1;
            UploadButton.Text = "טעינת קבצים";
            UploadButton.TextAlign = ContentAlignment.MiddleRight;
            UploadButton.UseVisualStyleBackColor = false;
            UploadButton.Click += UploadButton_Click;
            // 
            // ConvertToPDFButton
            // 
            ConvertToPDFButton.BackColor = Color.FromArgb(251, 251, 251);
            ConvertToPDFButton.FlatAppearance.BorderColor = Color.LightGray;
            ConvertToPDFButton.FlatAppearance.BorderSize = 2;
            ConvertToPDFButton.Font = new Font("Arial Narrow", 16F, FontStyle.Regular, GraphicsUnit.Point);
            ConvertToPDFButton.ForeColor = Color.FromArgb(38, 144, 148);
            ConvertToPDFButton.Image = (Image)resources.GetObject("ConvertToPDFButton.Image");
            ConvertToPDFButton.ImageAlign = ContentAlignment.MiddleLeft;
            ConvertToPDFButton.Location = new Point(11, 294);
            ConvertToPDFButton.Name = "ConvertToPDFButton";
            ConvertToPDFButton.Padding = new Padding(5, 0, 0, 0);
            ConvertToPDFButton.RightToLeft = RightToLeft.No;
            ConvertToPDFButton.Size = new Size(173, 41);
            ConvertToPDFButton.TabIndex = 8;
            ConvertToPDFButton.Text = "יצירת קובץ";
            ConvertToPDFButton.TextAlign = ContentAlignment.MiddleRight;
            ConvertToPDFButton.UseVisualStyleBackColor = false;
            ConvertToPDFButton.Click += ConvertToPDFButton_Click;
            // 
            // ClearAllButton
            // 
            ClearAllButton.BackColor = Color.FromArgb(251, 251, 251);
            ClearAllButton.FlatAppearance.BorderColor = Color.LightGray;
            ClearAllButton.FlatAppearance.BorderSize = 0;
            ClearAllButton.FlatStyle = FlatStyle.Flat;
            ClearAllButton.Font = new Font("Arial Narrow", 13F, FontStyle.Regular, GraphicsUnit.Point);
            ClearAllButton.ForeColor = Color.FromArgb(38, 144, 148);
            ClearAllButton.Image = (Image)resources.GetObject("ClearAllButton.Image");
            ClearAllButton.ImageAlign = ContentAlignment.MiddleLeft;
            ClearAllButton.Location = new Point(13, 238);
            ClearAllButton.Name = "ClearAllButton";
            ClearAllButton.Padding = new Padding(5, 0, 0, 0);
            ClearAllButton.RightToLeft = RightToLeft.No;
            ClearAllButton.Size = new Size(168, 41);
            ClearAllButton.TabIndex = 11;
            ClearAllButton.Text = "ניקוי הכל";
            ClearAllButton.TextAlign = ContentAlignment.MiddleRight;
            ClearAllButton.UseVisualStyleBackColor = false;
            ClearAllButton.Click += ClearAllButton_Click;
            // 
            // MoveUpButton
            // 
            MoveUpButton.BackColor = Color.FromArgb(251, 251, 251);
            MoveUpButton.FlatAppearance.BorderColor = Color.LightGray;
            MoveUpButton.FlatAppearance.BorderSize = 0;
            MoveUpButton.FlatStyle = FlatStyle.Flat;
            MoveUpButton.Font = new Font("Arial Narrow", 13F, FontStyle.Regular, GraphicsUnit.Point);
            MoveUpButton.ForeColor = Color.FromArgb(38, 144, 148);
            MoveUpButton.Image = (Image)resources.GetObject("MoveUpButton.Image");
            MoveUpButton.ImageAlign = ContentAlignment.MiddleLeft;
            MoveUpButton.Location = new Point(13, 156);
            MoveUpButton.Name = "MoveUpButton";
            MoveUpButton.Padding = new Padding(3, 0, 0, 0);
            MoveUpButton.RightToLeft = RightToLeft.No;
            MoveUpButton.Size = new Size(168, 41);
            MoveUpButton.TabIndex = 9;
            MoveUpButton.Text = "הזזה למעלה";
            MoveUpButton.TextAlign = ContentAlignment.MiddleRight;
            MoveUpButton.UseVisualStyleBackColor = false;
            MoveUpButton.Click += MoveUpButton_Click;
            // 
            // MoveDownButton
            // 
            MoveDownButton.BackColor = Color.FromArgb(251, 251, 251);
            MoveDownButton.FlatAppearance.BorderColor = Color.LightGray;
            MoveDownButton.FlatAppearance.BorderSize = 0;
            MoveDownButton.FlatStyle = FlatStyle.Flat;
            MoveDownButton.Font = new Font("Arial Narrow", 13F, FontStyle.Regular, GraphicsUnit.Point);
            MoveDownButton.ForeColor = Color.FromArgb(38, 144, 148);
            MoveDownButton.Image = (Image)resources.GetObject("MoveDownButton.Image");
            MoveDownButton.ImageAlign = ContentAlignment.MiddleLeft;
            MoveDownButton.Location = new Point(13, 197);
            MoveDownButton.Name = "MoveDownButton";
            MoveDownButton.Padding = new Padding(3, 0, 0, 0);
            MoveDownButton.RightToLeft = RightToLeft.No;
            MoveDownButton.Size = new Size(168, 41);
            MoveDownButton.TabIndex = 10;
            MoveDownButton.Text = "הזזה למטה";
            MoveDownButton.TextAlign = ContentAlignment.MiddleRight;
            MoveDownButton.UseVisualStyleBackColor = false;
            MoveDownButton.Click += MoveDownButton_Click;
            // 
            // RemoveButton
            // 
            RemoveButton.BackColor = Color.FromArgb(251, 251, 251);
            RemoveButton.FlatAppearance.BorderColor = Color.White;
            RemoveButton.FlatAppearance.BorderSize = 2;
            RemoveButton.FlatStyle = FlatStyle.Flat;
            RemoveButton.Font = new Font("Arial Narrow", 13F, FontStyle.Regular, GraphicsUnit.Point);
            RemoveButton.ForeColor = Color.FromArgb(38, 144, 148);
            RemoveButton.Image = (Image)resources.GetObject("RemoveButton.Image");
            RemoveButton.ImageAlign = ContentAlignment.MiddleLeft;
            RemoveButton.Location = new Point(13, 115);
            RemoveButton.Name = "RemoveButton";
            RemoveButton.RightToLeft = RightToLeft.No;
            RemoveButton.Size = new Size(168, 41);
            RemoveButton.TabIndex = 12;
            RemoveButton.Text = "מחיקת קובץ";
            RemoveButton.TextAlign = ContentAlignment.MiddleRight;
            RemoveButton.UseVisualStyleBackColor = false;
            RemoveButton.Click += RemoveButton_Click;
            // 
            // HelpToolTip
            // 
            HelpToolTip.IsBalloon = true;
            // 
            // pictureBoxLoader
            // 
            pictureBoxLoader.BackColor = Color.FromArgb(234, 234, 234);
            pictureBoxLoader.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBoxLoader.Image = (Image)resources.GetObject("pictureBoxLoader.Image");
            pictureBoxLoader.Location = new Point(1, 341);
            pictureBoxLoader.Name = "pictureBoxLoader";
            pictureBoxLoader.Size = new Size(187, 212);
            pictureBoxLoader.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxLoader.TabIndex = 14;
            pictureBoxLoader.TabStop = false;
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { toolStripMenuItem1, helpToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.RightToLeft = RightToLeft.Yes;
            menuStrip1.Size = new Size(1006, 28);
            menuStrip1.TabIndex = 15;
            menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.DropDownItems.AddRange(new ToolStripItem[] { LoadFilesToolStripMenuItem, ExportToolStripMenuItem, clearAllToolStripMenuItem, OpenLogsToolStripMenuItem });
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.RightToLeft = RightToLeft.Yes;
            toolStripMenuItem1.Size = new Size(54, 24);
            toolStripMenuItem1.Text = "קובץ";
            // 
            // LoadFilesToolStripMenuItem
            // 
            LoadFilesToolStripMenuItem.Name = "LoadFilesToolStripMenuItem";
            LoadFilesToolStripMenuItem.Size = new Size(178, 26);
            LoadFilesToolStripMenuItem.Text = "טעינת קבצים";
            LoadFilesToolStripMenuItem.Click += UploadButton_Click;
            // 
            // ExportToolStripMenuItem
            // 
            ExportToolStripMenuItem.Name = "ExportToolStripMenuItem";
            ExportToolStripMenuItem.Size = new Size(178, 26);
            ExportToolStripMenuItem.Text = "יצירת קובץ";
            ExportToolStripMenuItem.Click += ConvertToPDFButton_Click;
            // 
            // clearAllToolStripMenuItem
            // 
            clearAllToolStripMenuItem.Name = "clearAllToolStripMenuItem";
            clearAllToolStripMenuItem.Size = new Size(178, 26);
            clearAllToolStripMenuItem.Text = "ניקוי הכל";
            clearAllToolStripMenuItem.Click += ClearAllButton_Click;
            // 
            // OpenLogsToolStripMenuItem
            // 
            OpenLogsToolStripMenuItem.Name = "OpenLogsToolStripMenuItem";
            OpenLogsToolStripMenuItem.Size = new Size(178, 26);
            OpenLogsToolStripMenuItem.Text = "פתיחת לוגים";
            OpenLogsToolStripMenuItem.Click += OpenLogsToolStripMenuItem_Click;
            // 
            // helpToolStripMenuItem
            // 
            helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            helpToolStripMenuItem.Size = new Size(55, 24);
            helpToolStripMenuItem.Text = "עזרה";
            helpToolStripMenuItem.Click += helpToolStripMenuItem_Click;
            // 
            // labelPlaceholder
            // 
            labelPlaceholder.AutoSize = true;
            labelPlaceholder.BackColor = Color.White;
            labelPlaceholder.Location = new Point(208, 74);
            labelPlaceholder.Name = "labelPlaceholder";
            labelPlaceholder.Size = new Size(321, 20);
            labelPlaceholder.TabIndex = 16;
            labelPlaceholder.Text = "לתחילת עבודה יש ללחוץ על כפתור טעינת קבצים";
            // 
            // VersionLabel
            // 
            VersionLabel.AutoSize = true;
            VersionLabel.ForeColor = SystemColors.WindowFrame;
            VersionLabel.Location = new Point(941, 569);
            VersionLabel.Name = "VersionLabel";
            VersionLabel.Size = new Size(48, 20);
            VersionLabel.TabIndex = 18;
            VersionLabel.Text = "V1.0.0";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(234, 234, 234);
            ClientSize = new Size(1006, 593);
            Controls.Add(VersionLabel);
            Controls.Add(labelPlaceholder);
            Controls.Add(pictureBoxLoader);
            Controls.Add(RemoveButton);
            Controls.Add(MoveDownButton);
            Controls.Add(MoveUpButton);
            Controls.Add(ClearAllButton);
            Controls.Add(ConvertToPDFButton);
            Controls.Add(UploadButton);
            Controls.Add(fileListBox);
            Controls.Add(menuStrip1);
            ForeColor = Color.Black;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            RightToLeft = RightToLeft.Yes;
            RightToLeftLayout = true;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FileMerge";
            ((System.ComponentModel.ISupportInitialize)pictureBoxLoader).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox fileListBox;
        private Button UploadButton;
        private Button ConvertToPDFButton;
        private Button MoveUpButton2;
        private Button ClearAllButton;
        private Button MoveUpButton;
        private Button MoveDownButton;
        private Button RemoveButton;
        private ToolTip HelpToolTip;
        private PictureBox pictureBoxLoader;
        private FolderBrowserDialog folderBrowserDialog;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem toolStripMenuItem1;
        private ToolStripMenuItem LoadFilesToolStripMenuItem;
        private ToolStripMenuItem ExportToolStripMenuItem;
        private ToolStripMenuItem clearAllToolStripMenuItem;
        private ToolStripMenuItem helpToolStripMenuItem;
        private ToolStripMenuItem OpenLogsToolStripMenuItem;
        private Label labelPlaceholder;
        private Label VersionLabel;
    }
}