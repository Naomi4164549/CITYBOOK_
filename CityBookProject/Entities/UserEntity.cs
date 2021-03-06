using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Entities
{
    public class UserEntity
    {
        [Key]
        public int Id { get; set; }
        [Column(TypeName = "nvarchar(20)")]
        public string FirstName { get; set; }
        [Column(TypeName = "nvarchar(20)")]
        public string LastName { get; set; }
        [Column(TypeName = "nvarchar(9)")]
        public string Identity { get; set; }
        [Column(TypeName = "date")]
        public DateTime Dateborn { get; set; }
        [Column(TypeName = "nvarchar(10)")]
        public string Kind { get; set; }
        [Column(TypeName = "nvarchar(20)")]
        public string HMO { get; set; }
        [Column(TypeName = "int ")]
        public int NumOfChildren { get; set; }
        virtual
        public ChildEntity[] Children
        { get; set; }
       

        public UserEntity()
        {

        }
    }
}
