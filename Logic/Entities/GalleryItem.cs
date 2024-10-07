using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic.Entities
{
    public class GalleryItem
    {
        [Key]
        public Guid ID { get; set; }
        public string Title { get; set; } = null!;
        public string Description { get; set; } = null!;
        public ImageLink ThumbnailLink { get; set; } = null!;
        public ICollection<ImageLink> GalleryImageLinks { get; set; } 
        public ICollection<DownloadLink> GalleryDownloadLinks { get; set; }
        public bool Hidden { get; set; }
    }
}
