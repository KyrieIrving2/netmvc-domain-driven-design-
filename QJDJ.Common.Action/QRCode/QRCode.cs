using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ThoughtWorks.QRCode.Codec;

namespace QJDJ.Common.Action.QRCode
{
    public class QRCode
    {
        /// <summary>
        /// 生成二维码：//"D:\\QJDJ\\wwwroot\\api\\v1\\upload\\shops\\13007468412\\shopImg\\shopHead.jpg";
        /// </summary>
        /// <param name="imgUrl">二维码中间小图标路径：shopImg\\shopHead.jpg</param>
        /// <param name="scanGotoUrl">扫码跳转的路径：https://www.qianjidaojia.com/wxh5/zs/index.html?#/contractShop/index?shop_id=</param>
        /// <param name="mainPath">文件主路径：D:\\QJDJ\\wwwroot\\api\\v1\\upload\\shops\\13007468412</param>
        /// <param name="directoryName">二维码上级目录</param>
        /// <param name="imgName">二维码名称</param>
        public static void GenerateQRCode(string imgUrl, string scanGotoUrl, string mainPath, string directoryName, string imgName)
        {
            QRCodeEncoder endocder = new QRCodeEncoder();
            //二维码背景颜色
            endocder.QRCodeBackgroundColor = System.Drawing.Color.White;
            //二维码编码方式
            endocder.QRCodeEncodeMode = QRCodeEncoder.ENCODE_MODE.BYTE;
            //每个小方格的宽度
            endocder.QRCodeScale = 10;
            //二维码版本号
            endocder.QRCodeVersion = 5;
            //纠错等级
            endocder.QRCodeErrorCorrect = QRCodeEncoder.ERROR_CORRECTION.M;
            //将json做成二维码
            Bitmap bitmap = endocder.Encode(scanGotoUrl, System.Text.Encoding.UTF8);
            string filePhysicalPathes = mainPath + "\\" + directoryName + "\\";
            string url = mainPath + imgUrl;
            if (!Directory.Exists(filePhysicalPathes))
            {
                Directory.CreateDirectory(filePhysicalPathes);
            }
            string strSavePath = Path.Combine(filePhysicalPathes, imgName + ".png");
            if (!System.IO.File.Exists(strSavePath))
            {
                bitmap.Save(strSavePath);
            }
            CreateQRCode(filePhysicalPathes, scanGotoUrl, url,imgName);
        }

        /// <summary>
        /// 生成二维码（中间带LOGO）
        /// </summary>
        /// <param name="absoluteSave">保存的绝对路径</param>
        /// <param name="qrdata">要附加的内容</param>
        ///<param name="absoluteSave">保存的绝对路径</param>
        ///<param name="imgName">二维码名称</param>
        /// <returns></returns>
        public static void CreateQRCode(string absoluteSave, string qrdata, string AbsoluteLogo, string imgName)
        {
            try
            {
                QRCodeEncoder encoder = new QRCodeEncoder();
                encoder.QRCodeEncodeMode = QRCodeEncoder.ENCODE_MODE.BYTE;//编码方式(注意：BYTE能支持中文，ALPHA_NUMERIC扫描出来的都是数字)
                encoder.QRCodeScale = 8;//大小(值越大生成的二维码图片像素越高)
                encoder.QRCodeVersion = 0;//版本(注意：设置为0主要是防止编码的字符串太长时发生错误)
                encoder.QRCodeErrorCorrect = QRCodeEncoder.ERROR_CORRECTION.H;//错误效验、错误更正(有4个等级)
                encoder.QRCodeBackgroundColor = Color.White;
                encoder.QRCodeForegroundColor = Color.Black;
                System.Drawing.Image image = encoder.Encode(qrdata, Encoding.UTF8);
                Bitmap btm = new Bitmap(AbsoluteLogo);
                Bitmap copyImage = new Bitmap(btm, image.Width / 5, image.Height / 5);
                Graphics g = Graphics.FromImage(image);
                int x = image.Width / 2 - copyImage.Width / 2;
                int y = image.Height / 2 - copyImage.Height / 2;
                g.DrawImage(copyImage, x, y);
                System.IO.Directory.CreateDirectory(absoluteSave);
                //imgName = "QRCode.png";
                string strSavePath = Path.Combine(absoluteSave, imgName + ".png");
                image.Save(strSavePath);
                image.Dispose();
                btm.Dispose();
                copyImage.Dispose();
                g.Dispose();
            }
            catch (Exception ex)
            {
                //一些操作
            }
        }
    }
}
