using Logic.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic.DTOs
{
    public class TagDTO
    {
        public Guid ID { get; set; }
        public string? Name { get; set; }

        public TagDTO(Guid id, string name)
        {
            ID = id;
            Name = name;
        }
    }
}
