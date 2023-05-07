namespace FiatShamirAuth
{
    partial class manualMode
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
            this.panelVictor = new System.Windows.Forms.Panel();
            this.btnVictorVerifyY = new System.Windows.Forms.Button();
            this.btnVictorGenE = new System.Windows.Forms.Button();
            this.btnVictorGetNV = new System.Windows.Forms.Button();
            this.labelVictor = new System.Windows.Forms.Label();
            this.panelPeggy = new System.Windows.Forms.Panel();
            this.btnPeggyCalculateY = new System.Windows.Forms.Button();
            this.btnPeggyChooseRCalculateX = new System.Windows.Forms.Button();
            this.btnPeggyProvideV = new System.Windows.Forms.Button();
            this.btnPeggyGenSV = new System.Windows.Forms.Button();
            this.labelPeggy = new System.Windows.Forms.Label();
            this.panelTrustedCenter = new System.Windows.Forms.Panel();
            this.btnTCCalcN = new System.Windows.Forms.Button();
            this.labelRoundCount = new System.Windows.Forms.Label();
            this.labelLength = new System.Windows.Forms.Label();
            this.numUpDownRound = new System.Windows.Forms.NumericUpDown();
            this.numUpDownLenght = new System.Windows.Forms.NumericUpDown();
            this.btnTCGenPQ = new System.Windows.Forms.Button();
            this.labelTrustedCenter = new System.Windows.Forms.Label();
            this.labelRoundsLeft = new System.Windows.Forms.Label();
            this.tbRoundsLeft = new System.Windows.Forms.TextBox();
            this.panelRounds = new System.Windows.Forms.Panel();
            this.btnFullResetState = new System.Windows.Forms.Button();
            this.btnHelp = new System.Windows.Forms.Button();
            this.labelInfo = new System.Windows.Forms.Label();
            this.panelLb = new System.Windows.Forms.Panel();
            this.lbLog = new System.Windows.Forms.ListBox();
            this.contextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ctxMenuClearLb = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.menuFile = new System.Windows.Forms.ToolStripMenuItem();
            this.menuFormLogFile = new System.Windows.Forms.ToolStripMenuItem();
            this.menuLoadLogFile = new System.Windows.Forms.ToolStripMenuItem();
            this.menuClearLb = new System.Windows.Forms.ToolStripMenuItem();
            this.menuFullResetState = new System.Windows.Forms.ToolStripMenuItem();
            this.menuBack = new System.Windows.Forms.ToolStripMenuItem();
            this.menuInfo = new System.Windows.Forms.ToolStripMenuItem();
            this.btnClearEventLog = new System.Windows.Forms.Button();
            this.panelVictor.SuspendLayout();
            this.panelPeggy.SuspendLayout();
            this.panelTrustedCenter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDownRound)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDownLenght)).BeginInit();
            this.panelRounds.SuspendLayout();
            this.panelLb.SuspendLayout();
            this.contextMenu.SuspendLayout();
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelVictor
            // 
            this.panelVictor.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelVictor.Controls.Add(this.btnVictorVerifyY);
            this.panelVictor.Controls.Add(this.btnVictorGenE);
            this.panelVictor.Controls.Add(this.btnVictorGetNV);
            this.panelVictor.Location = new System.Drawing.Point(615, 68);
            this.panelVictor.Name = "panelVictor";
            this.panelVictor.Size = new System.Drawing.Size(255, 325);
            this.panelVictor.TabIndex = 5;
            // 
            // btnVictorVerifyY
            // 
            this.btnVictorVerifyY.Location = new System.Drawing.Point(13, 171);
            this.btnVictorVerifyY.Name = "btnVictorVerifyY";
            this.btnVictorVerifyY.Size = new System.Drawing.Size(218, 60);
            this.btnVictorVerifyY.TabIndex = 11;
            this.btnVictorVerifyY.Text = "11. Получить ответ y от Пэгги и подтвердить подлинность ее секрета\r\n";
            this.btnVictorVerifyY.UseVisualStyleBackColor = true;
            this.btnVictorVerifyY.Click += new System.EventHandler(this.btnVictorVerifyY_Click);
            // 
            // btnVictorGenE
            // 
            this.btnVictorGenE.Location = new System.Drawing.Point(13, 95);
            this.btnVictorGenE.Name = "btnVictorGenE";
            this.btnVictorGenE.Size = new System.Drawing.Size(218, 61);
            this.btnVictorGenE.TabIndex = 10;
            this.btnVictorGenE.Text = "9. Получить свидетельство x\r\nСгенерировать\r\n и передать вызов e\r\n";
            this.btnVictorGenE.UseVisualStyleBackColor = true;
            this.btnVictorGenE.Click += new System.EventHandler(this.btnVictorGenE_Click);
            // 
            // btnVictorGetNV
            // 
            this.btnVictorGetNV.Location = new System.Drawing.Point(13, 18);
            this.btnVictorGetNV.Name = "btnVictorGetNV";
            this.btnVictorGetNV.Size = new System.Drawing.Size(218, 62);
            this.btnVictorGetNV.TabIndex = 10;
            this.btnVictorGetNV.Text = "7. Получить общедоступное n от Доверительного центра и публичный ключ v от Пэгги";
            this.btnVictorGetNV.UseVisualStyleBackColor = true;
            this.btnVictorGetNV.Click += new System.EventHandler(this.btnVictorGetNV_Click);
            // 
            // labelVictor
            // 
            this.labelVictor.AutoSize = true;
            this.labelVictor.Location = new System.Drawing.Point(615, 42);
            this.labelVictor.Name = "labelVictor";
            this.labelVictor.Size = new System.Drawing.Size(151, 16);
            this.labelVictor.TabIndex = 2;
            this.labelVictor.Text = "Виктор (Victor - Verifier)";
            // 
            // panelPeggy
            // 
            this.panelPeggy.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelPeggy.Controls.Add(this.btnPeggyCalculateY);
            this.panelPeggy.Controls.Add(this.btnPeggyChooseRCalculateX);
            this.panelPeggy.Controls.Add(this.btnPeggyProvideV);
            this.panelPeggy.Controls.Add(this.btnPeggyGenSV);
            this.panelPeggy.Location = new System.Drawing.Point(316, 68);
            this.panelPeggy.Name = "panelPeggy";
            this.panelPeggy.Size = new System.Drawing.Size(273, 325);
            this.panelPeggy.TabIndex = 4;
            // 
            // btnPeggyCalculateY
            // 
            this.btnPeggyCalculateY.Location = new System.Drawing.Point(15, 247);
            this.btnPeggyCalculateY.Name = "btnPeggyCalculateY";
            this.btnPeggyCalculateY.Size = new System.Drawing.Size(231, 49);
            this.btnPeggyCalculateY.TabIndex = 10;
            this.btnPeggyCalculateY.Text = "10. Вычислить ответ y и передать Виктору";
            this.btnPeggyCalculateY.UseVisualStyleBackColor = true;
            this.btnPeggyCalculateY.Click += new System.EventHandler(this.btnPeggyCalculateY_Click);
            // 
            // btnPeggyChooseRCalculateX
            // 
            this.btnPeggyChooseRCalculateX.Location = new System.Drawing.Point(15, 171);
            this.btnPeggyChooseRCalculateX.Name = "btnPeggyChooseRCalculateX";
            this.btnPeggyChooseRCalculateX.Size = new System.Drawing.Size(231, 60);
            this.btnPeggyChooseRCalculateX.TabIndex = 10;
            this.btnPeggyChooseRCalculateX.Text = "8. Выбрать обязательство r вычислить и передать Виктору свидетельство x";
            this.btnPeggyChooseRCalculateX.UseVisualStyleBackColor = true;
            this.btnPeggyChooseRCalculateX.Click += new System.EventHandler(this.btnPeggyChooseRCalculateX_Click);
            // 
            // btnPeggyProvideV
            // 
            this.btnPeggyProvideV.Location = new System.Drawing.Point(15, 102);
            this.btnPeggyProvideV.Name = "btnPeggyProvideV";
            this.btnPeggyProvideV.Size = new System.Drawing.Size(231, 52);
            this.btnPeggyProvideV.TabIndex = 1;
            this.btnPeggyProvideV.Text = "6. Предоставить публичный ключ v Виктору";
            this.btnPeggyProvideV.UseVisualStyleBackColor = true;
            this.btnPeggyProvideV.Click += new System.EventHandler(this.btnPeggyProvideV_Click);
            // 
            // btnPeggyGenSV
            // 
            this.btnPeggyGenSV.Location = new System.Drawing.Point(15, 19);
            this.btnPeggyGenSV.Name = "btnPeggyGenSV";
            this.btnPeggyGenSV.Size = new System.Drawing.Size(231, 60);
            this.btnPeggyGenSV.TabIndex = 0;
            this.btnPeggyGenSV.Text = "5. Получить общедоступное n \r\nвыбрать секретный ключ s и публичный ключ v";
            this.btnPeggyGenSV.UseVisualStyleBackColor = true;
            this.btnPeggyGenSV.Click += new System.EventHandler(this.btnPeggyGenSV_Click);
            // 
            // labelPeggy
            // 
            this.labelPeggy.AutoSize = true;
            this.labelPeggy.Location = new System.Drawing.Point(318, 41);
            this.labelPeggy.Name = "labelPeggy";
            this.labelPeggy.Size = new System.Drawing.Size(146, 16);
            this.labelPeggy.TabIndex = 1;
            this.labelPeggy.Text = "Пэгги (Peggy - Prover)";
            // 
            // panelTrustedCenter
            // 
            this.panelTrustedCenter.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelTrustedCenter.Controls.Add(this.btnTCCalcN);
            this.panelTrustedCenter.Controls.Add(this.labelRoundCount);
            this.panelTrustedCenter.Controls.Add(this.labelLength);
            this.panelTrustedCenter.Controls.Add(this.numUpDownRound);
            this.panelTrustedCenter.Controls.Add(this.numUpDownLenght);
            this.panelTrustedCenter.Controls.Add(this.btnTCGenPQ);
            this.panelTrustedCenter.Location = new System.Drawing.Point(12, 69);
            this.panelTrustedCenter.Name = "panelTrustedCenter";
            this.panelTrustedCenter.Size = new System.Drawing.Size(264, 324);
            this.panelTrustedCenter.TabIndex = 3;
            // 
            // btnTCCalcN
            // 
            this.btnTCCalcN.Location = new System.Drawing.Point(13, 243);
            this.btnTCCalcN.Name = "btnTCCalcN";
            this.btnTCCalcN.Size = new System.Drawing.Size(231, 60);
            this.btnTCCalcN.TabIndex = 12;
            this.btnTCCalcN.Text = "4. Вычислить и предоставить Пэгги и Виктору общедоступное число n";
            this.btnTCCalcN.UseVisualStyleBackColor = true;
            this.btnTCCalcN.Click += new System.EventHandler(this.btnTCCalcN_Click);
            // 
            // labelRoundCount
            // 
            this.labelRoundCount.AutoSize = true;
            this.labelRoundCount.Location = new System.Drawing.Point(23, 17);
            this.labelRoundCount.Name = "labelRoundCount";
            this.labelRoundCount.Size = new System.Drawing.Size(150, 32);
            this.labelRoundCount.TabIndex = 9;
            this.labelRoundCount.Text = "1. Задать количество \r\nраундов протокола";
            // 
            // labelLength
            // 
            this.labelLength.Location = new System.Drawing.Point(23, 95);
            this.labelLength.Name = "labelLength";
            this.labelLength.Size = new System.Drawing.Size(224, 32);
            this.labelLength.TabIndex = 11;
            this.labelLength.Text = "2. Задать порядок \r\nинициализирующих чисел p и q";
            // 
            // numUpDownRound
            // 
            this.numUpDownRound.Location = new System.Drawing.Point(26, 55);
            this.numUpDownRound.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.numUpDownRound.Name = "numUpDownRound";
            this.numUpDownRound.Size = new System.Drawing.Size(141, 22);
            this.numUpDownRound.TabIndex = 1;
            this.numUpDownRound.ValueChanged += new System.EventHandler(this.numUpDownRound_ValueChanged);
            // 
            // numUpDownLenght
            // 
            this.numUpDownLenght.Location = new System.Drawing.Point(20, 137);
            this.numUpDownLenght.Name = "numUpDownLenght";
            this.numUpDownLenght.Size = new System.Drawing.Size(227, 22);
            this.numUpDownLenght.TabIndex = 1;
            this.numUpDownLenght.ValueChanged += new System.EventHandler(this.numUpDownLenght_ValueChanged);
            // 
            // btnTCGenPQ
            // 
            this.btnTCGenPQ.Location = new System.Drawing.Point(16, 172);
            this.btnTCGenPQ.Name = "btnTCGenPQ";
            this.btnTCGenPQ.Size = new System.Drawing.Size(231, 52);
            this.btnTCGenPQ.TabIndex = 1;
            this.btnTCGenPQ.Text = "3. Сгенерировать начальные простые числа p и q";
            this.btnTCGenPQ.UseVisualStyleBackColor = true;
            this.btnTCGenPQ.Click += new System.EventHandler(this.btnTCGenPQ_Click);
            // 
            // labelTrustedCenter
            // 
            this.labelTrustedCenter.AutoSize = true;
            this.labelTrustedCenter.Location = new System.Drawing.Point(11, 40);
            this.labelTrustedCenter.Name = "labelTrustedCenter";
            this.labelTrustedCenter.Size = new System.Drawing.Size(280, 16);
            this.labelTrustedCenter.TabIndex = 0;
            this.labelTrustedCenter.Text = "Доверительный центр (Trusted Center - TC)";
            // 
            // labelRoundsLeft
            // 
            this.labelRoundsLeft.AutoSize = true;
            this.labelRoundsLeft.Location = new System.Drawing.Point(15, 35);
            this.labelRoundsLeft.Name = "labelRoundsLeft";
            this.labelRoundsLeft.Size = new System.Drawing.Size(127, 16);
            this.labelRoundsLeft.TabIndex = 10;
            this.labelRoundsLeft.Text = "Раундов осталось";
            // 
            // tbRoundsLeft
            // 
            this.tbRoundsLeft.Location = new System.Drawing.Point(14, 54);
            this.tbRoundsLeft.Name = "tbRoundsLeft";
            this.tbRoundsLeft.ReadOnly = true;
            this.tbRoundsLeft.Size = new System.Drawing.Size(145, 22);
            this.tbRoundsLeft.TabIndex = 11;
            this.tbRoundsLeft.TabStop = false;
            // 
            // panelRounds
            // 
            this.panelRounds.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelRounds.Controls.Add(this.btnClearEventLog);
            this.panelRounds.Controls.Add(this.btnFullResetState);
            this.panelRounds.Controls.Add(this.btnHelp);
            this.panelRounds.Controls.Add(this.tbRoundsLeft);
            this.panelRounds.Controls.Add(this.labelRoundsLeft);
            this.panelRounds.Location = new System.Drawing.Point(897, 69);
            this.panelRounds.Name = "panelRounds";
            this.panelRounds.Size = new System.Drawing.Size(181, 324);
            this.panelRounds.TabIndex = 12;
            // 
            // btnFullResetState
            // 
            this.btnFullResetState.Location = new System.Drawing.Point(15, 166);
            this.btnFullResetState.Name = "btnFullResetState";
            this.btnFullResetState.Size = new System.Drawing.Size(144, 58);
            this.btnFullResetState.TabIndex = 2;
            this.btnFullResetState.Text = "Сбросить все шаги участников протокола";
            this.btnFullResetState.UseVisualStyleBackColor = true;
            this.btnFullResetState.Click += new System.EventHandler(this.btnFullResetState_Click);
            // 
            // btnHelp
            // 
            this.btnHelp.Location = new System.Drawing.Point(14, 98);
            this.btnHelp.Name = "btnHelp";
            this.btnHelp.Size = new System.Drawing.Size(145, 52);
            this.btnHelp.TabIndex = 12;
            this.btnHelp.Text = "Справка ";
            this.btnHelp.UseVisualStyleBackColor = true;
            this.btnHelp.Click += new System.EventHandler(this.btnHelp_Click);
            // 
            // labelInfo
            // 
            this.labelInfo.AutoSize = true;
            this.labelInfo.Location = new System.Drawing.Point(897, 45);
            this.labelInfo.Name = "labelInfo";
            this.labelInfo.Size = new System.Drawing.Size(92, 16);
            this.labelInfo.TabIndex = 13;
            this.labelInfo.Text = "Информация";
            // 
            // panelLb
            // 
            this.panelLb.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelLb.Controls.Add(this.lbLog);
            this.panelLb.Location = new System.Drawing.Point(12, 430);
            this.panelLb.Name = "panelLb";
            this.panelLb.Size = new System.Drawing.Size(1066, 405);
            this.panelLb.TabIndex = 14;
            // 
            // lbLog
            // 
            this.lbLog.ContextMenuStrip = this.contextMenu;
            this.lbLog.FormattingEnabled = true;
            this.lbLog.HorizontalScrollbar = true;
            this.lbLog.ItemHeight = 16;
            this.lbLog.Location = new System.Drawing.Point(16, 14);
            this.lbLog.Name = "lbLog";
            this.lbLog.Size = new System.Drawing.Size(1028, 372);
            this.lbLog.TabIndex = 8;
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
            this.ctxMenuClearLb.Click += new System.EventHandler(this.ctxMenuClearLb_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 402);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 16);
            this.label1.TabIndex = 15;
            this.label1.Text = "Журнал событий";
            // 
            // menuStrip
            // 
            this.menuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuFile,
            this.menuInfo});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(1096, 28);
            this.menuStrip.TabIndex = 16;
            this.menuStrip.Text = "menu";
            // 
            // menuFile
            // 
            this.menuFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuFormLogFile,
            this.menuLoadLogFile,
            this.menuClearLb,
            this.menuFullResetState,
            this.menuBack});
            this.menuFile.Name = "menuFile";
            this.menuFile.Size = new System.Drawing.Size(59, 24);
            this.menuFile.Text = "Файл";
            // 
            // menuFormLogFile
            // 
            this.menuFormLogFile.Name = "menuFormLogFile";
            this.menuFormLogFile.Size = new System.Drawing.Size(384, 26);
            this.menuFormLogFile.Text = "Создать файл журнала";
            this.menuFormLogFile.Click += new System.EventHandler(this.menuFormLogFile_Click);
            // 
            // menuLoadLogFile
            // 
            this.menuLoadLogFile.Name = "menuLoadLogFile";
            this.menuLoadLogFile.Size = new System.Drawing.Size(384, 26);
            this.menuLoadLogFile.Text = "Загрузить файл журнала";
            this.menuLoadLogFile.Click += new System.EventHandler(this.menuLoadLogFile_Click);
            // 
            // menuClearLb
            // 
            this.menuClearLb.Name = "menuClearLb";
            this.menuClearLb.Size = new System.Drawing.Size(384, 26);
            this.menuClearLb.Text = "Очистить поле журнала событий";
            this.menuClearLb.Click += new System.EventHandler(this.menuClearLb_Click);
            // 
            // menuFullResetState
            // 
            this.menuFullResetState.Name = "menuFullResetState";
            this.menuFullResetState.Size = new System.Drawing.Size(384, 26);
            this.menuFullResetState.Text = "Сбросить все шаги участников протокола";
            this.menuFullResetState.Click += new System.EventHandler(this.menuFullResetState_Click);
            // 
            // menuBack
            // 
            this.menuBack.Name = "menuBack";
            this.menuBack.Size = new System.Drawing.Size(384, 26);
            this.menuBack.Text = "Вернуться к главному окну";
            this.menuBack.Click += new System.EventHandler(this.menuBack_Click_1);
            // 
            // menuInfo
            // 
            this.menuInfo.Name = "menuInfo";
            this.menuInfo.Size = new System.Drawing.Size(81, 24);
            this.menuInfo.Text = "Справка";
            this.menuInfo.Click += new System.EventHandler(this.menuInfo_Click);
            // 
            // btnClearEventLog
            // 
            this.btnClearEventLog.Location = new System.Drawing.Point(18, 246);
            this.btnClearEventLog.Name = "btnClearEventLog";
            this.btnClearEventLog.Size = new System.Drawing.Size(142, 47);
            this.btnClearEventLog.TabIndex = 14;
            this.btnClearEventLog.Text = "Очистить поле журнала событий";
            this.btnClearEventLog.UseVisualStyleBackColor = true;
            this.btnClearEventLog.Click += new System.EventHandler(this.btnClearEventLog_Click);
            // 
            // manualMode
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1096, 864);
            this.Controls.Add(this.menuStrip);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panelLb);
            this.Controls.Add(this.labelInfo);
            this.Controls.Add(this.panelRounds);
            this.Controls.Add(this.labelVictor);
            this.Controls.Add(this.labelPeggy);
            this.Controls.Add(this.labelTrustedCenter);
            this.Controls.Add(this.panelVictor);
            this.Controls.Add(this.panelPeggy);
            this.Controls.Add(this.panelTrustedCenter);
            this.Name = "manualMode";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Последовательное выполнение действий участниками";
            this.panelVictor.ResumeLayout(false);
            this.panelPeggy.ResumeLayout(false);
            this.panelTrustedCenter.ResumeLayout(false);
            this.panelTrustedCenter.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDownRound)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDownLenght)).EndInit();
            this.panelRounds.ResumeLayout(false);
            this.panelRounds.PerformLayout();
            this.panelLb.ResumeLayout(false);
            this.contextMenu.ResumeLayout(false);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelVictor;
        private System.Windows.Forms.Label labelVictor;
        private System.Windows.Forms.Panel panelPeggy;
        private System.Windows.Forms.Label labelPeggy;
        private System.Windows.Forms.Panel panelTrustedCenter;
        private System.Windows.Forms.Label labelTrustedCenter;
        private System.Windows.Forms.Button btnPeggyGenSV;
        private System.Windows.Forms.Label labelLength;
        private System.Windows.Forms.NumericUpDown numUpDownLenght;
        private System.Windows.Forms.Label labelRoundCount;
        private System.Windows.Forms.NumericUpDown numUpDownRound;
        private System.Windows.Forms.Button btnTCCalcN;
        private System.Windows.Forms.Button btnTCGenPQ;
        private System.Windows.Forms.Button btnPeggyProvideV;
        private System.Windows.Forms.Button btnVictorGetNV;
        private System.Windows.Forms.Button btnPeggyChooseRCalculateX;
        private System.Windows.Forms.Button btnVictorGenE;
        private System.Windows.Forms.Button btnPeggyCalculateY;
        private System.Windows.Forms.Button btnVictorVerifyY;
        private System.Windows.Forms.Label labelRoundsLeft;
        private System.Windows.Forms.TextBox tbRoundsLeft;
        private System.Windows.Forms.Panel panelRounds;
        private System.Windows.Forms.Label labelInfo;
        private System.Windows.Forms.Panel panelLb;
        private System.Windows.Forms.ListBox lbLog;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnHelp;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem menuFile;
        private System.Windows.Forms.ToolStripMenuItem menuFormLogFile;
        private System.Windows.Forms.ToolStripMenuItem menuLoadLogFile;
        private System.Windows.Forms.ToolStripMenuItem menuClearLb;
        private System.Windows.Forms.ToolStripMenuItem menuBack;
        private System.Windows.Forms.ToolStripMenuItem menuInfo;
        private System.Windows.Forms.ContextMenuStrip contextMenu;
        private System.Windows.Forms.ToolStripMenuItem ctxMenuClearLb;
        private System.Windows.Forms.ToolStripMenuItem menuFullResetState;
        private System.Windows.Forms.Button btnFullResetState;
        private System.Windows.Forms.Button btnClearEventLog;
    }
}