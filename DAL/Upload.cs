using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Http;
using System.IO;

namespace DAL
{
   public class Upload
    {
        private Upload() { }
        private static Upload _instance = new Upload();
        public static Upload Instance
        {
            get
            {
                return _instance;
            }
        }
        public string UpImg(IFormFile file,string filename)
        {
            if (file == null || !file.ContentType.StartsWith("image"))
                return null;
            else
            {
                string ext = Path.GetExtension(file.FileName);
                filename = $"{filename}{ext}";
                using(FileStream fs = File.Create(filename))
                {
                    file.CopyTo(fs);
                    fs.Flush();
                }
                return ext;
            }
        }
    }
}
