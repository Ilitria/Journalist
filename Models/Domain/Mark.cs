using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Journalist.Models.Domain
{
    public class Mark
    {
        [Key]
        public int Id { get; set;}

        public double MarkValue { get; set; }

        [ForeignKey("EntryId")]
        public Entry Entry { get; set; }
    }
}