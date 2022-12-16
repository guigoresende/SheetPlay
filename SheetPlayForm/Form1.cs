using NAudio.Wave;
using SheetPlay.External.NAudio;
using System.ComponentModel;

namespace SheetPlayForm
{
    public partial class SheetPlayForm : Form
    {
        public SheetPlayForm()
        {
            InitializeComponent();

            var readExcelApplication = new SheetPlay.Lib.Application.Sheet.Read();
            tracePerTimeList = readExcelApplication.ReadExcel("C:\\Users\\guigo\\Downloads\\SheetPlay.csv").Value;

            backgroundWorker1.WorkerReportsProgress = true;
            backgroundWorker1.WorkerSupportsCancellation = true;

            backgroundWorker1.DoWork += new DoWorkEventHandler(backgroundWorker1_DoWork);
            backgroundWorker1.RunWorkerCompleted += new RunWorkerCompletedEventHandler(backgroundWorker1_RunWorkerCompleted);
            backgroundWorker1.ProgressChanged += new ProgressChangedEventHandler(backgroundWorker1_ProgressChanged);
        }

        private IEnumerable<global::SheetPlay.Lib.Model.Entity.TracePerTime> tracePerTimeList = null;

        private bool traceOnePlaying = false;
        private bool traceTwoPlaying = false;

        private string ValidateMultiplier(out int timeMultiplier)
        {
            timeMultiplier = default(int);
            var msgError = string.Empty;

            if (string.IsNullOrEmpty(txtTimeMultiplier.Text))
                return "Input time multiplier";

            if (!int.TryParse(txtTimeMultiplier.Text, out timeMultiplier))
                return "Time multiplier is not a number";

            if (timeMultiplier == 0)
                return "Time multiplier has to be higher than 0";

            return string.Empty;
        }

        private void Trace1_Click(object sender, EventArgs e)
        {
            if (traceTwoPlaying)
            {
                MessageBox.Show("Trace2 is playing");
                return;
            }

            var timeMultiplier = default(int);
            var msgError = ValidateMultiplier(out timeMultiplier);
            if (!string.IsNullOrEmpty(msgError))
            {
                MessageBox.Show(msgError);
                return;
            }

            if (traceOnePlaying)
            {
                backgroundWorker1.CancelAsync();
                traceOnePlaying = false;
                btnPlayTraceTwo.Enabled = true;
                txtTimeMultiplier.Enabled = true;
                btnPlayTraceOne.Text = "Play trace1";

                return;
            }

            traceOnePlaying = true;
            btnPlayTraceTwo.Enabled = false;
            txtTimeMultiplier.Enabled = false;
            btnPlayTraceOne.Text = "Stop trace1";

            backgroundWorker1.RunWorkerAsync(timeMultiplier);
        }

        private void btnPlayTrace2_Click(object sender, EventArgs e)
        {
            if (traceOnePlaying)
            {
                MessageBox.Show("Trace1 is playing");
                return;
            }

            var timeMultiplier = default(int);
            var msgError = ValidateMultiplier(out timeMultiplier);
            if (!string.IsNullOrEmpty(msgError))
            {
                MessageBox.Show(msgError);
                return;
            }

            if (traceTwoPlaying)
            {
                backgroundWorker1.CancelAsync();

                traceTwoPlaying = false;
                btnPlayTraceOne.Enabled = true;
                txtTimeMultiplier.Enabled = true;
                btnPlayTraceTwo.Text = "Play trace2";
                return;
            }

            traceTwoPlaying = true;
            btnPlayTraceOne.Enabled = false;
            txtTimeMultiplier.Enabled = true;
            btnPlayTraceTwo.Text = "Stop trace2";

            backgroundWorker1.RunWorkerAsync(timeMultiplier);
        }

        private void backgroundWorker1_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {
            var worker = sender as BackgroundWorker;

            for (int i = 0; i < tracePerTimeList.Count(); i++)
            {

                if (worker.CancellationPending)
                {
                    e.Cancel = true;
                    return;
                }

                if (traceOnePlaying)
                    using (var tone = new WaveTone(tracePerTimeList.ElementAt(i).Trace1, 0.1, 0))
                    {
                        using (var stream = new BlockAlignReductionStream(tone))
                        {
                            try
                            {
                                using (var output = new DirectSoundOut())
                                {
                                    output.Init(stream);
                                    output.Play();
                                    Thread.Sleep(Convert.ToInt32(tracePerTimeList.ElementAt(i).Time * (int)e.Argument));
                                    output.Stop();
                                }
                            }
                            catch (Exception)
                            {
                            }
                        }
                    }
                else if (traceTwoPlaying)
                    using (var tone = new WaveTone(tracePerTimeList.ElementAt(i).Trace2, 0.1, 0))
                    {
                        using (var stream = new BlockAlignReductionStream(tone))
                        {
                            try
                            {
                                using (var output = new DirectSoundOut())
                                {
                                    output.Init(stream);
                                    output.Play();
                                    Thread.Sleep(Convert.ToInt32(tracePerTimeList.ElementAt(i).Time * (int)e.Argument));
                                    output.Stop();
                                }
                            }
                            catch (Exception)
                            {
                            }
                        }
                    }

                ChangeLabelLine($"{(i + 1).ToString()} of {tracePerTimeList.Count()}");
            }

            backgroundWorker1.CancelAsync();
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (e.Error != null && !string.IsNullOrEmpty(e.Error.Message))
                MessageBox.Show(e.Error.Message);

            ChangeLabelLine($"0 of {tracePerTimeList.Count()}");
            traceOnePlaying = false;
            btnPlayTraceOne.Text = "Play trace1";
        }

        private void backgroundWorker1_ProgressChanged(object? sender, ProgressChangedEventArgs e)
        {

        }

        delegate void ChangeLabelLineCallback(string msg);
        ChangeLabelLineCallback callback = null;
        void ChangeLabelLine(string msg)
        {
            if (InvokeRequired)
            {
                callback = ChangeLabelLine;
                Invoke(callback, msg);
                return;
            }

            labelLine.Text = msg;
        }

        private bool IsDemonstring = false;
        private WaveTone _tone = null;
        private BlockAlignReductionStream _stream = null;
        private DirectSoundOut _output = null;
        private void btnDemonstrate_Click(object sender, EventArgs e)
        {
            if (IsDemonstring)
            {
                IsDemonstring = !IsDemonstring;

                btnPlayTraceOne.Enabled = true;
                btnPlayTraceTwo.Enabled = true;

                _output.Stop();
                _output.Dispose();

                _stream.Close();
                _stream.Dispose();

                _tone.Close();
                _tone.Dispose();

                return;
            }

            IsDemonstring = !IsDemonstring;

            btnPlayTraceOne.Enabled = true;
            btnPlayTraceTwo.Enabled = true;

            _tone = new WaveTone(1000, 0.1, 0);
            _stream = new BlockAlignReductionStream(_tone);

            _output = new DirectSoundOut();
            _output.Init(_stream);
            _output.Play();
        }
    }
}