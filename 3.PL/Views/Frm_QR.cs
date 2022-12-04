using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AForge.Video.DirectShow;
using AForge.Video;
using ZXing;
using _2.BUS.Services;
using _2.BUS.IServices;
using _1.DAL.DomainClass;

namespace _3.PL.Views
{
    public partial class Frm_QR : Form
    {
        public Frm_BanHang frmPatents { get; set; }
        BanHangServices _banHangServices = new BanHangServices();
        private IQLChiTietSpServices _iQLChiTietSpServices;
        public Frm_QR()
        {
            InitializeComponent();
            _iQLChiTietSpServices = new QLChiTietSpServices();
        }
        FilterInfoCollection filterInfoCollection;
        VideoCaptureDevice videoCaptureDevice;
        SaveFileDialog saveFile = new SaveFileDialog();
        private void Frm_QR_Load(object sender, EventArgs e)
        {
            filterInfoCollection = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            foreach (FilterInfo filterInfo in filterInfoCollection)
                cbx_Camera.Items.Add(filterInfo.Name);
            cbx_Camera.SelectedIndex = 0;
        }
        private void btn_Start_Click(object sender, EventArgs e)
        {
            videoCaptureDevice = new VideoCaptureDevice(filterInfoCollection[cbx_Camera.SelectedIndex].MonikerString);
            videoCaptureDevice.NewFrame += VideoCaptureDevice_NewFrame;
            videoCaptureDevice.Start();
            timer1.Start();
        }

        private void VideoCaptureDevice_NewFrame(object sender, AForge.Video.NewFrameEventArgs eventArgs)
        {
            ptb_QR.Image = (Bitmap)eventArgs.Frame.Clone();
        }

        private void Frm_QR_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (videoCaptureDevice != null)
            {
                if (videoCaptureDevice.IsRunning)
                {
                    videoCaptureDevice.SignalToStop();
                }
            }
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (ptb_QR.Image != null)
            {
                BarcodeReader barcodeReader = new BarcodeReader();
                Result result = barcodeReader.Decode((Bitmap)ptb_QR.Image);
                if(result != null)
                {
                    ChiTietSp temp = _iQLChiTietSpServices.GetAll().FirstOrDefault(c => c.Id == new Guid(result.ToString()));
                    if(temp != null)
                    {
                        _banHangServices.AddChiTietHD(temp, frmPatents._hoaDon);
                        frmPatents.LoadDTG_ChiTietHD(_banHangServices.GetAllChiTietHDV(frmPatents._hoaDon.Id));
                        timer1.Stop();
                        if (videoCaptureDevice.IsRunning)
                        {
                            videoCaptureDevice.SignalToStop();
                            this.Close();
                        }
                    }                 
                }

            }
        }
    }
}
