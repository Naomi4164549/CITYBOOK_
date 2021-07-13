using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Entities
{
     public class ChildEntity
    {
        [Key]
        public int Id { get; set; }
        [Column(TypeName = "nvarchar(20)")]
        public string FirstName { get; set; }
        [Column(TypeName = "nvarchar(20)")]
        public string identity { get; set; }
        [Column(TypeName = "date")]
        public DateTime Dateborn { get; set; }
        public string tzUser { get; set; }
    }
}
