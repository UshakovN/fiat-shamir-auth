using System;
using System.Text;
using System.Numerics;
using System.Windows.Forms;

using CommonForms;
using ZeroKnowledgeProof;

namespace FiatShamirAuth
{
    public partial class manualMode : Form
    {
        private string time;

        private int length;
        private int rounds;

        private TrustedCenter trustedCenter;
        private PeggyProver peggyProver;
        private VictorVerifier victorVerifier;

        private BigInteger? n;
        private BigInteger? v;
        private BigInteger? x;
        private int? call;
        private BigInteger? y;

        private int round;
        private bool verified;

        public manualMode()
        {
            InitializeComponent();

            time = ServiceTools.GetNowTime();

            numUpDownLenght.Value = 1;
            numUpDownRound.Value = 1;

            round = 0;
        }

        private void menuBack_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ctxMenuClearLb_Click(object sender, EventArgs e)
        {
            ServiceTools.ClearEventsLog(lbLog);
        }

        private void menuClearLb_Click(object sender, EventArgs e)
        {
            ServiceTools.ClearEventsLog(lbLog);
        }

        private void menuBack_Click_1(object sender, EventArgs e)
        {
            Close();
        }

        private void menuInfo_Click(object sender, EventArgs e)
        {
            ServiceTools.ShowInfoForModeManual();
        }

        private void btnHelp_Click(object sender, EventArgs e)
        {
            ServiceTools.ShowInfoForModeManual();
        }

        private void btnTCGenPQ_Click(object sender, EventArgs e)
        {
            length = (int)numUpDownLenght.Value;
            rounds = (int)numUpDownRound.Value;

            if (length == 0)
                return;

            numUpDownRound.ReadOnly = true;
            numUpDownLenght.ReadOnly = true;

            trustedCenter = new TrustedCenter(length, HandleLog);
        }

        private void numUpDownRound_ValueChanged(object sender, EventArgs e)
        {
            rounds = (int)numUpDownRound.Value;

            if (!ServiceTools.ValidateRoundsCount(rounds))
                rounds = 1;
                numUpDownRound.Value = rounds;

            tbRoundsLeft.Text = rounds.ToString();
        }

        private void numUpDownLenght_ValueChanged(object sender, EventArgs e)
        {
            length = (int)numUpDownLenght.Value;

            if (!ServiceTools.ValidateContantsLenght(length))
                length = 1; 
                numUpDownLenght.Value = length;
        }

        private void HandleLog(string log)
        {
            ServiceTools.HandleLog(log, lbLog);
        }

        private void btnTCCalcN_Click(object sender, EventArgs e)
        {
            if (trustedCenter == null)
                return;

            n = trustedCenter.CalculateN();
        }

        private void btnPeggyGenSV_Click(object sender, EventArgs e)
        {
            if (n == null)
                return;

            peggyProver = new PeggyProver(n.Value, HandleLog);
        }

        private void btnPeggyProvideV_Click(object sender, EventArgs e)
        {
            if (peggyProver == null)
                return;

            v = peggyProver.ProvideV();
        }

        private void btnVictorGetNV_Click(object sender, EventArgs e)
        {
            if (n == null || v == null)
                return;

            victorVerifier = new VictorVerifier(n.Value, v.Value, HandleLog);
        }

        private void btnPeggyChooseRCalculateX_Click(object sender, EventArgs e)
        {
            if (peggyProver == null)
                return;

            x = peggyProver.CalculateX();
        }

        private void btnVictorGenE_Click(object sender, EventArgs e)
        {
            if (victorVerifier == null || x == null)
                return;

            call = victorVerifier.GenerateE(x.Value);
        }

        private void btnPeggyCalculateY_Click(object sender, EventArgs e)
        {
            if (peggyProver == null || call == null)
                return;

            y = peggyProver.CalculateY(call.Value);
        }

        private void ResetProtocolRoundFields()
        {
            x = null;
            call = null;
            y = null;
        }

