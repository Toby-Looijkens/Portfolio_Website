using DB_Library;
using Logic.Business;
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
            return Ok();
        }

        [HttpPost(nameof(CreateGalleryItem))]
        public async Task<IActionResult> CreateGalleryItem(
            string title, 
            string description, 
            IFormFile? thumbnail, 
            IFormFileCollection images, 
            IFormFileCollection downloads, 
            bool hidden
            ) 
        {
            FileHandler fileHandler = new FileHandler();
            List<TransferableFile> tempImages = new List<TransferableFile>();
            List<TransferableFile> tempDownloads = new List<TransferableFile>();

            foreach (IFormFile image in images) {
                try
                {
                    tempImages.Add(fileHandler.CreateTransferableFile(image));
                }
                catch (Exception ex)
                {
                    return BadRequest(ex.Message);
                }
            }

            foreach (IFormFile download in downloads)
            {
                try
                {
                    tempDownloads.Add(fileHandler.CreateTransferableFile(download));
                }
                catch (Exception ex)
                {
                    return BadRequest(ex.Message);
                }
            }

            GalleryItem item = new GalleryItem(
                title, 
                description, 
                fileHandler.CreateTransferableFile(thumbnail), 
                tempImages, 
                tempDownloads, 
                hidden
                );

            GalleryManager gm = new GalleryManager(gir);
            return Ok(await gm.CreateGalleryItem(item));
        }
    }
}

