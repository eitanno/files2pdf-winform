namespace Files2PDFWFA
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
            pictureBox1 = new PictureBox();
            ConvertToPDFButton = new Button();
            ClearAllButton = new Button();
            MoveUpButton = new Button();
            MoveDownButton = new Button();
            RemoveButton = new Button();
            pictureBox2 = new PictureBox();
            HelpToolTip = new ToolTip(components);
            pictureBoxLoader = new PictureBox();
            folderBrowserDialog = new FolderBrowserDialog();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxLoader).BeginInit();
            SuspendLayout();
            // 
            // fileListBox
            // 
            fileListBox.FormattingEnabled = true;
            fileListBox.ItemHeight = 20;
            fileListBox.Location = new Point(190, 139);
            fileListBox.Name = "fileListBox";
            fileListBox.Size = new Size(644, 424);
            fileListBox.TabIndex = 0;
            // 
            // UploadButton
            // 
            UploadButton.BackColor = Color.FromArgb(251, 251, 251);
            UploadButton.FlatAppearance.BorderColor = Color.LightGray;
            UploadButton.FlatAppearance.BorderSize = 2;
            UploadButton.Font = new Font("Arial Narrow", 16F, FontStyle.Bold, GraphicsUnit.Point);
            UploadButton.ForeColor = Color.FromArgb(38, 144, 148);
            UploadButton.Image = (Image)resources.GetObject("UploadButton.Image");
            UploadButton.ImageAlign = ContentAlignment.MiddleLeft;
            UploadButton.Location = new Point(425, 86);
            UploadButton.Name = "UploadButton";
            UploadButton.Padding = new Padding(5, 0, 0, 0);
            UploadButton.Size = new Size(173, 41);
            UploadButton.TabIndex = 1;
            UploadButton.Text = "טעינת קבצים";
            UploadButton.TextAlign = ContentAlignment.MiddleRight;
            UploadButton.UseVisualStyleBackColor = false;
            UploadButton.Click += UploadButton_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImageLayout = ImageLayout.None;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(857, 30);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(142, 58);
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            // 
            // ConvertToPDFButton
            // 
            ConvertToPDFButton.BackColor = Color.FromArgb(251, 251, 251);
            ConvertToPDFButton.FlatAppearance.BorderColor = Color.LightGray;
            ConvertToPDFButton.FlatAppearance.BorderSize = 2;
            ConvertToPDFButton.Font = new Font("Arial Narrow", 16F, FontStyle.Bold, GraphicsUnit.Point);
            ConvertToPDFButton.ForeColor = Color.FromArgb(175, 13, 0);
            ConvertToPDFButton.Image = (Image)resources.GetObject("ConvertToPDFButton.Image");
            ConvertToPDFButton.ImageAlign = ContentAlignment.MiddleLeft;
            ConvertToPDFButton.Location = new Point(12, 580);
            ConvertToPDFButton.Name = "ConvertToPDFButton";
            ConvertToPDFButton.Padding = new Padding(5, 0, 0, 0);
            ConvertToPDFButton.Size = new Size(173, 41);
            ConvertToPDFButton.TabIndex = 8;
            ConvertToPDFButton.Text = "יצירת קובץ";
            ConvertToPDFButton.TextAlign = ContentAlignment.MiddleRight;
            ConvertToPDFButton.UseVisualStyleBackColor = false;
            ConvertToPDFButton.Click += ConvertToPDFButton_Click;
            // 
            // ClearAllButton
            // 
            ClearAllButton.BackColor = Color.Transparent;
            ClearAllButton.FlatAppearance.BorderColor = Color.LightGray;
            ClearAllButton.FlatAppearance.BorderSize = 0;
            ClearAllButton.FlatStyle = FlatStyle.Flat;
            ClearAllButton.Font = new Font("Arial Narrow", 13F, FontStyle.Regular, GraphicsUnit.Point);
            ClearAllButton.ForeColor = Color.FromArgb(38, 144, 148);
            ClearAllButton.Image = (Image)resources.GetObject("ClearAllButton.Image");
            ClearAllButton.ImageAlign = ContentAlignment.MiddleLeft;
            ClearAllButton.Location = new Point(843, 522);
            ClearAllButton.Name = "ClearAllButton";
            ClearAllButton.Padding = new Padding(5, 0, 0, 0);
            ClearAllButton.Size = new Size(144, 41);
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
            MoveUpButton.Location = new Point(847, 319);
            MoveUpButton.Name = "MoveUpButton";
            MoveUpButton.Padding = new Padding(3, 0, 0, 0);
            MoveUpButton.Size = new Size(144, 41);
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
            MoveDownButton.Location = new Point(847, 360);
            MoveDownButton.Name = "MoveDownButton";
            MoveDownButton.Padding = new Padding(3, 0, 0, 0);
            MoveDownButton.Size = new Size(144, 41);
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
            RemoveButton.Location = new Point(847, 278);
            RemoveButton.Name = "RemoveButton";
            RemoveButton.Size = new Size(144, 41);
            RemoveButton.TabIndex = 12;
            RemoveButton.Text = "מחיקת קובץ";
            RemoveButton.TextAlign = ContentAlignment.MiddleRight;
            RemoveButton.UseVisualStyleBackColor = false;
            RemoveButton.Click += RemoveButton_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(12, 21);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(39, 37);
            pictureBox2.TabIndex = 13;
            pictureBox2.TabStop = false;
            HelpToolTip.SetToolTip(pictureBox2, "יש להוסיף את הקבצים שאותם אתם רוצים לאחד לקובץ אחד");
            // 
            // pictureBoxLoader
            // 
            pictureBoxLoader.BackColor = Color.White;
            pictureBoxLoader.Image = (Image)resources.GetObject("pictureBoxLoader.Image");
            pictureBoxLoader.Location = new Point(406, 236);
            pictureBoxLoader.Name = "pictureBoxLoader";
            pictureBoxLoader.Size = new Size(210, 224);
            pictureBoxLoader.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBoxLoader.TabIndex = 14;
            pictureBoxLoader.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(234, 234, 234);
            ClientSize = new Size(1006, 633);
            Controls.Add(pictureBoxLoader);
            Controls.Add(pictureBox2);
            Controls.Add(RemoveButton);
            Controls.Add(MoveDownButton);
            Controls.Add(MoveUpButton);
            Controls.Add(ClearAllButton);
            Controls.Add(ConvertToPDFButton);
            Controls.Add(pictureBox1);
            Controls.Add(UploadButton);
            Controls.Add(fileListBox);
            ForeColor = Color.Black;
            Name = "Form1";
            RightToLeft = RightToLeft.No;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "העלאת קבצים";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxLoader).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox fileListBox;
        private Button UploadButton;
        private PictureBox pictureBox1;
        private Button ConvertToPDFButton;
        private Button MoveUpButton2;
        private Button ClearAllButton;
        private Button MoveUpButton;
        private Button MoveDownButton;
        private Button RemoveButton;
        private PictureBox pictureBox2;
        private ToolTip HelpToolTip;
        private PictureBox pictureBoxLoader;
        private FolderBrowserDialog folderBrowserDialog;
    }
}