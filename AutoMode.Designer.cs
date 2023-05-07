namespace FiatShamirAuth
{
    partial class autoMode
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
            this.btnDoAuth = new System.Windows.Forms.Button();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.menuFile = new System.Windows.Forms.ToolStripMenuItem();
            this.menuFormLogFile = new System.Windows.Forms.ToolStripMenuItem();
            this.menuLoadLogFile = new System.Windows.Forms.ToolStripMenuItem();
            this.menuClearLb = new System.Windows.Forms.ToolStripMenuItem();
            this.menuBack = new System.Windows.Forms.ToolStripMenuItem();
            this.menuInfo = new System.Windows.Forms.ToolStripMenuItem();
            this.mainPanel = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.labelLength = new System.Windows.Forms.Label();
            this.numUpDownLenght = new System.Windows.Forms.NumericUpDown();
            this.labelRoundCount = new System.Windows.Forms.Label();
            this.numUpDownRound = new System.Windows.Forms.NumericUpDown();
            this.contextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ctxMenuClearLb = new System.Windows.Forms.ToolStripMenuItem();
            this.panelLb = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.lbLog = new System.Windows.Forms.ListBox();
            this.panelBlank = new System.Windows.Forms.Panel();
            this.tbElapsedTime = new System.Windows.Forms.TextBox();
            this.labelStatus = new System.Windows.Forms.Label();
            this.menuClearFields = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip.SuspendLayout();
            this.mainPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDownLenght)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDownRound)).BeginInit();
            this.contextMenu.SuspendLayout();
            this.panelLb.SuspendLayout();
            this.panelBlank.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnDoAuth
            // 
            this.btnDoAuth.Location = new System.Drawing.Point(22, 29);
            this.btnDoAuth.Name = "btnDoAuth";
            this.btnDoAuth.Size = new System.Drawing.Size(213, 44);
            this.btnDoAuth.TabIndex = 1;
            this.btnDoAuth.Text = "Начать процесс аутентификации";
            this.btnDoAuth.UseVisualStyleBackColor = true;
            this.btnDoAuth.Click += new System.EventHandler(this.btnDoAuth_Click);
            // 
            // menuStrip
            // 
            this.menuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuFile,
            this.menuInfo});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(1054, 28);
            this.menuStrip.TabIndex = 2;
            this.menuStrip.Text = "menu";
            // 
            // menuFile
            // 
            this.menuFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuFormLogFile,
            this.menuLoadLogFile,
            this.menuClearLb,
            this.menuClearFields,
            this.menuBack});
            this.menuFile.Name = "menuFile";
            this.menuFile.Size = new System.Drawing.Size(59, 24);
            this.menuFile.Text = "Файл";
            // 
            // menuFormLogFile
            // 
            this.menuFormLogFile.Name = "menuFormLogFile";
            this.menuFormLogFile.Size = new System.Drawing.Size(322, 26);
            this.menuFormLogFile.Text = "Создать файл журнала";
            this.menuFormLogFile.Click += new System.EventHandler(this.menuFormLogFile_Click);
            // 
            // menuLoadLogFile
            // 
            this.menuLoadLogFile.Name = "menuLoadLogFile";
            this.menuLoadLogFile.Size = new System.Drawing.Size(322, 26);
            this.menuLoadLogFile.Text = "Загрузить файл журнала";
            this.menuLoadLogFile.Click += new System.EventHandler(this.menuLoadLogFile_Click);
            // 
            // menuClearLb
            // 
            this.menuClearLb.Name = "menuClearLb";
            this.menuClearLb.Size = new System.Drawing.Size(322, 26);
            this.menuClearLb.Text = "Очистить поле журнала событий";
            this.menuClearLb.Click += new System.EventHandler(this.menuClearLb_Click);
            // 
            // menuBack
            // 
            this.menuBack.Name = "menuBack";
            this.menuBack.Size = new System.Drawing.Size(322, 26);
            this.menuBack.Text = "Вернуться к главному окну";
            this.menuBack.Click += new System.EventHandler(this.menuBack_Click);
            // 
            // menuInfo
            // 
            this.menuInfo.Name = "menuInfo";
            this.menuInfo.Size = new System.Drawing.Size(81, 26);
            this.menuInfo.Text = "Справка";
            this.menuInfo.Click += new System.EventHandler(this.menuInfo_Click);
            // 
            // mainPanel
            // 
            this.mainPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.mainPanel.Controls.Add(this.label2);
            this.mainPanel.Controls.Add(this.labelLength);
            this.mainPanel.Controls.Add(this.numUpDownLenght);
            this.mainPanel.Controls.Add(this.labelRoundCount);
            this.mainPanel.Controls.Add(this.numUpDownRound);
            this.mainPanel.Controls.Add(this.btnDoAuth);
            this.mainPanel.Location = new System.Drawing.Point(12, 38);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(641, 86);
            this.mainPanel.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 7);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(158, 16);
            this.label2.TabIndex = 7;
            this.label2.Text = "Нажмите чтобы начать";
            // 
            // labelLength
            // 
            this.labelLength.AutoSize = true;
            this.labelLength.Location = new System.Drawing.Point(425, 10);
            this.labelLength.Name = "labelLength";
            this.labelLength.Size = new System.Drawing.Size(178, 32);
            this.labelLength.TabIndex = 7;
            this.labelLength.Text = "Порядок \r\nинициализирующих чисел";
            // 
            // numUpDownLenght
            // 
            this.numUpDownLenght.Location = new System.Drawing.Point(428, 48);
            this.numUpDownLenght.Name = "numUpDownLenght";
            this.numUpDownLenght.Size = new System.Drawing.Size(175, 22);
            this.numUpDownLenght.TabIndex = 6;
            // 
            // labelRoundCount
            // 
            this.labelRoundCount.AutoSize = true;
            this.labelRoundCount.Location = new System.Drawing.Point(254, 10);
            this.labelRoundCount.Name = "labelRoundCount";
            this.labelRoundCount.Size = new System.Drawing.Size(136, 32);
            this.labelRoundCount.TabIndex = 5;
            this.labelRoundCount.Text = "Количество \r\nраундов протокола";
            // 
            // numUpDownRound
            // 
            this.numUpDownRound.Location = new System.Drawing.Point(257, 48);
            this.numUpDownRound.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.numUpDownRound.Name = "numUpDownRound";
            this.numUpDownRound.Size = new System.Drawing.Size(141, 22);
            this.numUpDownRound.TabIndex = 4;
            // 
            // contextMenu
            // 
            this.contextMenu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ctxMenuClearLb});
            this.contextMenu.Name = "contextMenu";
            this.contextMenu.Size = new System.Drawing.Size(311, 28);
            // 
            // ctxMenuClearLb
            // 
            this.ctxMenuClearLb.Name = "ctxMenuClearLb";
            this.ctxMenuClearLb.Size = new System.Drawing.Size(310, 24);
            this.ctxMenuClearLb.Text = "Очистиль поле журнала событий";
            this.ctxMenuClearLb.Click += new System.EventHandler(this.ctxMenuClearLb_Click);
            // 
            // panelLb
            // 
            this.panelLb.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelLb.Controls.Add(this.label1);
            this.panelLb.Controls.Add(this.lbLog);
            this.panelLb.Location = new System.Drawing.Point(12, 130);
            this.panelLb.Name = "panelLb";
            this.panelLb.Size = new System.Drawing.Size(1030, 537);
            this.panelLb.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 16);
            this.label1.TabIndex = 9;
            this.label1.Text = "Журнал событий";
            // 
            // lbLog
            // 
            this.lbLog.ContextMenuStrip = this.contextMenu;
            this.lbLog.FormattingEnabled = true;
            this.lbLog.HorizontalScrollbar = true;
            this.lbLog.ItemHeight = 16;
            this.lbLog.Location = new System.Drawing.Point(16, 35);
            this.lbLog.Name = "lbLog";
            this.lbLog.Size = new System.Drawing.Size(995, 484);
            this.lbLog.TabIndex = 8;
            // 
            // panelBlank
            // 
            this.panelBlank.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelBlank.Controls.Add(this.tbElapsedTime);
            this.panelBlank.Controls.Add(this.labelStatus);
            this.panelBlank.Location = new System.Drawing.Point(669, 38);
            this.panelBlank.Name = "panelBlank";
            this.panelBlank.Size = new System.Drawing.Size(373, 86);
            this.panelBlank.TabIndex = 8;
            // 
            // tbElapsedTime
            // 
            this.tbElapsedTime.Location = new System.Drawing.Point(15, 47);
            this.tbElapsedTime.Name = "tbElapsedTime";
            this.tbElapsedTime.ReadOnly = true;
            this.tbElapsedTime.Size = new System.Drawing.Size(339, 22);
            this.tbElapsedTime.TabIndex = 1;
            this.tbElapsedTime.TabStop = false;
            // 
            // labelStatus
            // 
            this.labelStatus.AutoSize = true;
            this.labelStatus.Location = new System.Drawing.Point(16, 23);
            this.labelStatus.Name = "labelStatus";
            this.labelStatus.Size = new System.Drawing.Size(131, 16);
            this.labelStatus.TabIndex = 0;
            this.labelStatus.Text = "Время выполнения";
            // 
            // menuClearFields
            // 
            this.menuClearFields.Name = "menuClearFields";
            this.menuClearFields.Size = new System.Drawing.Size(322, 26);
            this.menuClearFields.Text = "Сбросить все поля";
            this.menuClearFields.Click += new System.EventHandler(this.menuClearFields_Click);
            // 
            // autoMode
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1054, 677);
            this.Controls.Add(this.panelBlank);
            this.Controls.Add(this.panelLb);
            this.Controls.Add(this.mainPanel);
            this.Controls.Add(this.menuStrip);
            this.MainMenuStrip = this.menuStrip;
            this.Name = "autoMode";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Автоматическое выполнение действий участниками";
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.mainPanel.ResumeLayout(false);
            this.mainPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDownLenght)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDownRound)).EndInit();
            this.contextMenu.ResumeLayout(false);
            this.panelLb.ResumeLayout(false);
            this.panelLb.PerformLayout();
            this.panelBlank.ResumeLayout(false);
            this.panelBlank.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnDoAuth;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.Panel mainPanel;
        private System.Windows.Forms.ToolStripMenuItem menuFile;
        private System.Windows.Forms.ToolStripMenuItem menuFormLogFile;
        private System.Windows.Forms.ToolStripMenuItem menuLoadLogFile;
        private System.Windows.Forms.ToolStripMenuItem menuClearLb;
        private System.Windows.Forms.ToolStripMenuItem menuBack;
        private System.Windows.Forms.Label labelRoundCount;
        private System.Windows.Forms.NumericUpDown numUpDownRound;
        private System.Windows.Forms.Label labelLength;
        private System.Windows.Forms.NumericUpDown numUpDownLenght;
        private System.Windows.Forms.ToolStripMenuItem menuInfo;
        private System.Windows.Forms.ContextMenuStrip contextMenu;
        private System.Windows.Forms.ToolStripMenuItem ctxMenuClearLb;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panelLb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lbLog;
        private System.Windows.Forms.Panel panelBlank;
        private System.Windows.Forms.Label labelStatus;
        private System.Windows.Forms.TextBox tbElapsedTime;
        private System.Windows.Forms.ToolStripMenuItem menuClearFields;
    }
}