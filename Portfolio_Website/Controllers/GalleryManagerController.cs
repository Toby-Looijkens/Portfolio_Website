using DB_Library;
using Logic.Business;
using Logic.DTOs;
using Logic.Entities;
using Logic.Interfaces;
using Logic.Utils;
using Microsoft.AspNetCore.Mvc;

namespace Portfolio_Website.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GalleryManagerController : Controller
    {
        private readonly IGalleryItemRepository gir = new DB_Library.Repositories.GalleryItemRepository();

        [HttpGet(nameof(GetAllGalleryItems))]
        public async Task<IActionResult> GetAllGalleryItems()
        {
            GalleryItem result = new GalleryItem();
            result.Title = "test";
            return Ok(result);
        }

        [HttpGet(nameof(GetGalleryItemByID))]
        public async Task<IActionResult> GetGalleryItemByID(Guid id)
        {
            GalleryManager gm = new GalleryManager(gir);
            return Ok(await gm.GetGalleryItemByID(id));
        }

        [HttpPost(nameof(CreateGalleryItem))]
        public async Task<IActionResult> CreateGalleryItem(string title, string description, List<TagDTO> tags, bool hidden) 
        {
            GalleryItem galleryItem = new GalleryItem();
            galleryItem.Title = title;
            galleryItem.Description = description;  
            galleryItem.Hidden = hidden;
            

            foreach (var tag in tags) {
                galleryItem.Tags.Add(Mapper.MapTagDTOToTag(tag));
            }
            GalleryManager gm = new GalleryManager(gir);
            return Ok(await gm.CreateGalleryItem(galleryItem));
        }

        [HttpDelete(nameof(DeleteGalleryItem))]
        public async Task<IActionResult> DeleteGalleryItem(Guid ID)
        {
            GalleryManager gm = new GalleryManager(gir);
            return Ok(gm.DeleteGalleryItem(ID));
        }

        [HttpPut(nameof(UpdateGalleryItemInfo))]
        public async Task<IActionResult> UpdateGalleryItemInfo(string test,IFormFile file)
        {
            return Ok();
        }

        [HttpPut(nameof(UpdateGalleryItemFiles))]
        public async Task<IActionResult> UpdateGalleryItemFiles(IFormFileCollection files)
        {
            return Ok();
        }

    }
}

