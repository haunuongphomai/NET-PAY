using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AForge.Video;
using AForge.Video.DirectShow;
using ZXing;
using ZXing.Windows.Compatibility;


namespace Project
{
    public partial class QRCode : Form
    {
        public QRCode()
        {
            InitializeComponent();
            cboDevice.Hide();
        }

        FilterInfoCollection filterInfoColleciton;
        VideoCaptureDevice captureDevice;

        private void QRCode_Load(object sender, EventArgs e)
        {
            filterInfoColleciton = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            foreach (FilterInfo filterInfo in filterInfoColleciton)
            {
                cboDevice.Items.Add(filterInfo.Name);
            }
            cboDevice.SelectedIndex = 0;

            captureDevice = new VideoCaptureDevice(filterInfoColleciton[cboDevice.SelectedIndex].MonikerString);
            captureDevice.NewFrame += CaptureDevice_NewFrame;
            captureDevice.Start();
            timer1.Start();
        }

        private void CaptureDevice_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            imgQRCode.Image = (Bitmap)eventArgs.Frame.Clone();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (imgQRCode.Image != null)
            {
                BarcodeReader barcodeReader = new BarcodeReader();
                Result result = barcodeReader.Decode((Bitmap)imgQRCode.Image);

                if (result != null)
                {
                    //txtPhone.Text = result.ToString();
                    TransactionPanel.instance.TextBoxValue = result.ToString();
                    timer1.Stop();
                    if (captureDevice.IsRunning)
                    {
                        captureDevice.SignalToStop();
                        captureDevice.WaitForStop();
                    }
                    this.Hide();

                }

            }
        }

        private void QRCode_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (captureDevice.IsRunning)
            {
                captureDevice.SignalToStop();
                captureDevice.WaitForStop();
            }
        }
    }
}
