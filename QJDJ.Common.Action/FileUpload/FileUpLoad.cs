using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace QJDJ.Common.Action.FileUpload
{
    public class FileUpLoad
    {
        /// <summary>
        /// 文件上传
        /// </summary>
        /// <param name="fileBase">文件</param>
        /// <param name="mainPath">文件主路径</param>
        /// <param name="fileDirectoryName">文件上级文件目录</param>
        /// <param name="fileName">文件名</param>
        public static void ImgUpload(HttpPostedFileBase fileBase, string mainPath, string fileDirectoryName, string fileName)
        {
            string filePhysicalPathes = mainPath + "\\" + fileDirectoryName + "\\";
            if (!Directory.Exists(filePhysicalPathes))
            {
                Directory.CreateDirectory(filePhysicalPathes);//不存在则创建文件夹 
                fileBase.SaveAs(filePhysicalPathes + fileName);
            }
            else
            {
                fileBase.SaveAs(filePhysicalPathes + fileName);
            }
        }
    }
}
