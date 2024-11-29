using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Runtime.InteropServices;
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
        public TransferableFile Thumbnail { get; set; } = null!;
        public List<TransferableFile> GalleryImages { get; set; } 
        public List<TransferableFile> GalleryDownloads { get; set; }
        public bool Hidden { get; set; }

        public GalleryItem (string title, string description, TransferableFile thumbnail, List<TransferableFile> galleryImages, List<TransferableFile> galleryDownloads, bool hidden)
        {
            Title = title;
            Description = description;
            Thumbnail = thumbnail;
            GalleryImages = galleryImages;
            GalleryDownloads = galleryDownloads;
            Hidden = hidden;
        }
    }
}