        private void btnVictorVerifyY_Click(object sender, EventArgs e)
        {
            if (victorVerifier == null || y == null)
                return;

            verified = victorVerifier.VerifyY(y.Value);

            if (!verified)
            {
                MessageBox.Show(
                    ServiceTools.failInfo,
                    ServiceTools.failTitle,
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);

                FullResetState();

                return;
            }

            ResetProtocolRoundFields();

            round++;
            victorVerifier.InfoVerified(round, rounds);

            int roundsLeft = rounds - round;
            tbRoundsLeft.Text = roundsLeft.ToString();

            if (round != rounds)
            {
                string roundTitle = BuildRoundTitle();
                string roundInfo = BuildRoundInfo();

                MessageBox.Show(
                    roundInfo,
                    roundTitle,
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Asterisk);
            }
            else 
            {
                MessageBox.Show(
                    ServiceTools.successInfo,
                    ServiceTools.successTitle,
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                DisableProtocolControls();

                return;
            }
        }

        private string BuildRoundTitle()
        {
            return "Подлинность подтверждена";
        }

        private string BuildRoundInfo()
        {
            var sb = new StringBuilder();
            sb.AppendLine("Подлинность секрета на раунде подтверждена\n");
            sb.AppendLine($"Раунд:  {round}");
            sb.AppendLine($"Всего раундов:  {rounds}");
            sb.AppendLine($"Осталось раундов:  {rounds - round}\n");
            sb.AppendLine("Необходимо повторить шаги:  8-11");
            return sb.ToString();
        }

        private void FullResetState()
        {
            numUpDownRound.ReadOnly = false;
            numUpDownLenght.ReadOnly = false;

            rounds = 1;
            length = 1;

            tbRoundsLeft.Text = rounds.ToString();

            numUpDownLenght.Value = rounds;
            numUpDownRound.Value = length;

            trustedCenter = null;
            peggyProver = null;
            victorVerifier = null;

            n = null;
            v = null;
            x = null;
            call = null;
            y = null;

            round = 0;
            verified = false;

            EnableProtocolControls();

            time = ServiceTools.GetNowTime();

            string warnInfo = BuildWarnInfo();

            MessageBox.Show(
                warnInfo,
                ServiceTools.warnTitle,
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning);
        }

        private string BuildWarnInfo()
        {
            var sb = new StringBuilder();
            sb.AppendLine("Все шаги участников протокола сброшены\n");
            sb.AppendLine("Требуется произвести последовательность действий участников протокола снова");
            return sb.ToString();
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

        private void menuFullResetState_Click(object sender, EventArgs e)
        {
            FullResetState();
        }

        private void ctxMenuClearLb_Click_1(object sender, EventArgs e)
        {
            ServiceTools.ClearEventsLog(lbLog);
        }

        private void btnFullResetState_Click(object sender, EventArgs e)
        {
            FullResetState();
        }

        private void btnClearEventLog_Click(object sender, EventArgs e)
        {
            ServiceTools.ClearEventsLog(lbLog);
        }

        private void EnableProtocolControls()
        {
            numUpDownLenght.Enabled = true;
            numUpDownRound.Enabled = true;

            btnTCGenPQ.Enabled = true;
            btnTCCalcN.Enabled = true;

            btnPeggyGenSV.Enabled = true;
            btnPeggyProvideV.Enabled = true;
            btnPeggyChooseRCalculateX.Enabled = true;
            btnPeggyCalculateY.Enabled = true;

            btnVictorGetNV.Enabled = true;
            btnVictorGenE.Enabled = true;
            btnVictorVerifyY.Enabled = true;
        }

        private void DisableProtocolControls()
        {
            numUpDownLenght.Enabled = false;
            numUpDownRound.Enabled = false;

            btnTCGenPQ.Enabled = false;
            btnTCCalcN.Enabled = false;

            btnPeggyGenSV.Enabled = false;  
            btnPeggyProvideV.Enabled = false;
            btnPeggyChooseRCalculateX.Enabled = false;
            btnPeggyCalculateY.Enabled = false;

            btnVictorGetNV.Enabled = false;
            btnVictorGenE.Enabled = false;
            btnVictorVerifyY.Enabled = false;
        }
    }
}
