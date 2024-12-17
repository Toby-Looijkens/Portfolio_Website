using Logic.DTOs;
using Logic.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic.Utils
{
    public class Mapper
    {
        public GalleryItemDTO MapGalleryItemToDTO(GalleryItem item)
        {
            GalleryItemDTO temp = new GalleryItemDTO();
            temp.ID = item.ID;
            temp.Title = item.Title;
            temp.Description = item.Description;
            foreach (Tag tag in item.Tags) 
            {
                temp.Tags.Add(new TagDTO(tag.ID, tag.Name));
            }

            return temp;
        }
    }
}
