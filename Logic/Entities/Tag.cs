using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.ComponentModel.DataAnnotations;
using System.Threading.Tasks;

namespace Logic.Entities
{
    public class Tag
    {
        [Key]
        public Guid ID { get; set; }
        public string Name { get; set; }
        [JsonIgnore]
        public ICollection<GalleryItem> GalleryItems { get; set; }
        public Tag() { }

        public Tag(Guid id) 
        { 
            ID = id;
        }
        public Tag(Guid id, string name) 
        { 
            ID = id;
            Name = name;
        }
    }
}
