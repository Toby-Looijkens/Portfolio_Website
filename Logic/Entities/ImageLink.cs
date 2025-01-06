using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic.Entities
{
    public class ImageLink : ITransferableFile
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public Guid ID { get; set; }
        public string Name { get; set; }
        public string Extension { get; set; }
        [NotMapped]
        public IFormFile File { get; set; }

        public ImageLink(Guid ID, string name, string extension)
        {
            this.ID = ID;
            this.Name = name;
            this.Extension = extension;
        }
    }
}
