using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic.Entities
{
    public class GalleryItem
    {
        public Guid ID { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string ThumbnailLink { get; set; }
        public string[] GalleryImageLinks { get; set; }
        public string[] GalleryDownloadLinks { get; set; }
        public bool Hidden { get; set; }
    }
}
