using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShakespeareReader
{
    public partial class MainScreen : Form
    {
        public MainScreen()
        {
            InitializeComponent();
            WSReader.SetReaderOutputAction(UpdateOutputField);
        }

        private void ToggleReadBtn(bool on)
        {
            if (InvokeRequired)
            {
                Invoke(new Action<bool>(ToggleReadBtn), new object[] { on });
                return;
            }
            ReadBtn.Enabled = on;
        }

        private void UpdateOutputField(string text)
        {
            if (InvokeRequired)
            {
                Invoke(new Action<string>(UpdateOutputField), new object[] { text });
                return;
            }
            OutputField.Text += text;
        }

        private void ReadBtn_Click(object sender, EventArgs e)
        {
            ToggleReadBtn(false);
            new Thread(() =>
            {
                Thread.CurrentThread.IsBackground = true;
                WSReader.ReadShakespeareText(InputTextfield.Text);
                ToggleReadBtn(true);
            }).Start();
        }

        private void ClearBtn_Click(object sender, EventArgs e)
        {
            OutputField.Clear();
        }

        private void TimeScaleSlider_ValueChanged(object sender, EventArgs e)
        {
            TimeScaleLbl.Text = ("Speed Rate: " + Convert.ToString((float)TimeScaleSlider.Value / 100.0f));
            WSReader.TimeScale = (float)TimeScaleSlider.Value / 100.0f;
        }
    }
}
