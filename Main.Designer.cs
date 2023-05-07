namespace FiatShamirAuth
{
    partial class mainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.menuFile = new System.Windows.Forms.ToolStripMenuItem();
            this.menuExit = new System.Windows.Forms.ToolStripMenuItem();
            this.menuInfo = new System.Windows.Forms.ToolStripMenuItem();
            this.menuAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.btnModeManual = new System.Windows.Forms.Button();
            this.btnModeAuto = new System.Windows.Forms.Button();
            this.panelMode = new System.Windows.Forms.Panel();
            this.labelMode = new System.Windows.Forms.Label();
            this.menuStrip.SuspendLayout();
            this.panelMode.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuFile,
            this.menuInfo});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(596, 30);
            this.menuStrip.TabIndex = 3;
            this.menuStrip.Text = "menu";
            // 
            // menuFile
            // 
            this.menuFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuExit});
            this.menuFile.Name = "menuFile";
            this.menuFile.Size = new System.Drawing.Size(59, 26);
            this.menuFile.Text = "Файл";
            // 
            // menuExit
            // 
            this.menuExit.Name = "menuExit";
            this.menuExit.Size = new System.Drawing.Size(136, 26);
            this.menuExit.Text = "Выход";
            this.menuExit.Click += new System.EventHandler(this.menuExit_Click);
            // 
            // menuInfo
            // 
            this.menuInfo.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuAbout});
            this.menuInfo.Name = "menuInfo";
            this.menuInfo.Size = new System.Drawing.Size(62, 26);
            this.menuInfo.Text = "Инфо";
            // 
            // menuAbout
            // 
            this.menuAbout.Name = "menuAbout";
            this.menuAbout.Size = new System.Drawing.Size(187, 26);
            this.menuAbout.Text = "О программе";
            this.menuAbout.Click += new System.EventHandler(this.menuAbout_Click);
            // 
            // btnModeManual
            // 
            this.btnModeManual.Location = new System.Drawing.Point(292, 6);
            this.btnModeManual.Name = "btnModeManual";
            this.btnModeManual.Size = new System.Drawing.Size(244, 51);
            this.btnModeManual.TabIndex = 4;
            this.btnModeManual.Text = "Последовательное выполнение действий участниками";
            this.btnModeManual.UseVisualStyleBackColor = true;
            this.btnModeManual.Click += new System.EventHandler(this.btnModeManual_Click);
            // 
            // btnModeAuto
            // 
            this.btnModeAuto.Location = new System.Drawing.Point(19, 6);
            this.btnModeAuto.Name = "btnModeAuto";
            this.btnModeAuto.Size = new System.Drawing.Size(244, 51);
            this.btnModeAuto.TabIndex = 5;
            this.btnModeAuto.Text = "Автоматическое выполнение\r\n действий участниками";
            this.btnModeAuto.UseVisualStyleBackColor = true;
            this.btnModeAuto.Click += new System.EventHandler(this.btnModeAuto_Click);
            // 
            // panelMode
            // 
            this.panelMode.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelMode.Controls.Add(this.btnModeManual);
            this.panelMode.Controls.Add(this.btnModeAuto);
            this.panelMode.Location = new System.Drawing.Point(12, 78);
            this.panelMode.Name = "panelMode";
            this.panelMode.Size = new System.Drawing.Size(561, 67);
            this.panelMode.TabIndex = 6;
            // 
            // labelMode
            // 
            this.labelMode.AutoSize = true;
            this.labelMode.Location = new System.Drawing.Point(9, 47);
            this.labelMode.Name = "labelMode";
            this.labelMode.Size = new System.Drawing.Size(244, 16);
            this.labelMode.TabIndex = 7;
            this.labelMode.Text = "Выберите требуемый режим работы";
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(596, 172);
            this.Controls.Add(this.labelMode);
            this.Controls.Add(this.panelMode);
            this.Controls.Add(this.menuStrip);
            this.MainMenuStrip = this.menuStrip;
            this.Name = "mainForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "А-05-19 Ушаков Никита Расчетное Задание";
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.panelMode.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem menuFile;
        private System.Windows.Forms.ToolStripMenuItem menuExit;
        private System.Windows.Forms.ToolStripMenuItem menuInfo;
        private System.Windows.Forms.Button btnModeManual;
        private System.Windows.Forms.Button btnModeAuto;
        private System.Windows.Forms.Panel panelMode;
        private System.Windows.Forms.Label labelMode;
        private System.Windows.Forms.ToolStripMenuItem menuAbout;
    }
}

