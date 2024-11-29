using Logic.Entities;
using Logic.Interfaces;
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

        public async Task<string> CreateGalleryItem(GalleryItem item)
        {
            TransferableFile file = await IGalleryItemRepository.CreateGalleryItem(item);
            return file.ID.ToString();
        }
    }
}
