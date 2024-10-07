using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic.Entities
{
    public class ImageLink
    {
        [Key]
        public Guid ID { get; set; }
        public string URL { get; set; }
    }
}
