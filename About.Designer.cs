namespace FiatShamirAuth
{
    partial class aboutForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(aboutForm));
            this.panelFields = new System.Windows.Forms.Panel();
            this.labelFields = new System.Windows.Forms.Label();
            this.btnOk = new System.Windows.Forms.Button();
            this.panelFields.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelFields
            // 
            this.panelFields.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelFields.Controls.Add(this.labelFields);
            this.panelFields.Location = new System.Drawing.Point(12, 12);
            this.panelFields.Name = "panelFields";
            this.panelFields.Size = new System.Drawing.Size(844, 296);
            this.panelFields.TabIndex = 0;
            // 
            // labelFields
            // 
            this.labelFields.Location = new System.Drawing.Point(8, 12);
            this.labelFields.Name = "labelFields";
            this.labelFields.Size = new System.Drawing.Size(824, 272);
            this.labelFields.TabIndex = 0;
            this.labelFields.Text = resources.GetString("labelFields.Text");
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(370, 314);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(128, 30);
            this.btnOk.TabIndex = 1;
            this.btnOk.Text = "ОК";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // aboutForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(864, 357);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.panelFields);
            this.Name = "aboutForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "О программе";
            this.panelFields.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelFields;
        private System.Windows.Forms.Label labelFields;
        private System.Windows.Forms.Button btnOk;
    }
}