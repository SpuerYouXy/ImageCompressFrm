using ImageCompress;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ImageCompressFrm
{
    public partial class MainFrm : Form
    {
        public MainFrm()
        {
            AppDomain.CurrentDomain.UnhandledException += CurrentDomain_UnhandledException;
            InitializeComponent();
        }

        private void CurrentDomain_UnhandledException(object sender, UnhandledExceptionEventArgs e)
        {
            MessageBox.Show("程序出错");
            this.Close();
        }

        private void btn_selectImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Title = "选择图片";
            openFileDialog.Filter = "图片|*.jpg|所有文件|*.*";
            openFileDialog.FileOk += OpenFileDialog_FileOk;
            openFileDialog.ShowDialog();
        }
        private void OpenFileDialog_FileOk(object sender, CancelEventArgs e)
        {
            var fileDialog = sender as OpenFileDialog;
            this.lb_imagePath.Text = fileDialog.FileName;
        }

        private void btn_compressImage_Click(object sender, EventArgs e)
        {
            var inpath = this.lb_imagePath.Text;
            if (string.IsNullOrWhiteSpace(inpath))
            {
                MessageBox.Show("请选择要压缩的图片");
                return;
            }
            var outpath = string.Empty;
            FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();
            if (folderBrowserDialog.ShowDialog() != DialogResult.OK) return;
            outpath = Path.Combine(folderBrowserDialog.SelectedPath, Guid.NewGuid().ToString() + Path.GetExtension(inpath));

            try
            {
                var imageReductionMultiplier = (int)num_imageReductionMultiplier.Value;
                var compressRatio = (int)num_compressionRatio.Value;
                ImageCompressHelper.imageCompress(inpath, outpath, imageReductionMultiplier, compressRatio);
                MessageBox.Show("压缩完成");
            }
            catch
            {
                MessageBox.Show("压缩失败,请确认文件格式是否正确!");
            }
        }
    }
}
