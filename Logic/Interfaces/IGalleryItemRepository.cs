using Logic.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic.Interfaces
{
    public interface IGalleryItemRepository
    {
        Task<IEnumerable<GalleryItem>> GetAllGalleryItems();
        Task<IEnumerable<GalleryItem>> GetGalleryItemByID(Guid ID);
        Task<IEnumerable<GalleryItem>> CreateGalleryItem(GalleryItem item);
        Task<IEnumerable<GalleryItem>> UpdateGalleryItem(GalleryItem item);
        Task DeleteGalleryItem(Guid ID);
    }
}
