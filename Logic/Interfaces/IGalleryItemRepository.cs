using Logic.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic.Interfaces
{
    public interface IGalleryItemRepository
    {
        Task<GalleryItem> GetGalleryItemByID(Guid id);

        //Task<IEnumerable<GalleryItem>> GetAllGalleryItems();
        //Task<IEnumerable<GalleryItem>> GetGalleryItemByID(Guid ID);
        Task<GalleryItem> CreateGalleryItem(GalleryItem item);
        //Task<IEnumerable<GalleryItem>> UpdateGalleryItem(GalleryItem item);
        Task<int> DeleteGalleryItem(Guid ID);
    }
}
