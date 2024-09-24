using Logic.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic.Utils
{
    public class Mapper
    {
        public User MapFromAsync()
        {
            return new User("test", "test", 1, "test");
        }
    }
}
