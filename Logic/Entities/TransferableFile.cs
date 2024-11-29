using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;
using Microsoft.AspNetCore.Http;
using System.Runtime.Serialization;

namespace Logic.Entities
{
    public class TransferableFile
    {
        [Key]
        public Guid ID { get; set; }
        public string Name { get; set; }
        public string Extension { get; set; }
        [IgnoreDataMember]
        public IFormFile File { get; set; }

        public TransferableFile(Guid ID, string name, string extension)
        {
            this.ID = ID;
            this.Name = name;
            this.Extension = extension;
        }
    }
}
