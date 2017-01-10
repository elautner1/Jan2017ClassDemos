using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

#region additional Namespaces
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
#endregion

namespace Chinook.Data.Entities
{

    [Table("Artists")]
   public class Artist
    {
        [Key]
        public int ArtistId { get; set; }
        public string Name { get; set; }

        //navigational properties.... this is the parent

        public virtual ICollection<Album> Albums { get; set; }

        
    }
}
