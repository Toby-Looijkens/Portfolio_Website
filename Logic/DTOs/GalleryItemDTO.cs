using Logic.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic.DTOs
{
    public class GalleryItemDTO
    {
        public Guid ID { get; set; }
        public string? Title { get; set; } = null!;
        public string? Description { get; set; } = null!;
        public ImageLink? Thumbnail { get; set; } = null!;
        public List<ImageLink>? GalleryImages { get; set; } = null!;
        public List<DownloadLink>? GalleryDownloads { get; set; } = null!;
        public ICollection<TagDTO> Tags { get; set; } = [];
        public bool? Hidden { get; set; }

        public GalleryItemDTO() { }

        public GalleryItemDTO(string title, string description, ImageLink thumbnail, List<ImageLink> galleryImages, List<DownloadLink> galleryDownloads, bool hidden)
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
