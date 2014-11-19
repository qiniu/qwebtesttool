using System;
using System.Diagnostics;
using System.Text;
using System.Windows.Forms;
using System.Threading;
using System.IO;

namespace QWebTestTool
{
    public partial class MainForm : Form
    {
        private Process diagDownloadProcess;
        private Process diagUploadProcess;
        private string appRoot;
        private string qwebtestExe;
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            this.initTestDownloadUI();
            this.initTestUploadUI();
            this.appRoot = Application.StartupPath;
            this.qwebtestExe = this.appRoot + "\\qwebtest.exe";
        }

        private void initTestDownloadUI()
        {
            this.DTDownloadHeaderTextBox.Enabled = false;
            this.DTFixedDownloadSrcUrlTextBox.Enabled = false;
            this.DTFromFixedSrcCheckBox.Enabled = false;
            this.DTStatusProgressBar.Visible = false;
            this.DTStatusProgressBar.Style = ProgressBarStyle.Marquee;
            this.DTOpenReportFileButton.Enabled = false;
        }

        private void initTestUploadUI()
        {
            this.UPUploadFileTextBox.Enabled = false;
            this.UPBrowseFileButton.Enabled = false;
            this.UPUploadFixedServerTextBox.Enabled = false;
            this.UPStatusProgressBar.Style = ProgressBarStyle.Marquee;
            this.UPStatusProgressBar.Visible = false;
            this.UPOpenReportFileButton.Enabled = false;
        }

        private delegate void setReportFileCallback(TextBox reportFileTextBox, string reportFile);
        private void setReportFile(TextBox reportFileTextBox, string reportFile)
        {
            if (this.InvokeRequired)
            {
                setReportFileCallback callback = new setReportFileCallback(setReportFile);
                this.Invoke(callback, reportFileTextBox, reportFile);
            }
            else
            {
                reportFileTextBox.Text = reportFile;
            }
        }

        private delegate void setButtonStatusCallback(Button button, bool enabled);
        private void setButtonStatus(Button button, bool enabled)
        {
            if (this.InvokeRequired)
            {
                setButtonStatusCallback callback = new setButtonStatusCallback(setButtonStatus);
                this.Invoke(callback, button, enabled);
            }
            else
            {
                button.Enabled = enabled;
            }
        }

        private delegate void setProgressBarStatusCallback(ProgressBar progressBar, bool run);
        private void setProgressBarStatus(ProgressBar progressBar, bool run)
        {
            if (this.InvokeRequired)
            {
                setProgressBarStatusCallback callback = new setProgressBarStatusCallback(setProgressBarStatus);
                this.Invoke(callback, progressBar, run);
            }
            else
            {
                if (run)
                {
                    progressBar.Show();
                }
                else
                {
                    progressBar.Hide();
                }
            }
        }

        private void TestDownloadButton_Click(object sender, EventArgs e)
        {
            string downloadUrl = this.DTDownloadUrlTextBox.Text.Trim();
            if (!string.IsNullOrEmpty(downloadUrl))
            {
                string header = "";
                if (DTRequestHeaderCheckBox.Checked &&
                    !string.IsNullOrEmpty(DTDownloadHeaderTextBox.Text.Trim()))
                {
                    header = DTDownloadHeaderTextBox.Text.Trim();
                }
                bool saveData = DTSaveFileCheckBox.Checked;
                bool fromSrc = this.DTFromSrcCheckBox.Checked;
                bool fromFixedSrc = this.DTFromFixedSrcCheckBox.Checked;
                string fromFixedUrl = "";
                if (fromSrc && fromFixedSrc &&
                    !string.IsNullOrEmpty(DTFixedDownloadSrcUrlTextBox.Text.Trim()))
                {
                    fromFixedUrl = DTFixedDownloadSrcUrlTextBox.Text.Trim();
                }
                StringBuilder cmdArgs = new StringBuilder();
                cmdArgs.Append(" -download -s ").Append(downloadUrl);
                if (!string.IsNullOrEmpty(header))
                {
                    cmdArgs.Append(" -H \"").Append(header).Append("\"");
                }
                if (saveData)
                {
                    if (!Directory.Exists(this.appRoot + "\\download"))
                    {
                        Directory.CreateDirectory(this.appRoot + "\\download");
                    }
                    DateTime now = DateTime.Now;
                    string randomFileName = this.appRoot + "\\download\\download_data_" + now.ToString("yyyyMMddHHmmss") + ".dat";
                    cmdArgs.Append(" -o \"").Append(randomFileName).Append("\"");
                }
                if (fromSrc)
                {
                    cmdArgs.Append(" -src ");
                    if (fromFixedSrc && !string.IsNullOrEmpty(fromFixedUrl))
                    {
                        cmdArgs.Append(" -from ").Append(fromFixedUrl);
                    }
                }
                //use fixed timeout 5 minutes
                int timeout = 5;
                if (DTTimeoutUpDown.Value > 0)
                {
                    timeout = Convert.ToInt32(DTTimeoutUpDown.Value);
                }
                cmdArgs.Append(" -timeout ").Append(timeout);
                //Console.WriteLine(cmdArgs.ToString());
                setProgressBarStatus(DTStatusProgressBar, true);
                setButtonStatus(DTOpenReportFileButton, false);
                setButtonStatus(DTStartTestButton, false);
                this.DTReportFileTextBox.Text = "";
                Thread testThread = new Thread(new ParameterizedThreadStart(testDownload));
                testThread.Start(cmdArgs);
            }
        }


