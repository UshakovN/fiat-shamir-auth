using System;
using System.Text;
using System.Windows.Forms;

namespace FiatShamirAuth
{
    public partial class mainForm : Form
    {
        private bool showedModeAuto = false;
        private bool showedModeManual = false;

        public mainForm()
        {
            InitializeComponent();
        }

        private void menuExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void menuAbout_Click(object sender, EventArgs e)
        {
            var about = new aboutForm(); 
            about.ShowDialog();
        }

        private void btnModeManual_Click(object sender, EventArgs e)
        {
            var res = DialogResult.OK;

            if (!showedModeAuto && !showedModeManual)
            {
                res = MessageBox.Show(
                    BuildRecInfo(),
                    BuildRecTitle(),
                    MessageBoxButtons.OKCancel,
                    MessageBoxIcon.Asterisk);
            }
            if (res == DialogResult.OK)
            {
                var manual = new manualMode();
                manual.ShowDialog();

                showedModeManual = true;
            }
        }

        private void btnModeAuto_Click(object sender, EventArgs e)
        {
            var auto = new autoMode();
            auto.ShowDialog();

            showedModeAuto = true;
        }

        private string BuildRecTitle()
        {
            return "Рекоммендация";
        }

        private string BuildRecInfo()
        {
            var sb = new StringBuilder();
            sb.AppendLine("Рекомендуется сначала ознакомиться с выполнением протокола в автоматическим режиме работы\n");
            sb.AppendLine("Нажмите Отмена для возврата в меню или OK чтобы продолжить с выполнением протокола в последовательном режиме работы");
            return sb.ToString();   
        }
    }
}
