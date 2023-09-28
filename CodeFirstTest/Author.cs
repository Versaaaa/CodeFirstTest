using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirstTest
{
    internal class Author
    {
        [Key]
        public string Name { get; set; }

        public virtual Post Post { get; set; }
    }
}