        //return the report id
        public void testDownload(object cmdArgsObj)
        {
            string cmdArgs = cmdArgsObj.ToString();
            diagDownloadProcess = new Process();
            diagDownloadProcess.StartInfo.FileName = qwebtestExe;
            diagDownloadProcess.StartInfo.Arguments = cmdArgs;
            diagDownloadProcess.StartInfo.UseShellExecute = false;
            diagDownloadProcess.StartInfo.RedirectStandardOutput = true;
            diagDownloadProcess.StartInfo.RedirectStandardError = true;
            diagDownloadProcess.StartInfo.CreateNoWindow = true;
            diagDownloadProcess.Start();

            //let it run
            string cmdOutput = diagDownloadProcess.StandardOutput.ReadToEnd();
            diagDownloadProcess.Close();
            //parse report id
            string tag = "Report ID:";
            int startIndex = cmdOutput.IndexOf(tag);
            if (startIndex != -1)
            {
                string reportID = cmdOutput.Substring(startIndex + tag.Length).Trim();
                setReportFile(DTReportFileTextBox, "qwebtest.result." + reportID);
            }
            else
            {
                MessageBox.Show("下载检测出错，没有生成报告内容！", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            setProgressBarStatus(DTStatusProgressBar, false);
            setButtonStatus(DTOpenReportFileButton, true);
            setButtonStatus(DTStartTestButton, true);
        }

        private void RequestHeaderCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (DTRequestHeaderCheckBox.Checked)
            {
                this.DTDownloadHeaderTextBox.Enabled = true;
            }
            else
            {
                this.DTDownloadHeaderTextBox.Enabled = false;
            }
        }

        private void FromSrcCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (DTFromSrcCheckBox.Checked)
            {
                this.DTFromFixedSrcCheckBox.Enabled = true;
            }
            else
            {
                this.DTFromFixedSrcCheckBox.Enabled = false;
                this.DTFixedDownloadSrcUrlTextBox.Enabled = false;
            }
        }

