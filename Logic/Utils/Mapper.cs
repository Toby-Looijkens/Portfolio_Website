using Logic.DTOs;
using Logic.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic.Utils
{
    public static class Mapper
    {
        public static GalleryItemDTO MapGalleryItemToDTO(GalleryItem item)
        {
            GalleryItemDTO temp = new GalleryItemDTO();
            temp.ID = item.ID;
            temp.Title = item.Title;
            temp.Description = item.Description;
            temp.GalleryImages = item.GalleryImages;
            foreach (Tag tag in item.Tags) 
            {
                temp.Tags.Add(new TagDTO(tag.ID, tag.Name));
            }

            return temp;
        }

        public static Tag MapTagDTOToTag(TagDTO dto)
        {
            Tag temp = new Tag(dto.ID, dto.Name);
            return temp;
        }
    }
}
