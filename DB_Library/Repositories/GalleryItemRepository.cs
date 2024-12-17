using Logic.Entities;
using Logic.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace DB_Library.Repositories
{
    public class GalleryItemRepository : IGalleryItemRepository
    {
        static HttpClient client = new HttpClient();
        private readonly DBContext _context = new DBContext();
        static async Task RunAsync()
        {
            // Update port # in the following line.
            client.BaseAddress = new Uri("http://localhost:5195/");
            client.DefaultRequestHeaders.Accept.Clear();
        }
        public GalleryItemRepository() { }

        public async Task<GalleryItem> GetGalleryItemByID(Guid id)
        {
            var result = _context.Gallery
                .Where(x => x.ID == id)
                .Include(x => x.Tags)
                .ToList();

            return result.FirstOrDefault();
        }

        public async Task<GalleryItem> CreateGalleryItem(GalleryItem item)
        {
            //item.Thumbnail = await UploadFileToStorage(item.Thumbnail.File);

            /*for (int i = 0; i < item.GalleryImages.Count(); i++) 
            {
                item.GalleryImages[i] = await UploadFileToStorage(item.GalleryImages[i].File);
            }*/

            var entity = _context.Add(item);
            
            _context.SaveChanges();
            return entity.Entity;
        }

        private async Task<ImageLink> UploadFileToStorage(IFormFile file)
        {
            using (var multipartFormContent = new MultipartFormDataContent())
            {
                //Load the file and set the file's Content-Type header
                var fileStreamContent = new StreamContent(file.OpenReadStream());
                fileStreamContent.Headers.ContentType = new MediaTypeHeaderValue("image/png");

                //Add the file
                multipartFormContent.Add(fileStreamContent, "file", file.FileName);

                //Send it
                var response = await client.PostAsync("http://localhost:5195/api/FileManager/UploadFile", multipartFormContent);
                response.EnsureSuccessStatusCode();
                return JsonConvert.DeserializeObject<ImageLink>(await response.Content.ReadAsStringAsync());
            }
        }
    }
}