        private void FromFixedSrcCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (DTFromFixedSrcCheckBox.Checked)
            {
                this.DTFixedDownloadSrcUrlTextBox.Enabled = true;
            }
            else
            {
                this.DTFixedDownloadSrcUrlTextBox.Enabled = false;
            }
        }

        private void OpenDownloadReportButton_Click(object sender, EventArgs e)
        {
            string reportFile = this.DTReportFileTextBox.Text.Trim();
            Process.Start(this.appRoot + "\\" + reportFile + ".txt");
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (this.diagDownloadProcess != null)
            {
                try
                {
                    this.diagDownloadProcess.Kill();
                }
                catch (Exception) { }
            }
            if (this.diagUploadProcess != null)
            {
                try
                {
                    this.diagUploadProcess.Kill();
                }
                catch (Exception) { }
            }
            Application.ExitThread();
        }

        private void UPUploadFileCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (UPUploadFileCheckBox.Checked)
            {
                this.UPUploadFileTextBox.Enabled = true;
                this.UPBrowseFileButton.Enabled = true;
            }
            else
            {
                this.UPUploadFileTextBox.Enabled = false;
                this.UPBrowseFileButton.Enabled = false;
            }
        }

        private void UPFixedServerCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (UPFixedServerCheckBox.Checked)
            {
                this.UPUploadFixedServerTextBox.Enabled = true;
            }
            else
            {
                this.UPUploadFixedServerTextBox.Enabled = false;
            }
        }

        private void UPOpenReportFileButton_Click(object sender, EventArgs e)
        {
            string reportFile = this.UPReportFileTextBox.Text.Trim();
            Process.Start(this.appRoot + "\\" + reportFile + ".txt");
        }

        private void UPStartTestButton_Click(object sender, EventArgs e)
        {
            string accessKey = this.UPAccessKeyTextBox.Text.Trim();
            string secretKey = this.UPSecretKeyTextBox.Text.Trim();
            string bucket = this.UPBucketNameTextBox.Text.Trim();
            bool uploadFile = this.UPUploadFileCheckBox.Checked;
            bool setFixedServer = this.UPFixedServerCheckBox.Checked;
            bool chunkUpload = this.UPEnableChunkUploadCheckBox.Checked;
            int timeout = 5;
            if (UPTimeoutUpDown.Value > 0)
            {
                timeout = Convert.ToInt32(UPTimeoutUpDown.Value);
            }
            StringBuilder cmdArgs = new StringBuilder();
            cmdArgs.Append(" -upload ");
            if (!string.IsNullOrEmpty(accessKey) &&
                !string.IsNullOrEmpty(secretKey) &&
                !string.IsNullOrEmpty(bucket))
            {
                cmdArgs.Append(" -ak ").Append(accessKey);
                cmdArgs.Append(" -sk ").Append(secretKey);
                cmdArgs.Append(" -bucket ").Append(bucket);
            }

            if (uploadFile && !string.IsNullOrEmpty(this.UPUploadFileTextBox.Text.Trim()))
            {
                string localFile = this.UPUploadFileTextBox.Text.Trim();
                cmdArgs.Append(" -f \"").Append(localFile).Append("\"");
            }
            if (setFixedServer && !string.IsNullOrEmpty(this.UPUploadFixedServerTextBox.Text.Trim()))
            {
                string fixedServer = this.UPUploadFixedServerTextBox.Text.Trim();
                cmdArgs.Append(" -to ").Append(fixedServer);
            }
            if (chunkUpload)
            {
                cmdArgs.Append(" -r ");
            }
            cmdArgs.Append(" -timeout ").Append(timeout);

            setProgressBarStatus(UPStatusProgressBar, true);
            setButtonStatus(UPOpenReportFileButton, false);
            setButtonStatus(UPStartTestButton, false);
            this.UPReportFileTextBox.Text = "";
            Thread testThread = new Thread(new ParameterizedThreadStart(testUpload));
            testThread.Start(cmdArgs);
        }

        private void UPBrowseFileButton_Click(object sender, EventArgs e)
        {
            DialogResult dr = UPOpenFileDialog.ShowDialog(this);
            if (dr.Equals(DialogResult.OK))
            {
                this.UPUploadFileTextBox.Text = UPOpenFileDialog.FileName;
            }
        }


        private void testUpload(object cmdArgsObj)
        {
            string cmdArgs = cmdArgsObj.ToString();
            diagUploadProcess = new Process();
            diagUploadProcess.StartInfo.FileName = qwebtestExe;
            diagUploadProcess.StartInfo.Arguments = cmdArgs;
            diagUploadProcess.StartInfo.UseShellExecute = false;
            diagUploadProcess.StartInfo.RedirectStandardOutput = true;
            diagUploadProcess.StartInfo.RedirectStandardError = true;
            diagUploadProcess.StartInfo.CreateNoWindow = true;
            diagUploadProcess.Start();

            //let it run
            string cmdOutput = diagUploadProcess.StandardOutput.ReadToEnd();
            diagUploadProcess.Close();
            //parse report id
            string tag = "Report ID:";
            int startIndex = cmdOutput.IndexOf(tag);
            if (startIndex != -1)
            {
                string reportID = cmdOutput.Substring(startIndex + tag.Length).Trim();
                setReportFile(UPReportFileTextBox, "qwebtest.result." + reportID);
            }
            else
            {
                MessageBox.Show("上传检测出错，没有生成报告内容！", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            setProgressBarStatus(UPStatusProgressBar, false);
            setButtonStatus(UPOpenReportFileButton, true);
            setButtonStatus(UPStartTestButton, true);
        }
    }
}