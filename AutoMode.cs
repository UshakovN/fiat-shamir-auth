using System;
using System.Diagnostics;
using System.Threading.Tasks;
using System.Windows.Forms;

using CommonForms;
using ZeroKnowledgeProof;

namespace FiatShamirAuth
{
    public partial class autoMode : Form
    {
        private int length;
        private int rounds;

        private string time;

        private readonly Stopwatch stopwatch = new Stopwatch();

        public autoMode()
        {
            InitializeComponent();

            time = ServiceTools.GetNowTime();

            numUpDownLenght.Value = 1;
            numUpDownRound.Value = 1;
        }

        private void menuBack_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnDoAuth_Click(object sender, EventArgs e)
        {
            ServiceTools.ClearEventsLog(lbLog);

            length = (int)numUpDownLenght.Value;
            rounds = (int)numUpDownRound.Value;

            if (!ServiceTools.ValidateContantsLenght(length))
                return;

            if (!ServiceTools.ValidateRoundsCount(rounds))
                return;

            numUpDownRound.ReadOnly = true;
            numUpDownLenght.ReadOnly = true;

            stopwatch.Start();
            bool authenticated = FiatShamirProtocol.DoAuth(length, rounds, HandleLog);
            stopwatch.Stop();

            numUpDownRound.ReadOnly = false;
            numUpDownLenght.ReadOnly = false;

            tbElapsedTime.Text = GetElapsedTime();

            Task.Run(async () =>
            {
                int lazy = 150;
                await Task.Delay(lazy);

                if (authenticated)
                {
                    MessageBox.Show(
                        ServiceTools.successInfo,
                        ServiceTools.successTitle,
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);

                    return;
                }
                else
                {
                    MessageBox.Show(
                        ServiceTools.failInfo,
                        ServiceTools.failTitle,
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Stop);
                }
            });

            time = ServiceTools.GetNowTime();
        }

        private void menuClearLb_Click(object sender, EventArgs e)
        {
            ServiceTools.ClearEventsLog(lbLog);
        }

        private void menuInfo_Click(object sender, EventArgs e)
        {
            ServiceTools.ShowInfoForModeAuto();
        }

        private void ctxMenuClearLb_Click(object sender, EventArgs e)
        {
            ServiceTools.ClearEventsLog(lbLog);
        }

        private void menuFormLogFile_Click(object sender, EventArgs e)
        {
            ServiceTools.FormLogFile(lbLog, time);
        }

        private void menuLoadLogFile_Click(object sender, EventArgs e)
        {
            ServiceTools.ClearEventsLog(lbLog);
            ServiceTools.LoadLogFile(lbLog);
        }

        private string GetElapsedTime()
        {
            TimeSpan ts = stopwatch.Elapsed;

            string elapsed = string.Format(
                "{0:00}:{1:00}:{2:00}.{3:00}",
                ts.Hours,
                ts.Minutes,
                ts.Seconds,
                ts.Milliseconds / 10);

            return elapsed;
        }

        private void HandleLog(string log)
        {
            ServiceTools.HandleLog(log, lbLog);
        }

        private void menuClearFields_Click(object sender, EventArgs e)
        {
            numUpDownLenght.Value = 1;
            numUpDownRound.Value = 1;

            tbElapsedTime.Clear();

            ServiceTools.ClearEventsLog(lbLog);
        }
    }
}
