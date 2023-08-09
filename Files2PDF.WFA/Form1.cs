using Files2PDFWFA.Objects;
using FilesToPDF.Api.Services;
using Microsoft.Extensions.Logging;
using System.ComponentModel;
using System.Diagnostics;

namespace Files2PDFWFA
{
    public partial class Form1 : Form
    {

        private List<string> uploadedFiles = new List<string>();
        private readonly FilesToPDFService _filesToPDFServicee;
        private readonly ILogger<Form1> _logger;
        private BackgroundWorker worker;

        public Form1(FilesToPDFService filesToPDFServicee, ILogger<Form1> logger)
        {
            _logger = logger;
            _filesToPDFServicee = filesToPDFServicee;
            InitializeComponent();
            HideLoader();
            worker = new BackgroundWorker();
            worker.DoWork += Worker_DoWork;
            worker.RunWorkerCompleted += Worker_RunWorkerCompleted;

        }

        private void Worker_DoWork(object sender, DoWorkEventArgs e)
        {
            StatusMessage? statusMessage = null;
            string output = e.Argument != null ? (string)e.Argument : "c:\\temp";
            try
            {
                statusMessage = _filesToPDFServicee.ConvertFilesToPDF(uploadedFiles, output);
            }
            catch (Exception ex)
            {
                statusMessage = new StatusMessage(false, ex.Message, "");
            }
            e.Result = statusMessage;


        }

        private void Worker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            HideLoader();
            EnableControls(this);
            StatusMessage status = e.Result != null ? (StatusMessage)e.Result : new StatusMessage(false, "התקבלה שגיאה במערכת", ""); ;
            if (status.IsSuccess)
            {
                string mes = status.Message + Environment.NewLine + "האם לפתוח את הקובץ" + "?";
                DialogResult result = MessageBox.Show(mes, "Confirmation", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (result == DialogResult.OK)
                {
                    // Action to perform after "OK" is clicked

                    try
                    {
                        // Open the file with the associated application
                        Process.Start("cmd", $"/c start {status.Url}");
                        //Process.Start(status.Url);
                        return;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        _logger.LogError(ex.Message);
                        return;
                    }
                }
            }
            else
            {
                MessageBox.Show(status.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                _logger.LogError(status.Message);
                return;
            }

        }

        // Recursively disable all controls
        private void DisableControls(Control control)
        {
            foreach (Control childControl in control.Controls)
            {
                childControl.Enabled = false;
                DisableControls(childControl);
            }
        }

        // Recursively enable all controls
        private void EnableControls(Control control)
        {
            foreach (Control childControl in control.Controls)
            {
                childControl.Enabled = true;
                EnableControls(childControl);
            }
        }


        private void UploadButton_Click(object sender, EventArgs e)
        {
            Console.WriteLine("UploadButton_Click");
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Multiselect = true;
                openFileDialog.Filter = "Supported Files(*.doc; *.docx; *.pdf; *.xls; *.xlsx; *.ppt; *.pptx; *.tiff; *.tif; *.jpg; *.jpeg; *.png)| " +
                                   "*.doc;*.docx;*.pdf;*.xls;*.xlsx;*.ppt;*.pptx;*.tiff;*.tif;*.jpg;*.jpeg;*.png";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    uploadedFiles.AddRange(openFileDialog.FileNames);
                    RefreshFileList();
                }
            }
        }

        private void RefreshFileList()
        {
            
            fileListBox.Items.Clear();
            for (int i = 0; i < uploadedFiles.Count; i++)
            {
                string itemText = $"{i + 1}. {uploadedFiles[i]}";
                fileListBox.Items.Add(itemText);

            }
        }




        private void RemoveButton_Click(object sender, EventArgs e)
        {
            if (fileListBox.SelectedIndex != -1)
            {
                uploadedFiles.RemoveAt(fileListBox.SelectedIndex);
                RefreshFileList();
            }
        }


        private void MoveDownButton_Click(object sender, EventArgs e)
        {
            if (fileListBox.SelectedIndex < uploadedFiles.Count - 1)
            {
                int selectedIndex = fileListBox.SelectedIndex;
                string selectedFile = uploadedFiles[selectedIndex];
                uploadedFiles.RemoveAt(selectedIndex);
                uploadedFiles.Insert(selectedIndex + 1, selectedFile);
                RefreshFileList();
                fileListBox.SelectedIndex = selectedIndex + 1;
            }
        }

        private void ConvertToPDFButton_Click(object sender, EventArgs e)
        {
            using (var folderDialog = new FolderBrowserDialog())
            {
                // Set dialog properties
                folderDialog.Description = "בחירת תיקיית יעד";
                folderDialog.ShowNewFolderButton = true;

                // Show the dialog
                DialogResult result = folderDialog.ShowDialog();

                // Process the result
                if (result == DialogResult.OK)
                {
                    string selectedFolder = folderDialog.SelectedPath;
                    PerformActionWithSelectedFolder(selectedFolder);
                }
            }


        }

        private void PerformActionWithSelectedFolder(string selectedFolder)
        {
            // Here, you can perform your desired action using the selected folder path
            //MessageBox.Show($"Performing action with selected folder: {selectedFolder}");
            ShowLoader();
            worker.RunWorkerAsync(selectedFolder);
        }

        private void MoveUpButton_Click(object sender, EventArgs e)
        {
            if (fileListBox.SelectedIndex > 0)
            {
                int selectedIndex = fileListBox.SelectedIndex;
                string selectedFile = uploadedFiles[selectedIndex];
                uploadedFiles.RemoveAt(selectedIndex);
                uploadedFiles.Insert(selectedIndex - 1, selectedFile);
                RefreshFileList();
                fileListBox.SelectedIndex = selectedIndex - 1;
            }
        }

        private void ClearAllButton_Click(object sender, EventArgs e)
        {
            uploadedFiles.Clear();
            RefreshFileList();
        }

        private void ShowLoader()
        {
            DisableControls(this);
            pictureBoxLoader.Enabled = true;
            pictureBoxLoader.Visible = true;
            pictureBoxLoader.Invalidate();
            pictureBoxLoader.Refresh();
        }

        private void HideLoader()
        {
            pictureBoxLoader.Visible = false;
            pictureBoxLoader.Refresh();
        }

        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("יש לבחור את הקבצים", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}