namespace QWebTestTool
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.UploadTabControl = new System.Windows.Forms.TabControl();
            this.DownloadTabPage = new System.Windows.Forms.TabPage();
            this.DTStatusProgressBar = new System.Windows.Forms.ProgressBar();
            this.DTResultGroupBox = new System.Windows.Forms.GroupBox();
            this.DTOpenReportFileButton = new System.Windows.Forms.Button();
            this.DTReportFileTextBox = new System.Windows.Forms.TextBox();
            this.DTReportNameLabel = new System.Windows.Forms.Label();
            this.DTStartTestButton = new System.Windows.Forms.Button();
            this.DTExtentInfoGroupBox = new System.Windows.Forms.GroupBox();
            this.DTTimeoutUpDown = new System.Windows.Forms.NumericUpDown();
            this.DTTimeoutLabel = new System.Windows.Forms.Label();
            this.DTSaveFileCheckBox = new System.Windows.Forms.CheckBox();
            this.DTFixedDownloadSrcUrlTextBox = new System.Windows.Forms.TextBox();
            this.DTFromFixedSrcCheckBox = new System.Windows.Forms.CheckBox();
            this.DTFromSrcCheckBox = new System.Windows.Forms.CheckBox();
            this.DTDownloadHeaderTextBox = new System.Windows.Forms.TextBox();
            this.DTRequestHeaderCheckBox = new System.Windows.Forms.CheckBox();
            this.DTBasicInfoGroupBox = new System.Windows.Forms.GroupBox();
            this.DTDownloadUrlTextBox = new System.Windows.Forms.TextBox();
            this.DTErrorUrlLabel = new System.Windows.Forms.Label();
            this.UploadTabPage = new System.Windows.Forms.TabPage();
            this.UPStatusProgressBar = new System.Windows.Forms.ProgressBar();
            this.UPTestResultGroupBox = new System.Windows.Forms.GroupBox();
            this.UPOpenReportFileButton = new System.Windows.Forms.Button();
            this.UPReportFileTextBox = new System.Windows.Forms.TextBox();
            this.UPReportNameLabel = new System.Windows.Forms.Label();
            this.UPStartTestButton = new System.Windows.Forms.Button();
            this.UPExtentInfoGroupBox = new System.Windows.Forms.GroupBox();
            this.UPTimeoutUpDown = new System.Windows.Forms.NumericUpDown();
            this.UPTestTimeoutLabel = new System.Windows.Forms.Label();
            this.UPEnableChunkUploadCheckBox = new System.Windows.Forms.CheckBox();
            this.UPUploadFixedServerTextBox = new System.Windows.Forms.TextBox();
            this.UPFixedServerCheckBox = new System.Windows.Forms.CheckBox();
            this.UPBrowseFileButton = new System.Windows.Forms.Button();
            this.UPUploadFileTextBox = new System.Windows.Forms.TextBox();
            this.UPUploadFileCheckBox = new System.Windows.Forms.CheckBox();
            this.UPBasicInfoGroupBox = new System.Windows.Forms.GroupBox();
            this.UPBucketNameTextBox = new System.Windows.Forms.TextBox();
            this.UPBucketNameLabel = new System.Windows.Forms.Label();
            this.UPAccessKeyTextBox = new System.Windows.Forms.TextBox();
            this.UPAccessKeyLabel = new System.Windows.Forms.Label();
            this.UPSecretKeyTextBox = new System.Windows.Forms.TextBox();
            this.UPSecretKeyLabel = new System.Windows.Forms.Label();
            this.UPOpenFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.UploadTabControl.SuspendLayout();
            this.DownloadTabPage.SuspendLayout();
            this.DTResultGroupBox.SuspendLayout();
            this.DTExtentInfoGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DTTimeoutUpDown)).BeginInit();
            this.DTBasicInfoGroupBox.SuspendLayout();
            this.UploadTabPage.SuspendLayout();
            this.UPTestResultGroupBox.SuspendLayout();
            this.UPExtentInfoGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.UPTimeoutUpDown)).BeginInit();
            this.UPBasicInfoGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // UploadTabControl
            // 
            this.UploadTabControl.Controls.Add(this.DownloadTabPage);
            this.UploadTabControl.Controls.Add(this.UploadTabPage);
            this.UploadTabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.UploadTabControl.Location = new System.Drawing.Point(0, 0);
            this.UploadTabControl.Name = "UploadTabControl";
            this.UploadTabControl.SelectedIndex = 0;
            this.UploadTabControl.Size = new System.Drawing.Size(578, 351);
            this.UploadTabControl.TabIndex = 0;
            // 
            // DownloadTabPage
            // 
            this.DownloadTabPage.Controls.Add(this.DTStatusProgressBar);
            this.DownloadTabPage.Controls.Add(this.DTResultGroupBox);
            this.DownloadTabPage.Controls.Add(this.DTStartTestButton);
            this.DownloadTabPage.Controls.Add(this.DTExtentInfoGroupBox);
            this.DownloadTabPage.Controls.Add(this.DTBasicInfoGroupBox);
            this.DownloadTabPage.Location = new System.Drawing.Point(4, 22);
            this.DownloadTabPage.Name = "DownloadTabPage";
            this.DownloadTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.DownloadTabPage.Size = new System.Drawing.Size(570, 325);
            this.DownloadTabPage.TabIndex = 0;
            this.DownloadTabPage.Text = "下载测试";
            this.DownloadTabPage.UseVisualStyleBackColor = true;
            // 
            // DTStatusProgressBar
            // 
            this.DTStatusProgressBar.Location = new System.Drawing.Point(465, 255);
            this.DTStatusProgressBar.Name = "DTStatusProgressBar";
            this.DTStatusProgressBar.Size = new System.Drawing.Size(92, 23);
            this.DTStatusProgressBar.TabIndex = 16;
            // 
            // DTResultGroupBox
            // 
            this.DTResultGroupBox.Controls.Add(this.DTOpenReportFileButton);
            this.DTResultGroupBox.Controls.Add(this.DTReportFileTextBox);
            this.DTResultGroupBox.Controls.Add(this.DTReportNameLabel);
            this.DTResultGroupBox.Location = new System.Drawing.Point(8, 247);
            this.DTResultGroupBox.Name = "DTResultGroupBox";
            this.DTResultGroupBox.Size = new System.Drawing.Size(451, 69);
            this.DTResultGroupBox.TabIndex = 15;
            this.DTResultGroupBox.TabStop = false;
            this.DTResultGroupBox.Text = "测试结果";
            // 
            // DTOpenReportFileButton
            // 
            this.DTOpenReportFileButton.Location = new System.Drawing.Point(370, 29);
            this.DTOpenReportFileButton.Name = "DTOpenReportFileButton";
            this.DTOpenReportFileButton.Size = new System.Drawing.Size(75, 23);
            this.DTOpenReportFileButton.TabIndex = 15;
            this.DTOpenReportFileButton.Text = "打开报告";
            this.DTOpenReportFileButton.UseVisualStyleBackColor = true;
            this.DTOpenReportFileButton.Click += new System.EventHandler(this.OpenDownloadReportButton_Click);
            // 
            // DTReportFileTextBox
            // 
            this.DTReportFileTextBox.Location = new System.Drawing.Point(71, 30);
            this.DTReportFileTextBox.Name = "DTReportFileTextBox";
            this.DTReportFileTextBox.ReadOnly = true;
            this.DTReportFileTextBox.Size = new System.Drawing.Size(293, 21);
            this.DTReportFileTextBox.TabIndex = 14;
            // 
            // DTReportNameLabel
            // 
            this.DTReportNameLabel.AutoSize = true;
            this.DTReportNameLabel.Location = new System.Drawing.Point(12, 34);
            this.DTReportNameLabel.Name = "DTReportNameLabel";
            this.DTReportNameLabel.Size = new System.Drawing.Size(53, 12);
            this.DTReportNameLabel.TabIndex = 13;
            this.DTReportNameLabel.Text = "报告名称";
            // 
            // DTStartTestButton
            // 
            this.DTStartTestButton.Location = new System.Drawing.Point(465, 284);
            this.DTStartTestButton.Name = "DTStartTestButton";
            this.DTStartTestButton.Size = new System.Drawing.Size(92, 31);
            this.DTStartTestButton.TabIndex = 12;
            this.DTStartTestButton.Text = "测试下载";
            this.DTStartTestButton.UseVisualStyleBackColor = true;
            this.DTStartTestButton.Click += new System.EventHandler(this.TestDownloadButton_Click);
            // 
            // DTExtentInfoGroupBox
            // 
            this.DTExtentInfoGroupBox.Controls.Add(this.DTTimeoutUpDown);
            this.DTExtentInfoGroupBox.Controls.Add(this.DTTimeoutLabel);
            this.DTExtentInfoGroupBox.Controls.Add(this.DTSaveFileCheckBox);
            this.DTExtentInfoGroupBox.Controls.Add(this.DTFixedDownloadSrcUrlTextBox);
            this.DTExtentInfoGroupBox.Controls.Add(this.DTFromFixedSrcCheckBox);
            this.DTExtentInfoGroupBox.Controls.Add(this.DTFromSrcCheckBox);
            this.DTExtentInfoGroupBox.Controls.Add(this.DTDownloadHeaderTextBox);
            this.DTExtentInfoGroupBox.Controls.Add(this.DTRequestHeaderCheckBox);
            this.DTExtentInfoGroupBox.Location = new System.Drawing.Point(8, 81);
            this.DTExtentInfoGroupBox.Name = "DTExtentInfoGroupBox";
            this.DTExtentInfoGroupBox.Size = new System.Drawing.Size(549, 160);
            this.DTExtentInfoGroupBox.TabIndex = 11;
            this.DTExtentInfoGroupBox.TabStop = false;
            this.DTExtentInfoGroupBox.Text = "扩展信息";
            // 
            // DTTimeoutUpDown
            // 
            this.DTTimeoutUpDown.Location = new System.Drawing.Point(197, 125);
            this.DTTimeoutUpDown.Name = "DTTimeoutUpDown";
            this.DTTimeoutUpDown.Size = new System.Drawing.Size(73, 21);
            this.DTTimeoutUpDown.TabIndex = 16;
            this.DTTimeoutUpDown.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // DTTimeoutLabel
            // 
            this.DTTimeoutLabel.AutoSize = true;
            this.DTTimeoutLabel.Location = new System.Drawing.Point(9, 130);
            this.DTTimeoutLabel.Name = "DTTimeoutLabel";
            this.DTTimeoutLabel.Size = new System.Drawing.Size(185, 12);
            this.DTTimeoutLabel.TabIndex = 15;
            this.DTTimeoutLabel.Text = "测试程序最大允许运行时长（分）";
            // 
            // DTSaveFileCheckBox
            // 
            this.DTSaveFileCheckBox.AutoSize = true;
            this.DTSaveFileCheckBox.Location = new System.Drawing.Point(9, 30);
            this.DTSaveFileCheckBox.Name = "DTSaveFileCheckBox";
            this.DTSaveFileCheckBox.Size = new System.Drawing.Size(72, 16);
            this.DTSaveFileCheckBox.TabIndex = 13;
            this.DTSaveFileCheckBox.Text = "保存下载";
            this.DTSaveFileCheckBox.UseVisualStyleBackColor = true;
            // 
            // DTFixedDownloadSrcUrlTextBox
            // 
            this.DTFixedDownloadSrcUrlTextBox.Location = new System.Drawing.Point(119, 94);
            this.DTFixedDownloadSrcUrlTextBox.Name = "DTFixedDownloadSrcUrlTextBox";
            this.DTFixedDownloadSrcUrlTextBox.Size = new System.Drawing.Size(414, 21);
            this.DTFixedDownloadSrcUrlTextBox.TabIndex = 12;
            // 
            // DTFromFixedSrcCheckBox
            // 
            this.DTFromFixedSrcCheckBox.AutoSize = true;
            this.DTFromFixedSrcCheckBox.Location = new System.Drawing.Point(9, 96);
            this.DTFromFixedSrcCheckBox.Name = "DTFromFixedSrcCheckBox";
            this.DTFromFixedSrcCheckBox.Size = new System.Drawing.Size(108, 16);
            this.DTFromFixedSrcCheckBox.TabIndex = 11;
            this.DTFromFixedSrcCheckBox.Text = "从指定源站下载";
            this.DTFromFixedSrcCheckBox.UseVisualStyleBackColor = true;
            this.DTFromFixedSrcCheckBox.CheckedChanged += new System.EventHandler(this.FromFixedSrcCheckBox_CheckedChanged);
            // 
            // DTFromSrcCheckBox
            // 
            this.DTFromSrcCheckBox.AutoSize = true;
            this.DTFromSrcCheckBox.Location = new System.Drawing.Point(9, 62);
            this.DTFromSrcCheckBox.Name = "DTFromSrcCheckBox";
            this.DTFromSrcCheckBox.Size = new System.Drawing.Size(84, 16);
            this.DTFromSrcCheckBox.TabIndex = 10;
            this.DTFromSrcCheckBox.Text = "从源站下载";
            this.DTFromSrcCheckBox.UseVisualStyleBackColor = true;
            this.DTFromSrcCheckBox.CheckedChanged += new System.EventHandler(this.FromSrcCheckBox_CheckedChanged);
            // 
            // DTDownloadHeaderTextBox
            // 
            this.DTDownloadHeaderTextBox.Location = new System.Drawing.Point(194, 28);
            this.DTDownloadHeaderTextBox.Name = "DTDownloadHeaderTextBox";
            this.DTDownloadHeaderTextBox.Size = new System.Drawing.Size(339, 21);
            this.DTDownloadHeaderTextBox.TabIndex = 9;
            // 
            // DTRequestHeaderCheckBox
            // 
            this.DTRequestHeaderCheckBox.AutoSize = true;
            this.DTRequestHeaderCheckBox.Location = new System.Drawing.Point(104, 30);
            this.DTRequestHeaderCheckBox.Name = "DTRequestHeaderCheckBox";
            this.DTRequestHeaderCheckBox.Size = new System.Drawing.Size(84, 16);
            this.DTRequestHeaderCheckBox.TabIndex = 8;
            this.DTRequestHeaderCheckBox.Text = "自定义头部";
            this.DTRequestHeaderCheckBox.UseVisualStyleBackColor = true;
            this.DTRequestHeaderCheckBox.CheckedChanged += new System.EventHandler(this.RequestHeaderCheckBox_CheckedChanged);
            // 
            // DTBasicInfoGroupBox
            // 
            this.DTBasicInfoGroupBox.Controls.Add(this.DTDownloadUrlTextBox);
            this.DTBasicInfoGroupBox.Controls.Add(this.DTErrorUrlLabel);
            this.DTBasicInfoGroupBox.Location = new System.Drawing.Point(8, 9);
            this.DTBasicInfoGroupBox.Name = "DTBasicInfoGroupBox";
            this.DTBasicInfoGroupBox.Size = new System.Drawing.Size(549, 67);
            this.DTBasicInfoGroupBox.TabIndex = 10;
            this.DTBasicInfoGroupBox.TabStop = false;
            this.DTBasicInfoGroupBox.Text = "基本信息";
            // 
            // DTDownloadUrlTextBox
            // 
            this.DTDownloadUrlTextBox.Location = new System.Drawing.Point(119, 28);
            this.DTDownloadUrlTextBox.Name = "DTDownloadUrlTextBox";
            this.DTDownloadUrlTextBox.Size = new System.Drawing.Size(414, 21);
            this.DTDownloadUrlTextBox.TabIndex = 0;
            // 
            // DTErrorUrlLabel
            // 
            this.DTErrorUrlLabel.AutoSize = true;
            this.DTErrorUrlLabel.Location = new System.Drawing.Point(9, 31);
            this.DTErrorUrlLabel.Name = "DTErrorUrlLabel";
            this.DTErrorUrlLabel.Size = new System.Drawing.Size(53, 12);
            this.DTErrorUrlLabel.TabIndex = 1;
            this.DTErrorUrlLabel.Text = "问题链接";
            // 
            // UploadTabPage
            // 
            this.UploadTabPage.Controls.Add(this.UPStatusProgressBar);
            this.UploadTabPage.Controls.Add(this.UPTestResultGroupBox);
            this.UploadTabPage.Controls.Add(this.UPStartTestButton);
            this.UploadTabPage.Controls.Add(this.UPExtentInfoGroupBox);
            this.UploadTabPage.Controls.Add(this.UPBasicInfoGroupBox);
            this.UploadTabPage.Location = new System.Drawing.Point(4, 22);
            this.UploadTabPage.Name = "UploadTabPage";
            this.UploadTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.UploadTabPage.Size = new System.Drawing.Size(570, 325);
            this.UploadTabPage.TabIndex = 1;
            this.UploadTabPage.Text = "上传测试";
            this.UploadTabPage.UseVisualStyleBackColor = true;
            // 
            // UPStatusProgressBar
            // 
            this.UPStatusProgressBar.Location = new System.Drawing.Point(470, 259);
            this.UPStatusProgressBar.Name = "UPStatusProgressBar";
            this.UPStatusProgressBar.Size = new System.Drawing.Size(92, 23);
            this.UPStatusProgressBar.TabIndex = 19;
            // 
            // UPTestResultGroupBox
            // 
            this.UPTestResultGroupBox.Controls.Add(this.UPOpenReportFileButton);
            this.UPTestResultGroupBox.Controls.Add(this.UPReportFileTextBox);
            this.UPTestResultGroupBox.Controls.Add(this.UPReportNameLabel);
            this.UPTestResultGroupBox.Location = new System.Drawing.Point(9, 251);
            this.UPTestResultGroupBox.Name = "UPTestResultGroupBox";
            this.UPTestResultGroupBox.Size = new System.Drawing.Size(455, 69);
            this.UPTestResultGroupBox.TabIndex = 18;
            this.UPTestResultGroupBox.TabStop = false;
            this.UPTestResultGroupBox.Text = "测试结果";
            // 
            // UPOpenReportFileButton
            // 
            this.UPOpenReportFileButton.Location = new System.Drawing.Point(374, 29);
            this.UPOpenReportFileButton.Name = "UPOpenReportFileButton";
            this.UPOpenReportFileButton.Size = new System.Drawing.Size(75, 23);
            this.UPOpenReportFileButton.TabIndex = 15;
            this.UPOpenReportFileButton.Text = "打开报告";
            this.UPOpenReportFileButton.UseVisualStyleBackColor = true;
            this.UPOpenReportFileButton.Click += new System.EventHandler(this.UPOpenReportFileButton_Click);
            // 
            // UPReportFileTextBox
            // 
            this.UPReportFileTextBox.Location = new System.Drawing.Point(71, 30);
            this.UPReportFileTextBox.Name = "UPReportFileTextBox";
            this.UPReportFileTextBox.ReadOnly = true;
            this.UPReportFileTextBox.Size = new System.Drawing.Size(297, 21);
            this.UPReportFileTextBox.TabIndex = 14;
            // 
            // UPReportNameLabel
            // 
            this.UPReportNameLabel.AutoSize = true;
            this.UPReportNameLabel.Location = new System.Drawing.Point(12, 34);
            this.UPReportNameLabel.Name = "UPReportNameLabel";
            this.UPReportNameLabel.Size = new System.Drawing.Size(53, 12);
            this.UPReportNameLabel.TabIndex = 13;
            this.UPReportNameLabel.Text = "报告名称";
            // 
            // UPStartTestButton
            // 
            this.UPStartTestButton.Location = new System.Drawing.Point(470, 288);
            this.UPStartTestButton.Name = "UPStartTestButton";
            this.UPStartTestButton.Size = new System.Drawing.Size(92, 31);
            this.UPStartTestButton.TabIndex = 17;
            this.UPStartTestButton.Text = "测试上传";
            this.UPStartTestButton.UseVisualStyleBackColor = true;
            this.UPStartTestButton.Click += new System.EventHandler(this.UPStartTestButton_Click);
            // 
            // UPExtentInfoGroupBox
            // 
            this.UPExtentInfoGroupBox.Controls.Add(this.UPTimeoutUpDown);
            this.UPExtentInfoGroupBox.Controls.Add(this.UPTestTimeoutLabel);
            this.UPExtentInfoGroupBox.Controls.Add(this.UPEnableChunkUploadCheckBox);
            this.UPExtentInfoGroupBox.Controls.Add(this.UPUploadFixedServerTextBox);
            this.UPExtentInfoGroupBox.Controls.Add(this.UPFixedServerCheckBox);
            this.UPExtentInfoGroupBox.Controls.Add(this.UPBrowseFileButton);
            this.UPExtentInfoGroupBox.Controls.Add(this.UPUploadFileTextBox);
            this.UPExtentInfoGroupBox.Controls.Add(this.UPUploadFileCheckBox);
            this.UPExtentInfoGroupBox.Location = new System.Drawing.Point(9, 117);
            this.UPExtentInfoGroupBox.Name = "UPExtentInfoGroupBox";
            this.UPExtentInfoGroupBox.Size = new System.Drawing.Size(549, 128);
            this.UPExtentInfoGroupBox.TabIndex = 12;
            this.UPExtentInfoGroupBox.TabStop = false;
            this.UPExtentInfoGroupBox.Text = "扩展信息";
            // 
            // UPTimeoutUpDown
            // 
            this.UPTimeoutUpDown.Location = new System.Drawing.Point(195, 97);
            this.UPTimeoutUpDown.Name = "UPTimeoutUpDown";
            this.UPTimeoutUpDown.Size = new System.Drawing.Size(73, 21);
            this.UPTimeoutUpDown.TabIndex = 18;
            this.UPTimeoutUpDown.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // UPTestTimeoutLabel
            // 
            this.UPTestTimeoutLabel.AutoSize = true;
            this.UPTestTimeoutLabel.Location = new System.Drawing.Point(7, 102);
            this.UPTestTimeoutLabel.Name = "UPTestTimeoutLabel";
            this.UPTestTimeoutLabel.Size = new System.Drawing.Size(185, 12);
            this.UPTestTimeoutLabel.TabIndex = 17;
            this.UPTestTimeoutLabel.Text = "测试程序最大允许运行时长（分）";
            // 
            // UPEnableChunkUploadCheckBox
            // 
            this.UPEnableChunkUploadCheckBox.AutoSize = true;
            this.UPEnableChunkUploadCheckBox.Location = new System.Drawing.Point(9, 75);
            this.UPEnableChunkUploadCheckBox.Name = "UPEnableChunkUploadCheckBox";
            this.UPEnableChunkUploadCheckBox.Size = new System.Drawing.Size(96, 16);
            this.UPEnableChunkUploadCheckBox.TabIndex = 9;
            this.UPEnableChunkUploadCheckBox.Text = "启动分片上传";
            this.UPEnableChunkUploadCheckBox.UseVisualStyleBackColor = true;
            // 
            // UPUploadFixedServerTextBox
            // 
            this.UPUploadFixedServerTextBox.Location = new System.Drawing.Point(107, 48);
            this.UPUploadFixedServerTextBox.Name = "UPUploadFixedServerTextBox";
            this.UPUploadFixedServerTextBox.Size = new System.Drawing.Size(354, 21);
            this.UPUploadFixedServerTextBox.TabIndex = 8;
            // 
            // UPFixedServerCheckBox
            // 
            this.UPFixedServerCheckBox.AutoSize = true;
            this.UPFixedServerCheckBox.Location = new System.Drawing.Point(9, 50);
            this.UPFixedServerCheckBox.Name = "UPFixedServerCheckBox";
            this.UPFixedServerCheckBox.Size = new System.Drawing.Size(84, 16);
            this.UPFixedServerCheckBox.TabIndex = 7;
            this.UPFixedServerCheckBox.Text = "指定服务器";
            this.UPFixedServerCheckBox.UseVisualStyleBackColor = true;
            this.UPFixedServerCheckBox.CheckedChanged += new System.EventHandler(this.UPFixedServerCheckBox_CheckedChanged);
            // 
            // UPBrowseFileButton
            // 
            this.UPBrowseFileButton.Location = new System.Drawing.Point(468, 18);
            this.UPBrowseFileButton.Name = "UPBrowseFileButton";
            this.UPBrowseFileButton.Size = new System.Drawing.Size(75, 23);
            this.UPBrowseFileButton.TabIndex = 6;
            this.UPBrowseFileButton.Text = "浏览 ...";
            this.UPBrowseFileButton.UseVisualStyleBackColor = true;
            this.UPBrowseFileButton.Click += new System.EventHandler(this.UPBrowseFileButton_Click);
            // 
            // UPUploadFileTextBox
            // 
            this.UPUploadFileTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.UPUploadFileTextBox.Location = new System.Drawing.Point(107, 20);
            this.UPUploadFileTextBox.Name = "UPUploadFileTextBox";
            this.UPUploadFileTextBox.ReadOnly = true;
            this.UPUploadFileTextBox.Size = new System.Drawing.Size(354, 21);
            this.UPUploadFileTextBox.TabIndex = 5;
            // 
            // UPUploadFileCheckBox
            // 
            this.UPUploadFileCheckBox.AutoSize = true;
            this.UPUploadFileCheckBox.Location = new System.Drawing.Point(9, 25);
            this.UPUploadFileCheckBox.Name = "UPUploadFileCheckBox";
            this.UPUploadFileCheckBox.Size = new System.Drawing.Size(72, 16);
            this.UPUploadFileCheckBox.TabIndex = 0;
            this.UPUploadFileCheckBox.Text = "上传文件";
            this.UPUploadFileCheckBox.UseVisualStyleBackColor = true;
            this.UPUploadFileCheckBox.CheckedChanged += new System.EventHandler(this.UPUploadFileCheckBox_CheckedChanged);
            // 
            // UPBasicInfoGroupBox
            // 
            this.UPBasicInfoGroupBox.Controls.Add(this.UPBucketNameTextBox);
            this.UPBasicInfoGroupBox.Controls.Add(this.UPBucketNameLabel);
            this.UPBasicInfoGroupBox.Controls.Add(this.UPAccessKeyTextBox);
            this.UPBasicInfoGroupBox.Controls.Add(this.UPAccessKeyLabel);
            this.UPBasicInfoGroupBox.Controls.Add(this.UPSecretKeyTextBox);
            this.UPBasicInfoGroupBox.Controls.Add(this.UPSecretKeyLabel);
            this.UPBasicInfoGroupBox.Location = new System.Drawing.Point(9, 10);
            this.UPBasicInfoGroupBox.Name = "UPBasicInfoGroupBox";
            this.UPBasicInfoGroupBox.Size = new System.Drawing.Size(549, 101);
            this.UPBasicInfoGroupBox.TabIndex = 11;
            this.UPBasicInfoGroupBox.TabStop = false;
            this.UPBasicInfoGroupBox.Text = "基本信息";
            // 
            // UPBucketNameTextBox
            // 
            this.UPBucketNameTextBox.Location = new System.Drawing.Point(108, 72);
            this.UPBucketNameTextBox.Name = "UPBucketNameTextBox";
            this.UPBucketNameTextBox.Size = new System.Drawing.Size(414, 21);
            this.UPBucketNameTextBox.TabIndex = 4;
            // 
            // UPBucketNameLabel
            // 
            this.UPBucketNameLabel.AutoSize = true;
            this.UPBucketNameLabel.Location = new System.Drawing.Point(15, 75);
            this.UPBucketNameLabel.Name = "UPBucketNameLabel";
            this.UPBucketNameLabel.Size = new System.Drawing.Size(53, 12);
            this.UPBucketNameLabel.TabIndex = 5;
            this.UPBucketNameLabel.Text = "空间名称";
            // 
            // UPAccessKeyTextBox
            // 
            this.UPAccessKeyTextBox.Location = new System.Drawing.Point(108, 20);
            this.UPAccessKeyTextBox.Name = "UPAccessKeyTextBox";
            this.UPAccessKeyTextBox.Size = new System.Drawing.Size(414, 21);
            this.UPAccessKeyTextBox.TabIndex = 2;
            // 
            // UPAccessKeyLabel
            // 
            this.UPAccessKeyLabel.AutoSize = true;
            this.UPAccessKeyLabel.Location = new System.Drawing.Point(15, 23);
            this.UPAccessKeyLabel.Name = "UPAccessKeyLabel";
            this.UPAccessKeyLabel.Size = new System.Drawing.Size(65, 12);
            this.UPAccessKeyLabel.TabIndex = 3;
            this.UPAccessKeyLabel.Text = "Access Key";
            // 
            // UPSecretKeyTextBox
            // 
            this.UPSecretKeyTextBox.Location = new System.Drawing.Point(108, 45);
            this.UPSecretKeyTextBox.Name = "UPSecretKeyTextBox";
            this.UPSecretKeyTextBox.Size = new System.Drawing.Size(414, 21);
            this.UPSecretKeyTextBox.TabIndex = 0;
            // 
            // UPSecretKeyLabel
            // 
            this.UPSecretKeyLabel.AutoSize = true;
            this.UPSecretKeyLabel.Location = new System.Drawing.Point(15, 48);
            this.UPSecretKeyLabel.Name = "UPSecretKeyLabel";
            this.UPSecretKeyLabel.Size = new System.Drawing.Size(65, 12);
            this.UPSecretKeyLabel.TabIndex = 1;
            this.UPSecretKeyLabel.Text = "Secret Key";
            // 
            // UPOpenFileDialog
            // 
            this.UPOpenFileDialog.Title = "选择上传文件";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(578, 351);
            this.Controls.Add(this.UploadTabControl);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "七牛云存储本地网络检测工具";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.UploadTabControl.ResumeLayout(false);
            this.DownloadTabPage.ResumeLayout(false);
            this.DTResultGroupBox.ResumeLayout(false);
            this.DTResultGroupBox.PerformLayout();
            this.DTExtentInfoGroupBox.ResumeLayout(false);
            this.DTExtentInfoGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DTTimeoutUpDown)).EndInit();
            this.DTBasicInfoGroupBox.ResumeLayout(false);
            this.DTBasicInfoGroupBox.PerformLayout();
            this.UploadTabPage.ResumeLayout(false);
            this.UPTestResultGroupBox.ResumeLayout(false);
            this.UPTestResultGroupBox.PerformLayout();
            this.UPExtentInfoGroupBox.ResumeLayout(false);
            this.UPExtentInfoGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.UPTimeoutUpDown)).EndInit();
            this.UPBasicInfoGroupBox.ResumeLayout(false);
            this.UPBasicInfoGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl UploadTabControl;
        private System.Windows.Forms.TabPage DownloadTabPage;
        private System.Windows.Forms.TabPage UploadTabPage;
        private System.Windows.Forms.Label DTErrorUrlLabel;
        private System.Windows.Forms.TextBox DTDownloadUrlTextBox;
        private System.Windows.Forms.CheckBox DTRequestHeaderCheckBox;
        private System.Windows.Forms.TextBox DTDownloadHeaderTextBox;
        private System.Windows.Forms.GroupBox DTBasicInfoGroupBox;
        private System.Windows.Forms.GroupBox DTExtentInfoGroupBox;
        private System.Windows.Forms.GroupBox DTResultGroupBox;
        private System.Windows.Forms.TextBox DTReportFileTextBox;
        private System.Windows.Forms.Label DTReportNameLabel;
        private System.Windows.Forms.Button DTStartTestButton;
        private System.Windows.Forms.TextBox DTFixedDownloadSrcUrlTextBox;
        private System.Windows.Forms.CheckBox DTFromFixedSrcCheckBox;
        private System.Windows.Forms.CheckBox DTFromSrcCheckBox;
        private System.Windows.Forms.Button DTOpenReportFileButton;
        private System.Windows.Forms.ProgressBar DTStatusProgressBar;
        private System.Windows.Forms.CheckBox DTSaveFileCheckBox;
        private System.Windows.Forms.GroupBox UPBasicInfoGroupBox;
        private System.Windows.Forms.TextBox UPBucketNameTextBox;
        private System.Windows.Forms.Label UPBucketNameLabel;
        private System.Windows.Forms.TextBox UPAccessKeyTextBox;
        private System.Windows.Forms.Label UPAccessKeyLabel;
        private System.Windows.Forms.TextBox UPSecretKeyTextBox;
        private System.Windows.Forms.Label UPSecretKeyLabel;
        private System.Windows.Forms.GroupBox UPExtentInfoGroupBox;
        private System.Windows.Forms.ProgressBar UPStatusProgressBar;
        private System.Windows.Forms.GroupBox UPTestResultGroupBox;
        private System.Windows.Forms.Button UPOpenReportFileButton;
        private System.Windows.Forms.TextBox UPReportFileTextBox;
        private System.Windows.Forms.Label UPReportNameLabel;
        private System.Windows.Forms.Button UPStartTestButton;
        private System.Windows.Forms.CheckBox UPEnableChunkUploadCheckBox;
        private System.Windows.Forms.TextBox UPUploadFixedServerTextBox;
        private System.Windows.Forms.CheckBox UPFixedServerCheckBox;
        private System.Windows.Forms.Button UPBrowseFileButton;
        private System.Windows.Forms.TextBox UPUploadFileTextBox;
        private System.Windows.Forms.CheckBox UPUploadFileCheckBox;
        private System.Windows.Forms.OpenFileDialog UPOpenFileDialog;
        private System.Windows.Forms.Label DTTimeoutLabel;
        private System.Windows.Forms.NumericUpDown DTTimeoutUpDown;
        private System.Windows.Forms.NumericUpDown UPTimeoutUpDown;
        private System.Windows.Forms.Label UPTestTimeoutLabel;
    }
}

