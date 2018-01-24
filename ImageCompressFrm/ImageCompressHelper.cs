using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImageCompress
{
    public class ImageCompressHelper
    {
        /// 压缩图片    
        /// <param name="inFilePath">原图片</param>    
        /// <param name="outFilePath">压缩后保存位置</param>    
        /// <param name="imageReductionMultiplier">图像缩小倍数</param> 
        /// <param name="compressRatio">压缩率</param>    
        /// <returns></returns>    

        public static void imageCompress(string inFilePath, string outFilePath, int imageReductionMultiplier, int compressRatio)
        {
            using (Image source = Image.FromFile(inFilePath))
            {
                ImageFormat imageFormat = source.RawFormat;
                // int sW = 0, sH = 0;

                //按比例缩放  
                Size size = new Size(source.Width, source.Height);

                var aimWidth = source.Width / imageReductionMultiplier;
                var aimHeight = source.Height / imageReductionMultiplier;

                using (Bitmap bitmap = new Bitmap(aimWidth, aimHeight))
                {
                    using (Graphics graphics = Graphics.FromImage(bitmap))
                    {
                        graphics.Clear(Color.WhiteSmoke);
                        graphics.CompositingQuality = CompositingQuality.HighQuality;
                        graphics.SmoothingMode = SmoothingMode.HighQuality;
                        graphics.InterpolationMode = InterpolationMode.HighQualityBicubic;
                        graphics.DrawImage(source, new Rectangle(0, 0, aimWidth, aimHeight), 0, 0, source.Width, source.Height, GraphicsUnit.Pixel);
                    }
                    //以下代码为保存图片时，设置压缩质量    
                    EncoderParameters encoderParameters = new EncoderParameters();
                    EncoderParameter encoderParameter = new EncoderParameter(System.Drawing.Imaging.Encoder.Quality,new long[1] { compressRatio });
                    encoderParameters.Param[0] = encoderParameter;
                    ImageCodecInfo[]  imageCodecInfos = ImageCodecInfo.GetImageEncoders();
                    ImageCodecInfo imageCodecInfo = imageCodecInfos.Where(p => p.FormatDescription.Equals("jpeg", StringComparison.OrdinalIgnoreCase)).FirstOrDefault();
                    if (imageCodecInfo != null)
                    {
                        bitmap.Save(outFilePath, imageCodecInfo, encoderParameters);//dFile是压缩后的新路径    
                    }
                    else
                    {
                        bitmap.Save(outFilePath, imageFormat);
                    }
                }
            }
        }
    }
}
