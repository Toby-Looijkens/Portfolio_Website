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
                .Include(x => x.GalleryImages)
                .ToList();

            return result.FirstOrDefault();
        }

        public async Task<GalleryItem> CreateGalleryItem(GalleryItem item)
        {
            List<Tag> tags = new List<Tag>();

            foreach (var tag in item.Tags) {
                if (tag.ID != Guid.Empty) {
                    tags.Add(_context.Tags.Where(x => x.ID == tag.ID).FirstOrDefault());
                } else
                {
                    tags.Add(tag);
                }
            }
            item.Tags = tags;
            var entity = _context.Add(item);
            _context.SaveChanges();
            return entity.Entity;
        }

        public async Task<int> DeleteGalleryItem(Guid ID)
        {
            _context.Gallery.Remove(_context.Gallery.Where(x => x.ID == ID).FirstOrDefault());
            return _context.SaveChanges();
        }

        private async Task<Tag> GetTag(Guid ID)
        {
            var result = _context.Tags.FirstOrDefault(x => x.ID == ID);
            return result;
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
