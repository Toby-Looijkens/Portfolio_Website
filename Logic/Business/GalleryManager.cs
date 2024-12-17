using Logic.DTOs;
using Logic.Entities;
using Logic.Interfaces;
using Logic.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic.Business
{
    public class GalleryManager
    {
        IGalleryItemRepository IGalleryItemRepository { get; set; }
        public GalleryManager(IGalleryItemRepository gir) 
        { 
            IGalleryItemRepository = gir;
        }

        public async Task<GalleryItemDTO> GetGalleryItemByID(Guid id)
        {
            var result = await IGalleryItemRepository.GetGalleryItemByID(id);
            Mapper mapper = new Mapper();
            
            return mapper.MapGalleryItemToDTO(result);
        }

        public async Task<string> CreateGalleryItem(GalleryItem item)
        {
            GalleryItem galleryItem = await IGalleryItemRepository.CreateGalleryItem(item);
            return galleryItem.ID.ToString();
        }
    }
}
