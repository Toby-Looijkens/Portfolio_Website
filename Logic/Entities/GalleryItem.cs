using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Logic.Entities
{
    public class GalleryItem
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public Guid ID { get; set; }
        public string? Title { get; set; } = null!;
        public string? Description { get; set; } = null!;
        public ImageLink? Thumbnail { get; set; } = null!;
        public List<ImageLink>? GalleryImages { get; set; } = null!;
        public List<DownloadLink>? GalleryDownloads { get; set; } = null!;
        [JsonIgnore]
        public ICollection<Tag> Tags { get; set; } = [];
        public bool? Hidden { get; set; }

        public GalleryItem() { }

        public GalleryItem (string title, string description, ImageLink thumbnail, List<ImageLink> galleryImages, List<DownloadLink> galleryDownloads, bool hidden)
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
