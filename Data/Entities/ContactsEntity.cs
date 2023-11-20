using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Phone_App.DBModels
{
    [Table("BookContact")]
    public class ContactsEntity
    {
        public int ID { get; set; }

        [MaxLength(30)]
        [Required]
        public string Name { get; set; }

        [Required]
        [Phone]
        public string Number { get; set; }

        [EmailAddress]
        [MaxLength (100)]
        public string? Email { get; set; }

        [MaxLength(100)]
        public string? Address { get; set; }
    }
}
