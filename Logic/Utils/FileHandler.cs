using Logic.Entities;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic.Utils
{
    public class FileHandler
    {
        public ImageLink CreateTransferableFile(IFormFile file)
        {
            //extension
            List<string> validExtensions = new List<string>()
            {
                ".jpg",
                ".jpeg",
                ".png",
                ".gif",
                ".mp4",
                ".blend",
                ".obj",
                ".stl",
                ".fbx",
                ".glb",
                ".gltf"
            };

            string extension = Path.GetExtension(file.FileName);
            if (!validExtensions.Contains(extension))
            {
                throw new Exception($"Extension is not valid ({string.Join(",", validExtensions)})");
            }

            //file size
            long size = file.Length;
            long maxSize = ((1024 * 1024 * 1024) / 2); // 500 MB filesize limit
            if (size > maxSize)
            {
                throw new Exception($"File is too big({maxSize.ToString() + "MB limit"})");
            }

            //name changing
            Guid ID = Guid.Empty;
            ImageLink temp = new ImageLink(ID, file.FileName, Path.GetExtension(file.FileName));
            temp.File = file;
            return temp;
        }
    }
}
